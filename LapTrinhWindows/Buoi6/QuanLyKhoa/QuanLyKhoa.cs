using LapTrinhWindows.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LapTrinhWindows.Buoi6.QuanLyKhoa
{
    public partial class QuanLyKhoa : Form
    {
        private Model1 dbContext;

        public QuanLyKhoa()
        {
            InitializeComponent();
            dbContext = new Model1();
            LoadData();
        }

        private void LoadData()
        {
            var faculties = dbContext.Faculties
                .Select(f => new
                {
                    f.FacultyID,
                    f.FacultyName,
                    f.TongSoGS,
                    StudentCount = f.Students.Count 
                }).ToList();

            dgvKhoa.DataSource = faculties;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                int facultyId = int.Parse(txtMaKhoa.Text);
                var faculty = dbContext.Faculties.FirstOrDefault(f => f.FacultyID == facultyId);

                if (faculty != null)
                {
                    // Sửa thông tin khoa
                    faculty.FacultyName = txtTenKhoa.Text;
                    faculty.TongSoGS = int.Parse(txtTongSoGS.Text);
                }
                else
                {
                    // Thêm mới khoa
                    dbContext.Faculties.Add(new Faculty
                    {
                        FacultyID = facultyId,
                        FacultyName = txtTenKhoa.Text,
                        TongSoGS = int.Parse(txtTongSoGS.Text)
                    });
                }

                dbContext.SaveChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhoa.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvKhoa.Rows[e.RowIndex];

                // Kiểm tra null trước khi gán
                txtMaKhoa.Text = selectedRow.Cells["FacultyID"].Value?.ToString() ?? string.Empty;
                txtTenKhoa.Text = selectedRow.Cells["FacultyName"].Value?.ToString() ?? string.Empty;
                txtTongSoGS.Text = selectedRow.Cells["TongSoGS"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int facultyId = int.Parse(txtMaKhoa.Text);
                var faculty = dbContext.Faculties.FirstOrDefault(f => f.FacultyID == facultyId);

                if (faculty != null)
                {
                    dbContext.Faculties.Remove(faculty);
                    dbContext.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa để xóa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
