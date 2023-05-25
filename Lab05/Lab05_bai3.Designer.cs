namespace Lab05
{
    partial class Lab05_bai3
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
            pictureBox1 = new PictureBox();
            total = new TextBox();
            label3 = new Label();
            btn_login = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            pass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            email = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._306741601_463645979202813_4431913471955987039_n;
            pictureBox1.Location = new Point(426, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // total
            // 
            total.BackColor = Color.White;
            total.BorderStyle = BorderStyle.None;
            total.Location = new Point(620, 111);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(99, 30);
            total.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(541, 114);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 18;
            label3.Text = "Total";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Black;
            btn_login.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(620, 28);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(229, 51);
            btn_login.TabIndex = 17;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, From, Time });
            dataGridView2.Location = new Point(26, 165);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(823, 364);
            dataGridView2.TabIndex = 16;
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
            // pass
            // 
            pass.BackColor = SystemColors.Menu;
            pass.Location = new Point(151, 86);
            pass.Name = "pass";
            pass.PasswordChar = '#';
            pass.Size = new Size(243, 37);
            pass.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // email
            // 
            email.BackColor = SystemColors.Menu;
            email.Location = new Point(151, 28);
            email.Name = "email";
            email.Size = new Size(243, 37);
            email.TabIndex = 12;
            // 
            // Lab05_bai3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(876, 557);
            Controls.Add(pictureBox1);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(dataGridView2);
            Controls.Add(pass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(email);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab05_bai3";
            Text = "Lab05_bai3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox total;
        private Label label3;
        private Button btn_login;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Time;
        private TextBox pass;
        private Label label2;
        private Label label1;
        private TextBox email;
    }
}