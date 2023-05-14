namespace Lab04
{
    partial class Lab04_bai3
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
            linkweb = new TextBox();
            linkfile = new TextBox();
            btn_download = new Button();
            bangshow = new RichTextBox();
            SuspendLayout();
            // 
            // linkweb
            // 
            linkweb.Location = new Point(37, 36);
            linkweb.Margin = new Padding(4);
            linkweb.Name = "linkweb";
            linkweb.Size = new Size(593, 37);
            linkweb.TabIndex = 0;
            // 
            // linkfile
            // 
            linkfile.Location = new Point(37, 96);
            linkfile.Name = "linkfile";
            linkfile.Size = new Size(593, 37);
            linkfile.TabIndex = 1;
            // 
            // btn_download
            // 
            btn_download.BackColor = Color.Black;
            btn_download.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_download.ForeColor = Color.White;
            btn_download.Location = new Point(643, 36);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(145, 50);
            btn_download.TabIndex = 2;
            btn_download.Text = "Download";
            btn_download.UseVisualStyleBackColor = false;
            btn_download.Click += btn_download_Click;
            // 
            // bangshow
            // 
            bangshow.Location = new Point(37, 165);
            bangshow.Name = "bangshow";
            bangshow.Size = new Size(751, 361);
            bangshow.TabIndex = 3;
            bangshow.Text = "";
            // 
            // Lab04_bai3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 552);
            Controls.Add(bangshow);
            Controls.Add(btn_download);
            Controls.Add(linkfile);
            Controls.Add(linkweb);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab04_bai3";
            Text = "Lab04_bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox linkweb;
        private TextBox linkfile;
        private Button btn_download;
        private RichTextBox bangshow;
    }
}