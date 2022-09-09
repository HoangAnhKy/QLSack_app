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
    public class BUS_Nhanvien
    {
        DAL_Nhanvien nv = new DAL_Nhanvien();
        public DataTable Get_Load()
        {
            return nv.get_Load();
        }
        public DataTable Get_add(DTO_Log log)
        {
            return nv.get_add(log);
        }
        public DataTable Get_AddNV(DTO_Thongtin tt, string tkname)
        {
            return nv.get_AddNhanvien(tt, tkname);

        }
        public DataTable Get_UPNV(DTO_Thongtin tt, string tkname)
        {
            return nv.get_UpNhanvien(tt, tkname);
        }
        public DataTable Get_DELTK( string tkname)
        {
            return nv.get_DELTK( tkname);
        }
        public DataTable Get_DELNV(string Maso)
        {
            return nv.get_DELNhanvien(Maso);
        }
    }
}
