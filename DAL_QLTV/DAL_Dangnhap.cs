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
    public class DAL_Dangnhap : ConnectDB
    {
        public DataTable get_role(DTO_Log log)
        {
            string sql = string.Format("select quyen from TaiKhoan where name = '{0}' and pass = '{1}'", log.Acc, log.Pass);
            return execSql(sql);
        }

        
    }
}
