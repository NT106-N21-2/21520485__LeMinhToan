namespace Lab3
{
    partial class Lab3_bai1_server
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
            port = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bangchat = new ListBox();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(469, 100);
            btn_listen.Margin = new Padding(4, 4, 4, 4);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(163, 54);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // port
            // 
            port.Location = new Point(116, 109);
            port.Margin = new Padding(4, 4, 4, 4);
            port.Name = "port";
            port.Size = new Size(179, 37);
            port.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 30);
            label1.TabIndex = 2;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 202);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 30);
            label2.TabIndex = 3;
            label2.Text = "Receive messages";
            // 
            // bangchat
            // 
            bangchat.FormattingEnabled = true;
            bangchat.ItemHeight = 30;
            bangchat.Location = new Point(61, 235);
            bangchat.Margin = new Padding(4, 4, 4, 4);
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(571, 244);
            bangchat.TabIndex = 4;
            // 
            // Lab3_bai1_server
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 557);
            Controls.Add(bangchat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(port);
            Controls.Add(btn_listen);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Lab3_bai1_server";
            Text = "Lab3_bai1_server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox port;
        private Label label1;
        private Label label2;
        private ListBox bangchat;
    }
}