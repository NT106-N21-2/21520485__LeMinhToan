namespace Lab05
{
    partial class Lab05_bai1
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
            btn_send = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mail = new TextBox();
            subject = new TextBox();
            to_e = new TextBox();
            from_e = new TextBox();
            password = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.Black;
            btn_send.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.ForeColor = Color.White;
            btn_send.Location = new Point(732, 467);
            btn_send.Margin = new Padding(4);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(133, 65);
            btn_send.TabIndex = 15;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 186);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 14;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 30);
            label2.TabIndex = 13;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 12;
            label1.Text = "From";
            // 
            // mail
            // 
            mail.BackColor = SystemColors.Menu;
            mail.Location = new Point(40, 264);
            mail.Margin = new Padding(4);
            mail.Multiline = true;
            mail.Name = "mail";
            mail.Size = new Size(660, 268);
            mail.TabIndex = 11;
            // 
            // subject
            // 
            subject.BackColor = SystemColors.Menu;
            subject.Location = new Point(160, 183);
            subject.Margin = new Padding(4);
            subject.Multiline = true;
            subject.Name = "subject";
            subject.Size = new Size(540, 47);
            subject.TabIndex = 10;
            // 
            // to_e
            // 
            to_e.BackColor = SystemColors.Menu;
            to_e.Location = new Point(160, 107);
            to_e.Margin = new Padding(4);
            to_e.Name = "to_e";
            to_e.Size = new Size(294, 37);
            to_e.TabIndex = 9;
            // 
            // from_e
            // 
            from_e.BackColor = SystemColors.Control;
            from_e.Location = new Point(160, 30);
            from_e.Margin = new Padding(4);
            from_e.Name = "from_e";
            from_e.Size = new Size(294, 37);
            from_e.TabIndex = 8;
            // 
            // password
            // 
            password.BackColor = SystemColors.Menu;
            password.Location = new Point(481, 30);
            password.Name = "password";
            password.PasswordChar = '#';
            password.Size = new Size(219, 37);
            password.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 70);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images111;
            pictureBox1.Location = new Point(707, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 293);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Lab05_bai1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(903, 571);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(btn_send);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mail);
            Controls.Add(subject);
            Controls.Add(to_e);
            Controls.Add(from_e);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab05_bai1";
            Text = "Lab05_bai1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_send;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox mail;
        private TextBox subject;
        private TextBox to_e;
        private TextBox from_e;
        private TextBox password;
        private Label label4;
        private PictureBox pictureBox1;
    }
}