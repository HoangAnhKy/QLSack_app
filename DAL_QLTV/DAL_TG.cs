using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLTV;

namespace DAL_QLTV 
{
    public class DAL_TG : ConnectDB
    {
         public DataTable Load()
        {
            string sql = "select * from TacGia";
            return execSql(sql);
         }

        public DataTable ADD_TG( DTO_TacGia TG )
        {
            string sql = string.Format("INSERT [dbo].[TacGia] ([MaTacGia],[TenTacgia],[DiaChi]) VALUES ('{0}',N'{1}',N'{2}')", TG.MaTacGia , TG.TenTacGia, TG.DiaChi);
            return execSql(sql);
        }

        public DataTable UP_TG(DTO_TacGia TG)
        {
            string sql = string.Format("UPDATE TacGia SET TenTacgia = N'{1}', DiaChi = N'{2}' Where  MaTacGia = '{0}'", TG.MaTacGia, TG.TenTacGia, TG.DiaChi);
            return execSql(sql);
        }

        public DataTable DEl_TG(string MaTacGia)
        {
            string sql = string.Format("DELETE FROM TacGia  Where  MaTacGia = '{0}'", MaTacGia);
            return execSql(sql);
        }
        
    }
}
