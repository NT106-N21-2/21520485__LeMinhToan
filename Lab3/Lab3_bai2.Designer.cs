namespace Lab3
{
    partial class Lab3_bai2
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
            bangchat = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.BackColor = Color.Black;
            btn_listen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_listen.ForeColor = Color.White;
            btn_listen.Location = new Point(40, 49);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(164, 55);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = false;
            btn_listen.Click += btn_listen_Click;
            // 
            // bangchat
            // 
            bangchat.BackColor = SystemColors.Control;
            bangchat.Location = new Point(40, 139);
            bangchat.Multiline = true;
            bangchat.Name = "bangchat";
            bangchat.ScrollBars = ScrollBars.Both;
            bangchat.Size = new Size(527, 328);
            bangchat.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._306741601_463645979202813_4431913471955987039_n;
            pictureBox1.Location = new Point(234, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Lab3_bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 501);
            Controls.Add(pictureBox1);
            Controls.Add(bangchat);
            Controls.Add(btn_listen);
            Name = "Lab3_bai2";
            Text = "Lab3_bai2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox bangchat;
        private PictureBox pictureBox1;
    }
}