using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLTV;
namespace DAL_QLTV
{
    public class DAL_LSach : ConnectDB
    {
        public DataTable Load()
        {
            string sql = "select * from LoaiSach";
            return execSql(sql);
        }

        public DataTable ADD_LS(DTO_LoaiSach ls)
        {
            string sql = string.Format("INSERT [dbo].[LoaiSach] ([MaLoaiSach],[TheLoai]) VALUES('{0}',N'{1}')",ls.MaLoaiSach, ls.Theloai);
            return execSql(sql);
        }

        public DataTable UP_LS(DTO_LoaiSach ls)
        {
            string sql = string.Format("UPDATE LoaiSach SET TheLoai = N'{1}' Where  MaLoaiSach = '{0}'", ls.MaLoaiSach, ls.Theloai);
            return execSql(sql);
        }

        public DataTable DEl_LS(string MaLoaiSach)
        {
            string sql = string.Format("DELETE FROM LoaiSach  Where  MaLoaiSach = '{0}'", MaLoaiSach);
            return execSql(sql);
        }
    }
}
