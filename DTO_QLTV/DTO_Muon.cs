using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTV
{
    public class DTO_Muon
    {
        private string MaMuon;
        private string MaDocGia;
        private string MaSach;
        private string SoLuong;
        private string NgayMuon;
        private string NgayHenTra;
        private string MaNhanVien;
        public DTO_Muon()
        {
            
        }
      

        public DTO_Muon(string maMuon, string maDocGia, string maSach, string soLuong, string ngayMuon, string ngayHenTra, string maNhanVien)
        {
            MaMuon = maMuon;
            MaDocGia = maDocGia;
            MaSach = maSach;
            SoLuong = soLuong;
            NgayMuon = ngayMuon;
            NgayHenTra = ngayHenTra;
            MaNhanVien = maNhanVien;
        }

        public string MaMuon1 { get => MaMuon; set => MaMuon = value; }
        public string MaDocGia1 { get => MaDocGia; set => MaDocGia = value; }
        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public string SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string NgayMuon1 { get => NgayMuon; set => NgayMuon = value; }
        public string NgayHenTra1 { get => NgayHenTra; set => NgayHenTra = value; }
        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    }
}
