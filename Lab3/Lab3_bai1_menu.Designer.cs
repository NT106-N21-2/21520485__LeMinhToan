namespace Lab3
{
    partial class Lab3_bai1_menu
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
            btn_serverform = new Button();
            btn_clientform = new Button();
            SuspendLayout();
            // 
            // btn_serverform
            // 
            btn_serverform.Location = new Point(97, 116);
            btn_serverform.Name = "btn_serverform";
            btn_serverform.Size = new Size(131, 82);
            btn_serverform.TabIndex = 0;
            btn_serverform.Text = "UDP server";
            btn_serverform.UseVisualStyleBackColor = true;
            btn_serverform.Click += button1_Click;
            // 
            // btn_clientform
            // 
            btn_clientform.Location = new Point(391, 116);
            btn_clientform.Name = "btn_clientform";
            btn_clientform.Size = new Size(142, 82);
            btn_clientform.TabIndex = 1;
            btn_clientform.Text = "UDP client";
            btn_clientform.UseVisualStyleBackColor = true;
            btn_clientform.Click += button2_Click;
            // 
            // Lab3_bai1_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 323);
            Controls.Add(btn_clientform);
            Controls.Add(btn_serverform);
            Name = "Lab3_bai1_menu";
            Text = "Lab3_bai1_menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_serverform;
        private Button btn_clientform;
    }
}