namespace Lab01
{
    partial class Lab01_Bai01
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
            num1 = new TextBox();
            num2 = new TextBox();
            result = new TextBox();
            btn_sum = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 91);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 0;
            label1.Text = "Số Thứ Nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 169);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 1;
            label2.Text = "Số Thứ Hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 356);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 2;
            label3.Text = "Kết Quả";
            // 
            // num1
            // 
            num1.AccessibleRole = AccessibleRole.None;
            num1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            num1.Location = new Point(219, 92);
            num1.Name = "num1";
            num1.Size = new Size(234, 37);
            num1.TabIndex = 3;
            num1.TextChanged += num1_TextChanged;
            // 
            // num2
            // 
            num2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            num2.Location = new Point(219, 170);
            num2.Name = "num2";
            num2.Size = new Size(234, 37);
            num2.TabIndex = 4;
            num2.TextChanged += num2_TextChanged;
            // 
            // result
            // 
            result.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(219, 349);
            result.Name = "result";
            result.Size = new Size(234, 37);
            result.TabIndex = 5;
            // 
            // btn_sum
            // 
            btn_sum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sum.Location = new Point(66, 250);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(387, 53);
            btn_sum.TabIndex = 6;
            btn_sum.Text = "Tính";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(98, 32);
            label4.Name = "label4";
            label4.Size = new Size(313, 32);
            label4.TabIndex = 7;
            label4.Text = "Tính Tổng Hai Số Nguyên";
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 439);
            Controls.Add(label4);
            Controls.Add(btn_sum);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai01";
            Text = "Lab01_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox num1;
        private TextBox num2;
        private TextBox result;
        private Button btn_sum;
        private Label label4;
    }
}