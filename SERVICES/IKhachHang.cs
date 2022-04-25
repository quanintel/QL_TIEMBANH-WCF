using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SERVICES
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKhachHang_Service" in both code and config file together.
    [ServiceContract]
    public interface IKhachHang
    {
        [OperationContract]
        void InsertKhachHang(string tenkh, string diachi, string dienthoai);
        [OperationContract]
        DataTable showGV();
        [OperationContract]
        void UpdateKhachHang(int makh, string tenkh, string diachi, string dienthoai);
        [OperationContract]
        void DelKhachHang(int makh);
        [OperationContract]
        DataTable SearchKhachHang(string tenkh);
    }
}
