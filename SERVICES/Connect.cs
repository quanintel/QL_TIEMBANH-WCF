using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class Connect
    {
        public SqlConnection Connection()
        {
            return new SqlConnection("Data Source=WIN-RNHFRKNNMCB;Initial Catalog=QL_TIEMBANH;Integrated Security=True");
        }

        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public DataTable getTable(string sql)
        {
            SqlConnection con = Connection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet table = new DataSet();
            adapter.Fill(table);
            return table.Tables[0];
        }
    }
}
