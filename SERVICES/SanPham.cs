using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SanPham" in both code and config file together.
    public class SanPham : ISanPham
    {
        Connect connect = new Connect();
        public void DelSanPham(int masp)
        {
            string sql_del = "DELETE FROM SANPHAM WHERE MASP = '" + masp + "'";
            connect.ExcuteNonQuery(sql_del);
        }

        public void InsertSanPham(string tensp, int soluong, float giaban, DateTime ngaynhap, string anh, string ghichu)
        {
            string sql_add = "INSERT INTO SANPHAM VALUES(N'" + tensp + "', " + soluong + ", " + giaban + ", '" + ngaynhap.ToString("yyyy-MM-dd") + "', N'" + anh + "', N'" + ghichu + "')";
            connect.ExcuteNonQuery(sql_add);
        }

        public DataTable SearchSanPham(string tensp)
        {
            string sql = "SELECT * FROM SANPHAM WHERE TENSP LIKE N'%" + tensp + "%' ";
            DataTable dataTable = new DataTable();
            dataTable = connect.getTable(sql);
            return dataTable;
        }

        public DataTable showGV()
        {
            string sql = "SELECT * FROM SANPHAM";
            DataTable dataTable = new DataTable();
            dataTable = connect.getTable(sql);
            return dataTable;
        }

        public void UpdateSanPham(int masp, string tensp, int soluong, float giaban, DateTime ngaynhap, string anh, string ghichu)
        {
            string sql_edit = "UPDATE SANPHAM SET TENSP=N'" + tensp + "', SL=N'" + soluong + "', NGAYNHAP='" + ngaynhap.ToString("yyyy-MM-dd") + "', GIABAN=N'" + giaban + "', ANH=N'" + anh + "', GHICHU=N'" + ghichu + "' WHERE MASP=" + masp + "";
            connect.ExcuteNonQuery(sql_edit);
        }
    }
}
