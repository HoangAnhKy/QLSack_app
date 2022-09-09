using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QLTV;
using DTO_QLTV;

namespace DAL_QLTV
{
    public class DAL_Nhanvien : ConnectDB
    {
        public DataTable get_Load()
        {
            string sql = "select * from NhanVien";
            return execSql(sql);
        }
        public DataTable get_add(DTO_Log log)
        {
            string sql = string.Format("INSERT [dbo].[TaiKhoan] ([name],[pass],[quyen]) VALUES(N'{0}', N'{1}',N'staff')", log.Acc, log.Pass);
            return execSql(sql);
        }
        public DataTable get_DELTK(string MaSo)
        {
            string sql = string.Format("DELETE from Taikhoan where name = '{0}' ", MaSo);
            return execSql(sql);
        }
        public DataTable get_AddNhanvien(DTO_Thongtin log, string tkname)
        {
            string sql = string.Format("INSERT INTO NhanVien VALUES('{0}','{1}', N'{2}',N'{3}',N'{4}','{5}','{6}')", log.MaSo, log.Sdt, log.GioiTinh, log.DiaChi, log.HoTen, log.NgaySinh, tkname);
            return execSql(sql);
        }
        public DataTable get_UpNhanvien(DTO_Thongtin log, string tkname)
        {
            string sql = string.Format("UPDATE  NhanVien SET  SDT = '{1}', GioiTinh = N'{2}', DiaChi = N'{3}', HoTen = N'{4}',NgaySinh = '{5}',name = '{6}' where MaNhanVien = '{0}' ", log.MaSo, log.Sdt, log.GioiTinh, log.DiaChi, log.HoTen, log.NgaySinh, tkname);
            return execSql(sql);
        }
        public DataTable get_DELNhanvien( string MaSo)
        {
            string sql = string.Format("DELETE from NhanVien where MaNhanVien = '{0}' ",  MaSo);
            return execSql(sql);
        }
    }
}
