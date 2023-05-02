namespace Lab3
{
    partial class Lab3_bai3_client
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
            btn_disconect = new Button();
            bangchat = new TextBox();
            SuspendLayout();
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.Black;
            btn_connect.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_connect.ForeColor = Color.White;
            btn_connect.Location = new Point(682, 54);
            btn_connect.Margin = new Padding(4);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(134, 41);
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
            btn_send.Location = new Point(682, 133);
            btn_send.Margin = new Padding(4);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(134, 41);
            btn_send.TabIndex = 1;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // btn_disconect
            // 
            btn_disconect.BackColor = Color.Black;
            btn_disconect.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_disconect.ForeColor = Color.White;
            btn_disconect.Location = new Point(682, 215);
            btn_disconect.Margin = new Padding(4);
            btn_disconect.Name = "btn_disconect";
            btn_disconect.Size = new Size(134, 41);
            btn_disconect.TabIndex = 2;
            btn_disconect.Text = "Disconnect";
            btn_disconect.UseVisualStyleBackColor = false;
            btn_disconect.Click += btn_disconect_Click;
            // 
            // bangchat
            // 
            bangchat.Location = new Point(41, 54);
            bangchat.Multiline = true;
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(562, 202);
            bangchat.TabIndex = 3;
            // 
            // Lab3_bai3_client
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 316);
            Controls.Add(bangchat);
            Controls.Add(btn_disconect);
            Controls.Add(btn_send);
            Controls.Add(btn_connect);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab3_bai3_client";
            Text = "Lab3_bai3_client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_connect;
        private Button btn_send;
        private Button btn_disconect;
        private TextBox bangchat;
    }
}