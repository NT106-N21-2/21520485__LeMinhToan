using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai4 : Form
    {
        public Lab02_Bai4()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        [Serializable]
        class Student
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double Average()
            {
                double t = Math.Round((Course1 + Course2 + Course3) / 3, 2);
                return t;
            }
        }


        private void btn_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = File.Create(filePath);
                binaryFormatter.Serialize(fileStream, students);
                fileStream.Close();
            }
        }
        List<Student> students = new List<Student>();

        private void btn_add_Click(object sender, EventArgs e)
        {
            double c1, c2, c3;
            if (double.TryParse(wC1.Text, out c1) && double.TryParse(wC3.Text, out c3) && double.TryParse(wC2.Text, out c2)
               && c1 >= 0 && c2 >= 0 && c3 >= 0 && wname.Text != "" && wPhone.Text != "" && wId.Text != "")
            {
                Student student = new Student()
                {
                    Name = wname.Text,
                    Id = wId.Text,
                    Phone = wPhone.Text,
                    Course1 = c1,
                    Course2 = c2,
                    Course3 = c3,
                };
                students.Add(student);
                wC1.Clear(); wC2.Clear(); wC3.Clear();
                wId.Clear(); wname.Clear(); wPhone.Clear();
                bangthongtin.Items.Add(student.Name);
                bangthongtin.Items.Add(student.Id);
                bangthongtin.Items.Add(student.Phone);
                bangthongtin.Items.Add(student.Course1);
                bangthongtin.Items.Add(student.Course2);
                bangthongtin.Items.Add(student.Course3);
                bangthongtin.Items.Add(student.Average());
                bangthongtin.Items.Add("");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại thông tin cho đúng!");
            }

        }

        List<Student> students_read;
        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                indexpage = 1;
                page.Text = "1";
                string filePath = openFileDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = File.OpenRead(filePath);
                students_read = binaryFormatter.Deserialize(fileStream) as List<Student>;
                lenoflist = students_read.Count;
                ChangeStatus();
                fileStream.Close();
            }
        }
        int lenoflist;
        int indexpage = -1;
        public void ChangeStatus()
        {
            rName.Text = students_read[indexpage - 1].Name;
            rPhone.Text = students_read[indexpage - 1].Phone;
            rId.Text = students_read[indexpage - 1].Id;
            rC3.Text = students_read[indexpage - 1].Course3.ToString();
            rC2.Text = students_read[indexpage - 1].Course2.ToString();
            rC1.Text = students_read[indexpage - 1].Course1.ToString();
            rAvr.Text = students_read[indexpage - 1].Average().ToString();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (indexpage < 0) { MessageBox.Show("Vui lòng chọn file đọc dữ liệu trước!"); }
            else
            {
                if (indexpage == 1)
                {
                    indexpage = lenoflist;
                }
                else indexpage -= 1;
                page.Text = indexpage.ToString();
                ChangeStatus();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (indexpage < 0) { MessageBox.Show("Vui lòng chọn file đọc dữ liệu trước!"); }
            else
            {
                if (indexpage == lenoflist)
                {
                    indexpage = 1;
                }
                else indexpage += 1;
                page.Text = indexpage.ToString();
                ChangeStatus();
            }
        }
    }
}
