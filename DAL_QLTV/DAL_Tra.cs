using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLTV;
namespace DAL_QLTV
{
    public class DAL_Tra : ConnectDB
    {
        public DataTable get_Date()
        {
            return execSql("select GETDATE()");
        }
        public DataTable get_addTra(DTO_Tra tr)
        {
            string sql = string.Format("INSERT into Tra VALUES('{0}','{1}','{2}','{3}')", tr.MaTra, tr.NgayTra, tr.MaNhanVien, tr.MaMuon);
            return execSql(sql);
        }
        public DataTable LoadTra()
        {
            string sql = "select *  from View_Tra";
            return execSql(sql);
        }

        public DataTable get_role(string role)
        {
            string sql = string.Format("select  NV.MaNhanVien from NhanVien as NV, TaiKhoan as TK where NV.name = TK.name and TK.name = '{0}'", role);
            return execSql(sql);
        }

        public DataTable get_mamuon(string ten)
        {
            string sql = string.Format("select m.MaMuon from Muon as m,DocGia as dg where m.MaDocGia = dg.MaDocGia and dg.HoTen = N'{0}'", ten);
            return execSql(sql);
        }
        public DataTable get_Tim(string ten)
        {
            string sql = string.Format("select * from view_Tra where [Tên Sinh Viên] = N'{0}'", ten);
            return execSql(sql);
        }
    }
}
