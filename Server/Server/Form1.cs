﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Server
{
    public struct Sweet{
        public string id;
        public string sender;
        public string content;
        public DateTime date;

        public Sweet(string sender_info, string content_info, string given_date, string given_id)
        {
            sender = sender_info;
            content = content_info;
            date = Convert.ToDateTime(given_date);
            id = given_id;
        }
        public Sweet(string sender_info, string content_info)
        {
            sender = sender_info;
            content = content_info;
            date = DateTime.Now;
            id = Guid.NewGuid().ToString("N");
        }

        public static Sweet stringToSweet(string msg)
        {
            string[] sweetList =  msg.Split('\t');
            string sender = sweetList[0];
            string date = sweetList[1];
            string id = sweetList[2];
            string content = sweetList[3];

            return new Sweet(sender, content, date, id);
        }
    }

    public struct Follow
    {
        public string sender;
        public string do_what;
        public string target_user;

        public Follow(string sender_info, string do_what_info, string target_user_info)
        {
            sender = sender_info;
            do_what = do_what_info;
            target_user = target_user_info;
        }

        public static Follow stringToFollow(string msg)
        {
            string[] followerList = msg.Split('\t');
            string sender = followerList[0];
            string do_what = followerList[1];
            string target_user = followerList[2];

            return new Follow(sender, do_what, target_user);
        }

    }

    public partial class Form1 : Form
    {
        Socket server_socket;
        List<Socket> client_sockets = new List<Socket>();
        List<string> connected_list = new List<string>();
        List<Sweet> sweets = new List<Sweet>();
        List<Follow> follows = new List<Follow>();
        int packet_size = 512;
        bool binded = false;

        bool terminating = false;
        bool listening = false;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            int server_port;
            if(Int32.TryParse(text_port.Text, out server_port))
            {
                try
                {
                    IPEndPoint end_point = new IPEndPoint(IPAddress.Any, server_port);
                    if (!binded)
                    {
                        server_socket.Bind(end_point);
                        binded = true;
                    }
                    server_socket.Listen(3);

                    text_msg_box.AppendText("Server is listening for connections.\n");
                }
                catch 
                {
                    text_msg_box.AppendText("Error occured while connecting to the Port!\n");
                }

                listening = true;
                text_port.Enabled = false;
                button_listen.Enabled = false;

                Thread accept_client_thread = new Thread(AcceptClients);
                accept_client_thread.Start();
            }
            else
            {
                text_msg_box.AppendText("Could not start listening port " + text_port.Text + "!\n");
                text_msg_box.AppendText("Please check port!\n");
            }

        }

        private void AcceptClients()
        {
            while (listening)
            {
                try
                {
                    Socket client_socket = server_socket.Accept();
                    Byte[] buffer = new Byte[packet_size];
                    client_socket.Receive(buffer);
                    string incomingUsername = Encoding.Default.GetString(buffer).Trim('\0');

                    string[] usernames = System.IO.File.ReadAllLines(@"..\\..\\user-db.txt");
                    bool user_name_check = CheckUserName(incomingUsername, usernames);

                    if (user_name_check)
                    {
                        client_sockets.Add(client_socket);
                        text_msg_box.AppendText(incomingUsername + " connected!\n");

                        Byte[] buffer2 = new byte[packet_size]; 
                        buffer2 = Encoding.Default.GetBytes("yes");
                        client_socket.Send(buffer2);
                        connected_list.Add(incomingUsername);

                        Thread recieve_msg_thread = new Thread(() => ReceiveMsg(client_socket, incomingUsername));
                        recieve_msg_thread.Start();
                    }
                    else
                    {
                        Byte[] buffer2 = new byte[packet_size];
                        buffer2 = Encoding.Default.GetBytes("no");
                        client_socket.Send(buffer2);
                    }
                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        text_msg_box.AppendText("An error occured while accepting clients!\n");
                    }
                }
            }
        }

        private bool CheckUserName(string given_username, string[] usernames)
        {
            bool isConnected = false;
            foreach (string username in connected_list)
            {
                if (username == given_username)
                {
                    text_msg_box.AppendText(given_username + " has already connected to the server!\n");
                    isConnected = true;
                    break;
                }
            }
            if (isConnected) return false;

            bool isIn = false;
            foreach (string username in usernames)
            {
                if (username == given_username)
                {
                    isIn = true;
                    break;
                }
            }
            if (!isIn) 
            {
                text_msg_box.AppendText(given_username + " does not exist in the database!\n");
                return false;
            } 
            return true;
        }

        private bool is_already_follows(string follower_name, string target_name)
        {
            string path = Directory.GetCurrentDirectory() + "\\follows.txt";
            foreach (string line in File.ReadLines(path))
            {
                Follow fllw = Follow.stringToFollow(line);

                if(fllw.sender == follower_name && fllw.target_user == target_name)
                {
                    return true;
                }
            }
            return false;
        }

        private void delete_follower(string follower_name, string target_name)
        {
            string path = Directory.GetCurrentDirectory() + "\\follows.txt";
            string[] user_list = System.IO.File.ReadAllLines(path);
            List<string> converted_user_list = new List<string>(user_list);
            List<string> temp_list = converted_user_list;

            string line_to_delete = follower_name + "\t" + "follow" + "\t" + target_name;
            converted_user_list.Remove(line_to_delete);
            text_msg_box.AppendText("Line deleted: " + line_to_delete + "\n");

            string[] final_user_list = converted_user_list.ToArray();
            File.WriteAllLines(path, final_user_list, Encoding.UTF8);

        }

        private void ReceiveMsg(Socket current_client, string user_name)
         {
            bool connected = true;
             while (connected && !terminating)
             {
                try
                {
                    string incoming_request = GetMsgFromClient(current_client);
                    string[] requestParams = incoming_request.Split(new string[] {"***"}, StringSplitOptions.RemoveEmptyEntries);
                    
                    if(requestParams[0] == "loadfeeds")
                    {
                        List<Sweet> feed_list = sweets.OrderBy(s => s.date).ToList();
                        
                        string path = Directory.GetCurrentDirectory() + "\\sweet.txt";
                        if (!File.Exists(path))
                        {
                            using (StreamWriter sw = File.CreateText(path));
                        }
                        foreach (string line in File.ReadLines(path))
                        {
                            Sweet swt = Sweet.stringToSweet(line);
                            if(swt.sender != user_name)
                            {
                                string message = "\n+--- " + swt.sender + " ---+ [" + swt.date + "] ID:" + swt.id + "\n" + swt.content + "\n";


                                if (message.Length <= packet_size)
                                {
                                    Byte[] buffer = new byte[packet_size];
                                    buffer = Encoding.Default.GetBytes(message);
                                    current_client.Send(buffer);
                                }
                            }
                            
                        }

                        text_msg_box.AppendText("Message feed send to " + user_name + ".\n");

                    }
                    else if (requestParams[0] == "listusers")
                    {
                        string[] user_list = System.IO.File.ReadAllLines(@"..\\..\\user-db.txt");

                        foreach (string user in user_list)
                        {
                            if (user != user_name)
                            {
                                Thread.Sleep(2);
                                string message = "+--- " + user + " ---+\n";

                                if (message.Length <= packet_size)
                                {
                                    Byte[] buffer = new byte[packet_size];
                                    buffer = Encoding.Default.GetBytes(message);
                                    current_client.Send(buffer);
                                }
                            }

                        }

                        text_msg_box.AppendText("User list send to " + user_name + ".\n");

                    }

                    else if (requestParams[0] == "follow")
                    {
                        string path = Directory.GetCurrentDirectory() + "\\follows.txt";
                        if (!File.Exists(path))
                            File.AppendAllText(path, "");

                        string[] user_list = System.IO.File.ReadAllLines(@"..\\..\\user-db.txt");

                        if (user_list.Contains(requestParams[1]) && !is_already_follows(user_name, requestParams[1]))
                        {
                            RecordFollower(user_name, requestParams[0], requestParams[1]);
                            text_msg_box.AppendText(user_name + "is following " + requestParams[1] + ".\n");
                        }

                        else if(is_already_follows(user_name, requestParams[1]))
                        {
                            string msg_to_send = ("User " + user_name + " already following " + requestParams[1] + "!" + "\n");
                            text_msg_box.AppendText(msg_to_send);
                        }

                        else
                        {
                            text_msg_box.AppendText("User " + requestParams[1] + " does not exists!" + "\n");
                        }
                    }

                    else if (requestParams[0] == "unfollow")
                    {
                        string path = Directory.GetCurrentDirectory() + "\\follows.txt";
                        if (!File.Exists(path))
                            File.AppendAllText(path, "");

                        string[] user_list = System.IO.File.ReadAllLines(@"..\\..\\user-db.txt");

                        if (user_list.Contains(requestParams[1]) && is_already_follows(user_name, requestParams[1]))
                        {
                            delete_follower(user_name, requestParams[1]);
                            text_msg_box.AppendText(user_name + " unfollowed " + requestParams[1] + ".\n");
                        }

                        else if (!is_already_follows(user_name, requestParams[1]))
                        {
                            string msg_to_send = ("User " + user_name + " can't unfollow " + requestParams[1] + " because user already not following the other user!" + "\n");
                            text_msg_box.AppendText(msg_to_send);
                        }

                        else
                        {
                            text_msg_box.AppendText("Something unexpected happened in the unfollowing action! \n");
                        }
                    }

                    else if (requestParams[0] == "sendmessage")
                    {
                        RecordSweet(user_name, requestParams[1]);
                        text_msg_box.AppendText("Message recieved from " + user_name + ".\n");
                    }

                    else if (requestParams[0] == "followedfeed")
                    {
                        List<Sweet> feedfollowed_list = sweets.OrderBy(s => s.date).ToList();
                        string[] user_list = System.IO.File.ReadAllLines(@"..\\..\\user-db.txt");
                        string path = Directory.GetCurrentDirectory() + "\\sweet.txt";
                        if (!File.Exists(path))
                        {
                            using (StreamWriter sw = File.CreateText(path));
                        }
                        foreach (string line in File.ReadLines(path))
                        {
                            Sweet swt = Sweet.stringToSweet(line);
                            if (swt.sender != user_name && is_already_follows(user_name, swt.sender))
                            {
                                string message = "\n+--- " + swt.sender + " ---+ [" + swt.date + "] ID:" + swt.id + "\n" + swt.content + "\n";


                                if (message.Length <= packet_size)
                                {
                                    Byte[] buffer = new byte[packet_size];
                                    buffer = Encoding.Default.GetBytes(message);
                                    current_client.Send(buffer);
                                }
                            }

                        }

                        text_msg_box.AppendText("Followed users message feed send to " + user_name + ".\n");
                    }
                    

                }
                 catch 
                 {
                     if (!terminating)
                     {
                         text_msg_box.AppendText(user_name + " has disconnected!\n");
                     }
                     current_client.Close();
                     client_sockets.Remove(current_client);
                     connected_list.Remove(user_name);
                     connected = false;
                 }
             }
         }
       

        private string GetMsgFromClient(Socket client_socket)
        {
            Byte[] buffer = new byte[packet_size];
            client_socket.Receive(buffer);
            return Encoding.Default.GetString(buffer).Trim('\0');
        }

        private void RecordSweet(string user_name, string sweet_content)
        {
            Sweet newSweet = new Sweet(user_name, sweet_content);
            sweets.Add(newSweet);

            string message = newSweet.sender + "\t" + newSweet.date + "\t" + newSweet.id + "\t" + newSweet.content;

            try
            {
                string path = Directory.GetCurrentDirectory() + "\\sweet.txt";
                File.AppendAllText(path, message + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void RecordFollower(string user_name, string do_what, string target_name)
        {
            Follow newFollow = new Follow(user_name, do_what, target_name);
            follows.Add(newFollow);

            string action = newFollow.sender + "\t" + newFollow.do_what + "\t" + newFollow.target_user;

            try
            {
                string path = Directory.GetCurrentDirectory() + "\\follows.txt";
                File.AppendAllText(path, action + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }


        private void text_msg_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
