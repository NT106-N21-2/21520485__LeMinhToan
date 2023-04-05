namespace Lab01
{
    partial class Lab01_Bai05
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
            label_A = new Label();
            label_B = new Label();
            numA = new TextBox();
            numB = new TextBox();
            btn_del = new Button();
            btn_close = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_cal = new Button();
            groupBox1 = new GroupBox();
            sumtoAB = new TextBox();
            sumtoB = new TextBox();
            sumtoA = new TextBox();
            gt_B = new TextBox();
            gt_A = new TextBox();
            label_tittle = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label_A
            // 
            label_A.AutoSize = true;
            label_A.Location = new Point(74, 125);
            label_A.Margin = new Padding(4, 0, 4, 0);
            label_A.Name = "label_A";
            label_A.Size = new Size(85, 30);
            label_A.TabIndex = 0;
            label_A.Text = "Nhập A";
            // 
            // label_B
            // 
            label_B.AutoSize = true;
            label_B.Location = new Point(472, 118);
            label_B.Margin = new Padding(4, 0, 4, 0);
            label_B.Name = "label_B";
            label_B.Size = new Size(84, 30);
            label_B.TabIndex = 1;
            label_B.Text = "Nhập B";
            // 
            // numA
            // 
            numA.BorderStyle = BorderStyle.FixedSingle;
            numA.Location = new Point(204, 118);
            numA.Margin = new Padding(4);
            numA.Name = "numA";
            numA.Size = new Size(180, 37);
            numA.TabIndex = 2;
            numA.TextChanged += btn_del_Click;
            // 
            // numB
            // 
            numB.Location = new Point(570, 111);
            numB.Margin = new Padding(4);
            numB.Name = "numB";
            numB.Size = new Size(179, 37);
            numB.TabIndex = 3;
            numB.TextChanged += btn_del_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(499, 209);
            btn_del.Margin = new Padding(4);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(134, 53);
            btn_del.TabIndex = 5;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(679, 209);
            btn_close.Margin = new Padding(4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(134, 53);
            btn_close.TabIndex = 6;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_cal
            // 
            btn_cal.Location = new Point(74, 209);
            btn_cal.Margin = new Padding(4);
            btn_cal.Name = "btn_cal";
            btn_cal.Size = new Size(338, 53);
            btn_cal.TabIndex = 9;
            btn_cal.Text = "Tính Các Giá Trị";
            btn_cal.UseVisualStyleBackColor = true;
            btn_cal.Click += btn_cal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sumtoAB);
            groupBox1.Controls.Add(sumtoB);
            groupBox1.Controls.Add(sumtoA);
            groupBox1.Controls.Add(gt_B);
            groupBox1.Controls.Add(gt_A);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(74, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 290);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết Quả";
            // 
            // sumtoAB
            // 
            sumtoAB.BackColor = SystemColors.Menu;
            sumtoAB.BorderStyle = BorderStyle.None;
            sumtoAB.ForeColor = Color.Blue;
            sumtoAB.Location = new Point(43, 239);
            sumtoAB.Name = "sumtoAB";
            sumtoAB.Size = new Size(581, 27);
            sumtoAB.TabIndex = 16;
            // 
            // sumtoB
            // 
            sumtoB.BackColor = SystemColors.Menu;
            sumtoB.BorderStyle = BorderStyle.None;
            sumtoB.ForeColor = Color.Blue;
            sumtoB.Location = new Point(43, 177);
            sumtoB.Name = "sumtoB";
            sumtoB.Size = new Size(581, 27);
            sumtoB.TabIndex = 15;
            // 
            // sumtoA
            // 
            sumtoA.BackColor = SystemColors.Menu;
            sumtoA.BorderStyle = BorderStyle.None;
            sumtoA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            sumtoA.ForeColor = Color.Blue;
            sumtoA.Location = new Point(43, 119);
            sumtoA.Name = "sumtoA";
            sumtoA.Size = new Size(581, 27);
            sumtoA.TabIndex = 14;
            // 
            // gt_B
            // 
            gt_B.BackColor = SystemColors.Menu;
            gt_B.BorderStyle = BorderStyle.None;
            gt_B.ForeColor = Color.Blue;
            gt_B.Location = new Point(357, 58);
            gt_B.Name = "gt_B";
            gt_B.Size = new Size(267, 27);
            gt_B.TabIndex = 13;
            // 
            // gt_A
            // 
            gt_A.BackColor = SystemColors.Menu;
            gt_A.BorderStyle = BorderStyle.None;
            gt_A.ForeColor = Color.Blue;
            gt_A.Location = new Point(43, 59);
            gt_A.Name = "gt_A";
            gt_A.Size = new Size(247, 27);
            gt_A.TabIndex = 12;
            // 
            // label_tittle
            // 
            label_tittle.AutoSize = true;
            label_tittle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_tittle.Location = new Point(312, 37);
            label_tittle.Name = "label_tittle";
            label_tittle.Size = new Size(214, 38);
            label_tittle.TabIndex = 12;
            label_tittle.Text = "Tính Biểu Thức";
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 606);
            Controls.Add(label_tittle);
            Controls.Add(groupBox1);
            Controls.Add(btn_cal);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(numB);
            Controls.Add(numA);
            Controls.Add(label_B);
            Controls.Add(label_A);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab01_Bai05";
            Text = "Lab01_Bai05";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_A;
        private Label label_B;
        private TextBox numA;
        private TextBox numB;
        private Button btn_del;
        private Button btn_close;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_cal;
        private GroupBox groupBox1;
        private TextBox gt_A;
        private TextBox sumtoB;
        private TextBox sumtoA;
        private TextBox gt_B;
        private TextBox sumtoAB;
        private Label label_tittle;
    }
}