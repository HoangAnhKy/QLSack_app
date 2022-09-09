using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTV
{
    public class DTO_Tra 
    {
        private string maTra;
        private string ngayTra;
        private string maNhanVien;
        private string maMuon;
        public DTO_Tra()
        {
            
        }

        public DTO_Tra(string maTra, string ngayTra, string maNhanVien, string maMuon)
        {
            this.maTra = maTra;
            this.ngayTra = ngayTra;
            this.maNhanVien = maNhanVien;
            this.maMuon = maMuon;
        }

        public string MaTra { get => maTra; set => maTra = value; }
        public string NgayTra { get => ngayTra; set => ngayTra = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaMuon { get => maMuon; set => maMuon = value; }
    }
}
