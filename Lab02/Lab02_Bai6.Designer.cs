namespace Lab02
{
    partial class Lab02_Bai6
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
            groupBox = new GroupBox();
            treeView = new TreeView();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Location = new Point(288, 26);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(708, 550);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "File Content";
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 40);
            treeView.Name = "treeView";
            treeView.Size = new Size(255, 536);
            treeView.TabIndex = 2;
            treeView.NodeMouseDoubleClick += treeView_NodeMouseDoubleClick;
            // 
            // Lab02_Bai6
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 615);
            Controls.Add(treeView);
            Controls.Add(groupBox);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Lab02_Bai6";
            Text = "Lab02_Bai6";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TreeView treeView;
    }
}