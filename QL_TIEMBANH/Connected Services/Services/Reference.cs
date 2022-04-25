﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_TIEMBANH.Services {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.IServices")]
    public interface IServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/InsertSanPham", ReplyAction="http://tempuri.org/IServices/InsertSanPhamResponse")]
        void InsertSanPham(string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/InsertSanPham", ReplyAction="http://tempuri.org/IServices/InsertSanPhamResponse")]
        System.Threading.Tasks.Task InsertSanPhamAsync(string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/showGVSanPham", ReplyAction="http://tempuri.org/IServices/showGVSanPhamResponse")]
        System.Data.DataTable showGVSanPham();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/showGVSanPham", ReplyAction="http://tempuri.org/IServices/showGVSanPhamResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> showGVSanPhamAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/UpdateSanPham", ReplyAction="http://tempuri.org/IServices/UpdateSanPhamResponse")]
        void UpdateSanPham(int masp, string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/UpdateSanPham", ReplyAction="http://tempuri.org/IServices/UpdateSanPhamResponse")]
        System.Threading.Tasks.Task UpdateSanPhamAsync(int masp, string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DelSanPham", ReplyAction="http://tempuri.org/IServices/DelSanPhamResponse")]
        void DelSanPham(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DelSanPham", ReplyAction="http://tempuri.org/IServices/DelSanPhamResponse")]
        System.Threading.Tasks.Task DelSanPhamAsync(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/SearchSanPham", ReplyAction="http://tempuri.org/IServices/SearchSanPhamResponse")]
        System.Data.DataTable SearchSanPham(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/SearchSanPham", ReplyAction="http://tempuri.org/IServices/SearchSanPhamResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchSanPhamAsync(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/InsertNhanVien", ReplyAction="http://tempuri.org/IServices/InsertNhanVienResponse")]
        void InsertNhanVien(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/InsertNhanVien", ReplyAction="http://tempuri.org/IServices/InsertNhanVienResponse")]
        System.Threading.Tasks.Task InsertNhanVienAsync(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/showGVNhanVien", ReplyAction="http://tempuri.org/IServices/showGVNhanVienResponse")]
        System.Data.DataTable showGVNhanVien();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/showGVNhanVien", ReplyAction="http://tempuri.org/IServices/showGVNhanVienResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> showGVNhanVienAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/UpdateNhanVien", ReplyAction="http://tempuri.org/IServices/UpdateNhanVienResponse")]
        void UpdateNhanVien(int manv, string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/UpdateNhanVien", ReplyAction="http://tempuri.org/IServices/UpdateNhanVienResponse")]
        System.Threading.Tasks.Task UpdateNhanVienAsync(int manv, string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DelNhanVien", ReplyAction="http://tempuri.org/IServices/DelNhanVienResponse")]
        void DelNhanVien(int manv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DelNhanVien", ReplyAction="http://tempuri.org/IServices/DelNhanVienResponse")]
        System.Threading.Tasks.Task DelNhanVienAsync(int manv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/SearchNhanVien", ReplyAction="http://tempuri.org/IServices/SearchNhanVienResponse")]
        System.Data.DataTable SearchNhanVien(string tennv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/SearchNhanVien", ReplyAction="http://tempuri.org/IServices/SearchNhanVienResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchNhanVienAsync(string tennv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/InsertKhachHang", ReplyAction="http://tempuri.org/IServices/InsertKhachHangResponse")]
        void InsertKhachHang(string tenkh, string diachi, string dienthoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/InsertKhachHang", ReplyAction="http://tempuri.org/IServices/InsertKhachHangResponse")]
        System.Threading.Tasks.Task InsertKhachHangAsync(string tenkh, string diachi, string dienthoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/showGVKhachHang", ReplyAction="http://tempuri.org/IServices/showGVKhachHangResponse")]
        System.Data.DataTable showGVKhachHang();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/showGVKhachHang", ReplyAction="http://tempuri.org/IServices/showGVKhachHangResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> showGVKhachHangAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/UpdateKhachHang", ReplyAction="http://tempuri.org/IServices/UpdateKhachHangResponse")]
        void UpdateKhachHang(int makh, string tenkh, string diachi, string dienthoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/UpdateKhachHang", ReplyAction="http://tempuri.org/IServices/UpdateKhachHangResponse")]
        System.Threading.Tasks.Task UpdateKhachHangAsync(int makh, string tenkh, string diachi, string dienthoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DelKhachHang", ReplyAction="http://tempuri.org/IServices/DelKhachHangResponse")]
        void DelKhachHang(int makh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/DelKhachHang", ReplyAction="http://tempuri.org/IServices/DelKhachHangResponse")]
        System.Threading.Tasks.Task DelKhachHangAsync(int makh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/SearchKhachHang", ReplyAction="http://tempuri.org/IServices/SearchKhachHangResponse")]
        System.Data.DataTable SearchKhachHang(string tenkh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/SearchKhachHang", ReplyAction="http://tempuri.org/IServices/SearchKhachHangResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchKhachHangAsync(string tenkh);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicesChannel : QL_TIEMBANH.Services.IServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicesClient : System.ServiceModel.ClientBase<QL_TIEMBANH.Services.IServices>, QL_TIEMBANH.Services.IServices {
        
        public ServicesClient() {
        }
        
        public ServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertSanPham(string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu) {
            base.Channel.InsertSanPham(tensp, soluong, giaban, ngaynhap, anh, ghichu);
        }
        
        public System.Threading.Tasks.Task InsertSanPhamAsync(string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu) {
            return base.Channel.InsertSanPhamAsync(tensp, soluong, giaban, ngaynhap, anh, ghichu);
        }
        
        public System.Data.DataTable showGVSanPham() {
            return base.Channel.showGVSanPham();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> showGVSanPhamAsync() {
            return base.Channel.showGVSanPhamAsync();
        }
        
        public void UpdateSanPham(int masp, string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu) {
            base.Channel.UpdateSanPham(masp, tensp, soluong, giaban, ngaynhap, anh, ghichu);
        }
        
        public System.Threading.Tasks.Task UpdateSanPhamAsync(int masp, string tensp, int soluong, float giaban, System.DateTime ngaynhap, string anh, string ghichu) {
            return base.Channel.UpdateSanPhamAsync(masp, tensp, soluong, giaban, ngaynhap, anh, ghichu);
        }
        
        public void DelSanPham(int masp) {
            base.Channel.DelSanPham(masp);
        }
        
        public System.Threading.Tasks.Task DelSanPhamAsync(int masp) {
            return base.Channel.DelSanPhamAsync(masp);
        }
        
        public System.Data.DataTable SearchSanPham(string tensp) {
            return base.Channel.SearchSanPham(tensp);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchSanPhamAsync(string tensp) {
            return base.Channel.SearchSanPhamAsync(tensp);
        }
        
        public void InsertNhanVien(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi) {
            base.Channel.InsertNhanVien(tennv, gioitinh, dienthoai, ngaysinh, diachi);
        }
        
        public System.Threading.Tasks.Task InsertNhanVienAsync(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi) {
            return base.Channel.InsertNhanVienAsync(tennv, gioitinh, dienthoai, ngaysinh, diachi);
        }
        
        public System.Data.DataTable showGVNhanVien() {
            return base.Channel.showGVNhanVien();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> showGVNhanVienAsync() {
            return base.Channel.showGVNhanVienAsync();
        }
        
        public void UpdateNhanVien(int manv, string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi) {
            base.Channel.UpdateNhanVien(manv, tennv, gioitinh, dienthoai, ngaysinh, diachi);
        }
        
        public System.Threading.Tasks.Task UpdateNhanVienAsync(int manv, string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi) {
            return base.Channel.UpdateNhanVienAsync(manv, tennv, gioitinh, dienthoai, ngaysinh, diachi);
        }
        
        public void DelNhanVien(int manv) {
            base.Channel.DelNhanVien(manv);
        }
        
        public System.Threading.Tasks.Task DelNhanVienAsync(int manv) {
            return base.Channel.DelNhanVienAsync(manv);
        }
        
        public System.Data.DataTable SearchNhanVien(string tennv) {
            return base.Channel.SearchNhanVien(tennv);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchNhanVienAsync(string tennv) {
            return base.Channel.SearchNhanVienAsync(tennv);
        }
        
        public void InsertKhachHang(string tenkh, string diachi, string dienthoai) {
            base.Channel.InsertKhachHang(tenkh, diachi, dienthoai);
        }
        
        public System.Threading.Tasks.Task InsertKhachHangAsync(string tenkh, string diachi, string dienthoai) {
            return base.Channel.InsertKhachHangAsync(tenkh, diachi, dienthoai);
        }
        
        public System.Data.DataTable showGVKhachHang() {
            return base.Channel.showGVKhachHang();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> showGVKhachHangAsync() {
            return base.Channel.showGVKhachHangAsync();
        }
        
        public void UpdateKhachHang(int makh, string tenkh, string diachi, string dienthoai) {
            base.Channel.UpdateKhachHang(makh, tenkh, diachi, dienthoai);
        }
        
        public System.Threading.Tasks.Task UpdateKhachHangAsync(int makh, string tenkh, string diachi, string dienthoai) {
            return base.Channel.UpdateKhachHangAsync(makh, tenkh, diachi, dienthoai);
        }
        
        public void DelKhachHang(int makh) {
            base.Channel.DelKhachHang(makh);
        }
        
        public System.Threading.Tasks.Task DelKhachHangAsync(int makh) {
            return base.Channel.DelKhachHangAsync(makh);
        }
        
        public System.Data.DataTable SearchKhachHang(string tenkh) {
            return base.Channel.SearchKhachHang(tenkh);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchKhachHangAsync(string tenkh) {
            return base.Channel.SearchKhachHangAsync(tenkh);
        }
    }
}
