using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTV
{
    public class DTO_Sach
    {
        private string maSach;
        private string tenSach;
        private string maLoaiSach;
        private string soLuong;
        private string maTacGia;

        public DTO_Sach()
        {
            
        }

        public DTO_Sach(string maSach, string tenSach, string maLoaiSach, string soLuong, string maTacGia)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.maLoaiSach = maLoaiSach;
            this.soLuong = soLuong;
            this.maTacGia = maTacGia;
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string MaLoaiSach { get => maLoaiSach; set => maLoaiSach = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string MaTacGia { get => maTacGia; set => maTacGia = value; }
    }
}
