using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NhanVien" in both code and config file together.
    public class NhanVien : INhanVien
    {
        Connect connect = new Connect();
        public void DelNhanVien(int manv)
        {
            string sql_del = "DELETE FROM NHANVIEN WHERE MANV = '" + manv + "'";
            connect.ExcuteNonQuery(sql_del);
        }

        public void InsertNhanVien(string tennv, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi)
        {
            string sql_add = "INSERT INTO NHANVIEN VALUES(N'" + tennv + "', N'" + gioitinh + "', N'" + dienthoai + "', '" + ngaysinh.ToString("yyyy-MM-dd") + "', N'" + diachi + "')";
            connect.ExcuteNonQuery(sql_add);
        }

        public DataTable SearchNhanVien(string tennv)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE TENNV LIKE N'%" + tennv + "%' ";
            DataTable dataTable = new DataTable();
            dataTable = connect.getTable(sql);
            return dataTable;
        }

        public DataTable showGV()
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dataTable = new DataTable();
            dataTable = connect.getTable(sql);
            return dataTable;
        }

        public void UpdateNhanVien(int manv, string tennv, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi)
        {
            string sql_edit = "UPDATE NHANVIEN SET TENNV=N'" + tennv + "', GIOITINH=N'" + gioitinh + "', NGAYSINH='" + ngaysinh.ToString("yyyy-MM-dd") + "', DIACHI=N'" + diachi + "', DIENTHOAI=N'" + dienthoai + "' WHERE MANV=" + manv + "";
            connect.ExcuteNonQuery(sql_edit);
        }
    }
}
