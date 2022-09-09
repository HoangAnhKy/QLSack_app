using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTV
{
    public class DTO_Thongtin
    {
        private string maSo;
        private string sdt;
        private string gioiTinh;
        private string diaChi;
        private string hoTen;
        private string ngaySinh;
        public DTO_Thongtin()
        {
            
        }
        public DTO_Thongtin(string maSo, string sdt, string gioiTinh, string diaChi, string hoTen, string ngaySinh)
        {
            this.maSo = maSo;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
        }

        public string MaSo { get => maSo; set => maSo = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
