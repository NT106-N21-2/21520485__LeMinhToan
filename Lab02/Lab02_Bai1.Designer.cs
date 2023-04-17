namespace Lab02
{
    partial class Lab02_Bai1
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
            btn_read = new Button();
            btn_write = new Button();
            textBox = new TextBox();
            label_title = new Label();
            SuspendLayout();
            // 
            // btn_read
            // 
            btn_read.BackColor = Color.White;
            btn_read.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_read.Location = new Point(24, 110);
            btn_read.Margin = new Padding(4);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(247, 86);
            btn_read.TabIndex = 0;
            btn_read.Text = "Đọc File";
            btn_read.UseVisualStyleBackColor = false;
            btn_read.Click += btn_read_Click;
            // 
            // btn_write
            // 
            btn_write.BackColor = Color.White;
            btn_write.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_write.Location = new Point(24, 256);
            btn_write.Margin = new Padding(4);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(247, 86);
            btn_write.TabIndex = 1;
            btn_write.Text = "Ghi file";
            btn_write.UseVisualStyleBackColor = false;
            btn_write.Click += btn_write_Click;
            // 
            // textBox
            // 
            textBox.BackColor = Color.White;
            textBox.Location = new Point(293, 110);
            textBox.Margin = new Padding(4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(482, 352);
            textBox.TabIndex = 2;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.BackColor = Color.Transparent;
            label_title.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Yellow;
            label_title.Location = new Point(307, 31);
            label_title.Margin = new Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(215, 38);
            label_title.TabIndex = 3;
            label_title.Text = "Ghi Và Đọc File";
            // 
            // Lab02_Bai1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d4bcc46e371e194b20854acd1ba3a86b;
            ClientSize = new Size(809, 486);
            Controls.Add(label_title);
            Controls.Add(textBox);
            Controls.Add(btn_write);
            Controls.Add(btn_read);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab02_Bai1";
            Text = "Lab02_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_read;
        private Button btn_write;
        private TextBox textBox;
        private Label label_title;
    }
}