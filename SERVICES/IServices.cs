using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServices" in both code and config file together.
    [ServiceContract]
    public interface IServices
    {
        /*Sản Phẩm*/
        [OperationContract]
        void InsertSanPham(string tensp, int soluong, float giaban, DateTime ngaynhap, string anh, string ghichu);
        [OperationContract]
        DataTable showGVSanPham();
        [OperationContract]
        void UpdateSanPham(int masp, string tensp, int soluong, float giaban, DateTime ngaynhap, string anh, string ghichu);
        [OperationContract]
        void DelSanPham(int masp);
        [OperationContract]
        DataTable SearchSanPham(string tensp);
        /*Nhân Viên*/
        [OperationContract]
        void InsertNhanVien(string tennv, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi);
        [OperationContract]
        DataTable showGVNhanVien();
        [OperationContract]
        void UpdateNhanVien(int manv, string tennv, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi);
        [OperationContract]
        void DelNhanVien(int manv);
        [OperationContract]
        DataTable SearchNhanVien(string tennv);
        /*Khách Hàng*/
        [OperationContract]
        void InsertKhachHang(string tenkh, string diachi, string dienthoai);
        [OperationContract]
        DataTable showGVKhachHang();
        [OperationContract]
        void UpdateKhachHang(int makh, string tenkh, string diachi, string dienthoai);
        [OperationContract]
        void DelKhachHang(int makh);
        [OperationContract]
        DataTable SearchKhachHang(string tenkh);
    }
}
