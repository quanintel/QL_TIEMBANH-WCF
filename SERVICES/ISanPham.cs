using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISanPham" in both code and config file together.
    [ServiceContract]
    public interface ISanPham
    {
        [OperationContract]
        void InsertSanPham(string tensp, int soluong, float giaban, DateTime ngaynhap, string anh, string ghichu);
        [OperationContract]
        DataTable showGV();
        [OperationContract]
        void UpdateSanPham(int masp, string tensp, int soluong, float giaban, DateTime ngaynhap, string anh, string ghichu);
        [OperationContract]
        void DelSanPham(int masp);
        [OperationContract]
        DataTable SearchSanPham(string tensp);
    }
}
