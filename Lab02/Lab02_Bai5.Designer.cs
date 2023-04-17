namespace Lab02
{
    partial class Lab02_Bai5
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
            label1 = new Label();
            btn_luufiledenen = new Button();
            bangthongtin = new TextBox();
            label2 = new Label();
            btn_chonluufile = new Button();
            pictureBox1 = new PictureBox();
            btn_chosezip = new Button();
            btn_chosefolderextract = new Button();
            btn_giainenzip = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(364, 45);
            label1.TabIndex = 0;
            label1.Text = "Nén Dữ Liệu Trong File";
            // 
            // btn_luufiledenen
            // 
            btn_luufiledenen.BackColor = Color.Black;
            btn_luufiledenen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_luufiledenen.ForeColor = Color.White;
            btn_luufiledenen.Location = new Point(33, 378);
            btn_luufiledenen.Name = "btn_luufiledenen";
            btn_luufiledenen.Size = new Size(164, 137);
            btn_luufiledenen.TabIndex = 2;
            btn_luufiledenen.Text = "Chọn nơi lưu file zip và nén";
            btn_luufiledenen.UseVisualStyleBackColor = false;
            btn_luufiledenen.Click += btn_luufiledenen_Click;
            // 
            // bangthongtin
            // 
            bangthongtin.Location = new Point(226, 237);
            bangthongtin.Multiline = true;
            bangthongtin.Name = "bangthongtin";
            bangthongtin.ScrollBars = ScrollBars.Both;
            bangthongtin.Size = new Size(349, 364);
            bangthongtin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(226, 204);
            label2.Name = "label2";
            label2.Size = new Size(249, 30);
            label2.TabIndex = 4;
            label2.Text = "Nhập dữ liệu ghi vào file";
            // 
            // btn_chonluufile
            // 
            btn_chonluufile.BackColor = Color.WhiteSmoke;
            btn_chonluufile.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chonluufile.Location = new Point(33, 237);
            btn_chonluufile.Name = "btn_chonluufile";
            btn_chonluufile.Size = new Size(164, 95);
            btn_chonluufile.TabIndex = 5;
            btn_chonluufile.Text = "Chọn nơi lưu file";
            btn_chonluufile.UseVisualStyleBackColor = false;
            btn_chonluufile.Click += btn_chonluufile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._316621181_692162748901872_4721747070078868613_n;
            pictureBox1.Location = new Point(622, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btn_chosezip
            // 
            btn_chosezip.BackColor = Color.WhiteSmoke;
            btn_chosezip.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chosezip.Location = new Point(637, 237);
            btn_chosezip.Name = "btn_chosezip";
            btn_chosezip.Size = new Size(164, 95);
            btn_chosezip.TabIndex = 7;
            btn_chosezip.Text = "Chọn file zip cần giải nén";
            btn_chosezip.UseVisualStyleBackColor = false;
            btn_chosezip.Click += btn_chosezip_Click;
            // 
            // btn_chosefolderextract
            // 
            btn_chosefolderextract.BackColor = Color.WhiteSmoke;
            btn_chosefolderextract.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chosefolderextract.Location = new Point(637, 378);
            btn_chosefolderextract.Name = "btn_chosefolderextract";
            btn_chosefolderextract.Size = new Size(164, 94);
            btn_chosefolderextract.TabIndex = 8;
            btn_chosefolderextract.Text = "chọn nơi để giải nén";
            btn_chosefolderextract.UseVisualStyleBackColor = false;
            btn_chosefolderextract.Click += btn_chosefolderextract_Click;
            // 
            // btn_giainenzip
            // 
            btn_giainenzip.BackColor = Color.Black;
            btn_giainenzip.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_giainenzip.ForeColor = Color.White;
            btn_giainenzip.Location = new Point(637, 519);
            btn_giainenzip.Name = "btn_giainenzip";
            btn_giainenzip.Size = new Size(164, 82);
            btn_giainenzip.TabIndex = 10;
            btn_giainenzip.Text = "Giải Nén";
            btn_giainenzip.UseVisualStyleBackColor = false;
            btn_giainenzip.Click += btn_giainenzip_Click;
            // 
            // Lab02_Bai5
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 638);
            Controls.Add(btn_giainenzip);
            Controls.Add(btn_chosefolderextract);
            Controls.Add(btn_chosezip);
            Controls.Add(pictureBox1);
            Controls.Add(btn_chonluufile);
            Controls.Add(label2);
            Controls.Add(bangthongtin);
            Controls.Add(btn_luufiledenen);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab02_Bai5";
            Text = "Lab02_Bai4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_luufiledenen;
        private TextBox bangthongtin;
        private Label label2;
        private Button btn_chonluufile;
        private PictureBox pictureBox1;
        private Button btn_chosezip;
        private Button btn_chosefolderextract;
        private Button btn_giainenzip;
    }
}