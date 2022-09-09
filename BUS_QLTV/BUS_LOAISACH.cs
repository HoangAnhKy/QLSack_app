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
    public class BUS_LOAISACH
    {
        DAL_LSach ls = new DAL_LSach();
        public DataTable Get_Load()
        {
            return ls.Load();
        }

        public DataTable Get_add(DTO_LoaiSach Ls)
        {
            return ls.ADD_LS(Ls);
        }

        public DataTable Get_UP(DTO_LoaiSach Ls)
        {
            return ls.UP_LS(Ls);
        }

        public DataTable Get_DEL(string maLS)
        {
            return ls.DEl_LS(maLS);
        }
    }
}
