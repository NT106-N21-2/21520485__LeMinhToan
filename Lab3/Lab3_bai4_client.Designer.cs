namespace Lab3
{
    partial class Lab3_bai4_client
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
            btn_connect = new Button();
            btn_send = new Button();
            btn_disconnect = new Button();
            bangchat = new TextBox();
            ips1 = new TextBox();
            ports1 = new TextBox();
            ips2 = new TextBox();
            ports2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.Black;
            btn_connect.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_connect.ForeColor = Color.White;
            btn_connect.Location = new Point(832, 39);
            btn_connect.Margin = new Padding(4);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(145, 60);
            btn_connect.TabIndex = 0;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.Black;
            btn_send.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.ForeColor = Color.White;
            btn_send.Location = new Point(784, 415);
            btn_send.Margin = new Padding(4);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(193, 56);
            btn_send.TabIndex = 1;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // btn_disconnect
            // 
            btn_disconnect.BackColor = Color.Black;
            btn_disconnect.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_disconnect.ForeColor = Color.White;
            btn_disconnect.Location = new Point(832, 134);
            btn_disconnect.Margin = new Padding(4);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(145, 59);
            btn_disconnect.TabIndex = 2;
            btn_disconnect.Text = "Disconnect";
            btn_disconnect.UseVisualStyleBackColor = false;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // bangchat
            // 
            bangchat.Location = new Point(59, 257);
            bangchat.Margin = new Padding(4);
            bangchat.Multiline = true;
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(667, 214);
            bangchat.TabIndex = 3;
            // 
            // ips1
            // 
            ips1.Location = new Point(59, 41);
            ips1.Margin = new Padding(4);
            ips1.Name = "ips1";
            ips1.Size = new Size(179, 37);
            ips1.TabIndex = 4;
            // 
            // ports1
            // 
            ports1.Location = new Point(59, 156);
            ports1.Margin = new Padding(4);
            ports1.Name = "ports1";
            ports1.Size = new Size(179, 37);
            ports1.TabIndex = 5;
            // 
            // ips2
            // 
            ips2.Location = new Point(404, 41);
            ips2.Margin = new Padding(4);
            ips2.Name = "ips2";
            ips2.Size = new Size(179, 37);
            ips2.TabIndex = 6;
            // 
            // ports2
            // 
            ports2.Location = new Point(404, 156);
            ports2.Margin = new Padding(4);
            ports2.Name = "ports2";
            ports2.Size = new Size(179, 37);
            ports2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 8;
            label1.Text = "IP server 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(611, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 9;
            label2.Text = "IP server 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 163);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 10;
            label3.Text = "Port server 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 161);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 11;
            label4.Text = "Port serer 1";
            // 
            // Lab3_bai4_client
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1012, 499);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ports2);
            Controls.Add(ips2);
            Controls.Add(ports1);
            Controls.Add(ips1);
            Controls.Add(bangchat);
            Controls.Add(btn_disconnect);
            Controls.Add(btn_send);
            Controls.Add(btn_connect);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab3_bai4_client";
            Text = "Lab3_bai4_client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_connect;
        private Button btn_send;
        private Button btn_disconnect;
        private TextBox bangchat;
        private TextBox ips1;
        private TextBox ports1;
        private TextBox ips2;
        private TextBox ports2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}