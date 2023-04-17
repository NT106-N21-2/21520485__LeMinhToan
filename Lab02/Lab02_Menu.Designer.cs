namespace Lab02
{
    partial class Lab02_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02_Menu));
            btn_bai1 = new Button();
            btn_bai2 = new Button();
            btn_bai3 = new Button();
            btn_bai4 = new Button();
            btn_bai5 = new Button();
            btn_bai6 = new Button();
            label_title = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_bai1
            // 
            btn_bai1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bai1.Location = new Point(381, 152);
            btn_bai1.Margin = new Padding(4);
            btn_bai1.Name = "btn_bai1";
            btn_bai1.Size = new Size(235, 91);
            btn_bai1.TabIndex = 0;
            btn_bai1.Text = "Ghi và đọc file";
            btn_bai1.UseVisualStyleBackColor = true;
            btn_bai1.Click += btn_bai1_Click;
            // 
            // btn_bai2
            // 
            btn_bai2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bai2.Location = new Point(646, 152);
            btn_bai2.Margin = new Padding(4);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(235, 91);
            btn_bai2.TabIndex = 1;
            btn_bai2.Text = "Đọc thông tin 1 file .txt";
            btn_bai2.UseVisualStyleBackColor = true;
            btn_bai2.Click += btn_bai2_Click;
            // 
            // btn_bai3
            // 
            btn_bai3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bai3.Location = new Point(381, 270);
            btn_bai3.Margin = new Padding(4);
            btn_bai3.Name = "btn_bai3";
            btn_bai3.Size = new Size(235, 104);
            btn_bai3.TabIndex = 2;
            btn_bai3.Text = "Đọc và ghi file (mở rộng)";
            btn_bai3.UseVisualStyleBackColor = true;
            btn_bai3.Click += btn_bai3_Click;
            // 
            // btn_bai4
            // 
            btn_bai4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bai4.Location = new Point(646, 270);
            btn_bai4.Margin = new Padding(4);
            btn_bai4.Name = "btn_bai4";
            btn_bai4.Size = new Size(235, 104);
            btn_bai4.TabIndex = 3;
            btn_bai4.Text = "Đọc và ghi file sử dụng BinaryFormatter";
            btn_bai4.TextAlign = ContentAlignment.BottomCenter;
            btn_bai4.UseVisualStyleBackColor = true;
            btn_bai4.Click += btn_bai4_Click;
            // 
            // btn_bai5
            // 
            btn_bai5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bai5.Location = new Point(381, 401);
            btn_bai5.Margin = new Padding(4);
            btn_bai5.Name = "btn_bai5";
            btn_bai5.Size = new Size(235, 91);
            btn_bai5.TabIndex = 4;
            btn_bai5.Text = "Nén dữ liệu trong file";
            btn_bai5.UseVisualStyleBackColor = true;
            btn_bai5.Click += btn_bai5_Click;
            // 
            // btn_bai6
            // 
            btn_bai6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bai6.Location = new Point(646, 401);
            btn_bai6.Margin = new Padding(4);
            btn_bai6.Name = "btn_bai6";
            btn_bai6.Size = new Size(235, 91);
            btn_bai6.TabIndex = 5;
            btn_bai6.Text = "Duyệt thư mục";
            btn_bai6.UseVisualStyleBackColor = true;
            btn_bai6.Click += btn_bai6_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.Location = new Point(251, 57);
            label_title.Margin = new Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(376, 38);
            label_title.TabIndex = 6;
            label_title.Text = "Danh sách các bài làm Lab2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Lab02_Menu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 547);
            Controls.Add(pictureBox1);
            Controls.Add(label_title);
            Controls.Add(btn_bai6);
            Controls.Add(btn_bai5);
            Controls.Add(btn_bai4);
            Controls.Add(btn_bai3);
            Controls.Add(btn_bai2);
            Controls.Add(btn_bai1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab02_Menu";
            Text = "Lab02_Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_bai1;
        private Button btn_bai2;
        private Button btn_bai3;
        private Button btn_bai4;
        private Button btn_bai5;
        private Button btn_bai6;
        private Label label_title;
        private PictureBox pictureBox1;
    }
}