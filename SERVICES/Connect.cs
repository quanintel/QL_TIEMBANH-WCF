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
        public string GetFieldValues(string sql)
        {
            string id = "";
            SqlConnection con = Connection();
            con.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetValue(0).ToString();
            }
            reader.Close();
            return id;
        }
        public bool CheckKey(string sql)
        {
            SqlConnection con = Connection();
            con.Open();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
    }
}
