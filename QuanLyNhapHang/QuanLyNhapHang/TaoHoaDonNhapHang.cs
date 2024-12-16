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

namespace QuanLyNhapHang
{
    public partial class TaoHoaDonNhapHang : Form
    {

        static string connString = @"Data Source=PETER\SQLEXPRESS;Initial Catalog=QuanLySieuThiBanLe;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);

        public TaoHoaDonNhapHang()
        {
            InitializeComponent();
        }


        public string getMaNhaCungCap(string maSP)
        {
            string maNCC = "";
            string getMNCC = "select maNhaCungCap from SanPham Where maSanPham = @maSanPham";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(getMNCC, conn);
                    cmd.Parameters.AddWithValue("@maSanPham", maSP);

                    IDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        maNCC = reader["maNhaCungCap"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return maNCC;
        }



        public bool KiemTraMaHoaDon(string maHD)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM NhapKho WHERE maHoaDon = @maHoaDon";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maHoaDon", maHD);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            exists = true;
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return exists;
        }


        private void TaoHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            tongTienHoaDon.Text = "0";
            // Thêm dữ liệu cho table sản phẩm
            try
            {
                conn.Open();
                String selectAllSP = "SELECT maSanPham, tenSanPham, maNhaCungCap, maLoaiSanPham, giaNhap, donGia, xuatXu, soLuongTon FROM SanPham";

                SqlCommand cmd = new SqlCommand(selectAllSP, conn);
                DataTable dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                sanPhamTable.DataSource = dt;

                sanPhamTable.Columns[0].HeaderText = "Mã Sản Phẩm";
                sanPhamTable.Columns[1].HeaderText = "Tên Sản Phẩm";
                sanPhamTable.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
                sanPhamTable.Columns[3].HeaderText = "Mã Loại Sản Phẩm";
                sanPhamTable.Columns[4].HeaderText = "Giá Nhập";
                sanPhamTable.Columns[5].HeaderText = "Đơn Giá";
                sanPhamTable.Columns[6].HeaderText = "Xuất Xứ";
                sanPhamTable.Columns[7].HeaderText = "Số Lượng Tồn";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }

            hoaDonNhapHangTable.Columns.Add("maSanPham", "Mã Sản Phẩm");
            hoaDonNhapHangTable.Columns.Add("tenSanPham", "Tên Sản Phẩm");
            hoaDonNhapHangTable.Columns.Add("donGia", "Giá Nhập");
            hoaDonNhapHangTable.Columns.Add("soLuong", "Số Lượng");
            hoaDonNhapHangTable.Columns.Add("tongTien", "Tổng Tiền");

        }

        private void sanPhamTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sanPhamTable.Rows[e.RowIndex].Cells["maSanPham"].Value != null)
            {
                maSP.Text = sanPhamTable["maSanPham", e.RowIndex].Value.ToString();
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSP.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn !");
                return;
            }
            if (string.IsNullOrWhiteSpace(soLuongSP.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng !");
                return;
            }

            string getSanPham = "select maSanPham, tenSanPham, giaNhap from SanPham where maSanPham = @maSanPham";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(getSanPham, conn);
                cmd.Parameters.AddWithValue("@maSanPham", maSP.Text);
                int dem = 0;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {


                    string maSanPham = reader["maSanPham"].ToString();
                    string tenSanPham = reader["tenSanPham"].ToString();
                    string giaNhap = reader["giaNhap"].ToString();
                    string soLuongSanpham = soLuongSP.Text;
                    string tongTien = int.Parse(giaNhap) * int.Parse(soLuongSanpham) + "";
                    tongTienHoaDon.Text = (int.Parse(tongTienHoaDon.Text) + float.Parse(tongTien) + "");

                    foreach (DataGridViewRow row in hoaDonNhapHangTable.Rows)
                    {
                        if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString().Equals(maSanPham))
                        {
                            row.Cells["soLuong"].Value = (int.Parse(row.Cells["soLuong"].Value.ToString()) + int.Parse(soLuongSanpham)) + "";
                            row.Cells["tongTien"].Value = (int.Parse(row.Cells["soLuong"].Value.ToString()) * int.Parse(row.Cells["donGia"].Value.ToString())) + "";

                            ++dem;
                            conn.Close();
                            return;
                        }
                    }

                    if (dem == 0)
                    {
                        hoaDonNhapHangTable.Rows.Add(maSanPham, tenSanPham, giaNhap, soLuongSanpham, tongTien);

                    }


                }


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDonNH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn !");
                return;
            }

            if (string.IsNullOrWhiteSpace(soLuongSP.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng !");
                return;
            }

            string ghiChu = ghiChuHoaDon.Text;
            string maHoaDon = maHoaDonNH.Text;

            if (KiemTraMaHoaDon(maHoaDon))
            {
                MessageBox.Show("Mã hóa đơn bạn nhập đã tồn tại !");
                return;
            }



            try
            {
                conn.Open();

                string insertHDNH = "Insert into NhapKho(maHoaDon, maNhanVien, maNhaCungCap, maSanPham, soLuong, donGia, ghiChu, thanhTien, ngayNhap) " +
            "Values (@maHoaDon, @maNhanVien, @maNhaCungCap, @maSanPham, @soLuong, @donGia, @ghiChu, @thanhTien, @ngayNhap)  ";

                int rowsAffected = 0;

                foreach (DataGridViewRow row in hoaDonNhapHangTable.Rows)
                {
                    using (SqlCommand cmd = new SqlCommand(insertHDNH, conn))
                    {
                        if (row.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();

                            string maNCC = getMaNhaCungCap(row.Cells["maSanPham"].Value.ToString());

                            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                            cmd.Parameters.AddWithValue("@maNhanVien", 1);
                            cmd.Parameters.AddWithValue("@maNhaCungCap", maNCC);
                            cmd.Parameters.AddWithValue("@maSanPham", row.Cells["maSanPham"].Value);
                            cmd.Parameters.AddWithValue("@soLuong", row.Cells["soLuong"].Value);
                            cmd.Parameters.AddWithValue("@donGia", row.Cells["donGia"].Value);
                            cmd.Parameters.AddWithValue("@thanhTien", row.Cells["tongTien"].Value);
                            cmd.Parameters.AddWithValue("@ghiChu", ghiChu);
                            cmd.Parameters.AddWithValue("@ngayNhap", DateTime.Today);

                            rowsAffected = cmd.ExecuteNonQuery();

                        }
                    }
                }

                conn.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Hóa đơn được tạo thành công !");
                    this.Hide();
                    new Form1().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void hoaDonNhapHangTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && hoaDonNhapHangTable.Rows[e.RowIndex].Cells["maSanPham"].Value != null)
            {
                maSPHD.Text = hoaDonNhapHangTable["maSanPham", e.RowIndex].Value.ToString();
                soLuongSPHD.Text = hoaDonNhapHangTable["soLuong", e.RowIndex].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSPHD.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !");
                return;
            }


            foreach (DataGridViewRow row in hoaDonNhapHangTable.Rows)
            {
                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString().Equals(maSPHD.Text))
                {
                    hoaDonNhapHangTable["soLuong", row.Index].Value = soLuongSPHD.Text;
                    tongTienHoaDon.Text = (float.Parse(tongTienHoaDon.Text) - float.Parse(hoaDonNhapHangTable["tongTien", row.Index].Value.ToString())) + "";
                    hoaDonNhapHangTable.Rows.Remove(row);
                    return;
                }
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSPHD.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !");
                return;
            }
            if (string.IsNullOrWhiteSpace(soLuongSPHD.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng !");
                return;
            }




            foreach (DataGridViewRow row in hoaDonNhapHangTable.Rows)
            {
                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString().Equals(maSPHD.Text))
                {
                    hoaDonNhapHangTable["soLuong", row.Index].Value = soLuongSPHD.Text;
                    tongTienHoaDon.Text = (float.Parse(tongTienHoaDon.Text) - float.Parse(hoaDonNhapHangTable["tongTien", row.Index].Value.ToString())) + "";
                    row.Cells["tongTien"].Value = (int.Parse(row.Cells["soLuong"].Value.ToString()) * int.Parse(row.Cells["donGia"].Value.ToString())) + "";
                    tongTienHoaDon.Text = (float.Parse(tongTienHoaDon.Text) + float.Parse(hoaDonNhapHangTable["tongTien", row.Index].Value.ToString())) + "";
                    return;
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                string selectAllSP = "SELECT maSanPham, tenSanPham, maNhaCungCap, maLoaiSanPham, giaNhap, donGia, xuatXu, soLuongTon FROM SanPham " +
                    "WHERE maSanPham LIKE @maSanPham OR tenSanPham LIKE LOWER(@tenSanPham) ORDER BY maSanPham ASC";

                SqlCommand cmd = new SqlCommand(selectAllSP, conn);
                cmd.Parameters.AddWithValue("@maSanPham", maSPTK.Text);
                cmd.Parameters.AddWithValue("@tenSanPham", "%" + tenSPTK.Text + "%");



                DataTable dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                sanPhamTable.DataSource = dt;

                sanPhamTable.Columns[0].HeaderText = "Mã Sản Phẩm";
                sanPhamTable.Columns[1].HeaderText = "Tên Sản Phẩm";
                sanPhamTable.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
                sanPhamTable.Columns[3].HeaderText = "Mã Loại Sản Phẩm";
                sanPhamTable.Columns[4].HeaderText = "Giá Nhập";
                sanPhamTable.Columns[5].HeaderText = "Đơn Giá";
                sanPhamTable.Columns[6].HeaderText = "Xuất Xứ";
                sanPhamTable.Columns[7].HeaderText = "Số Lượng Tồn";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String selectAllSP = "SELECT maSanPham, tenSanPham, maNhaCungCap, maLoaiSanPham, giaNhap, donGia, xuatXu, soLuongTon FROM SanPham";

                SqlCommand cmd = new SqlCommand(selectAllSP, conn);
                DataTable dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                sanPhamTable.DataSource = dt;

                sanPhamTable.Columns[0].HeaderText = "Mã Sản Phẩm";
                sanPhamTable.Columns[1].HeaderText = "Tên Sản Phẩm";
                sanPhamTable.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
                sanPhamTable.Columns[3].HeaderText = "Mã Loại Sản Phẩm";
                sanPhamTable.Columns[4].HeaderText = "Giá Nhập";
                sanPhamTable.Columns[5].HeaderText = "Đơn Giá";
                sanPhamTable.Columns[6].HeaderText = "Xuất Xứ";
                sanPhamTable.Columns[7].HeaderText = "Số Lượng Tồn";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }
    }
}
