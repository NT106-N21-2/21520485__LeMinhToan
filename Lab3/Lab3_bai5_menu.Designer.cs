namespace Lab3
{
    partial class Lab3_bai5_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3_bai5_menu));
            btn_client = new Button();
            btn_server = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_client
            // 
            btn_client.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_client.Location = new Point(46, 113);
            btn_client.Name = "btn_client";
            btn_client.Size = new Size(128, 67);
            btn_client.TabIndex = 0;
            btn_client.Text = "Client";
            btn_client.UseVisualStyleBackColor = true;
            btn_client.Click += btn_client_Click;
            // 
            // btn_server
            // 
            btn_server.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_server.Location = new Point(46, 233);
            btn_server.Name = "btn_server";
            btn_server.Size = new Size(128, 67);
            btn_server.TabIndex = 1;
            btn_server.Text = "Server";
            btn_server.UseVisualStyleBackColor = true;
            btn_server.Click += btn_server_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Lab3_bai5_menu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(572, 483);
            Controls.Add(pictureBox1);
            Controls.Add(btn_server);
            Controls.Add(btn_client);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Lab3_bai5_menu";
            Text = "Lab3_bai5_menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_client;
        private Button btn_server;
        private PictureBox pictureBox1;
    }
}