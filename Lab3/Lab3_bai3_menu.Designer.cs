﻿namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3_bai3_menu));
            btn_client = new Button();
            btn_server = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_client
            // 
            btn_client.BackColor = Color.Black;
            btn_client.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_client.ForeColor = Color.White;
            btn_client.Location = new Point(69, 250);
            btn_client.Name = "btn_client";
            btn_client.Size = new Size(153, 75);
            btn_client.TabIndex = 0;
            btn_client.Text = "Client";
            btn_client.UseVisualStyleBackColor = false;
            btn_client.Click += btn_client_Click;
            // 
            // btn_server
            // 
            btn_server.BackColor = Color.Black;
            btn_server.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_server.ForeColor = Color.White;
            btn_server.Location = new Point(69, 82);
            btn_server.Name = "btn_server";
            btn_server.Size = new Size(153, 75);
            btn_server.TabIndex = 1;
            btn_server.Text = "Server";
            btn_server.UseVisualStyleBackColor = false;
            btn_server.Click += btn_server_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Lab3_bai3_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(522, 409);
            Controls.Add(pictureBox1);
            Controls.Add(btn_server);
            Controls.Add(btn_client);
            Name = "Lab3_bai3_menu";
            Text = "Lab3_bai3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_client;
        private Button btn_server;
        private PictureBox pictureBox1;
    }
}