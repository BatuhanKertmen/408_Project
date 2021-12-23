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
            this.button_followedfeed = new System.Windows.Forms.Button();
            this.block_button = new System.Windows.Forms.Button();
            this.button_current_followed_users = new System.Windows.Forms.Button();
            this.button_current_followers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_sweet_id = new System.Windows.Forms.TextBox();
            this.button_delete_sweet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(101, 62);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(173, 22);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(101, 97);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(173, 22);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(101, 172);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(93, 28);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(383, 62);
            this.logs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(464, 308);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Enabled = false;
            this.textBox_message.Location = new System.Drawing.Point(101, 309);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(243, 22);
            this.textBox_message.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(101, 335);
            this.button_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(93, 27);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(101, 132);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(173, 22);
            this.textBox_username.TabIndex = 4;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // button_loadfeeds
            // 
            this.button_loadfeeds.Enabled = false;
            this.button_loadfeeds.Location = new System.Drawing.Point(383, 389);
            this.button_loadfeeds.Margin = new System.Windows.Forms.Padding(4);
            this.button_loadfeeds.Name = "button_loadfeeds";
            this.button_loadfeeds.Size = new System.Drawing.Size(108, 28);
            this.button_loadfeeds.TabIndex = 11;
            this.button_loadfeeds.Text = "Load Feeds";
            this.button_loadfeeds.UseVisualStyleBackColor = true;
            this.button_loadfeeds.Click += new System.EventHandler(this.button_loadfeeds_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Enabled = false;
            this.button_disconnect.Location = new System.Drawing.Point(201, 172);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(93, 28);
            this.button_disconnect.TabIndex = 12;
            this.button_disconnect.Text = "disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_listusers
            // 
            this.button_listusers.Enabled = false;
            this.button_listusers.Location = new System.Drawing.Point(499, 389);
            this.button_listusers.Margin = new System.Windows.Forms.Padding(4);
            this.button_listusers.Name = "button_listusers";
            this.button_listusers.Size = new System.Drawing.Size(108, 28);
            this.button_listusers.TabIndex = 13;
            this.button_listusers.Text = "Users";
            this.button_listusers.UseVisualStyleBackColor = true;
            this.button_listusers.Click += new System.EventHandler(this.button_listusers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name:";
            // 
            // follower_text_box
            // 
            this.follower_text_box.Enabled = false;
            this.follower_text_box.Location = new System.Drawing.Point(101, 219);
            this.follower_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.follower_text_box.Name = "follower_text_box";
            this.follower_text_box.Size = new System.Drawing.Size(171, 22);
            this.follower_text_box.TabIndex = 17;
            // 
            // follow_button
            // 
            this.follow_button.Enabled = false;
            this.follow_button.Location = new System.Drawing.Point(48, 251);
            this.follow_button.Margin = new System.Windows.Forms.Padding(4);
            this.follow_button.Name = "follow_button";
            this.follow_button.Size = new System.Drawing.Size(93, 28);
            this.follow_button.TabIndex = 18;
            this.follow_button.Text = "Follow";
            this.follow_button.UseVisualStyleBackColor = true;
            this.follow_button.Click += new System.EventHandler(this.follow_button_Click);
            // 
            // unfollow_button
            // 
            this.unfollow_button.Enabled = false;
            this.unfollow_button.Location = new System.Drawing.Point(149, 251);
            this.unfollow_button.Margin = new System.Windows.Forms.Padding(4);
            this.unfollow_button.Name = "unfollow_button";
            this.unfollow_button.Size = new System.Drawing.Size(92, 28);
            this.unfollow_button.TabIndex = 19;
            this.unfollow_button.Text = "Unfollow";
            this.unfollow_button.UseVisualStyleBackColor = true;
            this.unfollow_button.Click += new System.EventHandler(this.unfollow_button_Click);
            // 
            // button_followedfeed
            // 
            this.button_followedfeed.Enabled = false;
            this.button_followedfeed.Location = new System.Drawing.Point(615, 389);
            this.button_followedfeed.Name = "button_followedfeed";
            this.button_followedfeed.Size = new System.Drawing.Size(172, 28);
            this.button_followedfeed.TabIndex = 20;
            this.button_followedfeed.Text = "Load Feeds of Followed";
            this.button_followedfeed.UseVisualStyleBackColor = true;
            this.button_followedfeed.Click += new System.EventHandler(this.button_followedfeed_Click);
            // 
            // block_button
            // 
            this.block_button.Enabled = false;
            this.block_button.Location = new System.Drawing.Point(251, 251);
            this.block_button.Name = "block_button";
            this.block_button.Size = new System.Drawing.Size(93, 28);
            this.block_button.TabIndex = 21;
            this.block_button.Text = "Block";
            this.block_button.UseVisualStyleBackColor = true;
            this.block_button.Click += new System.EventHandler(this.block_button_Click);
            // 
            // button_current_followed_users
            // 
            this.button_current_followed_users.Location = new System.Drawing.Point(383, 424);
            this.button_current_followed_users.Name = "button_current_followed_users";
            this.button_current_followed_users.Size = new System.Drawing.Size(209, 28);
            this.button_current_followed_users.TabIndex = 22;
            this.button_current_followed_users.Text = "Current Followed Users";
            this.button_current_followed_users.UseVisualStyleBackColor = true;
            this.button_current_followed_users.Click += new System.EventHandler(this.button_current_followed_users_Click);
            // 
            // button_current_followers
            // 
            this.button_current_followers.Location = new System.Drawing.Point(598, 424);
            this.button_current_followers.Name = "button_current_followers";
            this.button_current_followers.Size = new System.Drawing.Size(189, 28);
            this.button_current_followers.TabIndex = 23;
            this.button_current_followers.Text = "Current Followers";
            this.button_current_followers.UseVisualStyleBackColor = true;
            this.button_current_followers.Click += new System.EventHandler(this.button_current_followers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sweet id:";
            // 
            // textBox_sweet_id
            // 
            this.textBox_sweet_id.Location = new System.Drawing.Point(101, 379);
            this.textBox_sweet_id.Name = "textBox_sweet_id";
            this.textBox_sweet_id.Size = new System.Drawing.Size(243, 22);
            this.textBox_sweet_id.TabIndex = 25;
            // 
            // button_delete_sweet
            // 
            this.button_delete_sweet.Location = new System.Drawing.Point(101, 407);
            this.button_delete_sweet.Name = "button_delete_sweet";
            this.button_delete_sweet.Size = new System.Drawing.Size(104, 30);
            this.button_delete_sweet.TabIndex = 26;
            this.button_delete_sweet.Text = "Delete Sweet";
            this.button_delete_sweet.UseVisualStyleBackColor = true;
            this.button_delete_sweet.Click += new System.EventHandler(this.button_delete_sweet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 466);
            this.Controls.Add(this.button_delete_sweet);
            this.Controls.Add(this.textBox_sweet_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_current_followers);
            this.Controls.Add(this.button_current_followed_users);
            this.Controls.Add(this.block_button);
            this.Controls.Add(this.button_followedfeed);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button_followedfeed;
        private System.Windows.Forms.Button block_button;
        private System.Windows.Forms.Button button_current_followed_users;
        private System.Windows.Forms.Button button_current_followers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_sweet_id;
        private System.Windows.Forms.Button button_delete_sweet;
    }
}

