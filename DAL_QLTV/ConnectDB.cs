using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_QLTV
{
    public class ConnectDB
    {
        private string strConnect = "Data Source=.;Initial Catalog=QLSACHZZ;Integrated Security=True;";

        protected DataTable execSql(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, strConnect);
            adp.Fill(tb);
            return tb;
        }

        SqlDataAdapter _sqlAda;
        SqlConnection _sqlConnect;
        SqlCommand _sqlCommand;
        SqlDataReader _sqlReader;
        public void _openSQL()
        {
            _sqlConnect = new SqlConnection(strConnect);
            if (_sqlConnect.State == ConnectionState.Closed)
                _sqlConnect.Open();
        }
        public void _closedSQL()
        {
            _sqlConnect = new SqlConnection(strConnect);
            if (_sqlConnect.State == ConnectionState.Open)
                _sqlConnect.Close();
        }

       public DataTable _load_QLMuon(string strsql)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Tên Độc Giả");
            tb.Columns.Add("Tên Sách");
            tb.Columns.Add("Số Lượng Mượn");
            tb.Columns.Add("Ngày Mượn");
            tb.Columns.Add("Ngày Hẹn Trả");
            tb.Columns.Add("Tên Nhân Viên");
            _openSQL();
            _sqlCommand = new SqlCommand(strsql, _sqlConnect);
            _sqlReader = _sqlCommand.ExecuteReader();
            while (_sqlReader.Read())
            {
                tb.Rows.Add(_sqlReader[1].ToString(), _sqlReader[3].ToString(), _sqlReader[9].ToString(), _sqlReader[7].ToString(), _sqlReader[8].ToString(), _sqlReader[11].ToString());
            }
            _closedSQL();
            return tb;
        }

        public string _get_Count(string sql)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Count");
            _openSQL();
            _sqlCommand = new SqlCommand(sql, _sqlConnect);
            _sqlReader = _sqlCommand.ExecuteReader();
            while (_sqlReader.Read())
            {
                tb.Rows.Add(_sqlReader[0].ToString());
            }
            _closedSQL();

            return tb.Rows[0][0].ToString();

        }

        public string _check_STT(string sql, string MaSV)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MSSV");
            _openSQL();
            _sqlCommand = new SqlCommand(sql, _sqlConnect);
            _sqlReader = _sqlCommand.ExecuteReader();
            while (_sqlReader.Read())
            {
                tb.Rows.Add(_sqlReader[0].ToString());
            }
            _closedSQL();

            int i = 1;
            foreach (DataRow row in tb.Rows)
            {
                if (tb.Rows[i][0].ToString() == MaSV)
                {
                    break;
                }
                i++;
            }
            return i.ToString();
        }

    }
}
