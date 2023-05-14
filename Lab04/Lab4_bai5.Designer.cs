namespace Lab04
{
    partial class Lab4_bai5
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
            groupBox1 = new GroupBox();
            ttuser = new TextBox();
            ttpage = new TextBox();
            userspage = new TextBox();
            page = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label12 = new Label();
            label1 = new Label();
            btn_next = new Button();
            btn_back = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(ttuser);
            groupBox1.Controls.Add(ttpage);
            groupBox1.Controls.Add(userspage);
            groupBox1.Controls.Add(page);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_next);
            groupBox1.Controls.Add(btn_back);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(960, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // ttuser
            // 
            ttuser.BackColor = SystemColors.Menu;
            ttuser.BorderStyle = BorderStyle.None;
            ttuser.Location = new Point(403, 126);
            ttuser.Name = "ttuser";
            ttuser.Size = new Size(78, 30);
            ttuser.TabIndex = 10;
            // 
            // ttpage
            // 
            ttpage.BackColor = SystemColors.Menu;
            ttpage.BorderStyle = BorderStyle.None;
            ttpage.Location = new Point(402, 45);
            ttpage.Name = "ttpage";
            ttpage.Size = new Size(78, 30);
            ttpage.TabIndex = 9;
            // 
            // userspage
            // 
            userspage.BackColor = SystemColors.Menu;
            userspage.BorderStyle = BorderStyle.None;
            userspage.Location = new Point(164, 127);
            userspage.Name = "userspage";
            userspage.Size = new Size(79, 30);
            userspage.TabIndex = 8;
            // 
            // page
            // 
            page.BackColor = SystemColors.Menu;
            page.BorderStyle = BorderStyle.None;
            page.Location = new Point(114, 42);
            page.Name = "page";
            page.Size = new Size(78, 30);
            page.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 127);
            label5.Name = "label5";
            label5.Size = new Size(115, 30);
            label5.TabIndex = 6;
            label5.Text = "Total users";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 45);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 5;
            label4.Text = "Total page";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 127);
            label3.Name = "label3";
            label3.Size = new Size(122, 30);
            label3.TabIndex = 4;
            label3.Text = "Users/Page";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 45);
            label12.Name = "label12";
            label12.Size = new Size(60, 30);
            label12.TabIndex = 3;
            label12.Text = "Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(697, 83);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 2;
            label1.Text = "User List";
            // 
            // btn_next
            // 
            btn_next.Location = new Point(824, 78);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(124, 40);
            btn_next.TabIndex = 1;
            btn_next.Text = ">>";
            btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.AutoSize = true;
            btn_back.Location = new Point(554, 78);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(124, 40);
            btn_back.TabIndex = 0;
            btn_back.Text = "<<";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 346);
            panel1.TabIndex = 1;
            // 
            // Lab4_bai5
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab4_bai5";
            Text = "Lab4_bai5";
            Load += Lab4_bai5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btn_next;
        private Button btn_back;
        private TextBox ttuser;
        private TextBox ttpage;
        private TextBox userspage;
        private TextBox page;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label12;
        private Panel panel1;
    }
}