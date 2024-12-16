using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        static String conString = @"Data Source=PETER\SQLEXPRESS;Initial Catalog=QuanLySieuThiBanLe;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(conString);

        public Form1()
        {
            InitializeComponent();



        }


        public Boolean KiemTraMaHoaDon(string maHD)
        {
            bool exists = false;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM HoaDonbanHang WHERE maHoaDon = @maHoaDon";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHoaDon", maHD);
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


        private void Form1_Load(object sender, EventArgs e)
        {
            dateHD.Value = DateTime.Now;

            string sellectALL = "select maHoaDon, maKhachHang, sum(thanhTien) as TienThanhToan ,  ngayMua from HoaDonBanHang where ngayMua = @dateHD Group by maHoaDon,maKhachHang, ngayMua";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectALL, conn))
                    {
                        cmd.Parameters.AddWithValue("@dateHD", DateTime.Today);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        // Gán dữ liệu cho DataGridView
                        hoaDonBanHangTable.DataSource = dt;

                        // Thiết lập tiêu đề cho các cột
                        hoaDonBanHangTable.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                        hoaDonBanHangTable.Columns["maKhachHang"].HeaderText = "Mã Khách Hàng";
                        hoaDonBanHangTable.Columns["TienThanhToan"].HeaderText = "Tiền Thanh Toán";
                        hoaDonBanHangTable.Columns["ngayMua"].HeaderText = "Ngày Mua";

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDonText.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn hóa đơn !");
                return;
            }
            else if (!KiemTraMaHoaDon(maHoaDonText.Text))
            {
                MessageBox.Show("Hóa đơn không tồn tại !");
                return;
            }
            else
            {
                this.Hide();
                ChinhSuaHoaDonBanHang A = new ChinhSuaHoaDonBanHang(maHoaDonText.Text);
                A.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDonText.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn hóa đơn !");
                return;
            }
            else if (!KiemTraMaHoaDon(maHoaDonText.Text))
            {
                MessageBox.Show("Hóa đơn không tồn tại !");
                return;
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    String removeNV = "DELETE FROM HoaDonbanHang WHERE maHoaDon = @maHoaDon";

                    SqlCommand cmd = new SqlCommand(removeNV, conn);

                    string maNVText = maHoaDonText.Text;
                    cmd.Parameters.AddWithValue("@maHoaDon", maNVText);

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        maHoaDonText.Text = "";
                        MessageBox.Show("Xóa hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void hoaDonBanHangTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < hoaDonBanHangTable.Rows.Count)
            {
                hoaDonBanHangTable.Rows[e.RowIndex].Selected = true;
                // Kiểm tra nếu giá trị của ô không phải là null
                if (hoaDonBanHangTable.Rows[e.RowIndex].Cells["maHoaDon"].Value != null)
                {
                    maHoaDonText.Text = hoaDonBanHangTable.Rows[e.RowIndex].Cells["maHoaDon"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể lấy giá trị của Mã Hóa Đơn.");
                }
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHoaDonBanHang themHoaDon = new ThemHoaDonBanHang();
            themHoaDon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            String maHoaDon = maHD.Text;
            String ngayMuaHang = dateHD.Value.ToString("MM/dd/yyyy");

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string selectAll = "SELECT maHoaDon, maKhachHang, SUM(thanhTien) as TongThanhTien, ngayMua " + "FROM HoaDonBanHang " + "WHERE (maHoaDon = @maHoaDon OR @maHoaDon IS NULL OR @maHoaDon = '') " + "AND (ngayMua = @ngayMuaHang) " + "GROUP BY maHoaDon, maKhachHang, ngayMua";
                SqlCommand cmd = new SqlCommand(selectAll, conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@maHoaDon", string.IsNullOrWhiteSpace(maHoaDon) ? (object)DBNull.Value : maHoaDon);
                cmd.Parameters.AddWithValue("@ngayMuaHang", ngayMuaHang);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                // Gán dữ liệu cho DataGridView
                hoaDonBanHangTable.DataSource = dt;

                hoaDonBanHangTable.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                hoaDonBanHangTable.Columns["maKhachHang"].HeaderText = "Mã Khách Hàng";
                hoaDonBanHangTable.Columns["TongThanhTien"].HeaderText = "Tiền Thanh Toán"; 
                hoaDonBanHangTable.Columns["ngayMua"].HeaderText = "Ngày Mua";
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

        private void dateHD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
