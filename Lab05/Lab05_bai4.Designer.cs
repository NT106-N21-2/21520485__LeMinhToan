namespace Lab05
{
    partial class Lab05_bai4
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
            btn_signin = new Button();
            btn_signout = new Button();
            btn_refresh = new Button();
            btn_send = new Button();
            password = new TextBox();
            account = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            port_imap = new TextBox();
            set_imap = new TextBox();
            port_smtp = new TextBox();
            set_smtp = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            From = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            Datetime = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_signin);
            groupBox1.Controls.Add(btn_signout);
            groupBox1.Controls.Add(btn_refresh);
            groupBox1.Controls.Add(btn_send);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(account);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // btn_signin
            // 
            btn_signin.BackColor = Color.Black;
            btn_signin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_signin.ForeColor = Color.White;
            btn_signin.Location = new Point(259, 159);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(171, 34);
            btn_signin.TabIndex = 7;
            btn_signin.Text = "Đăng nhập";
            btn_signin.UseVisualStyleBackColor = false;
            btn_signin.Click += btn_signin_Click;
            // 
            // btn_signout
            // 
            btn_signout.BackColor = Color.Black;
            btn_signout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_signout.ForeColor = Color.White;
            btn_signout.Location = new Point(318, 159);
            btn_signout.Name = "btn_signout";
            btn_signout.Size = new Size(112, 34);
            btn_signout.TabIndex = 6;
            btn_signout.Text = "Đăng xuất";
            btn_signout.UseVisualStyleBackColor = false;
            btn_signout.Visible = false;
            btn_signout.Click += btn_signout_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.Black;
            btn_refresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_refresh.ForeColor = Color.White;
            btn_refresh.Location = new Point(173, 159);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(112, 34);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Visible = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.Black;
            btn_send.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.ForeColor = Color.White;
            btn_send.Location = new Point(24, 159);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(112, 34);
            btn_send.TabIndex = 4;
            btn_send.Text = "Gửi email";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Visible = false;
            btn_send.Click += btn_send_Click;
            // 
            // password
            // 
            password.Location = new Point(131, 106);
            password.Name = "password";
            password.PasswordChar = '#';
            password.Size = new Size(299, 31);
            password.TabIndex = 3;
            // 
            // account
            // 
            account.Location = new Point(131, 47);
            account.Name = "account";
            account.Size = new Size(299, 31);
            account.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 112);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 1;
            label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 50);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 0;
            label5.Text = "Tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(port_imap);
            groupBox2.Controls.Add(set_imap);
            groupBox2.Controls.Add(port_smtp);
            groupBox2.Controls.Add(set_smtp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(483, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(563, 209);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài đặt";
            // 
            // port_imap
            // 
            port_imap.Location = new Point(97, 109);
            port_imap.Name = "port_imap";
            port_imap.Size = new Size(176, 31);
            port_imap.TabIndex = 7;
            // 
            // set_imap
            // 
            set_imap.Location = new Point(97, 39);
            set_imap.Name = "set_imap";
            set_imap.Size = new Size(176, 31);
            set_imap.TabIndex = 6;
            // 
            // port_smtp
            // 
            port_smtp.Location = new Point(358, 109);
            port_smtp.Name = "port_smtp";
            port_smtp.Size = new Size(164, 31);
            port_smtp.TabIndex = 5;
            // 
            // set_smtp
            // 
            set_smtp.Location = new Point(358, 39);
            set_smtp.Name = "set_smtp";
            set_smtp.Size = new Size(164, 31);
            set_smtp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 113);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 45);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "SMTP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 116);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 45);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "IMAP";
            // 
            // dataGridView1
            // 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { From, Subject, Datetime });
            dataGridView1.Location = new Point(12, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1034, 330);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // From
            // 
            From.HeaderText = "From";
            From.MinimumWidth = 8;
            From.Name = "From";
            From.Width = 280;
            // 
            // Subject
            // 
            Subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 8;
            Subject.Name = "Subject";
            // 
            // Datetime
            // 
            Datetime.HeaderText = "Datetime";
            Datetime.MinimumWidth = 8;
            Datetime.Name = "Datetime";
            Datetime.Width = 200;
            // 
            // Lab05_bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 587);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Lab05_bai4";
            Text = "Lab05_bai4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox password;
        private TextBox account;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox port_imap;
        private TextBox set_imap;
        private TextBox port_smtp;
        private TextBox set_smtp;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_signout;
        private Button btn_refresh;
        private Button btn_send;
        private Button btn_signin;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Datetime;
    }
}