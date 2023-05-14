namespace Lab04
{
    partial class Lab4_bai6
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            button2 = new Button();
            url = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 576);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(url);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 87);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Dock = DockStyle.Right;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(845, 33);
            button2.Name = "button2";
            button2.Size = new Size(131, 51);
            button2.TabIndex = 1;
            button2.Text = "GET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // url
            // 
            url.Dock = DockStyle.Fill;
            url.Location = new Point(3, 33);
            url.Multiline = true;
            url.Name = "url";
            url.Size = new Size(973, 51);
            url.TabIndex = 0;
            // 
            // Lab4_bai6
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 576);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab4_bai6";
            Text = "Lab4_bai6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox url;
    }
}