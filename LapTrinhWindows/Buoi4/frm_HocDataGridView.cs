using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LapTrinhWindows
{
    public partial class frm_HocDataGridView : Form
    {
        DataGridViewCellEventArgs Ev;
        List<Student> students = new List<Student>();
        public frm_HocDataGridView()
        {
            InitializeComponent();
        }

        private void frm_HocDataGridView_Load(object sender, EventArgs e)
        {
            students.Add(new Student(1, "A", "0344590957"));
            students.Add(new Student(2, "B", "0344590957"));
            students.Add(new Student(3, "C", "0344590957"));
            dataStudent.DataSource = students;
        }

        private void dataStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        
        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Ev = e;
                DataGridViewRow selectedRow = dataStudent.Rows[e.RowIndex];


                textBox1.Text = selectedRow.Cells[0].Value?.ToString();
                textBox2.Text = selectedRow.Cells[1].Value?.ToString();
                textBox3.Text = selectedRow.Cells[2].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Ev.RowIndex >= 0)
            {
                students.RemoveAt(Ev.RowIndex);
                dataStudent.DataSource = new BindingList<Student>(students);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Ev.RowIndex >= 0)
    {

                DataGridViewRow selectedRow = dataStudent.Rows[Ev.RowIndex];
                selectedRow.Cells[0].Value = textBox1.Text;
                selectedRow.Cells[1].Value = textBox2.Text;
                selectedRow.Cells[2].Value = textBox3.Text;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
    else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                students.Add(new Student(int.Parse(textBox1.Text),
                    textBox2.Text, textBox3.Text));
                dataStudent.DataSource = new BindingList<Student>(  students);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            }
        }
    }
}
