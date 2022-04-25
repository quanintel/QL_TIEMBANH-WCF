using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INhanVien" in both code and config file together.
    [ServiceContract]
    public interface INhanVien
    {
        [OperationContract]
        void InsertNhanVien(string tennv, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi);
        [OperationContract]
        DataTable showGV();
        [OperationContract]
        void UpdateNhanVien(int manv, string tennv, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi);
        [OperationContract]
        void DelNhanVien(int manv);
        [OperationContract]
        DataTable SearchNhanVien(string tennv);
    }
}
