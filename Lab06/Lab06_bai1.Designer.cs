namespace Lab06
{
    partial class Lab06_bai1
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
            shift = new TextBox();
            input = new TextBox();
            output = new TextBox();
            btn_encoder = new Button();
            btn_decoder = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 0;
            label1.Text = "MÃ HÓA CAESAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 121);
            label2.Name = "label2";
            label2.Size = new Size(55, 30);
            label2.TabIndex = 1;
            label2.Text = "Dịch";
            // 
            // shift
            // 
            shift.BackColor = SystemColors.Menu;
            shift.Location = new Point(50, 154);
            shift.Name = "shift";
            shift.Size = new Size(179, 37);
            shift.TabIndex = 2;
            // 
            // input
            // 
            input.BackColor = SystemColors.Menu;
            input.Location = new Point(50, 261);
            input.Multiline = true;
            input.Name = "input";
            input.Size = new Size(624, 119);
            input.TabIndex = 3;
            // 
            // output
            // 
            output.BackColor = SystemColors.Menu;
            output.Location = new Point(50, 444);
            output.Multiline = true;
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(624, 123);
            output.TabIndex = 4;
            // 
            // btn_encoder
            // 
            btn_encoder.BackColor = Color.Black;
            btn_encoder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_encoder.ForeColor = Color.White;
            btn_encoder.Location = new Point(328, 49);
            btn_encoder.Name = "btn_encoder";
            btn_encoder.Size = new Size(154, 59);
            btn_encoder.TabIndex = 5;
            btn_encoder.Text = "Mã hóa";
            btn_encoder.UseVisualStyleBackColor = false;
            btn_encoder.Click += btn_encoder_Click;
            // 
            // btn_decoder
            // 
            btn_decoder.BackColor = Color.Black;
            btn_decoder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_decoder.ForeColor = Color.White;
            btn_decoder.Location = new Point(525, 49);
            btn_decoder.Name = "btn_decoder";
            btn_decoder.Size = new Size(149, 59);
            btn_decoder.TabIndex = 6;
            btn_decoder.Text = "Giải mã";
            btn_decoder.UseVisualStyleBackColor = false;
            btn_decoder.Click += btn_decoder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 214);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 7;
            label3.Text = "Input";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 411);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 8;
            label4.Text = "Output";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._344542990_247747164432357_8767651817081568893_n;
            pictureBox1.Location = new Point(328, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Lab06_bai1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(705, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_decoder);
            Controls.Add(btn_encoder);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(shift);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab06_bai1";
            Text = "Lab06_bai1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox shift;
        private TextBox input;
        private TextBox output;
        private Button btn_encoder;
        private Button btn_decoder;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}