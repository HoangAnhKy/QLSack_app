using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLTV;

namespace DAL_QLTV
{
    public class DAL_SACH : ConnectDB
    {
        public DataTable Load()
        {
            string sql = "select MaSach, TenSach, TheLoai, SoLuong, TenTacgia from view_Sach";
            return execSql(sql);
        }
        public DataTable LoadS()
        {
            string sql = "select * from Sach";
            return execSql(sql);
        }
        public DataTable TimkiemTG(string keywork)
        {
            string sql = string.Format("select MaSach, TenSach, TheLoai, SoLuong, TenTacgia from view_Sach where TenTacgia = N'{0}'", keywork);
            return execSql(sql);
        }
        public DataTable TimkiemSach(string keywork)
        {
            string sql = string.Format("select MaSach, TenSach, TheLoai, SoLuong, TenTacgia from view_Sach where TenSach = N'{0}'", keywork);
            return execSql(sql);
        }
        public DataTable Load_View()
        {
            string sql = "select * from view_Sach";
            return execSql(sql);
        }
        public DataTable ADD_S(DTO_Sach s)
        {
            string sql = string.Format("INSERT [dbo].[SACH] ([MaSach],[TenSach],[MaLoaiSach],[SoLuong],[MaTacGia]) VALUES ('{0}',N'{1}','{2}','{3}','{4}')", s.MaLoaiSach, s.TenSach, s.MaLoaiSach, s.SoLuong, s.MaTacGia);
            return execSql(sql);
        }

        public DataTable UP_S(DTO_Sach s)
        {
            string sql = string.Format("UPDATE Sach SET  TenSach = N'{1}', MaLoaiSach = '{2}',SoLuong = '{3}', MaTacGia = '{4}' where MaSach = '{0}' ", s.MaLoaiSach, s.TenSach, s.MaLoaiSach, s.SoLuong, s.MaTacGia);
            return execSql(sql);
        }

        public DataTable DEl_S(string MaSach)
        {
            string sql = string.Format("DELETE FROM Sach  Where  MaSach = '{0}'", MaSach);
            return execSql(sql);
        }
        public DataTable findThongTin(string tt)
        {
            string sql = string.Format("select MaSach, TenSach, TheLoai, SoLuong, TenTacgia from view_Sach where TenTacgia like N'%{0}%' or TenSach like N'%{0}%'", tt);
            return execSql(sql);
        }
        public DataTable findsach(string tt)
        {
            string sql = string.Format("select MaSach, TenSach,TheLoai, SoLuong, TenTacgia from view_Sach where MaSach like N'%{0}%'", tt);
            return execSql(sql);
        }
        public DataTable upsl2(string sl, string masach)
        {
            string sql = string.Format("UPDATE Sach SET SoLuong = '{0}' where MaSach = '{1}'", sl, masach);
            return execSql(sql);
        }
        public DataTable upslgiam(string sl, string masach)
        {
            string sql = string.Format("select SoLuong - {0} from Sach where MaSach = '{1}'", sl, masach);
            return execSql(sql);
        }
        public DataTable upsltang(string sl, string masach)
        {
            string sql = string.Format("select SoLuong + {0} from Sach where MaSach = '{1}'", sl, masach);
            return execSql(sql);
        }
        public DataTable masv(string ten)
        {
            string sql = string.Format("select MaSach from Sach where TenSach = N'{0}'", ten);
            return execSql(sql);
        }
    }
}
