using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLTV;
using DTO_QLTV;
using System.Data;
namespace BUS_QLTV
{
    public class BUS_SV
    {
        DAL_SV sv = new DAL_SV();
        public DataTable Get_Load()
        {
            return sv.get_Load();
        }

        public DataTable Get_add(DTO_Thongtin tt)
        {
            return sv.get_AddSinhVien(tt);
        }

        public DataTable Get_up(DTO_Thongtin tt)
        {
            return sv.get_UpSinhVien(tt);
        }

        public DataTable Get_del(string ms)
        {
            return sv.get_DELSinhVien(ms);
        }

    }
}
