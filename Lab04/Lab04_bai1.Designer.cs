namespace Lab04
{
    partial class Lab04_bai1
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
            link = new TextBox();
            btn_get = new Button();
            banghienthi = new RichTextBox();
            SuspendLayout();
            // 
            // link
            // 
            link.Location = new Point(39, 34);
            link.Name = "link";
            link.Size = new Size(535, 37);
            link.TabIndex = 0;
            // 
            // btn_get
            // 
            btn_get.BackColor = Color.Black;
            btn_get.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_get.ForeColor = Color.White;
            btn_get.Location = new Point(580, 31);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(164, 42);
            btn_get.TabIndex = 2;
            btn_get.Text = "GET";
            btn_get.UseVisualStyleBackColor = false;
            btn_get.Click += btn_get_Click;
            // 
            // banghienthi
            // 
            banghienthi.Location = new Point(39, 100);
            banghienthi.Name = "banghienthi";
            banghienthi.Size = new Size(705, 409);
            banghienthi.TabIndex = 3;
            banghienthi.Text = "";
            // 
            // Lab04_bai1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 540);
            Controls.Add(banghienthi);
            Controls.Add(btn_get);
            Controls.Add(link);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab04_bai1";
            Text = "Lab04_bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox link;
        private Button btn_get;
        private RichTextBox banghienthi;
    }
}