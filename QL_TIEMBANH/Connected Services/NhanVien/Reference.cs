﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_TIEMBANH.NhanVien {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NhanVien.INhanVien")]
    public interface INhanVien {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/InsertNhanVien", ReplyAction="http://tempuri.org/INhanVien/InsertNhanVienResponse")]
        void InsertNhanVien(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/InsertNhanVien", ReplyAction="http://tempuri.org/INhanVien/InsertNhanVienResponse")]
        System.Threading.Tasks.Task InsertNhanVienAsync(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/showGV", ReplyAction="http://tempuri.org/INhanVien/showGVResponse")]
        System.Data.DataTable showGV();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/showGV", ReplyAction="http://tempuri.org/INhanVien/showGVResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> showGVAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/UpdateNhanVien", ReplyAction="http://tempuri.org/INhanVien/UpdateNhanVienResponse")]
        void UpdateNhanVien(int manv, string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/UpdateNhanVien", ReplyAction="http://tempuri.org/INhanVien/UpdateNhanVienResponse")]
        System.Threading.Tasks.Task UpdateNhanVienAsync(int manv, string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/DelNhanVien", ReplyAction="http://tempuri.org/INhanVien/DelNhanVienResponse")]
        void DelNhanVien(int manv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/DelNhanVien", ReplyAction="http://tempuri.org/INhanVien/DelNhanVienResponse")]
        System.Threading.Tasks.Task DelNhanVienAsync(int manv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/SearchNhanVien", ReplyAction="http://tempuri.org/INhanVien/SearchNhanVienResponse")]
        System.Data.DataTable SearchNhanVien(string tennv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INhanVien/SearchNhanVien", ReplyAction="http://tempuri.org/INhanVien/SearchNhanVienResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchNhanVienAsync(string tennv);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INhanVienChannel : QL_TIEMBANH.NhanVien.INhanVien, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NhanVienClient : System.ServiceModel.ClientBase<QL_TIEMBANH.NhanVien.INhanVien>, QL_TIEMBANH.NhanVien.INhanVien {
        
        public NhanVienClient() {
        }
        
        public NhanVienClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NhanVienClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NhanVienClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NhanVienClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertNhanVien(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi) {
            base.Channel.InsertNhanVien(tennv, gioitinh, dienthoai, ngaysinh, diachi);
        }
        
        public System.Threading.Tasks.Task InsertNhanVienAsync(string tennv, string gioitinh, string dienthoai, System.DateTime ngaysinh, string diachi) {
            return base.Channel.InsertNhanVienAsync(tennv, gioitinh, dienthoai, ngaysinh, diachi);
        }
        
        public System.Data.DataTable showGV() {
            return base.Channel.showGV();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> showGVAsync() {
            return base.Channel.showGVAsync();
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
    }
}