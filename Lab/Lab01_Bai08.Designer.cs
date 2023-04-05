namespace Lab01
{
    partial class Lab01_Bai08
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
            thongtin_label = new Label();
            dtb_label = new Label();
            label_mondcn = new Label();
            label4 = new Label();
            dau_label = new Label();
            khongdau_label = new Label();
            thongtin = new TextBox();
            Dtb = new TextBox();
            monmax = new TextBox();
            monmin = new TextBox();
            mondau = new TextBox();
            monrot = new TextBox();
            bangthongtin = new FlowLayoutPanel();
            xeploai_label = new Label();
            xeploai = new TextBox();
            danhsach_label = new Label();
            btn_find = new Button();
            btn_del = new Button();
            btn_close = new Button();
            label_tittle = new Label();
            SuspendLayout();
            // 
            // thongtin_label
            // 
            thongtin_label.AutoSize = true;
            thongtin_label.Location = new Point(50, 108);
            thongtin_label.Margin = new Padding(4, 0, 4, 0);
            thongtin_label.Name = "thongtin_label";
            thongtin_label.Size = new Size(248, 30);
            thongtin_label.TabIndex = 0;
            thongtin_label.Text = "Nhập thông tin sinh viên";
            // 
            // dtb_label
            // 
            dtb_label.AutoSize = true;
            dtb_label.Location = new Point(50, 305);
            dtb_label.Margin = new Padding(4, 0, 4, 0);
            dtb_label.Name = "dtb_label";
            dtb_label.Size = new Size(53, 30);
            dtb_label.TabIndex = 1;
            dtb_label.Text = "ĐTB";
            // 
            // label_mondcn
            // 
            label_mondcn.AutoSize = true;
            label_mondcn.Location = new Point(52, 357);
            label_mondcn.Margin = new Padding(4, 0, 4, 0);
            label_mondcn.Name = "label_mondcn";
            label_mondcn.Size = new Size(201, 30);
            label_mondcn.TabIndex = 2;
            label_mondcn.Text = "Môn điểm cao nhất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 419);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 30);
            label4.TabIndex = 3;
            label4.Text = "Môn điểm thấp nhất";
            // 
            // dau_label
            // 
            dau_label.AutoSize = true;
            dau_label.Location = new Point(53, 474);
            dau_label.Margin = new Padding(4, 0, 4, 0);
            dau_label.Name = "dau_label";
            dau_label.Size = new Size(130, 30);
            dau_label.TabIndex = 4;
            dau_label.Text = "Số môn đậu";
            // 
            // khongdau_label
            // 
            khongdau_label.AutoSize = true;
            khongdau_label.Location = new Point(53, 530);
            khongdau_label.Margin = new Padding(4, 0, 4, 0);
            khongdau_label.Name = "khongdau_label";
            khongdau_label.Size = new Size(197, 30);
            khongdau_label.TabIndex = 5;
            khongdau_label.Text = "Số môn không đậu";
            // 
            // thongtin
            // 
            thongtin.Location = new Point(50, 151);
            thongtin.Margin = new Padding(4);
            thongtin.Name = "thongtin";
            thongtin.Size = new Size(390, 37);
            thongtin.TabIndex = 6;
            // 
            // Dtb
            // 
            Dtb.Location = new Point(261, 298);
            Dtb.Margin = new Padding(4);
            Dtb.Name = "Dtb";
            Dtb.ReadOnly = true;
            Dtb.Size = new Size(179, 37);
            Dtb.TabIndex = 7;
            // 
            // monmax
            // 
            monmax.Location = new Point(261, 354);
            monmax.Margin = new Padding(4);
            monmax.Name = "monmax";
            monmax.ReadOnly = true;
            monmax.Size = new Size(179, 37);
            monmax.TabIndex = 8;
            // 
            // monmin
            // 
            monmin.Location = new Point(261, 412);
            monmin.Margin = new Padding(4);
            monmin.Name = "monmin";
            monmin.ReadOnly = true;
            monmin.Size = new Size(179, 37);
            monmin.TabIndex = 9;
            // 
            // mondau
            // 
            mondau.Location = new Point(261, 467);
            mondau.Margin = new Padding(4);
            mondau.Name = "mondau";
            mondau.ReadOnly = true;
            mondau.Size = new Size(179, 37);
            mondau.TabIndex = 10;
            // 
            // monrot
            // 
            monrot.Location = new Point(261, 523);
            monrot.Margin = new Padding(4);
            monrot.Name = "monrot";
            monrot.ReadOnly = true;
            monrot.Size = new Size(179, 37);
            monrot.TabIndex = 11;
            // 
            // bangthongtin
            // 
            bangthongtin.Enabled = false;
            bangthongtin.Location = new Point(493, 172);
            bangthongtin.Margin = new Padding(4);
            bangthongtin.Name = "bangthongtin";
            bangthongtin.Size = new Size(266, 448);
            bangthongtin.TabIndex = 12;
            // 
            // xeploai_label
            // 
            xeploai_label.AutoSize = true;
            xeploai_label.Location = new Point(55, 590);
            xeploai_label.Name = "xeploai_label";
            xeploai_label.Size = new Size(91, 30);
            xeploai_label.TabIndex = 13;
            xeploai_label.Text = "Xếp loại";
            // 
            // xeploai
            // 
            xeploai.Location = new Point(261, 583);
            xeploai.Name = "xeploai";
            xeploai.ReadOnly = true;
            xeploai.Size = new Size(176, 37);
            xeploai.TabIndex = 14;
            // 
            // danhsach_label
            // 
            danhsach_label.AutoSize = true;
            danhsach_label.Location = new Point(519, 113);
            danhsach_label.Name = "danhsach_label";
            danhsach_label.Size = new Size(204, 30);
            danhsach_label.TabIndex = 15;
            danhsach_label.Text = "Danh sách thông tin";
            // 
            // btn_find
            // 
            btn_find.Location = new Point(50, 214);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(112, 47);
            btn_find.TabIndex = 16;
            btn_find.Text = "Xuất";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(196, 214);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(112, 46);
            btn_del.TabIndex = 17;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(328, 214);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(112, 46);
            btn_close.TabIndex = 18;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // label_tittle
            // 
            label_tittle.AutoSize = true;
            label_tittle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_tittle.Location = new Point(196, 45);
            label_tittle.Name = "label_tittle";
            label_tittle.Size = new Size(353, 38);
            label_tittle.TabIndex = 19;
            label_tittle.Text = "Xử Lý Mảng Và Tổng Hợp";
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 659);
            Controls.Add(label_tittle);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(btn_find);
            Controls.Add(danhsach_label);
            Controls.Add(xeploai);
            Controls.Add(xeploai_label);
            Controls.Add(bangthongtin);
            Controls.Add(monrot);
            Controls.Add(mondau);
            Controls.Add(monmin);
            Controls.Add(monmax);
            Controls.Add(Dtb);
            Controls.Add(thongtin);
            Controls.Add(khongdau_label);
            Controls.Add(dau_label);
            Controls.Add(label4);
            Controls.Add(label_mondcn);
            Controls.Add(dtb_label);
            Controls.Add(thongtin_label);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab01_Bai08";
            Text = "Lab01_Bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label thongtin_label;
        private Label dtb_label;
        private Label label_mondcn;
        private Label label4;
        private Label dau_label;
        private Label khongdau_label;
        private TextBox thongtin;
        private TextBox Dtb;
        private TextBox monmax;
        private TextBox monmin;
        private TextBox mondau;
        private TextBox monrot;
        private FlowLayoutPanel bangthongtin;
        private Label xeploai_label;
        private TextBox xeploai;
        private Label danhsach_label;
        private Button btn_find;
        private Button btn_del;
        private Button btn_close;
        private Label label_tittle;
    }
}