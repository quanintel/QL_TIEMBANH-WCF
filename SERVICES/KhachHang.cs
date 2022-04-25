using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KhachHang_Service" in both code and config file together.
    public class KhachHang : IKhachHang
    {
        Connect connect = new Connect();
        public void DelKhachHang(int makh)
        {
            string sql_del = "DELETE FROM KHACHHANG WHERE MAKH = '" + makh + "'";
            connect.ExcuteNonQuery(sql_del);
        }

        public void InsertKhachHang(string tenkh, string diachi, string dienthoai)
        {
            string sql_add = "INSERT INTO KHACHHANG VALUES(N'" + tenkh + "', N'" + diachi + "', N'" + dienthoai + "')";
            connect.ExcuteNonQuery(sql_add);
        }

        public DataTable SearchKhachHang(string tenkh)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE TENKH LIKE N'%" + tenkh + "%' ";
            DataTable dataTable = new DataTable();
            dataTable = connect.getTable(sql);
            return dataTable;
        }

        public DataTable showGV()
        {
            string sql = "SELECT * FROM KHACHHANG";
            DataTable dataTable = new DataTable();
            dataTable = connect.getTable(sql);
            return dataTable;
        }

        public void UpdateKhachHang(int makh, string tenkh, string diachi, string dienthoai)
        {
            string sql_edit = "UPDATE KHACHHANG SET TENKH=N'" + tenkh + "', DIACHI=N'" + diachi + "', DIENTHOAI=N'" + dienthoai + "' WHERE MAKH=" + makh + "";
            connect.ExcuteNonQuery(sql_edit);
        }
    }
}
