namespace Lab06
{
    partial class Lab06_bai3_server
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
            pictureBox1 = new PictureBox();
            btn_listen = new Button();
            btn_stop = new Button();
            bangchat = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._344542990_247747164432357_8767651817081568893_n1;
            pictureBox1.Location = new Point(532, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_listen
            // 
            btn_listen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_listen.Location = new Point(543, 26);
            btn_listen.Margin = new Padding(4);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(187, 53);
            btn_listen.TabIndex = 3;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // btn_stop
            // 
            btn_stop.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stop.Location = new Point(543, 101);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(187, 58);
            btn_stop.TabIndex = 6;
            btn_stop.Text = "Stop Listen";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Visible = false;
            btn_stop.Click += btn_stop_Click;
            // 
            // bangchat
            // 
            bangchat.BackColor = SystemColors.Menu;
            bangchat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bangchat.FormattingEnabled = true;
            bangchat.ItemHeight = 32;
            bangchat.Location = new Point(14, 26);
            bangchat.Margin = new Padding(5);
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(491, 356);
            bangchat.TabIndex = 17;
            // 
            // Lab06_bai3_server
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(777, 413);
            Controls.Add(bangchat);
            Controls.Add(btn_stop);
            Controls.Add(pictureBox1);
            Controls.Add(btn_listen);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab06_bai3_server";
            Text = "Lab06_bai3_server";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_listen;
        private Button btn_stop;
        private ListBox bangchat;
    }
}