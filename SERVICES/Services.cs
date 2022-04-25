using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Services" in both code and config file together.
    public class Services : IServices
    {
        Connect connect = new Connect();

        /*Sản Phẩm*/
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

        public DataTable showGVSanPham()
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
        /*Nhân Viên*/

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

        public DataTable showGVNhanVien()
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
        /*Khách Hàng*/
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

        public DataTable showGVKhachHang()
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
