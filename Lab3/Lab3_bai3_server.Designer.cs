﻿namespace Lab3
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.BackColor = Color.Black;
            btn_listen.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_listen.ForeColor = Color.White;
            btn_listen.Location = new Point(549, 43);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(178, 58);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = false;
            btn_listen.Click += btn_listen_Click;
            // 
            // bangchat
            // 
            bangchat.BackColor = SystemColors.Control;
            bangchat.FormattingEnabled = true;
            bangchat.ItemHeight = 25;
            bangchat.Location = new Point(48, 43);
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(474, 329);
            bangchat.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._337377924_753227822941188_8911353241790681256_n1;
            pictureBox1.Location = new Point(552, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 253);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Lab3_bai3_server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(752, 405);
            Controls.Add(pictureBox1);
            Controls.Add(bangchat);
            Controls.Add(btn_listen);
            Name = "Lab3_bai3_server";
            Text = "Lab3_bai3_server";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_listen;
        private ListBox bangchat;
        private PictureBox pictureBox1;
    }
}