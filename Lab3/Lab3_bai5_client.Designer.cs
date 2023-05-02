namespace Lab3
{
    partial class Lab3_bai5_client
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
            message = new TextBox();
            bangchat = new ListBox();
            nameclient = new TextBox();
            label_name = new Label();
            btn_send = new Button();
            danhsachclient = new ListBox();
            toclient = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // message
            // 
            message.Location = new Point(47, 474);
            message.Multiline = true;
            message.Name = "message";
            message.Size = new Size(454, 75);
            message.TabIndex = 0;
            // 
            // bangchat
            // 
            bangchat.FormattingEnabled = true;
            bangchat.ItemHeight = 30;
            bangchat.Location = new Point(47, 44);
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(454, 394);
            bangchat.TabIndex = 1;
            // 
            // nameclient
            // 
            nameclient.Location = new Point(549, 77);
            nameclient.Name = "nameclient";
            nameclient.Size = new Size(239, 37);
            nameclient.TabIndex = 2;
            nameclient.Leave += nameclient_Leave;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(549, 44);
            label_name.Name = "label_name";
            label_name.Size = new Size(128, 30);
            label_name.TabIndex = 3;
            label_name.Text = "Tên của bạn";
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.Black;
            btn_send.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.ForeColor = Color.White;
            btn_send.Location = new Point(549, 474);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(112, 75);
            btn_send.TabIndex = 4;
            btn_send.Text = "Gửi";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // danhsachclient
            // 
            danhsachclient.FormattingEnabled = true;
            danhsachclient.ItemHeight = 30;
            danhsachclient.Location = new Point(549, 168);
            danhsachclient.Name = "danhsachclient";
            danhsachclient.Size = new Size(239, 184);
            danhsachclient.TabIndex = 5;
            // 
            // toclient
            // 
            toclient.FormattingEnabled = true;
            toclient.Location = new Point(549, 400);
            toclient.Name = "toclient";
            toclient.Size = new Size(239, 38);
            toclient.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 367);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 7;
            label1.Text = "Bạn muốn gửi tin đến:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 135);
            label2.Name = "label2";
            label2.Size = new Size(266, 30);
            label2.TabIndex = 8;
            label2.Text = "Những người đang online:";
            // 
            // Lab3_bai5_client
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(830, 578);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toclient);
            Controls.Add(danhsachclient);
            Controls.Add(btn_send);
            Controls.Add(label_name);
            Controls.Add(nameclient);
            Controls.Add(bangchat);
            Controls.Add(message);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab3_bai5_client";
            Text = "Lab3_bai5_client";
            FormClosed += Lab3_bai5_client_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox message;
        private ListBox bangchat;
        private TextBox nameclient;
        private Label label_name;
        private Button btn_send;
        private ListBox danhsachclient;
        private ComboBox toclient;
        private Label label1;
        private Label label2;
    }
}