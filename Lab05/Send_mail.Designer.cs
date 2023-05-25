namespace Lab05
{
    partial class Send_mail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            from = new TextBox();
            name = new TextBox();
            to = new TextBox();
            subject = new TextBox();
            content = new TextBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            file_link = new TextBox();
            btn_browse = new Button();
            btn_send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 109);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 2;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 153);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 3;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 206);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 4;
            label5.Text = "Body";
            // 
            // from
            // 
            from.Location = new Point(122, 12);
            from.Name = "from";
            from.Size = new Size(428, 34);
            from.TabIndex = 5;
            // 
            // name
            // 
            name.Location = new Point(122, 58);
            name.Name = "name";
            name.Size = new Size(428, 34);
            name.TabIndex = 6;
            // 
            // to
            // 
            to.Location = new Point(122, 103);
            to.Name = "to";
            to.Size = new Size(428, 34);
            to.TabIndex = 7;
            // 
            // subject
            // 
            subject.Location = new Point(122, 147);
            subject.Name = "subject";
            subject.Size = new Size(428, 34);
            subject.TabIndex = 8;
            // 
            // content
            // 
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Location = new Point(122, 257);
            content.Multiline = true;
            content.Name = "content";
            content.Size = new Size(428, 338);
            content.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(122, 206);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 32);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "HTML";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 607);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 12;
            label6.Text = "Attachment";
            // 
            // file_link
            // 
            file_link.Location = new Point(151, 601);
            file_link.Name = "file_link";
            file_link.Size = new Size(281, 34);
            file_link.TabIndex = 13;
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(438, 601);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(112, 34);
            btn_browse.TabIndex = 14;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += button1_Click;
            // 
            // btn_send
            // 
            btn_send.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.Location = new Point(396, 650);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(154, 34);
            btn_send.TabIndex = 15;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // Send_mail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 696);
            Controls.Add(btn_send);
            Controls.Add(btn_browse);
            Controls.Add(file_link);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(content);
            Controls.Add(subject);
            Controls.Add(to);
            Controls.Add(name);
            Controls.Add(from);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Send_mail";
            Text = "Send_mail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox from;
        private TextBox name;
        private TextBox to;
        private TextBox subject;
        private TextBox content;
        private CheckBox checkBox1;
        private Label label6;
        private TextBox file_link;
        private Button btn_browse;
        private Button btn_send;
    }
}