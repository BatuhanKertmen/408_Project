using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        string sender;
        string content;
        DateTime date;
        public Sweet(string sender_info, string content_info)
        {
            sender = sender_info;
            content = content_info;
            date = DateTime.Now;
        }
    }

    public partial class Form1 : Form
    {
        Socket server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> client_sockets = new List<Socket>();
        List<string> connected_list = new List<string>();
        List<Sweet> sweets = new List<Sweet>();

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
            int server_port;
            if(Int32.TryParse(text_port.Text, out server_port))
            {
                try
                {
                    IPEndPoint end_point = new IPEndPoint(IPAddress.Any, server_port);
                    server_socket.Bind(end_point);
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
                    Byte[] buffer = new Byte[256];
                    client_socket.Receive(buffer);
                    string incomingUsername = Encoding.Default.GetString(buffer);

                    string[] usernames = System.IO.File.ReadAllLines(@"C:\Users\Lenovo\Desktop\408_Project\408_Project\Server\user-db.txt");
                    bool user_name_check = CheckUserName(incomingUsername, usernames);

                    if (user_name_check)
                    {
                        client_sockets.Add(client_socket);
                        text_msg_box.AppendText(incomingUsername + " connected!\n");

                        Byte[] buffer2 = new byte[64]; 
                        buffer2 = Encoding.Default.GetBytes("yes");
                        client_socket.Send(buffer2);
                        connected_list.Add(incomingUsername);

                        Thread recieve_msg_thread = new Thread(() => RecieveMsg(client_socket));
                    }
                    else
                    {
                        Byte[] buffer2 = new byte[64];
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
            if (connected_list.Any(given_username.Contains))
            {
                text_msg_box.AppendText(given_username + " has already connected to server!\n");
                return false;
            }
            if (!usernames.Any(given_username.Contains))
            {
                text_msg_box.AppendText("Could not found " + given_username + " in the user database!\n");
                return false;
            } 
            return true;
        }
        private void RecieveMsg(Socket current_client)
        {
            bool connected = true;
            while (connected && !terminating)
            {
                try
                { 
                    string incoming_sweet = GetMsgFromClient(current_client);
                    Sweet new_sweet = ParseSweetString(incoming_sweet);

                    RecordSweet(new_sweet);
                    text_msg_box.AppendText("Message recieved.\n");
                }
                catch 
                {
                    if (!terminating)
                    {
                        text_msg_box.AppendText("A client has disconnected!\n");
                    }
                }
            }
        }

        private string GetMsgFromClient(Socket client_socket)
        {
            Byte[] buffer = new byte[256];
            client_socket.Receive(buffer);
            return Encoding.Default.GetString(buffer);
        }
        private Sweet ParseSweetString(string sweet_string)
        {
            /*
             *
             * TO DO: parse sweet string to sender and content
             *
             */
            string sweet_sender = "dummy sender";
            string sweet_content = "dummy content";
            return new Sweet(sweet_sender, sweet_content);
        }
        private void RecordSweet(Sweet sweet)
        {
            sweets.Add(sweet);
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }
    }
}
