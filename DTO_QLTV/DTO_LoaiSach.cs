using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTV
{
    public class DTO_LoaiSach
    {
        private string maLoaiSach;
        private string theloai;

        public DTO_LoaiSach()
        {
            
        }
        public DTO_LoaiSach(string maLoaiSach, string theloai)
        {
            this.maLoaiSach = maLoaiSach;
            this.theloai = theloai;
        }

        public string MaLoaiSach { get => maLoaiSach; set => maLoaiSach = value; }
        public string Theloai { get => theloai; set => theloai = value; }
    }
}
