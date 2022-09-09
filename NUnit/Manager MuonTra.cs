using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLTV;
using BUS_QLTV;
using NUnit.Framework;
using QLSACH;
using System.Data;
using System.Data.SqlClient;

namespace NUnit
{
    [TestFixture]
    public class Class1
    {
        private string strConnect = "Data Source=.;Initial Catalog=QLSACHZZ;Integrated Security=True;";

        protected DataTable execSql(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, strConnect);
            adp.Fill(tb);
            return tb;
        }

        Mượn_Trả mt = new Mượn_Trả();
        BUS_Muon bus_muon = new BUS_Muon();
        DTO_Muon dto_muon = new DTO_Muon();
        BUS_TRa bus_tra = new BUS_TRa();

        [TestCase]
        public void TC_01()
        {
            Random r = new Random();
            string mamuon = (r.Next(1000000, 9999999).ToString());
            DTO_Muon m = new DTO_Muon(mamuon, "411", "312", "2", "2021 -10-17", "2021-10-17", "NV01");
            bus_muon.Get_add(m);
            string sql = string.Format("select * from Muon where MaMuon = '{0}'", mamuon);
            DataTable tb = execSql(sql);
            Assert.NotNull(tb.Rows[0][0].ToString());
            bus_muon.Get_DEL(mamuon);
        }

        [TestCase]
        public void TC_02()
        {
            Random r = new Random();
            string matra = (r.Next(1000, 9999).ToString());
            string Nowdate = DateTime.Now.ToString("yyyyMMdd");

            DTO_Tra tr = new DTO_Tra(matra, Nowdate, "NV01", "6489726");
            bus_tra.Get_addtra(tr);
            string sql = string.Format("select * from Tra where MaTra =  '{0}'", matra);
            DataTable tb = execSql(sql);
            Assert.NotNull(tb.Rows[0][0].ToString());
            string sql2 = string.Format("DELETE from Tra where MaTra = '{0}'", matra);
            execSql(sql2);
        }

        [TestCase("411", "310", "2", "2021 -10-17", "2021-10-17", "NV01")]
        [TestCase("411", "311", "", "2021 -10-17", "2021-10-17", "NV01")]
        [TestCase("411", "", "2", "2021 -10-17", "2021-10-17", "NV01")]
        public void TC_06_07_08( string maDG, string Masach, string sluong, string ngaymuon, string ngaytra, string manv)
        {
            Random r = new Random();
            string mamuon = (r.Next(1000000, 9999999).ToString());
            DTO_Muon m = new DTO_Muon(mamuon, maDG, Masach, sluong, ngaymuon, ngaytra, manv);
            bus_muon.Get_add(m);
            string sql = string.Format("select * from Muon where MaMuon = '{0}'", mamuon);
            DataTable tb = execSql(sql);
            Assert.IsNull(tb.Rows[0][0].ToString());
            bus_muon.Get_DEL(mamuon);
        }


        [TestCase("NV01", "6489726")]
        [TestCase("NV01", "6489726")]
        [TestCase("411", "6489726")]
        public void TC_09_10_11(string maNV, string MaMuon)
        {
            Random r = new Random();
            string matra = (r.Next(1000, 9999).ToString());
            string Nowdate = DateTime.Now.ToString("yyyyMMdd");
            DTO_Tra tr = new DTO_Tra(matra, Nowdate, maNV, MaMuon);
            bus_tra.Get_addtra(tr);
            string sql = string.Format("select * from Tra where MaTra =  '{0}'", matra);
            DataTable tb = execSql(sql);
            Assert.NotNull(tb.Rows[0][0].ToString());
            string sql2 = string.Format("DELETE from Tra where MaTra = '{0}'", matra);
            execSql(sql2);
        }
    }
}
