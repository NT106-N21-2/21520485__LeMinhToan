namespace Lab06
{
    partial class Lab06_bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab06_bai2));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btn_decoder = new Button();
            btn_encoder = new Button();
            output = new TextBox();
            input = new TextBox();
            key = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(445, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 390);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 18;
            label4.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 193);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 17;
            label3.Text = "Input";
            // 
            // btn_decoder
            // 
            btn_decoder.BackColor = Color.Black;
            btn_decoder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_decoder.ForeColor = Color.White;
            btn_decoder.Location = new Point(542, 28);
            btn_decoder.Name = "btn_decoder";
            btn_decoder.Size = new Size(149, 59);
            btn_decoder.TabIndex = 16;
            btn_decoder.Text = "Giải mã";
            btn_decoder.UseVisualStyleBackColor = false;
            btn_decoder.Click += btn_decoder_Click;
            // 
            // btn_encoder
            // 
            btn_encoder.BackColor = Color.Black;
            btn_encoder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_encoder.ForeColor = Color.White;
            btn_encoder.Location = new Point(345, 28);
            btn_encoder.Name = "btn_encoder";
            btn_encoder.Size = new Size(154, 59);
            btn_encoder.TabIndex = 15;
            btn_encoder.Text = "Mã hóa";
            btn_encoder.UseVisualStyleBackColor = false;
            btn_encoder.Click += btn_encoder_Click;
            // 
            // output
            // 
            output.BackColor = SystemColors.Menu;
            output.Location = new Point(67, 423);
            output.Multiline = true;
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(624, 123);
            output.TabIndex = 14;
            // 
            // input
            // 
            input.BackColor = SystemColors.Menu;
            input.Location = new Point(67, 240);
            input.Multiline = true;
            input.Name = "input";
            input.Size = new Size(624, 119);
            input.TabIndex = 13;
            // 
            // key
            // 
            key.BackColor = SystemColors.Menu;
            key.Location = new Point(67, 133);
            key.Name = "key";
            key.Size = new Size(179, 37);
            key.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 100);
            label2.Name = "label2";
            label2.Size = new Size(49, 30);
            label2.TabIndex = 11;
            label2.Text = "Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 10;
            label1.Text = "MÃ HÓA VIGENÈRE";
            // 
            // Lab06_bai2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(730, 581);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_decoder);
            Controls.Add(btn_encoder);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(key);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab06_bai2";
            Text = "Lab06_bai2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Button btn_decoder;
        private Button btn_encoder;
        private TextBox output;
        private TextBox input;
        private TextBox key;
        private Label label2;
        private Label label1;
    }
}