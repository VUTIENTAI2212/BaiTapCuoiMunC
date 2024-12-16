using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyBanHang
{

    public partial class ThemHoaDonBanHang : Form
    {
        private DataTable originalData;

        static string conString = @"Data Source=PETER\SQLEXPRESS;Initial Catalog=QuanLySieuThiBanLe;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(conString);

        public ThemHoaDonBanHang()
        {
            InitializeComponent();
        }


        public bool IsDuplicateInvoice(string maHoaDon)
        {
            bool isDuplicate = false;
            string query = "SELECT COUNT(*) FROM HoaDonBanHang WHERE maHoaDon = @maHoaDon";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            isDuplicate = true;
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            return isDuplicate;
        }


        private void ThemHoaDonBanHang_Load(object sender, EventArgs e)
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


            string sellectALLSanPham = "SELECT maSanPham, tenSanPham, maNhaCungCap, maLoaiSanPham, giaNhap, donGia, xuatXu, soLuongTon FROM SanPham";
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
                        sanPhamTable.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
                        sanPhamTable.Columns[3].HeaderText = "Mã Loại Sản Phẩm";
                        sanPhamTable.Columns[4].HeaderText = "Giá Nhập";
                        sanPhamTable.Columns[5].HeaderText = "Đơn Giá";
                        sanPhamTable.Columns[6].HeaderText = "Xuất Xứ";
                        sanPhamTable.Columns[7].HeaderText = "Số Lượng Tồn";
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }


            sanPhamMuaTable.Columns.Add("maSanPham", "Mã Sản Phẩm");
            sanPhamMuaTable.Columns.Add("tenSanPham", "Tên Sản Phẩm");
            sanPhamMuaTable.Columns.Add("donGia", "Đơn Giá");
            sanPhamMuaTable.Columns.Add("soLuong", "Số Lượng");
            sanPhamMuaTable.Columns.Add("tongTien", "Tổng tiền");

        }


        private void button4_Click(object sender, EventArgs e)
        {
            originalData = new DataTable();
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

                            int dem = 0;

                            foreach (DataGridViewRow row in sanPhamMuaTable.Rows) // Sửa DataGridView thành DataGridViewRow
                            {
                                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString() == (maSanPham) && int.Parse(row.Cells["soLuong"].Value.ToString()) + int.Parse(soLuongHang.Text) > soLuongTonSP)
                                {
                                    MessageBox.Show("Số lượng sản phẩm đặt mua vượt quá giới hạn !");
                                    return;
                                }

                                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString() == (maSanPham))
                                {
                                    row.Cells["soLuong"].Value = (Convert.ToInt32(row.Cells["soLuong"].Value) + soLuongSanPhamNhap) + "";

                                    row.Cells["tongTien"].Value = int.Parse(row.Cells["soLuong"].Value.ToString()) * giaBan;
                                    ++dem;
                                    break;
                                }

                            }
                            if (dem == 0)
                            {
                                sanPhamMuaTable.Rows.Add(maSanPham, tenSanPham, donGia, soLuongSanPhamNhap, tongTien);
                                originalData.Rows.Add(maSanPham, tenSanPham, donGia, soLuongSanPhamNhap, tongTien);
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









            // Khởi tạo tổng tiền thanh toán
            float tongTienThanhToan = 0; // Đặt giá trị khởi tạo là 0

            string soLuongMua = "";
            string giaTienMua = "";

            int soLuongMuaSP = 0;
            float giaTienMuaSP = 0; // Đổi tên biến

            foreach (DataGridViewRow row in sanPhamMuaTable.Rows) // Sửa DataGridView thành DataGridViewRow
            {
                soLuongMuaSP = Convert.ToInt32(row.Cells["soLuong"].Value); // Chuyển đổi sang int
                giaTienMuaSP = Convert.ToSingle(row.Cells["donGia"].Value); // Chuyển đổi sang float


                tongTienThanhToan += soLuongMuaSP * giaTienMuaSP;

            }

            // Cập nhật giá trị cho TextBox
            tongTienSPText.Text = tongTienThanhToan.ToString("F2"); // Chuyển đổi thành string với 2 chữ số thập phân
        }













        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void khachHangTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            khachHangTable.Rows[e.RowIndex].Selected = true;
            maKhachHangText.Text = khachHangTable.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void sanPhamTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            sanPhamTable.Rows[e.RowIndex].Selected = true;
            maSanPhamText.Text = sanPhamTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            soLuongHang.Text = sanPhamTable.Rows[e.RowIndex].Cells["soLuongTon"].Value.ToString();
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

        private void button8_Click(object sender, EventArgs e)
        {


        }

        private void sanPhamMuaTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sanPhamMuaTable.Rows[e.RowIndex].Selected = true;
            maSanPhamMuaText.Text = sanPhamMuaTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            soLuongMuaText.Text = sanPhamMuaTable.Rows[e.RowIndex].Cells["soLuong"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sanPhamMuaTable.DataSource = originalData;
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
                    row.Cells["tongTien"].Value = int.Parse(row.Cells["soLuong"].Value.ToString()) * float.Parse(row.Cells["donGia"].Value.ToString());

                    break; 
                }
            }

            foreach (DataGridViewRow row in sanPhamMuaTable.Rows)
            {
                if (row.Cells["maSanPham"].Value != null)
                {
                    gia += float.Parse(row.Cells["tongTien"].Value.ToString());
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
                    tongTienSPText.Text = (float.Parse(tongTienSPText.Text) - float.Parse(row.Cells["tongTien"].Value.ToString())) + "";
                    sanPhamMuaTable.Rows.Remove(row);

                    

                    return;
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDonHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn !");
                return;
            }

            if (IsDuplicateInvoice(maHoaDonHD.Text) == true)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại !");
                return;
            }

            if (string.IsNullOrWhiteSpace(maKHHD.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng !");
                return;
            }


            float tienThanhToan = float.Parse(tongTienSPText.Text);
            
            if (!string.IsNullOrWhiteSpace(maKHHD.Text))
            {
                string insertQuery = "INSERT INTO HoaDonBanHang (maHoaDon, maSanPham, maNhanVien, maKhachHang, tenSanPham, soLuong, donGia,  thanhTien, ngayMua) " +
                     "VALUES (@maHoaDon, @maSanPham, @maNhanVien, @maKhachHang, @tenSanPham, @soLuong, @donGia, @thanhTien, @ngayMua)";

                using (SqlConnection conn = new SqlConnection(conString))
                {
                    try
                    {
                        int rowsAffected = 0;
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {

                            foreach(DataGridViewRow row in sanPhamMuaTable.Rows)
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
                                    cmd.Parameters.AddWithValue("@thanhTien", row.Cells["tongTien"].Value);
                                    cmd.Parameters.AddWithValue("@ngayMua", DateTime.Today);

                                    rowsAffected = cmd.ExecuteNonQuery();
                                    

                                }
                            }
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Hóa đơn được tạo thành công !");
                                this.Hide();
                                new Form1().Show();
                            }


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
    }
}
