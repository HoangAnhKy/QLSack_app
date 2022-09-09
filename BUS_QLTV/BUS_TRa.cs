using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLTV;
using System.Data;
using DAL_QLTV;
namespace BUS_QLTV
{
    public class BUS_TRa
    {
        DAL_Tra tra = new DAL_Tra();
        public DataTable Get_code(string ten)
        {
            return tra.get_mamuon(ten);
        }
        public DataTable Get_date()
        {
            return tra.get_Date();
        }
        public DataTable Get_LoadTra()
        {
            return tra.LoadTra();
        }
        public DataTable Get_addtra(DTO_Tra tr)
        {
            return tra.get_addTra(tr);
        }

        public DataTable Get_Tim(string ten)
        {
            return tra.get_Tim(ten);
        }
    }
}
