namespace Lab05
{
    partial class Lab05_bai2
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
            email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pass = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            btn_login = new Button();
            label3 = new Label();
            total = new TextBox();
            pictureBox1 = new PictureBox();
            recent = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // email
            // 
            email.BackColor = SystemColors.Menu;
            email.Location = new Point(161, 33);
            email.Name = "email";
            email.Size = new Size(243, 37);
            email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // pass
            // 
            pass.BackColor = SystemColors.Menu;
            pass.Location = new Point(161, 91);
            pass.Name = "pass";
            pass.PasswordChar = '#';
            pass.Size = new Size(243, 37);
            pass.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, From, Time });
            dataGridView2.Location = new Point(36, 170);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(823, 364);
            dataGridView2.TabIndex = 5;
            dataGridView2.RowHeaderMouseDoubleClick += dataGridView2_RowHeaderMouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Email";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // From
            // 
            From.HeaderText = "From";
            From.MinimumWidth = 8;
            From.Name = "From";
            From.Width = 180;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.Width = 180;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Black;
            btn_login.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(630, 33);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(229, 51);
            btn_login.TabIndex = 6;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 120);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 7;
            label3.Text = "Total";
            // 
            // total
            // 
            total.BackColor = Color.White;
            total.BorderStyle = BorderStyle.None;
            total.Location = new Point(544, 117);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(99, 30);
            total.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._306741601_463645979202813_4431913471955987039_n;
            pictureBox1.Location = new Point(436, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // recent
            // 
            recent.BackColor = Color.White;
            recent.BorderStyle = BorderStyle.None;
            recent.Location = new Point(756, 117);
            recent.Name = "recent";
            recent.ReadOnly = true;
            recent.Size = new Size(101, 30);
            recent.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(672, 120);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 8;
            label4.Text = "Recent";
            // 
            // Lab05_bai2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 566);
            Controls.Add(pictureBox1);
            Controls.Add(recent);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(dataGridView2);
            Controls.Add(pass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(email);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab05_bai2";
            Text = "Lab05_bai2";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private Label label1;
        private Label label2;
        private TextBox pass;
        private DataGridView dataGridView2;
        private Button btn_login;
        private Label label3;
        private TextBox total;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Time;
        private PictureBox pictureBox1;
        private TextBox recent;
        private Label label4;
    }
}