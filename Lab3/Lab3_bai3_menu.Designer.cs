namespace Lab3
{
    partial class Lab3_bai3_menu
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
            btn_client = new Button();
            btn_server = new Button();
            SuspendLayout();
            // 
            // btn_client
            // 
            btn_client.Location = new Point(93, 199);
            btn_client.Name = "btn_client";
            btn_client.Size = new Size(112, 34);
            btn_client.TabIndex = 0;
            btn_client.Text = "button1";
            btn_client.UseVisualStyleBackColor = true;
            btn_client.Click += btn_client_Click;
            // 
            // btn_server
            // 
            btn_server.Location = new Point(403, 176);
            btn_server.Name = "btn_server";
            btn_server.Size = new Size(112, 34);
            btn_server.TabIndex = 1;
            btn_server.Text = "button2";
            btn_server.UseVisualStyleBackColor = true;
            btn_server.Click += btn_server_Click;
            // 
            // Lab3_bai3_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_server);
            Controls.Add(btn_client);
            Name = "Lab3_bai3_menu";
            Text = "Lab3_bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_client;
        private Button btn_server;
    }
}