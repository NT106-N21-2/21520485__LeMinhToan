namespace Lab3
{
    partial class Lab3_bai1_client
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
            btn_send = new Button();
            bangchat = new TextBox();
            ip = new TextBox();
            port = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_send
            // 
            btn_send.Location = new Point(73, 382);
            btn_send.Margin = new Padding(4);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(134, 41);
            btn_send.TabIndex = 0;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // bangchat
            // 
            bangchat.Location = new Point(72, 182);
            bangchat.Margin = new Padding(4);
            bangchat.Multiline = true;
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(631, 177);
            bangchat.TabIndex = 1;
            // 
            // ip
            // 
            ip.Location = new Point(73, 80);
            ip.Margin = new Padding(4);
            ip.Name = "ip";
            ip.Size = new Size(246, 37);
            ip.TabIndex = 2;
            // 
            // port
            // 
            port.Location = new Point(524, 80);
            port.Margin = new Padding(4);
            port.Name = "port";
            port.Size = new Size(179, 37);
            port.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 4;
            label1.Text = "IP Remote Host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 6;
            label3.Text = "Message";
            // 
            // Lab3_bai1_client
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 462);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(port);
            Controls.Add(ip);
            Controls.Add(bangchat);
            Controls.Add(btn_send);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab3_bai1_client";
            Text = "Lab3_bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_send;
        private TextBox bangchat;
        private TextBox ip;
        private TextBox port;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}