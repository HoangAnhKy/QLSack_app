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
    public class BUS_Muon
    {
        DAL_Muon dalmuon = new DAL_Muon();
        public DataTable _loadQLMuon(string sql)
        {
            return dalmuon._LoadQLMuon(sql);
        }
        public DataTable Get_Load()
        {
            return dalmuon.Load();
        }

        public DataTable Get_Tim(string ten)
        {
            return dalmuon.Tim(ten);
        }


        public DataTable Get_MaNV(string role)
        {
            return dalmuon.get_role(role);
        }
        public DataTable Get_DEL(string role)
        {
            return dalmuon.get_del(role);
        }
        public DataTable Get_add(DTO_Muon muon)
        {
            return dalmuon.get_add(muon);
        }

    }
}
