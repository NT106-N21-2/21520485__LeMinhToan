namespace Lab02
{
    partial class Lab02_Bai2
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
            rff = new Button();
            btn_close = new Button();
            bangthongtin = new TextBox();
            name = new TextBox();
            size = new TextBox();
            url = new TextBox();
            linecount = new TextBox();
            wordcount = new TextBox();
            charactercount = new TextBox();
            filename_label = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // rff
            // 
            rff.BackColor = Color.White;
            rff.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rff.Location = new Point(55, 32);
            rff.Name = "rff";
            rff.Size = new Size(340, 49);
            rff.TabIndex = 0;
            rff.Text = "Read from file";
            rff.UseVisualStyleBackColor = false;
            rff.Click += rff_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.LimeGreen;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.Location = new Point(55, 479);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(340, 48);
            btn_close.TabIndex = 1;
            btn_close.Text = "EXIT";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // bangthongtin
            // 
            bangthongtin.BackColor = Color.FromArgb(64, 64, 64);
            bangthongtin.BorderStyle = BorderStyle.FixedSingle;
            bangthongtin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bangthongtin.ForeColor = SystemColors.MenuHighlight;
            bangthongtin.Location = new Point(443, 31);
            bangthongtin.Multiline = true;
            bangthongtin.Name = "bangthongtin";
            bangthongtin.ReadOnly = true;
            bangthongtin.Size = new Size(351, 495);
            bangthongtin.TabIndex = 2;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(187, 107);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(208, 37);
            name.TabIndex = 3;
            // 
            // size
            // 
            size.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            size.Location = new Point(154, 167);
            size.Name = "size";
            size.ReadOnly = true;
            size.Size = new Size(241, 37);
            size.TabIndex = 4;
            // 
            // url
            // 
            url.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            url.Location = new Point(154, 224);
            url.Name = "url";
            url.ReadOnly = true;
            url.Size = new Size(241, 37);
            url.TabIndex = 5;
            // 
            // linecount
            // 
            linecount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linecount.Location = new Point(245, 291);
            linecount.Name = "linecount";
            linecount.ReadOnly = true;
            linecount.Size = new Size(150, 37);
            linecount.TabIndex = 6;
            // 
            // wordcount
            // 
            wordcount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            wordcount.Location = new Point(245, 348);
            wordcount.Name = "wordcount";
            wordcount.ReadOnly = true;
            wordcount.Size = new Size(150, 37);
            wordcount.TabIndex = 7;
            // 
            // charactercount
            // 
            charactercount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            charactercount.Location = new Point(245, 412);
            charactercount.Name = "charactercount";
            charactercount.ReadOnly = true;
            charactercount.Size = new Size(150, 37);
            charactercount.TabIndex = 8;
            // 
            // filename_label
            // 
            filename_label.AutoSize = true;
            filename_label.BackColor = Color.Transparent;
            filename_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            filename_label.ForeColor = SystemColors.MenuHighlight;
            filename_label.Location = new Point(55, 114);
            filename_label.Name = "filename_label";
            filename_label.Size = new Size(115, 30);
            filename_label.TabIndex = 9;
            filename_label.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(55, 174);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 10;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(55, 231);
            label3.Name = "label3";
            label3.Size = new Size(54, 30);
            label3.TabIndex = 11;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(55, 298);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 12;
            label4.Text = "Line Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(55, 355);
            label5.Name = "label5";
            label5.Size = new Size(148, 30);
            label5.TabIndex = 13;
            label5.Text = "Words Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(55, 412);
            label6.Name = "label6";
            label6.Size = new Size(182, 30);
            label6.TabIndex = 14;
            label6.Text = "Character Count";
            // 
            // Lab02_Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(848, 569);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(filename_label);
            Controls.Add(charactercount);
            Controls.Add(wordcount);
            Controls.Add(linecount);
            Controls.Add(url);
            Controls.Add(size);
            Controls.Add(name);
            Controls.Add(bangthongtin);
            Controls.Add(btn_close);
            Controls.Add(rff);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Lab02_Bai2";
            Text = "Lab02_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rff;
        private Button btn_close;
        private TextBox bangthongtin;
        private TextBox name;
        private TextBox size;
        private TextBox url;
        private TextBox linecount;
        private TextBox wordcount;
        private TextBox charactercount;
        private Label filename_label;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}