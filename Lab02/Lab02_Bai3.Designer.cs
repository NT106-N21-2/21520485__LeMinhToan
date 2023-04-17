namespace Lab02
{
    partial class Lab02_Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02_Bai3));
            btn_read = new Button();
            btn_write = new Button();
            label_title = new Label();
            bangthongtin = new TextBox();
            SuspendLayout();
            // 
            // btn_read
            // 
            btn_read.BackColor = Color.White;
            btn_read.Location = new Point(33, 131);
            btn_read.Margin = new Padding(4);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(146, 61);
            btn_read.TabIndex = 0;
            btn_read.Text = "Đọc File";
            btn_read.UseVisualStyleBackColor = false;
            btn_read.Click += btn_read_Click;
            // 
            // btn_write
            // 
            btn_write.BackColor = Color.White;
            btn_write.Location = new Point(33, 237);
            btn_write.Margin = new Padding(4);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(146, 61);
            btn_write.TabIndex = 1;
            btn_write.Text = "Ghi File";
            btn_write.UseVisualStyleBackColor = false;
            btn_write.Click += btn_write_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.BackColor = Color.Transparent;
            label_title.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Yellow;
            label_title.Location = new Point(122, 38);
            label_title.Margin = new Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(313, 45);
            label_title.TabIndex = 2;
            label_title.Text = "Đọc File (Mở Rộng)";
            // 
            // bangthongtin
            // 
            bangthongtin.BackColor = Color.White;
            bangthongtin.Location = new Point(215, 131);
            bangthongtin.Multiline = true;
            bangthongtin.Name = "bangthongtin";
            bangthongtin.ReadOnly = true;
            bangthongtin.Size = new Size(335, 268);
            bangthongtin.TabIndex = 3;
            // 
            // Lab02_Bai3
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(602, 463);
            Controls.Add(bangthongtin);
            Controls.Add(label_title);
            Controls.Add(btn_write);
            Controls.Add(btn_read);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab02_Bai3";
            Text = "Lab02_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_read;
        private Button btn_write;
        private Label label_title;
        private TextBox bangthongtin;
    }
}