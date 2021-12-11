namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_loadfeeds = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_listusers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.follower_text_box = new System.Windows.Forms.TextBox();
            this.follow_button = new System.Windows.Forms.Button();
            this.unfollow_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(76, 50);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(131, 20);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(76, 79);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(131, 20);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(76, 140);
            this.button_connect.Margin = new System.Windows.Forms.Padding(2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(70, 23);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(287, 50);
            this.logs.Margin = new System.Windows.Forms.Padding(2);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(349, 251);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Enabled = false;
            this.textBox_message.Location = new System.Drawing.Point(76, 245);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(183, 20);
            this.textBox_message.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(76, 279);
            this.button_send.Margin = new System.Windows.Forms.Padding(2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(70, 22);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(76, 107);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(131, 20);
            this.textBox_username.TabIndex = 10;
            // 
            // button_loadfeeds
            // 
            this.button_loadfeeds.Enabled = false;
            this.button_loadfeeds.Location = new System.Drawing.Point(287, 316);
            this.button_loadfeeds.Name = "button_loadfeeds";
            this.button_loadfeeds.Size = new System.Drawing.Size(81, 23);
            this.button_loadfeeds.TabIndex = 11;
            this.button_loadfeeds.Text = "Load Feeds";
            this.button_loadfeeds.UseVisualStyleBackColor = true;
            this.button_loadfeeds.Click += new System.EventHandler(this.button_loadfeeds_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Enabled = false;
            this.button_disconnect.Location = new System.Drawing.Point(151, 140);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(70, 23);
            this.button_disconnect.TabIndex = 12;
            this.button_disconnect.Text = "disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_listusers
            // 
            this.button_listusers.Enabled = false;
            this.button_listusers.Location = new System.Drawing.Point(374, 316);
            this.button_listusers.Name = "button_listusers";
            this.button_listusers.Size = new System.Drawing.Size(81, 23);
            this.button_listusers.TabIndex = 13;
            this.button_listusers.Text = "Users";
            this.button_listusers.UseVisualStyleBackColor = true;
            this.button_listusers.Click += new System.EventHandler(this.button_listusers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name:";
            // 
            // follower_text_box
            // 
            this.follower_text_box.Enabled = false;
            this.follower_text_box.Location = new System.Drawing.Point(78, 178);
            this.follower_text_box.Name = "follower_text_box";
            this.follower_text_box.Size = new System.Drawing.Size(129, 20);
            this.follower_text_box.TabIndex = 17;
            // 
            // follow_button
            // 
            this.follow_button.Enabled = false;
            this.follow_button.Location = new System.Drawing.Point(76, 204);
            this.follow_button.Name = "follow_button";
            this.follow_button.Size = new System.Drawing.Size(70, 23);
            this.follow_button.TabIndex = 18;
            this.follow_button.Text = "Follow";
            this.follow_button.UseVisualStyleBackColor = true;
            this.follow_button.Click += new System.EventHandler(this.follow_button_Click);
            // 
            // unfollow_button
            // 
            this.unfollow_button.Enabled = false;
            this.unfollow_button.Location = new System.Drawing.Point(152, 204);
            this.unfollow_button.Name = "unfollow_button";
            this.unfollow_button.Size = new System.Drawing.Size(69, 23);
            this.unfollow_button.TabIndex = 19;
            this.unfollow_button.Text = "Unfollow";
            this.unfollow_button.UseVisualStyleBackColor = true;
            this.unfollow_button.Click += new System.EventHandler(this.unfollow_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 379);
            this.Controls.Add(this.unfollow_button);
            this.Controls.Add(this.follow_button);
            this.Controls.Add(this.follower_text_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_listusers);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_loadfeeds);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button button_loadfeeds;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_listusers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox follower_text_box;
        private System.Windows.Forms.Button follow_button;
        private System.Windows.Forms.Button unfollow_button;
    }
}

