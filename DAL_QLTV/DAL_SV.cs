using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLTV;
using System.Data;
namespace DAL_QLTV
{
    public class DAL_SV : ConnectDB
    {
        public DataTable get_Load()
        {
            string sql = "select * from DocGia";
            return execSql(sql);
        }
      
        public DataTable get_AddSinhVien(DTO_Thongtin log)
        {
            string sql = string.Format("INSERT INTO DocGia VALUES('{0}','{1}', N'{2}',N'{3}',N'{4}','{5}')", log.MaSo, log.Sdt, log.GioiTinh, log.DiaChi, log.HoTen, log.NgaySinh);
            return execSql(sql);
        }
        public DataTable get_UpSinhVien(DTO_Thongtin log)
        {
            string sql = string.Format("UPDATE DocGia SET  SDT = '{1}', GioiTinh = N'{2}', DiaChi = N'{3}', HoTen = N'{4}',NgaySinh = '{5}' where MaDocGia = '{0}' ", log.MaSo, log.Sdt, log.GioiTinh, log.DiaChi, log.HoTen, log.NgaySinh);
            return execSql(sql);
        }
        public DataTable get_DELSinhVien(string MaSo)
        {
            string sql = string.Format("DELETE from DocGia where MaDocGia = '{0}' ", MaSo);
            return execSql(sql);
        }
    }
}
