using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {

        bool terminating = false;
        bool connected = false;
        Socket clientSocket;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = textBox_ip.Text;

            int portNum;
            if(Int32.TryParse(textBox_port.Text, out portNum))
            {
                try
                {
                    clientSocket.Connect(IP, portNum);
                    button_connect.Enabled = false;
                    textBox_message.Enabled = true;
                    textBox_username.Enabled = false;
                    button_send.Enabled = true;
                    connected = true;
                    logs.AppendText("Connecting to the server!\n");

                    Byte[] buffer = new Byte[64];

                    string username = textBox_username.Text;
                    buffer = Encoding.Default.GetBytes(username);
                    clientSocket.Send(buffer);

                    Byte[] buffer2 = new Byte[64];
                    clientSocket.Receive(buffer2);

                    string incomingMessage = Encoding.Default.GetString(buffer2).Trim('\0');

                    if (incomingMessage == "yes")
                    {
                        logs.AppendText("Connected to the server!\n");
                        button_connect.Enabled = false;
                        textBox_message.Enabled = true;
                        button_send.Enabled = true;

                        connected = true;

                        Thread receiveThread = new Thread(Receive);
                        receiveThread.Start();
                    }
                    if (incomingMessage == "no")
                    {
                        button_connect.Enabled = true;
                        textBox_message.Enabled = false;
                        textBox_username.Enabled = true;
                        button_send.Enabled = false;
                        connected = false;

                        logs.AppendText("Username Check Failed!\n");

                    }
                   
                }
                catch
                {
                    logs.AppendText("Could not connect to the server!\n");
                }
            }
            else
            {
                logs.AppendText("Check the port\n");
            }

        }

        private void Receive()
        {
            while(connected)
            {
                try
                {
                    Byte[] buffer = new Byte[256];
                    clientSocket.Receive(buffer);

                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));

                    logs.AppendText("Server: " + incomingMessage + "\n");
                }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("The server has disconnected\n");
                        button_connect.Enabled = true;
                        textBox_message.Enabled = false;
                        button_send.Enabled = false;
                        textBox_username.Enabled = true;
                    }

                    clientSocket.Close();
                    connected = false;
                }

            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;

            if(message != "" && message.Length <= 64)
            {
                Byte[] buffer = Encoding.Default.GetBytes(message);
                clientSocket.Send(buffer);
            }

        }

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
