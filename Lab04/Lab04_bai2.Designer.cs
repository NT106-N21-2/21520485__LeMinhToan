namespace Lab04
{
    partial class Lab04_bai2
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
            url = new TextBox();
            datapost = new TextBox();
            button1 = new Button();
            banghienthi = new RichTextBox();
            SuspendLayout();
            // 
            // url
            // 
            url.Location = new Point(30, 22);
            url.Name = "url";
            url.Size = new Size(490, 37);
            url.TabIndex = 0;
            // 
            // datapost
            // 
            datapost.Location = new Point(30, 80);
            datapost.Name = "datapost";
            datapost.Size = new Size(490, 37);
            datapost.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(549, 22);
            button1.Name = "button1";
            button1.Size = new Size(126, 37);
            button1.TabIndex = 2;
            button1.Text = "POST";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // banghienthi
            // 
            banghienthi.Location = new Point(30, 149);
            banghienthi.Name = "banghienthi";
            banghienthi.Size = new Size(645, 380);
            banghienthi.TabIndex = 3;
            banghienthi.Text = "";
            // 
            // Lab04_bai2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 564);
            Controls.Add(banghienthi);
            Controls.Add(button1);
            Controls.Add(datapost);
            Controls.Add(url);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab04_bai2";
            Text = "Lab04_bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox url;
        private TextBox datapost;
        private Button button1;
        private RichTextBox banghienthi;
    }
}