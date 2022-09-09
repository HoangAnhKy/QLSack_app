using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTV
{
    public class DTO_TacGia
    {
        private string maTacGia;
        private string tenTacGia;
        private string diaChi;
        
        public DTO_TacGia()
        {
            
        }
        public DTO_TacGia(string maTacGia, string tenTacGia, string diaChi)
        {
            this.maTacGia = maTacGia;
            this.tenTacGia = tenTacGia;
            this.diaChi = diaChi;
        }

        public string MaTacGia { get => maTacGia; set => maTacGia = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
