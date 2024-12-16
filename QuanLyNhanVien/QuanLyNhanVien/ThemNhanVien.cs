using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{

    public partial class ThemNhanVien : Form
    {
        static String conString = @"Data Source=PETER\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHIcSahap;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(conString);
        public ThemNhanVien()
        {
            InitializeComponent();
        }


        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10,11}$"; // Kiểm tra số điện thoại có 10 hoặc 11 chữ số
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }


        public bool KiemTraSoDienThoai(string soDienThoai, string maNV)
        {
            int count = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM NhanVien WHERE soDienThoai = @soDienThoai AND maNhanVien != @maNV";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    count = (int)cmd.ExecuteScalar();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count == 0;
        }


        public bool KiemTraEmail(string email, string maNV)
        {
            int count = 0;
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "SELECT COUNT(*) FROM NhanVien WHERE gmail = @gmail AND maNhanVien != @maNV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@gmail", email);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    count = (int)cmd.ExecuteScalar();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count == 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            String manv = maNV.Text;
            String hoten = tenNV.Text;
            String gioiTinh = "";

            if (gtnNV.Checked)
            {
                gioiTinh = gtnNV.Text;
            }
            else if (gtnuNV.Checked)
            {
                gioiTinh = gtnuNV.Text;
            }

            String ngaySinh = dateNV.Value.ToString("MM/dd/yyyy");
            String chucVu = cvNV.Text;
            String diaChi = dcNV.Text;
            String sdt = sdtNV.Text;
            String gmail = gmailNV.Text;
            String password = mkNV.Text;
            String ngayVaoLam = datevlNV.Value.ToString("MM/dd/yyyy");


            if (string.IsNullOrWhiteSpace(manv) || string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(gioiTinh) || string.IsNullOrWhiteSpace(ngaySinh) || string.IsNullOrWhiteSpace(chucVu) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(gmail) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(ngayVaoLam))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào tất cả các trường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            // Kiểm tra định dạng số điện thoại
            if (!IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Định dạng số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraSoDienThoai(sdt, manv))
            {
                MessageBox.Show("Số điện thoại đã được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(gmail))
            {
                MessageBox.Show("Định dạng email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraEmail(gmail, manv))
            {
                MessageBox.Show("Email đã được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng mật khẩu
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, chữ số và ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                DateTime ngaySinhParsed;
                DateTime ngayVaoLamParsed;

                bool isNgaySinhValid = DateTime.TryParseExact(ngaySinh, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinhParsed);
                bool isNgayVaoLamValid = DateTime.TryParseExact(ngayVaoLam, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out ngayVaoLamParsed);


                // Thêm dữ liệu vào cơ sở dữ liệu
                String sqlInsert = "INSERT INTO NhanVien(maNhanVien, hoTen, ngaySinh, gioiTinh, chucVu, diaChi, soDienThoai, gmail, password, ngayVaoLam) " +
                                   "VALUES(@manv, @hoten, @ngaySinh, @gioiTinh, @chucVu, @diaChi, @sdt, @gmail, @password, @ngayVaoLam);";

                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@hoten", hoten);
                cmd.Parameters.AddWithValue("@ngaySinh", ngaySinhParsed);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@chucVu", chucVu);
                cmd.Parameters.AddWithValue("@diaChi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@gmail", gmail);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@ngayVaoLam", ngayVaoLamParsed);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }




            this.Hide();
            TrangChuNhanVien tcnv = new TrangChuNhanVien();
            tcnv.Show();

        }











        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChuNhanVien tcnv = new TrangChuNhanVien();
            tcnv.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox1.BackColor);
            ControlPaint.DrawBorder(e.Graphics, groupBox1.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

    }
}
