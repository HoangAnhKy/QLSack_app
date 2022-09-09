using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLTV;
using DTO_QLTV;

namespace BUS_QLTV
{
    public class BUS_Log
    {
        DAL_Dangnhap dn = new DAL_Dangnhap();
        public DataTable Get_role( DTO_Log log)
        {
            return dn.get_role(log);
        }
       
    }
}
