namespace Lab01
{
    partial class Lab01_Bai07
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
            sb_mask = new TextBox();
            gachcheo_label = new Label();
            btn_close = new Button();
            btn_del = new Button();
            host = new TextBox();
            label_host = new Label();
            ip = new TextBox();
            btn_div = new Button();
            label_ip = new Label();
            groupBox1 = new GroupBox();
            bangip = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            diachimang = new DataGridViewTextBoxColumn();
            diachidau = new DataGridViewTextBoxColumn();
            diachicuoi = new DataGridViewTextBoxColumn();
            diachibroadcast = new DataGridViewTextBoxColumn();
            label_tittle = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bangip).BeginInit();
            SuspendLayout();
            // 
            // sb_mask
            // 
            sb_mask.Location = new Point(294, 168);
            sb_mask.Name = "sb_mask";
            sb_mask.Size = new Size(60, 31);
            sb_mask.TabIndex = 62;
            // 
            // gachcheo_label
            // 
            gachcheo_label.AutoSize = true;
            gachcheo_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gachcheo_label.Location = new Point(272, 168);
            gachcheo_label.Name = "gachcheo_label";
            gachcheo_label.Size = new Size(23, 32);
            gachcheo_label.TabIndex = 61;
            gachcheo_label.Text = "/";
            // 
            // btn_close
            // 
            btn_close.Location = new Point(851, 454);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(126, 81);
            btn_close.TabIndex = 57;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(851, 317);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(126, 81);
            btn_del.TabIndex = 56;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // host
            // 
            host.Location = new Point(449, 169);
            host.Name = "host";
            host.Size = new Size(191, 31);
            host.TabIndex = 55;
            // 
            // label_host
            // 
            label_host.AutoSize = true;
            label_host.Location = new Point(449, 120);
            label_host.Name = "label_host";
            label_host.Size = new Size(225, 25);
            label_host.TabIndex = 54;
            label_host.Text = "Nhập Số Lượng Mạng Con";
            // 
            // ip
            // 
            ip.Location = new Point(39, 168);
            ip.Margin = new Padding(4);
            ip.Name = "ip";
            ip.Size = new Size(226, 31);
            ip.TabIndex = 50;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(851, 169);
            btn_div.Margin = new Padding(4);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(126, 81);
            btn_div.TabIndex = 49;
            btn_div.Text = "Chia Mạng Con";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // label_ip
            // 
            label_ip.AutoSize = true;
            label_ip.Location = new Point(39, 120);
            label_ip.Margin = new Padding(4, 0, 4, 0);
            label_ip.Name = "label_ip";
            label_ip.Size = new Size(315, 25);
            label_ip.TabIndex = 48;
            label_ip.Text = "Nhập Địa Chỉ Mạng Kèm Subnet Mask";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bangip);
            groupBox1.Location = new Point(39, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 395);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            // 
            // bangip
            // 
            bangip.BackgroundColor = SystemColors.ButtonHighlight;
            bangip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bangip.Columns.AddRange(new DataGridViewColumn[] { STT, diachimang, diachidau, diachicuoi, diachibroadcast });
            bangip.Dock = DockStyle.Fill;
            bangip.GridColor = SystemColors.Desktop;
            bangip.Location = new Point(3, 27);
            bangip.Name = "bangip";
            bangip.ReadOnly = true;
            bangip.RowHeadersWidth = 62;
            bangip.RowTemplate.Height = 33;
            bangip.Size = new Size(769, 365);
            bangip.TabIndex = 0;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT.FillWeight = 45F;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 76;
            // 
            // diachimang
            // 
            diachimang.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            diachimang.FillWeight = 150F;
            diachimang.HeaderText = "Địa chỉ mạng";
            diachimang.MinimumWidth = 8;
            diachimang.Name = "diachimang";
            diachimang.ReadOnly = true;
            diachimang.Width = 152;
            // 
            // diachidau
            // 
            diachidau.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            diachidau.FillWeight = 150F;
            diachidau.HeaderText = "Địa chỉ đầu";
            diachidau.MinimumWidth = 8;
            diachidau.Name = "diachidau";
            diachidau.ReadOnly = true;
            diachidau.Width = 136;
            // 
            // diachicuoi
            // 
            diachicuoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            diachicuoi.FillWeight = 150F;
            diachicuoi.HeaderText = "Địa chỉ cuối";
            diachicuoi.MinimumWidth = 8;
            diachicuoi.Name = "diachicuoi";
            diachicuoi.ReadOnly = true;
            diachicuoi.Width = 139;
            // 
            // diachibroadcast
            // 
            diachibroadcast.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            diachibroadcast.FillWeight = 150F;
            diachibroadcast.HeaderText = "Địa chỉ Broadcast";
            diachibroadcast.MinimumWidth = 8;
            diachibroadcast.Name = "diachibroadcast";
            diachibroadcast.ReadOnly = true;
            diachibroadcast.Width = 184;
            // 
            // label_tittle
            // 
            label_tittle.AutoSize = true;
            label_tittle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_tittle.Location = new Point(366, 42);
            label_tittle.Name = "label_tittle";
            label_tittle.Size = new Size(217, 38);
            label_tittle.TabIndex = 64;
            label_tittle.Text = "Chia Mạng Con";
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 650);
            Controls.Add(label_tittle);
            Controls.Add(groupBox1);
            Controls.Add(sb_mask);
            Controls.Add(gachcheo_label);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(host);
            Controls.Add(label_host);
            Controls.Add(ip);
            Controls.Add(btn_div);
            Controls.Add(label_ip);
            Name = "Lab01_Bai07";
            Text = "Lab01_Bai09";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bangip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sb_mask;
        private Label gachcheo_label;
        private Button btn_close;
        private Button btn_del;
        private TextBox host;
        private Label label_host;
        private TextBox ip;
        private Button btn_div;
        private Label label_ip;
        private GroupBox groupBox1;
        private DataGridView bangip;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn diachimang;
        private DataGridViewTextBoxColumn diachidau;
        private DataGridViewTextBoxColumn diachicuoi;
        private DataGridViewTextBoxColumn diachibroadcast;
        private Label label_tittle;
    }
}