namespace Lab01
{
    partial class Lab01_Bai03_2
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
            label2 = new Label();
            num = new TextBox();
            result = new TextBox();
            btn_read = new Button();
            btn_del = new Button();
            btn_close = new Button();
            tittle_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 119);
            label1.Name = "label1";
            label1.Size = new Size(371, 30);
            label1.TabIndex = 0;
            label1.Text = "Nhập Số Nguyên Có Tối đa 4 Chữ Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Menu;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 237);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 1;
            label2.Text = "Kết Quả";
            // 
            // num
            // 
            num.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            num.Location = new Point(419, 112);
            num.Name = "num";
            num.Size = new Size(150, 37);
            num.TabIndex = 2;
            num.TextChanged += num_TextChanged;
            // 
            // result
            // 
            result.BackColor = SystemColors.Window;
            result.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            result.ForeColor = SystemColors.WindowFrame;
            result.Location = new Point(42, 303);
            result.Name = "result";
            result.Size = new Size(424, 37);
            result.TabIndex = 3;
            // 
            // btn_read
            // 
            btn_read.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_read.Location = new Point(639, 119);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(112, 57);
            btn_read.TabIndex = 4;
            btn_read.Text = "Đọc";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_del.Location = new Point(639, 224);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(112, 57);
            btn_del.TabIndex = 5;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Location = new Point(639, 328);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(112, 57);
            btn_close.TabIndex = 6;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // tittle_label
            // 
            tittle_label.AutoSize = true;
            tittle_label.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tittle_label.Location = new Point(221, 33);
            tittle_label.Name = "tittle_label";
            tittle_label.Size = new Size(245, 38);
            tittle_label.TabIndex = 7;
            tittle_label.Text = "Đọc Số Nâng Cao";
            // 
            // Lab01_Bai03_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 440);
            Controls.Add(tittle_label);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(btn_read);
            Controls.Add(result);
            Controls.Add(num);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai03_2";
            Text = "Lab01_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num;
        private TextBox result;
        private Button btn_read;
        private Button btn_del;
        private Button btn_close;
        private Label tittle_label;
    }
}