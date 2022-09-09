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
    public class BUS_Sach
    {
        DAL_SACH s = new DAL_SACH();
        public DataTable Get_Load()
        {
            return s.Load();
        }
        public DataTable Get_LoadS()
        {
            return s.LoadS();
        }

        public DataTable Get_SearchTG(string keywork)
        {
            return s.TimkiemTG(keywork);
        }
        public DataTable Get_SearchSach(string keywork)
        {
            return s.TimkiemSach(keywork);
        }
        public DataTable Get_Load_view()
        {
            return s.Load_View();
        }
        public DataTable Get_add(DTO_Sach ls)
        {
            return s.ADD_S(ls);
        }

        public DataTable Get_UP(DTO_Sach Ls)
        {
            return s.UP_S(Ls);
        }

        public DataTable Get_DEL(string maLS)
        {
            return s.DEl_S(maLS);
        }
        public DataTable Get_find(string tt)
        {
            return s.findThongTin(tt);
        }
        public DataTable Get_finds(string tt)
        {
            return s.findsach(tt);
        }
        public DataTable Get_slgiam(string sl, string msach)
        {
            return s.upslgiam(sl, msach);
        }
        public DataTable Get_sltang(string sl, string msach)
        {
            return s.upsltang(sl, msach);
        }
        public DataTable Get_sl2(string sl, string msach)
        {
            return s.upsl2(sl, msach);
        }
        public DataTable Get_ma(string tsach)
        {
            return s.masv(tsach);
        }
    }
}
