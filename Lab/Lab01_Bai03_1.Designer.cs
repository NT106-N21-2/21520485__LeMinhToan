namespace Lab01
{
    partial class Lab01_Bai03_1
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
            tittle_label = new Label();
            ketqua_label = new Label();
            btn_read = new Button();
            btn_del = new Button();
            btn_close = new Button();
            num = new TextBox();
            result = new TextBox();
            label_tittle = new Label();
            SuspendLayout();
            // 
            // tittle_label
            // 
            tittle_label.AutoSize = true;
            tittle_label.Location = new Point(67, 101);
            tittle_label.Name = "tittle_label";
            tittle_label.Size = new Size(332, 30);
            tittle_label.TabIndex = 0;
            tittle_label.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
            // 
            // ketqua_label
            // 
            ketqua_label.AutoSize = true;
            ketqua_label.Location = new Point(67, 237);
            ketqua_label.Name = "ketqua_label";
            ketqua_label.Size = new Size(91, 30);
            ketqua_label.TabIndex = 1;
            ketqua_label.Text = "Kết Quả";
            // 
            // btn_read
            // 
            btn_read.Location = new Point(647, 94);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(112, 72);
            btn_read.TabIndex = 2;
            btn_read.Text = "Đọc";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(647, 195);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(112, 72);
            btn_del.TabIndex = 3;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(647, 294);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(112, 72);
            btn_close.TabIndex = 4;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // num
            // 
            num.Location = new Point(425, 94);
            num.Name = "num";
            num.Size = new Size(150, 37);
            num.TabIndex = 5;
            num.TextChanged += num_TextChanged;
            // 
            // result
            // 
            result.BackColor = SystemColors.Menu;
            result.ForeColor = SystemColors.WindowFrame;
            result.Location = new Point(67, 312);
            result.Name = "result";
            result.Size = new Size(403, 37);
            result.TabIndex = 6;
            // 
            // label_tittle
            // 
            label_tittle.AutoSize = true;
            label_tittle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_tittle.Location = new Point(320, 29);
            label_tittle.Name = "label_tittle";
            label_tittle.Size = new Size(109, 38);
            label_tittle.TabIndex = 7;
            label_tittle.Text = "Đọc Số";
            // 
            // Lab01_Bai03_1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 437);
            Controls.Add(label_tittle);
            Controls.Add(result);
            Controls.Add(num);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(btn_read);
            Controls.Add(ketqua_label);
            Controls.Add(tittle_label);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab01_Bai03_1";
            Text = "Lab01_Bai03_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tittle_label;
        private Label ketqua_label;
        private Button btn_read;
        private Button btn_del;
        private Button btn_close;
        private TextBox num;
        private TextBox result;
        private Label label_tittle;
    }
}