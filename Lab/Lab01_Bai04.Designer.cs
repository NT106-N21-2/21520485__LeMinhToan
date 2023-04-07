namespace Lab01
{
    partial class Lab01_Bai04
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
            km = new Label();
            loaixang = new ComboBox();
            loaixe = new ComboBox();
            money = new Label();
            total_km = new TextBox();
            total_money = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_cal = new Button();
            btn_del = new Button();
            btn_close = new Button();
            tittle_label = new Label();
            SuspendLayout();
            // 
            // km
            // 
            km.AutoSize = true;
            km.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            km.Location = new Point(36, 379);
            km.Name = "km";
            km.Size = new Size(308, 28);
            km.TabIndex = 0;
            km.Text = "Số km Đi Được Khi Xăng Đầy Bình";
            // 
            // loaixang
            // 
            loaixang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loaixang.FormattingEnabled = true;
            loaixang.Location = new Point(474, 149);
            loaixang.Name = "loaixang";
            loaixang.RightToLeft = RightToLeft.No;
            loaixang.Size = new Size(228, 38);
            loaixang.TabIndex = 1;
            loaixang.SelectedIndexChanged += loaixang_SelectedIndexChanged;
            // 
            // loaixe
            // 
            loaixe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            loaixe.DropDownHeight = 100;
            loaixe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loaixe.FormattingEnabled = true;
            loaixe.IntegralHeight = false;
            loaixe.Items.AddRange(new object[] { "Wave Alpha", "Sirius", "Vision", "Lead", "Winner", "AirBlade", "Xe tải 9 tấn" });
            loaixe.Location = new Point(36, 149);
            loaixe.MaxDropDownItems = 3;
            loaixe.Name = "loaixe";
            loaixe.RightToLeft = RightToLeft.No;
            loaixe.Size = new Size(256, 38);
            loaixe.TabIndex = 2;
            loaixe.SelectedIndexChanged += loaixe_SelectedIndexChanged;
            // 
            // money
            // 
            money.AutoSize = true;
            money.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            money.Location = new Point(404, 379);
            money.Name = "money";
            money.Size = new Size(338, 28);
            money.TabIndex = 3;
            money.Text = "Số Tiền Cần Trả Khi Xăng Đầy Bình (đ)";
            // 
            // total_km
            // 
            total_km.BackColor = SystemColors.Menu;
            total_km.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            total_km.ForeColor = SystemColors.WindowFrame;
            total_km.Location = new Point(36, 437);
            total_km.Name = "total_km";
            total_km.Size = new Size(222, 37);
            total_km.TabIndex = 4;
            // 
            // total_money
            // 
            total_money.BackColor = SystemColors.Menu;
            total_money.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            total_money.ForeColor = SystemColors.WindowFrame;
            total_money.Location = new Point(404, 437);
            total_money.Name = "total_money";
            total_money.Size = new Size(246, 37);
            total_money.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 99);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 6;
            label3.Text = "Chọn Loại Xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(474, 99);
            label4.Name = "label4";
            label4.Size = new Size(164, 30);
            label4.TabIndex = 7;
            label4.Text = "Chọn Loại Xăng";
            // 
            // btn_cal
            // 
            btn_cal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cal.Location = new Point(77, 273);
            btn_cal.Name = "btn_cal";
            btn_cal.Size = new Size(112, 64);
            btn_cal.TabIndex = 8;
            btn_cal.Text = "Tính";
            btn_cal.UseVisualStyleBackColor = true;
            btn_cal.Click += btn_cal_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_del.Location = new Point(315, 273);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(112, 64);
            btn_del.TabIndex = 9;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Location = new Point(561, 273);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(112, 64);
            btn_close.TabIndex = 10;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // tittle_label
            // 
            tittle_label.AutoSize = true;
            tittle_label.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tittle_label.Location = new Point(247, 31);
            tittle_label.Name = "tittle_label";
            tittle_label.Size = new Size(214, 38);
            tittle_label.TabIndex = 11;
            tittle_label.Text = "Tính Tiền Xăng";
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 538);
            Controls.Add(tittle_label);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(btn_cal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(total_money);
            Controls.Add(total_km);
            Controls.Add(money);
            Controls.Add(loaixe);
            Controls.Add(loaixang);
            Controls.Add(km);
            Name = "Lab01_Bai04";
            RightToLeft = RightToLeft.Yes;
            Text = "Lab01_Bai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label km;
        private ComboBox loaixang;
        private ComboBox loaixe;
        private Label money;
        private TextBox total_km;
        private TextBox total_money;
        private Label label3;
        private Label label4;
        private Button btn_cal;
        private Button btn_del;
        private Button btn_close;
        private Label tittle_label;
    }
}