namespace Lab01
{
    partial class Lab01_Bai02
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
            num1_label = new Label();
            num2_label = new Label();
            num3_label = new Label();
            max_label = new Label();
            min_label = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            num3 = new TextBox();
            max = new TextBox();
            min = new TextBox();
            btn_find = new Button();
            btn_del = new Button();
            btn_close = new Button();
            tittle_lable = new Label();
            SuspendLayout();
            // 
            // num1_label
            // 
            num1_label.AutoSize = true;
            num1_label.Location = new Point(16, 153);
            num1_label.Margin = new Padding(4, 0, 4, 0);
            num1_label.Name = "num1_label";
            num1_label.Size = new Size(133, 30);
            num1_label.TabIndex = 0;
            num1_label.Text = "Số Thứ Nhất";
            // 
            // num2_label
            // 
            num2_label.AutoSize = true;
            num2_label.Location = new Point(356, 157);
            num2_label.Margin = new Padding(4, 0, 4, 0);
            num2_label.Name = "num2_label";
            num2_label.Size = new Size(119, 30);
            num2_label.TabIndex = 1;
            num2_label.Text = "Số Thứ Hai";
            // 
            // num3_label
            // 
            num3_label.AutoSize = true;
            num3_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            num3_label.Location = new Point(680, 157);
            num3_label.Margin = new Padding(4, 0, 4, 0);
            num3_label.Name = "num3_label";
            num3_label.Size = new Size(111, 30);
            num3_label.TabIndex = 2;
            num3_label.Text = "Số Thứ Ba";
            // 
            // max_label
            // 
            max_label.AutoSize = true;
            max_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            max_label.Location = new Point(68, 408);
            max_label.Margin = new Padding(4, 0, 4, 0);
            max_label.Name = "max_label";
            max_label.Size = new Size(120, 28);
            max_label.TabIndex = 3;
            max_label.Text = "Số Lớn Nhất";
            // 
            // min_label
            // 
            min_label.AutoSize = true;
            min_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            min_label.Location = new Point(543, 408);
            min_label.Margin = new Padding(4, 0, 4, 0);
            min_label.Name = "min_label";
            min_label.Size = new Size(126, 28);
            min_label.TabIndex = 4;
            min_label.Text = "Số Nhỏ Nhất";
            // 
            // num1
            // 
            num1.Location = new Point(157, 150);
            num1.Margin = new Padding(4);
            num1.Name = "num1";
            num1.Size = new Size(179, 37);
            num1.TabIndex = 5;
            num1.TextChanged += num1_TextChanged;
            // 
            // num2
            // 
            num2.Location = new Point(483, 150);
            num2.Margin = new Padding(4);
            num2.Name = "num2";
            num2.Size = new Size(179, 37);
            num2.TabIndex = 6;
            num2.TextChanged += num2_TextChanged;
            // 
            // num3
            // 
            num3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            num3.Location = new Point(789, 150);
            num3.Margin = new Padding(4);
            num3.Name = "num3";
            num3.Size = new Size(179, 37);
            num3.TabIndex = 7;
            num3.TextChanged += num3_TextChanged;
            // 
            // max
            // 
            max.BackColor = SystemColors.Menu;
            max.BorderStyle = BorderStyle.FixedSingle;
            max.ForeColor = SystemColors.WindowFrame;
            max.Location = new Point(196, 399);
            max.Margin = new Padding(4);
            max.Name = "max";
            max.Size = new Size(180, 37);
            max.TabIndex = 8;
            // 
            // min
            // 
            min.BackColor = SystemColors.Menu;
            min.ForeColor = SystemColors.WindowFrame;
            min.Location = new Point(680, 398);
            min.Margin = new Padding(4);
            min.Name = "min";
            min.Size = new Size(179, 37);
            min.TabIndex = 9;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_find.Location = new Point(169, 269);
            btn_find.Margin = new Padding(4);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(134, 63);
            btn_find.TabIndex = 10;
            btn_find.Text = "Tìm ";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_del.Location = new Point(432, 269);
            btn_del.Margin = new Padding(4);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(134, 63);
            btn_del.TabIndex = 11;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Location = new Point(707, 269);
            btn_close.Margin = new Padding(4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(134, 63);
            btn_close.TabIndex = 12;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // tittle_lable
            // 
            tittle_lable.AutoSize = true;
            tittle_lable.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tittle_lable.Location = new Point(356, 67);
            tittle_lable.Name = "tittle_lable";
            tittle_lable.Size = new Size(325, 38);
            tittle_lable.TabIndex = 13;
            tittle_lable.Text = "Số Lớn Nhất, Nhỏ Nhất";
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 505);
            Controls.Add(tittle_lable);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(btn_find);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(min_label);
            Controls.Add(max_label);
            Controls.Add(num3_label);
            Controls.Add(num2_label);
            Controls.Add(num1_label);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "Lab01_Bai02";
            Text = "Lab01_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1_label;
        private Label num2_label;
        private Label num3_label;
        private Label max_label;
        private Label min_label;
        private TextBox num1;
        private TextBox num2;
        private TextBox num3;
        private TextBox max;
        private TextBox min;
        private Button btn_find;
        private Button btn_del;
        private Button btn_close;
        private Label tittle_lable;
    }
}