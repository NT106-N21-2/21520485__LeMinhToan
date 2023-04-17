namespace Lab02
{
    partial class Lab02_Bai4
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
            bangthongtin = new ListBox();
            btn_write = new Button();
            btn_read = new Button();
            Name_label = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_add = new Button();
            btn_back = new Button();
            btn_next = new Button();
            wname = new TextBox();
            wId = new TextBox();
            wPhone = new TextBox();
            wC1 = new TextBox();
            wC2 = new TextBox();
            wC3 = new TextBox();
            page = new TextBox();
            label8 = new Label();
            rC3 = new TextBox();
            rC2 = new TextBox();
            rC1 = new TextBox();
            rPhone = new TextBox();
            rId = new TextBox();
            rName = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            rAvr = new TextBox();
            SuspendLayout();
            // 
            // bangthongtin
            // 
            bangthongtin.FormattingEnabled = true;
            bangthongtin.ItemHeight = 30;
            bangthongtin.Location = new Point(375, 29);
            bangthongtin.Name = "bangthongtin";
            bangthongtin.ScrollAlwaysVisible = true;
            bangthongtin.Size = new Size(333, 604);
            bangthongtin.TabIndex = 0;
            // 
            // btn_write
            // 
            btn_write.BackColor = SystemColors.AppWorkspace;
            btn_write.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_write.ForeColor = Color.Black;
            btn_write.Location = new Point(21, 29);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(299, 47);
            btn_write.TabIndex = 1;
            btn_write.Text = "Write to a File";
            btn_write.UseVisualStyleBackColor = false;
            btn_write.Click += btn_write_Click;
            // 
            // btn_read
            // 
            btn_read.BackColor = Color.DarkGray;
            btn_read.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_read.ForeColor = Color.Black;
            btn_read.Location = new Point(751, 29);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(274, 47);
            btn_read.TabIndex = 2;
            btn_read.Text = "Button to read a file";
            btn_read.UseVisualStyleBackColor = false;
            btn_read.Click += btn_read_Click;
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Location = new Point(253, 106);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(71, 30);
            Name_label.TabIndex = 3;
            Name_label.Text = "Name";
            Name_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 177);
            label2.Name = "label2";
            label2.Size = new Size(34, 30);
            label2.TabIndex = 4;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 245);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 308);
            label4.Name = "label4";
            label4.Size = new Size(93, 30);
            label4.TabIndex = 6;
            label4.Text = "Course1";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 369);
            label5.Name = "label5";
            label5.Size = new Size(99, 30);
            label5.TabIndex = 7;
            label5.Text = "Course 2";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 437);
            label6.Name = "label6";
            label6.Size = new Size(99, 30);
            label6.TabIndex = 8;
            label6.Text = "Course 3";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.White;
            btn_add.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.Black;
            btn_add.Location = new Point(70, 538);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(156, 60);
            btn_add.TabIndex = 10;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.Location = new Point(751, 574);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(95, 47);
            btn_back.TabIndex = 11;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.White;
            btn_next.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.Location = new Point(941, 574);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(91, 47);
            btn_next.TabIndex = 12;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // wname
            // 
            wname.Location = new Point(21, 106);
            wname.Name = "wname";
            wname.Size = new Size(205, 37);
            wname.TabIndex = 13;
            // 
            // wId
            // 
            wId.Location = new Point(21, 177);
            wId.Name = "wId";
            wId.Size = new Size(205, 37);
            wId.TabIndex = 14;
            // 
            // wPhone
            // 
            wPhone.Location = new Point(21, 248);
            wPhone.Name = "wPhone";
            wPhone.Size = new Size(205, 37);
            wPhone.TabIndex = 15;
            // 
            // wC1
            // 
            wC1.Location = new Point(21, 304);
            wC1.Name = "wC1";
            wC1.Size = new Size(205, 37);
            wC1.TabIndex = 16;
            // 
            // wC2
            // 
            wC2.Location = new Point(21, 365);
            wC2.Name = "wC2";
            wC2.Size = new Size(205, 37);
            wC2.TabIndex = 17;
            // 
            // wC3
            // 
            wC3.Location = new Point(21, 433);
            wC3.Name = "wC3";
            wC3.Size = new Size(205, 37);
            wC3.TabIndex = 19;
            // 
            // page
            // 
            page.BackColor = SystemColors.Menu;
            page.BorderStyle = BorderStyle.None;
            page.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            page.Location = new Point(852, 582);
            page.Multiline = true;
            page.Name = "page";
            page.ReadOnly = true;
            page.Size = new Size(83, 37);
            page.TabIndex = 32;
            page.Text = "1";
            page.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(979, 516);
            label8.Name = "label8";
            label8.Size = new Size(94, 30);
            label8.TabIndex = 26;
            label8.Text = "Average";
            // 
            // rC3
            // 
            rC3.Location = new Point(751, 436);
            rC3.Name = "rC3";
            rC3.ReadOnly = true;
            rC3.Size = new Size(205, 37);
            rC3.TabIndex = 44;
            // 
            // rC2
            // 
            rC2.Location = new Point(751, 368);
            rC2.Name = "rC2";
            rC2.ReadOnly = true;
            rC2.Size = new Size(205, 37);
            rC2.TabIndex = 43;
            // 
            // rC1
            // 
            rC1.Location = new Point(751, 307);
            rC1.Name = "rC1";
            rC1.ReadOnly = true;
            rC1.Size = new Size(205, 37);
            rC1.TabIndex = 42;
            // 
            // rPhone
            // 
            rPhone.Location = new Point(751, 241);
            rPhone.Name = "rPhone";
            rPhone.ReadOnly = true;
            rPhone.Size = new Size(205, 37);
            rPhone.TabIndex = 41;
            // 
            // rId
            // 
            rId.Location = new Point(751, 180);
            rId.Name = "rId";
            rId.ReadOnly = true;
            rId.Size = new Size(205, 37);
            rId.TabIndex = 40;
            // 
            // rName
            // 
            rName.Location = new Point(751, 109);
            rName.Name = "rName";
            rName.ReadOnly = true;
            rName.Size = new Size(205, 37);
            rName.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(979, 443);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 38;
            label1.Text = "Course 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(979, 375);
            label7.Name = "label7";
            label7.Size = new Size(99, 30);
            label7.TabIndex = 37;
            label7.Text = "Course 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(979, 314);
            label9.Name = "label9";
            label9.Size = new Size(93, 30);
            label9.TabIndex = 36;
            label9.Text = "Course1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(979, 248);
            label10.Name = "label10";
            label10.Size = new Size(74, 30);
            label10.TabIndex = 35;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(979, 183);
            label11.Name = "label11";
            label11.Size = new Size(34, 30);
            label11.TabIndex = 34;
            label11.Text = "ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(979, 112);
            label12.Name = "label12";
            label12.Size = new Size(71, 30);
            label12.TabIndex = 33;
            label12.Text = "Name";
            // 
            // rAvr
            // 
            rAvr.Location = new Point(751, 513);
            rAvr.Name = "rAvr";
            rAvr.ReadOnly = true;
            rAvr.Size = new Size(205, 37);
            rAvr.TabIndex = 45;
            // 
            // Lab02_Bai4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 648);
            Controls.Add(rAvr);
            Controls.Add(rC3);
            Controls.Add(rC2);
            Controls.Add(rC1);
            Controls.Add(rPhone);
            Controls.Add(rId);
            Controls.Add(rName);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(page);
            Controls.Add(label8);
            Controls.Add(wC3);
            Controls.Add(wC2);
            Controls.Add(wC1);
            Controls.Add(wPhone);
            Controls.Add(wId);
            Controls.Add(wname);
            Controls.Add(btn_next);
            Controls.Add(btn_back);
            Controls.Add(btn_add);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Name_label);
            Controls.Add(btn_read);
            Controls.Add(btn_write);
            Controls.Add(bangthongtin);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab02_Bai4";
            Text = "Lab02_Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox bangthongtin;
        private Button btn_write;
        private Button btn_read;
        private Label Name_label;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_add;
        private Button btn_back;
        private Button btn_next;
        private TextBox wname;
        private TextBox wId;
        private TextBox wPhone;
        private TextBox wC1;
        private TextBox wC2;
        private TextBox wC3;
        private TextBox page;
        private Label label8;
        private TextBox rC3;
        private TextBox rC2;
        private TextBox rC1;
        private TextBox rPhone;
        private TextBox rId;
        private TextBox rName;
        private Label label1;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox rAvr;
    }
}