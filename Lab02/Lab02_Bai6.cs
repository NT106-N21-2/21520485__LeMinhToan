using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace Lab02
{
    public partial class Lab02_Bai6 : Form
    {
        public Lab02_Bai6()
        {
            InitializeComponent();
            /*
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                TreeNode node=new TreeNode() { Text=d.Name};
                 Loadfile_folder(node);
                 treeView.Nodes.Add(node);
            
            }
            */
            string path = @"D:\";
            TreeNode node = new TreeNode() { Text = path };
            Loadfile_folder(node);
            treeView.Nodes.Add(node);
            
        }
        public void Loadfile_folder(TreeNode root)
        {
            if (root == null) return;
            try
            {
                string[] filePaths = Directory.GetFiles(root.Text);
                foreach (string filePath in filePaths)
                {
                    TreeNode node = new TreeNode() { Text = filePath };
                    root.Nodes.Add(node);
                }
                var folderlist = new DirectoryInfo(root.Text).GetDirectories();
                if (folderlist.Count() == 0) return;
                foreach (DirectoryInfo d in folderlist)
                {
                    if (Directory.Exists(d.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = d.FullName };
                        root.Nodes.Add(node);
                        Loadfile_folder(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            groupBox.Controls.Clear();
            TreeNode node = treeView.GetNodeAt(treeView.PointToClient(Cursor.Position));
            if (node != null)
            {
                string filePath = node.Text;
                if (Path.GetExtension(filePath).ToLower() == ".jpg" || Path.GetExtension(filePath).ToLower() == ".jpeg" || Path.GetExtension(filePath).ToLower() == ".png" || Path.GetExtension(filePath).ToLower() == ".bmp" || Path.GetExtension(filePath).ToLower() == ".gif")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(filePath);
                    pictureBox.Dock = DockStyle.Fill;
                    groupBox.Controls.Add(pictureBox);
                }
                else if (Path.GetExtension(filePath).ToLower() == ".txt")
                {
                    System.Windows.Forms.TextBox tb = new TextBox();
                    tb.Multiline = true;
                    tb.Dock = DockStyle.Fill;
                    tb.ScrollBars = ScrollBars.Vertical;
                    tb.Text = File.ReadAllText(filePath);
                    groupBox.Controls.Add(tb);
                }
                else
                {
                    MessageBox.Show("Hiện tại chưa hỗ trợ hiển thị loại này!");
                }
            }
        }
    }
}
