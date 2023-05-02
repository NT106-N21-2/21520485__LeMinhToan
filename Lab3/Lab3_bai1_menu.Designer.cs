namespace Lab3
{
    partial class Lab3_bai1_menu
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
            btn_serverform = new Button();
            btn_clientform = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_serverform
            // 
            btn_serverform.BackColor = Color.Black;
            btn_serverform.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_serverform.ForeColor = Color.White;
            btn_serverform.Location = new Point(94, 89);
            btn_serverform.Name = "btn_serverform";
            btn_serverform.Size = new Size(131, 82);
            btn_serverform.TabIndex = 0;
            btn_serverform.Text = "UDP server";
            btn_serverform.UseVisualStyleBackColor = false;
            btn_serverform.Click += button1_Click;
            // 
            // btn_clientform
            // 
            btn_clientform.BackColor = Color.Black;
            btn_clientform.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clientform.ForeColor = Color.White;
            btn_clientform.Location = new Point(94, 234);
            btn_clientform.Name = "btn_clientform";
            btn_clientform.Size = new Size(131, 82);
            btn_clientform.TabIndex = 1;
            btn_clientform.Text = "UDP client";
            btn_clientform.UseVisualStyleBackColor = false;
            btn_clientform.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._09fcc60a5507d1ab92b587284f09a9c2;
            pictureBox1.Location = new Point(269, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Lab3_bai1_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 435);
            Controls.Add(pictureBox1);
            Controls.Add(btn_clientform);
            Controls.Add(btn_serverform);
            Name = "Lab3_bai1_menu";
            Text = "Lab3_bai1_menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_serverform;
        private Button btn_clientform;
        private PictureBox pictureBox1;
    }
}