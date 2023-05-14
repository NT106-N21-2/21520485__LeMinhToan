namespace Lab04
{
    partial class Lab4_bai4
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
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btn_pagesource = new Button();
            btn_download = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(940, 37);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(webView21);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(940, 571);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_pagesource);
            groupBox3.Controls.Add(btn_download);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(813, 33);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(124, 535);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btn_pagesource
            // 
            btn_pagesource.BackColor = Color.Black;
            btn_pagesource.Dock = DockStyle.Fill;
            btn_pagesource.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pagesource.ForeColor = Color.White;
            btn_pagesource.Location = new Point(3, 384);
            btn_pagesource.Name = "btn_pagesource";
            btn_pagesource.Size = new Size(118, 148);
            btn_pagesource.TabIndex = 1;
            btn_pagesource.Text = "View Page Source";
            btn_pagesource.UseVisualStyleBackColor = false;
            btn_pagesource.Click += btn_pagesource_Click_1;
            // 
            // btn_download
            // 
            btn_download.BackColor = Color.Black;
            btn_download.Dock = DockStyle.Top;
            btn_download.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_download.ForeColor = Color.White;
            btn_download.Location = new Point(3, 33);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(118, 351);
            btn_download.TabIndex = 0;
            btn_download.Text = "Tải";
            btn_download.UseVisualStyleBackColor = false;
            btn_download.Click += btn_download_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 33);
            webView21.Name = "webView21";
            webView21.Size = new Size(934, 535);
            webView21.Source = new Uri("https://www.google.com/?hl=vi", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // Lab4_bai4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(940, 608);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab4_bai4";
            Text = "Lab4_bai4";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btn_pagesource;
        private Button btn_download;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}