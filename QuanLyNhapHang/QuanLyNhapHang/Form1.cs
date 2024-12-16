using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhapHang
{
    public partial class Form1 : Form
    {
        static string connString = @"Data Source=PETER\SQLEXPRESS;Initial Catalog=QuanLySieuThiBanLe;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=50;";
        SqlConnection conn = new SqlConnection(connString);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string selectHD = "SELECT maHoaDon, ghiChu, ngayNhap, SUM(thanhTien) AS thanhTien " +
                                    "FROM NhapKho " +
                                    "GROUP BY maHoaDon, ghiChu, ngayNhap";
                using (SqlCommand cmd = new SqlCommand(selectHD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    hoaDonNhapKho.DataSource = dt;

                    hoaDonNhapKho.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                    hoaDonNhapKho.Columns["ghiChu"].HeaderText = "Ghi Chú";
                    hoaDonNhapKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
                    hoaDonNhapKho.Columns["thanhTien"].HeaderText = "Thành Tiền";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TaoHoaDonNhapHang().Show();
        }

        private void hoaDonNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && hoaDonNhapKho.Rows[e.RowIndex].Cells["maHoaDon"].Value != null)
            {
                hoaDonNhapKho.Rows[e.RowIndex].Selected = true;
                maHoaDon.Text = hoaDonNhapKho["maHoaDon", e.RowIndex].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDon.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn hóa đơn !");
                return;
            }
            this.Hide();
            new ChinhSuaHoaDonNhapKho(maHoaDon.Text).Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDon.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn hóa đơn !");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    string deleteHD = "DELETE FROM NhapKho WHERE maHoaDon = @maHoaDon";
                    using (SqlCommand cmd = new SqlCommand(deleteHD, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hóa đơn đã được xóa thành công !");

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn cần xóa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình xóa: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            Form1_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maHDNM = maHDKT.Text;

            try
            {
                conn.Open();
                string selectHD = "SELECT maHoaDon, ghiChu, ngayNhap, SUM(thanhTien) AS thanhTien " +
                                    "FROM NhapKho " +
                                    "WHERE maHoaDon = @maHoaDon " +
                                    "GROUP BY maHoaDon, ghiChu, ngayNhap order by maHoaDon ASC";
                using (SqlCommand cmd = new SqlCommand(selectHD, conn))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHDNM);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    hoaDonNhapKho.DataSource = dt;

                    hoaDonNhapKho.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                    hoaDonNhapKho.Columns["ghiChu"].HeaderText = "Ghi Chú";
                    hoaDonNhapKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
                    hoaDonNhapKho.Columns["thanhTien"].HeaderText = "Thành Tiền";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ngayMBatDau = dateFrom.Value.ToString("yyyy-MM-dd");
            String ngayMKetThuc = dateEnd.Value.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                string selectHD = "SELECT maHoaDon, ghiChu, ngayNhap, SUM(thanhTien) AS thanhTien " +
                                  "FROM NhapKho " +
                                  "WHERE ngayNhap BETWEEN @ngayMBatDau AND @ngayMKetThuc " +
                                  "GROUP BY maHoaDon, ghiChu, ngayNhap ORDER BY maHoaDon ASC";
                using (SqlCommand cmd = new SqlCommand(selectHD, conn))
                {
                    cmd.Parameters.AddWithValue("@ngayMBatDau", ngayMBatDau);
                    cmd.Parameters.AddWithValue("@ngayMKetThuc", ngayMKetThuc);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    hoaDonNhapKho.DataSource = dt;

                    // Thiết lập tiêu đề cho các cột
                    hoaDonNhapKho.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
                    hoaDonNhapKho.Columns["ghiChu"].HeaderText = "Ghi Chú";
                    hoaDonNhapKho.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
                    hoaDonNhapKho.Columns["thanhTien"].HeaderText = "Thành Tiền";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }



        }
    }
}
