using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyquankem
{
    class ThaotacCSDL
    {
        SplConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public ThaotacCSDL()
        {
            string strCnn = "Data Source=.; Database=QuanLyQuanKem; Integrated Security=True";
            sqlConn = new SplConnection(strCnn);
        }

        //Cho cau lenh select
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        //Cho cau lenh insert, update, delete
        public void ExecuteNonQuery(string sqlStr)
        {
            SqlCommand sqlcmd = new SqlCommand(sqlStr, sqlConn);
            sqlConn.Open();

            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
