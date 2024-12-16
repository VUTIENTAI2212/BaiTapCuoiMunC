using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class ChinhSuaHoaDonBanHang : Form
    {
        private string maHoaDonBanHang;
        private DataTable originalData;

        static String conString = @"Data Source=PETER\SQLEXPRESS;Initial Catalog=QuanLySieuThiBanLe;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(conString);
        public ChinhSuaHoaDonBanHang(string maHoaDonBanHangK)
        {
            InitializeComponent();
            maHoaDonBanHang = maHoaDonBanHangK;
        }

        private void ChinhSuaHoaDonBanHang_Load(object sender, EventArgs e)
        {
            string sellectALLKhachHang = "select maKhachHang, hoTen, gioiTinh, soDienThoai, diaChi from KhachHang";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectALLKhachHang, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        khachHangTable.DataSource = dt;

                        // Đặt tên cột cho DataGridView
                        khachHangTable.Columns[0].HeaderText = "Mã khách hàng";
                        khachHangTable.Columns[1].HeaderText = "Họ tên";
                        khachHangTable.Columns[2].HeaderText = "Giới tính";
                        khachHangTable.Columns[3].HeaderText = "Số điện thoại";
                        khachHangTable.Columns[4].HeaderText = "Địa chỉ";
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }


            string sellectALLSanPham = "SELECT maSanPham, tenSanPham, donGia, xuatXu, soLuongTon FROM SanPham";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectALLSanPham, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        sanPhamTable.DataSource = dt;

                        // Đặt tên cột cho DataGridView
                        sanPhamTable.Columns[0].HeaderText = "Mã Sản Phẩm";
                        sanPhamTable.Columns[1].HeaderText = "Tên Sản Phẩm";
                        sanPhamTable.Columns[2].HeaderText = "Đơn Giá";
                        sanPhamTable.Columns[3].HeaderText = "Xuất Xứ";
                        sanPhamTable.Columns[4].HeaderText = "Số Lượng Tồn";
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }




            string sellectALLHoaDon = "SELECT maSanPham, tenSanPham, donGia, soLuong, thanhTien from HoaDonBanHang where maHoaDon = @maHoaDon";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectALLHoaDon, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHoaDon", maHoaDonBanHang);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        sanPhamMuaTable.DataSource = dt;

                        // Đặt tên cột cho DataGridView
                        sanPhamMuaTable.Columns[0].HeaderText = "Mã Sản Phẩm";
                        sanPhamMuaTable.Columns[1].HeaderText = "Tên Sản Phẩm";
                        sanPhamMuaTable.Columns[2].HeaderText = "Đơn Giá";
                        sanPhamMuaTable.Columns[3].HeaderText = "Số Lượng";
                        sanPhamMuaTable.Columns[4].HeaderText = "Thành Tiền";
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }




            string sellectThongTinHoaDon = "SELECT maHoaDon, maKhachHang, SUM(thanhTien) AS tongTien FROM HoaDonBanHang WHERE maHoaDon = @maHoaDon GROUP BY maHoaDon, maKhachHang";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectThongTinHoaDon, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHoaDon", maHoaDonBanHang);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count > 0)
                        {
                            maKHHD.Text = dt.Rows[0]["maKhachHang"].ToString();
                            maHoaDonHD.Text = dt.Rows[0]["maHoaDon"].ToString();
                            tongTienSPText.Text = dt.Rows[0]["tongTien"].ToString();
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        private void sanPhamTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            sanPhamTable.Rows[e.RowIndex].Selected = true;
            maSanPhamText.Text = sanPhamTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            soLuongHang.Text = sanPhamTable.Rows[e.RowIndex].Cells["soLuongTon"].Value.ToString();
        }

        private void khachHangTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            khachHangTable.Rows[e.RowIndex].Selected = true;
            maKhachHangText.Text = khachHangTable.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maKhachHangText.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng !");
                return;
            }
            else
            {
                maKHHD.Text = maKhachHangText.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sdt = sdtKH.Text;
            string ten = nameKH.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sellectAll = "SELECT * FROM KhachHang WHERE (HOTEN LIKE @hoTen OR @hoTen IS NULL OR @hoTen = '') AND (soDienThoai LIKE @sdt OR @sdt IS NULL OR @sdt = '')";
                SqlCommand cmd = new SqlCommand(sellectAll, conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@hoTen", string.IsNullOrWhiteSpace(ten) ? (object)DBNull.Value : "%" + ten + "%");
                cmd.Parameters.AddWithValue("@sdt", string.IsNullOrWhiteSpace(sdt) ? (object)DBNull.Value : "%" + sdt + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                khachHangTable.DataSource = dt;

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

        private void button3_Click(object sender, EventArgs e)
        {
            string maSP = idSP.Text;
            string ten = nameSP.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sellectAll = "SELECT * FROM SanPham WHERE (tenSanPham LIKE @tenSanPham OR @tenSanPham IS NULL OR @tenSanPham = '') AND (maSanPham LIKE @maSanPham OR @maSanPham IS NULL OR @maSanPham = '')";
                SqlCommand cmd = new SqlCommand(sellectAll, conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@tenSanPham", string.IsNullOrWhiteSpace(ten) ? (object)DBNull.Value : "%" + ten + "%");
                cmd.Parameters.AddWithValue("@maSanPham", string.IsNullOrWhiteSpace(maSP) ? (object)DBNull.Value : maSP);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                sanPhamTable.DataSource = dt;

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

        private void button9_Click(object sender, EventArgs e)
        {
            float gia = 0;
            if (string.IsNullOrWhiteSpace(maSanPhamMuaText.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !");
                return;
            }

            if (string.IsNullOrWhiteSpace(soLuongMuaText.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng !");
                return;
            }

            int soLuongSanPham = 0;
            string sellectSoLT = "select soLuongTon from SanPham where maSanPham = @maSanPham";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectSoLT, conn))
                    {
                        cmd.Parameters.AddWithValue("@maSanPham", maSanPhamMuaText.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            soLuongSanPham = reader.GetInt32(0);
                        }

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            int soLuongSanPhamNhap = int.Parse(soLuongMuaText.Text);

            if (soLuongSanPhamNhap > soLuongSanPham)
            {
                MessageBox.Show("Vui lòng nhập số lượng không lớn hơn '" + soLuongSanPham + "'!");
                return;
            }


            foreach (DataGridViewRow row in sanPhamMuaTable.Rows)
            {
                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString() == maSanPhamMuaText.Text)
                {
                    row.Cells["soLuong"].Value = soLuongMuaText.Text;
                    row.Cells["thanhTien"].Value = int.Parse(row.Cells["soLuong"].Value.ToString()) * float.Parse(row.Cells["donGia"].Value.ToString());

                    break;
                }
            }

            foreach (DataGridViewRow row in sanPhamMuaTable.Rows)
            {
                if (row.Cells["maSanPham"].Value != null)
                {
                    gia += float.Parse(row.Cells["thanhTien"].Value.ToString());
                }
            }
            tongTienSPText.Text = gia + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSanPhamMuaText.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !");
                return;
            }
            foreach (DataGridViewRow row in sanPhamMuaTable.Rows)
            {
                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString() == maSanPhamMuaText.Text)
                {
                    tongTienSPText.Text = (float.Parse(tongTienSPText.Text) - float.Parse(row.Cells["thanhTien"].Value.ToString())) + "";
                    sanPhamMuaTable.Rows.Remove(row);



                    return;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }





        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSanPhamText.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn sản phẩm !");
                return;
            }

            if (string.IsNullOrWhiteSpace(soLuongHang.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng !");
                return;
            }

            int soLuongSanPham = 0;

            string sellectSoLT = "select soLuongTon from SanPham where maSanPham = @maSanPham";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectSoLT, conn))
                    {
                        cmd.Parameters.AddWithValue("@maSanPham", maSanPhamText.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            soLuongSanPham = reader.GetInt32(0);
                        }

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            int soLuongSanPhamNhap = int.Parse(soLuongHang.Text);

            if (soLuongSanPhamNhap > soLuongSanPham)
            {
                MessageBox.Show("Vui lòng nhập số lượng không lớn hơn '" + soLuongSanPham + "'!");
                return;
            }


            string sellectSanPham = "select maSanPham, tenSanPham, donGia, soLuongTon from SanPham where maSanPham = @maSanPham";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sellectSanPham, conn))
                    {
                        cmd.Parameters.AddWithValue("@maSanPham", maSanPhamText.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        int dem = 0;
                        while (reader.Read())
                        {
                            
                            string maSanPham = reader["maSanPham"].ToString();
                            string tenSanPham = reader["tenSanPham"].ToString();
                            string donGia = reader["donGia"].ToString();
                            int soLuongTonSP = Convert.ToInt32(reader["soLuongTon"]);
                            float giaBan;
                            float.TryParse(donGia, out giaBan);
                            float tongTien = giaBan * soLuongSanPhamNhap;
                            // Thêm một hàng mới vào DataGridView

                            

                            foreach (DataGridViewRow row in sanPhamMuaTable.Rows)
                            {
                                dem = 0;
                                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString() == maSanPham)
                                {
                                    int soLuongHienTai = int.Parse(row.Cells["soLuong"].Value.ToString());
                                    int soLuongMoi = soLuongHienTai + int.Parse(soLuongHang.Text);

                                    // Kiểm tra nếu số lượng mới vượt quá giới hạn
                                    if (soLuongMoi > soLuongTonSP)
                                    {
                                        MessageBox.Show("Số lượng sản phẩm đặt mua vượt quá giới hạn !");
                                        conn.Close();
                                        return;
                                    }

                                    // Cập nhật số lượng và tổng tiền
                                    row.Cells["soLuong"].Value = soLuongMoi.ToString();
                                    row.Cells["tongTien"].Value = (soLuongMoi * giaBan).ToString();
                                    ++dem;
                                    break;
                                }
                                // Thêm sản phẩm mới nếu không tồn tại
                                if (dem == 0)
                                {
                                    sanPhamMuaTable.Rows.Add(maSanPham, tenSanPham, donGia, soLuongSanPhamNhap, tongTien);
                                }
                            }



                        }

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }











        private void sanPhamMuaTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sanPhamMuaTable.Rows[e.RowIndex].Selected = true;
            maSanPhamMuaText.Text = sanPhamMuaTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            soLuongMuaText.Text = sanPhamMuaTable.Rows[e.RowIndex].Cells["soLuong"].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {


            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string deleteQuery = "DELETE FROM HoaDonBanHang WHERE maHoaDon = @maHoaDon";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDonBanHang);
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO HoaDonBanHang (maHoaDon, maSanPham, maNhanVien, maKhachHang, tenSanPham, soLuong, donGia, thanhTien, ngayMua) " +
                                     "VALUES (@maHoaDon, @maSanPham, @maNhanVien, @maKhachHang, @tenSanPham, @soLuong, @donGia, @thanhTien, @ngayMua)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    int rowsAffected = 0;
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    foreach (DataGridViewRow row in sanPhamMuaTable.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDonHD.Text);
                            cmd.Parameters.AddWithValue("@maSanPham", row.Cells["maSanPham"].Value);
                            cmd.Parameters.AddWithValue("@maNhanVien", 1);
                            cmd.Parameters.AddWithValue("@maKhachHang", maKHHD.Text);
                            cmd.Parameters.AddWithValue("@tenSanPham", row.Cells["tenSanPham"].Value);
                            cmd.Parameters.AddWithValue("@soLuong", row.Cells["soLuong"].Value);
                            cmd.Parameters.AddWithValue("@donGia", row.Cells["donGia"].Value);
                            cmd.Parameters.AddWithValue("@thanhTien", row.Cells["thanhTien"].Value);
                            cmd.Parameters.AddWithValue("@ngayMua", DateTime.Today);


                            if (result == DialogResult.Yes)
                            {
                                rowsAffected = cmd.ExecuteNonQuery();

                            }
                            
                            
                        }
                    }
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hóa đơn được cập nhật thành công!");
                        this.Close();
                        new Form1().Show();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }
    }
}
