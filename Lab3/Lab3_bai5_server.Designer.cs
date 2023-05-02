namespace Lab3
{
    partial class Lab3_bai5_server
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
            btn_listen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_listen.Location = new Point(552, 29);
            btn_listen.Margin = new Padding(4);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(187, 53);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // bangchat
            // 
            bangchat.BackColor = SystemColors.Menu;
            bangchat.FormattingEnabled = true;
            bangchat.ItemHeight = 30;
            bangchat.Location = new Point(38, 29);
            bangchat.Margin = new Padding(4);
            bangchat.Name = "bangchat";
            bangchat.Size = new Size(466, 484);
            bangchat.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.yellow_orange_animated_character_larva_animal_with_confused_expression_on_white_background_wallpaper_828x1792_218;
            pictureBox1.Location = new Point(529, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Lab3_bai5_server
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 551);
            Controls.Add(pictureBox1);
            Controls.Add(bangchat);
            Controls.Add(btn_listen);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab3_bai5_server";
            Text = "Lab3_bai5_server";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_listen;
        private ListBox bangchat;
        private PictureBox pictureBox1;
    }
}