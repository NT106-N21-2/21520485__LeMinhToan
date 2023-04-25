namespace Lab3
{
    partial class Lab3_bai2
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
            btn_listen = new Button();
            bangchat = new TextBox();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(455, 64);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(112, 34);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // bangchat
            // 
            bangchat.Location = new Point(40, 139);
            bangchat.Multiline = true;
            bangchat.Name = "bangchat";
            bangchat.ScrollBars = ScrollBars.Both;
            bangchat.Size = new Size(527, 272);
            bangchat.TabIndex = 2;
            // 
            // Lab3_bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 448);
            Controls.Add(bangchat);
            Controls.Add(btn_listen);
            Name = "Lab3_bai2";
            Text = "Lab3_bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox bangchat;
    }
}