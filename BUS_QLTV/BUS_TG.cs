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
    public class BUS_TG
    {
        DAL_TG tg = new DAL_TG();
        public DataTable Get_Load()
        {
            return tg.Load();
        }

        public DataTable Get_add(DTO_TacGia TG)
        {
            return tg.ADD_TG(TG);
        }

        public DataTable Get_UP(DTO_TacGia TG)
        {
            return tg.UP_TG(TG);
        }

        public DataTable Get_DEL(string maTG)
        {
            return tg.DEl_TG(maTG);
        }
    }
}
