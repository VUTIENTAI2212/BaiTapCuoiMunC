using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang
{
    internal class HoaDonNhapKho
    {
        private int maHoaDon;
        private int maNhanVien;
        private int maNhaCungCap;
        private int maSanPham;
        private int soLuong;
        private float donGia;
        private String ghiChu;
        private float thanhTien;
        private String ngayNhap;

        public HoaDonNhapKho()
        {

        }

        // Constructor đầy đủ tham số
        public HoaDonNhapKho(int maHoaDon, int maNhanVien, int maNhaCungCap, int maSanPham, int soLuong, float donGia, String ghiChu, float thanhTien, String ngayNhap)
        {
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.maNhaCungCap = maNhaCungCap;
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.ghiChu = ghiChu;
            this.thanhTien = thanhTien;
            this.ngayNhap = ngayNhap;
        }

        // Getter và Setter
        public int getMaHoaDon()
        {
            return maHoaDon;
        }

        public void setMaHoaDon(int maHoaDon)
        {
            this.maHoaDon = maHoaDon;
        }

        public int getMaNhanVien()
        {
            return maNhanVien;
        }

        public void setMaNhanVien(int maNhanVien)
        {
            this.maNhanVien = maNhanVien;
        }

        public int getMaNhaCungCap()
        {
            return maNhaCungCap;
        }

        public void setMaNhaCungCap(int maNhaCungCap)
        {
            this.maNhaCungCap = maNhaCungCap;
        }

        public int getMaSanPham()
        {
            return maSanPham;
        }

        public void setMaSanPham(int maSanPham)
        {
            this.maSanPham = maSanPham;
        }

        public int getSoLuong()
        {
            return soLuong;
        }

        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }

        public float getDonGia()
        {
            return donGia;
        }

        public void setDonGia(float donGia)
        {
            this.donGia = donGia;
        }

        public String getGhiChu()
        {
            return ghiChu;
        }

        public void setGhiChu(String ghiChu)
        {
            this.ghiChu = ghiChu;
        }

        public float getThanhTien()
        {
            return thanhTien;
        }

        public void setThanhTien(float thanhTien)
        {
            this.thanhTien = thanhTien;
        }

        public String getNgayNhap()
        {
            return ngayNhap;
        }

        public void setNgayNhap(String ngayNhap)
        {
            this.ngayNhap = ngayNhap;
        }
    }
}

