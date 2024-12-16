using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private string gioiTinh;
        private string ngaySinh;
        private string chucVu;
        private string diaChi;
        private string soDienThoai;
        private string gmail;
        private string password;
        private string ngayVaoLam;

        // Constructor không tham số
        public NhanVien() { }

        // Constructor có tham số để khởi tạo đầy đủ thông tin
        public NhanVien(string maNV, string hoTen, string gioiTinh, string ngaySinh, string chucVu, string diaChi, string soDienThoai, string gmail, string password, string ngayVaoLam)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.chucVu = chucVu;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.gmail = gmail;
            this.password = password;
            this.ngayVaoLam = ngayVaoLam;
        }

        // Getter và Setter cho từng thuộc tính
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }

    }
}
