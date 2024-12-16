using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyNhanVien
{
    public partial class TrangChuNhanVien : Form
    {

        static String conString = @"Data Source=PETER\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHIcSahap;Integrated Security=True;TrustServerCertificate=True";
        public SqlConnection conn = new SqlConnection(conString);

        private NhanVien nhanVien;


        public Boolean KiemTraMaNhanVien(string maNV)
        {
            bool exists = false;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM NhanVien WHERE maNhanVien = @maNhanVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maNhanVien", maNV);
                        int count = (int)cmd.ExecuteScalar();
                        exists = (count > 0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return exists;
        }


        public TrangChuNhanVien()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            NhanVien_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemNhanVien themNV = new ThemNhanVien();
            themNV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maNV.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn nhân viên !");
                return;
            }
            else if (!KiemTraMaNhanVien(maNV.Text))
            {
                MessageBox.Show("Nhân viên không tồn tại !");
                return;
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    String removeNV = "DELETE FROM NHANVIEN WHERE maNhanVien = @maNhanVien";

                    SqlCommand cmd = new SqlCommand(removeNV, conn);

                    string maNVText = maNV.Text;
                    cmd.Parameters.AddWithValue("@maNhanVien", maNVText);

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    int rowsAffected = 0;
                    if (result == DialogResult.Yes)
                    {
                        rowsAffected = cmd.ExecuteNonQuery();
                        
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }


                    if (rowsAffected > 0)
                    {
                        maNV.Text = "";
                        MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }


        }



        private void NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                String selectAll = "SELECT * FROM NhanVien ORDER BY maNhanVien ASC";
                SqlCommand cmd = new SqlCommand(selectAll, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                nhanVienTable.DataSource = dt;

                nhanVienTable.Columns[0].HeaderText = "Mã Nhân Viên";
                nhanVienTable.Columns[1].HeaderText = "Họ Tên";
                nhanVienTable.Columns[2].HeaderText = "Ngày Sinh";
                nhanVienTable.Columns[3].HeaderText = "Giới Tính";
                nhanVienTable.Columns[4].HeaderText = "Địa Chỉ";
                nhanVienTable.Columns[5].HeaderText = "Chức Vụ";
                nhanVienTable.Columns[6].HeaderText = "Số Điện Thoại";
                nhanVienTable.Columns[7].HeaderText = "Email";
                nhanVienTable.Columns[8].HeaderText = "Mật Khẩu";
                nhanVienTable.Columns[9].HeaderText = "Ngày Vào Làm";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhanVienTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                nhanVienTable.Rows[e.RowIndex].Selected = true;
                maNV.Text = nhanVienTable[0, e.RowIndex].Value.ToString();
        }

        private void ChinhSuaNhanVien_Click(object sender, EventArgs e)
        {
            String maNVText = maNV.Text;
            if (string.IsNullOrWhiteSpace(maNV.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn nhân viên !");
                return;
            }
            else if (!KiemTraMaNhanVien(maNV.Text))
            {
                MessageBox.Show("Nhân viên không tồn tại !");
                return;
            }
            else
            {
                this.Hide();
                ChinhSuaNhanVien csNV = new ChinhSuaNhanVien(maNVText);
                csNV.Show();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String sdt = tkSdt_NV.Text;
            String ten = tkName_NV.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                String sellectAll = "SELECT * FROM NhanVien WHERE (HOTEN LIKE @hoTen OR @hoTen IS NULL OR @hoTen = '') AND (soDienThoai LIKE @sdt OR @sdt IS NULL OR @sdt = '' )";
                SqlCommand cmd = new SqlCommand(sellectAll, conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@hoTen", string.IsNullOrWhiteSpace(ten) ? (object)DBNull.Value : "%" + ten + "%");
                cmd.Parameters.AddWithValue("@sdt", string.IsNullOrWhiteSpace(sdt) ? (object)DBNull.Value : sdt);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                nhanVienTable.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();


            }
        }
    }
}
