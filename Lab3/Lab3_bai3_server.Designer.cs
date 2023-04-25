namespace Lab3
{
    partial class Lab3_bai3_server
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
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(568, 39);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(178, 58);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // bangchat
            // 
            bangchat.FormattingEnabled = true;
            bangchat.ItemHeight = 25;
            bangchat.Location = new Point(48, 118);
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(505, 254);
            bangchat.TabIndex = 1;
            // 
            // Lab3_bai3_server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 402);
            Controls.Add(bangchat);
            Controls.Add(btn_listen);
            Name = "Lab3_bai3_server";
            Text = "Lab3_bai3_server";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_listen;
        private ListBox bangchat;
    }
}