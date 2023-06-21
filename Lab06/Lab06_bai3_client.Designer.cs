namespace Lab06
{
    partial class Lab06_bai3_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab06_bai3_client));
            panel_main = new Panel();
            label2 = new Label();
            label1 = new Label();
            port_tb = new TextBox();
            ip_tb = new TextBox();
            btn_disconnect = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            Chat = new ListBox();
            btn_connect = new Button();
            inputmess = new TextBox();
            btn_send = new Button();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.White;
            panel_main.Controls.Add(btn_send);
            panel_main.Controls.Add(label2);
            panel_main.Controls.Add(label1);
            panel_main.Controls.Add(port_tb);
            panel_main.Controls.Add(ip_tb);
            panel_main.Controls.Add(btn_disconnect);
            panel_main.Controls.Add(label3);
            panel_main.Controls.Add(pictureBox2);
            panel_main.Controls.Add(Chat);
            panel_main.Controls.Add(btn_connect);
            panel_main.Controls.Add(inputmess);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(657, 581);
            panel_main.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 86);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 26;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 25;
            label1.Text = "IP";
            // 
            // port_tb
            // 
            port_tb.Location = new Point(20, 83);
            port_tb.Name = "port_tb";
            port_tb.Size = new Size(257, 37);
            port_tb.TabIndex = 24;
            // 
            // ip_tb
            // 
            ip_tb.Location = new Point(20, 29);
            ip_tb.Name = "ip_tb";
            ip_tb.Size = new Size(257, 37);
            ip_tb.TabIndex = 23;
            // 
            // btn_disconnect
            // 
            btn_disconnect.BackColor = Color.Black;
            btn_disconnect.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_disconnect.ForeColor = Color.White;
            btn_disconnect.Location = new Point(459, 29);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(170, 64);
            btn_disconnect.TabIndex = 22;
            btn_disconnect.Text = "Disconnect";
            btn_disconnect.UseVisualStyleBackColor = false;
            btn_disconnect.Visible = false;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 136);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 21;
            label3.Text = "Nhập tin nhắn";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(443, 231);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 324);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Chat
            // 
            Chat.BackColor = SystemColors.Menu;
            Chat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Chat.FormattingEnabled = true;
            Chat.ItemHeight = 32;
            Chat.Location = new Point(20, 231);
            Chat.Margin = new Padding(5);
            Chat.Name = "Chat";
            Chat.Size = new Size(402, 324);
            Chat.TabIndex = 16;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.Black;
            btn_connect.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_connect.ForeColor = Color.White;
            btn_connect.Location = new Point(457, 29);
            btn_connect.Margin = new Padding(5);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(170, 64);
            btn_connect.TabIndex = 15;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_find_Click;
            // 
            // inputmess
            // 
            inputmess.BackColor = SystemColors.Menu;
            inputmess.Location = new Point(20, 171);
            inputmess.Margin = new Padding(5);
            inputmess.Name = "inputmess";
            inputmess.Size = new Size(402, 37);
            inputmess.TabIndex = 14;
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.Black;
            btn_send.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.ForeColor = Color.White;
            btn_send.Location = new Point(459, 156);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(168, 52);
            btn_send.TabIndex = 27;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += button1_Click;
            // 
            // Lab06_bai3_client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 581);
            Controls.Add(panel_main);
            Name = "Lab06_bai3_client";
            Text = "Lab06_bai3_client";
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Button btn_disconnect;
        private Label label3;
        private Label label4;
        private CheckBox checkBoxipv6;
        private CheckBox checkBoxipv4;
        private PictureBox pictureBox2;
        private ListBox Chat;
        private Button btn_connect;
        private TextBox inputmess;
        private Label label2;
        private Label label1;
        private TextBox port_tb;
        private TextBox ip_tb;
        private Button btn_send;
    }
}