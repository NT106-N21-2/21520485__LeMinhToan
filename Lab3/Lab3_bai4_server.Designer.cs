namespace Lab3
{
    partial class Lab3_bai4_server
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
            btn_listen = new Button();
            bangchat = new ListBox();
            ip = new TextBox();
            port = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.BackColor = Color.Black;
            btn_listen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_listen.ForeColor = Color.White;
            btn_listen.Location = new Point(461, 43);
            btn_listen.Margin = new Padding(4);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(277, 59);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = false;
            btn_listen.Click += btn_listen_Click_1;
            // 
            // bangchat
            // 
            bangchat.BackColor = SystemColors.Control;
            bangchat.FormattingEnabled = true;
            bangchat.ItemHeight = 30;
            bangchat.Location = new Point(37, 43);
            bangchat.Margin = new Padding(4);
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(399, 454);
            bangchat.TabIndex = 1;
            // 
            // ip
            // 
            ip.Location = new Point(520, 175);
            ip.Margin = new Padding(4);
            ip.Name = "ip";
            ip.Size = new Size(218, 37);
            ip.TabIndex = 2;
            // 
            // port
            // 
            port.Location = new Point(520, 267);
            port.Margin = new Padding(4);
            port.Name = "port";
            port.Size = new Size(218, 37);
            port.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 182);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 4;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 274);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._316621181_692162748901872_4721747070078868613_n;
            pictureBox1.Location = new Point(520, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Lab3_bai4_server
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(771, 534);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(port);
            Controls.Add(ip);
            Controls.Add(bangchat);
            Controls.Add(btn_listen);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab3_bai4_server";
            Text = "Lab3_bai4_server";
            FormClosed += Lab3_bai4_server_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private ListBox bangchat;
        private TextBox ip;
        private TextBox port;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}