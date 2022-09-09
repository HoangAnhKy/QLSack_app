using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLTV;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTV
{
    public class DAL_Muon : ConnectDB
    {
        public DataTable _LoadQLMuon(string sql)
        {
            return _load_QLMuon(sql);
        }

        public DataTable Load()
        {
            string sql = "select MaMuon, [Họ Tên Người Mượn], TenSach, SoLuong, NgayMuon, NgayHenTra,[Tên Nhân Viên]  from View_Muon";
            return execSql(sql);
        }

        public DataTable Tim(string ten)
        {
            string sql = string.Format("select MaMuon, [Họ Tên Người Mượn],TenSach,SoLuong, NgayMuon,NgayHenTra,[Tên Nhân Viên]  from View_Muon where [Họ Tên Người Mượn] = N'{0}'", ten);
            return execSql(sql);
        }
        public DataTable get_role(string role)
        {
            string sql = string.Format("select  NV.MaNhanVien from NhanVien as NV, TaiKhoan as TK where NV.name = TK.name and TK.name = '{0}'", role);
            return execSql(sql);
        }
        public DataTable get_add(DTO_Muon muon)
        {
            string sql = string.Format("INSERT [dbo].[Muon] ([MaMuon],[MaDocGia],[MaSach],[SoLuong],[NgayMuon],[NgayHenTra],[MaNhanVien]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", muon.MaMuon1, muon.MaDocGia1, muon.MaSach1, muon.SoLuong1, muon.NgayMuon1, muon.NgayHenTra1, muon.MaNhanVien1);
            return execSql(sql);
        }
        public DataTable get_del(string mamuon)
        {
            string sql = string.Format("DELETE from Muon where MaMuon = '{0}'", mamuon);
            return execSql(sql);
        }



    }
}
