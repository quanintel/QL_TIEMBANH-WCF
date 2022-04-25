using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QL_TIEMBANH
{
    public partial class Frm_HoaDon : Form
    {
        public Frm_HoaDon()
        {
            InitializeComponent();
        }
        Services.ServicesClient sv = new Services.ServicesClient();
        string sl_bak, id_bak, sp_bak, thanhtien_bak;
        private void FillComboxNHANVIEN()
        {
            DataTable data = new DataTable();
            data = sv.showComboxNhanVien();
            cb_manv.DataSource = data;
            cb_manv.ValueMember = "MANV";
            cb_manv.DisplayMember = "MANV";
        }
        private void FillComboxKHACHHANG()
        {
            DataTable data = new DataTable();
            data = sv.showComboxKhachHang();
            cb_makh.DataSource = data;
            cb_makh.ValueMember = "MAKH";
            cb_makh.DisplayMember = "MAKH";
        }
        private void FillComboxSANPHAM()
        {
            DataTable data = new DataTable();
            data = sv.showComboxSanPham();
            cb_masp.DataSource = data;
            cb_masp.ValueMember = "MASP";
            cb_masp.DisplayMember = "MASP";
        }
        private void showGVHoaDon()
        {
            DataTable data = new DataTable();
            data = sv.showGVHoaDon();
            tb_hoadon.DataSource = data;
        }
        private void showGVChiTietHoaDon(int mahd)
        {
            DataTable data = new DataTable();
            data = sv.showGVHoaDonChiTiet(mahd);
            tb_chitietHD.DataSource = data;
        }
        private void Reset()
        {
            cb_mahd.Clear();
            cb_manv.SelectedIndex = -1;
            cb_makh.SelectedIndex = -1;
            cb_masp.SelectedIndex = -1;
            txt_ngayban.Value = DateTime.Now;
            txt_soluong.Text = "0";
            txt_giasp.Clear();
            txt_thanhtien.Clear();
            btn_xoa.Enabled = false;
        }
        private void ResetButton()
        {
            btn_taoHD.Enabled = true;
            btn_them.Enabled = false;
            btn_xuat.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            FillComboxKHACHHANG();
            FillComboxNHANVIEN();
            FillComboxSANPHAM();
            showGVHoaDon();
            Reset();
            ResetButton();
        }

        private void btn_taoHD_Click(object sender, EventArgs e)
        {
            if (cb_manv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên bán !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_manv.Focus();
                return;
            }
            else if (cb_makh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng mua !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_makh.Focus();
                return;
            }
            else
            {
                sv.InsertHoaDon(Convert.ToInt32(cb_manv.SelectedValue), Convert.ToInt32(cb_makh.SelectedValue), txt_ngayban.Value, 0);
                MessageBox.Show("Tạo hoá đơn trắng thành công !");
                showGVHoaDon();
                Reset();
                ResetButton();
            }
        }

        private void btn_resetHD_Click(object sender, EventArgs e)
        {
            Reset();
            ResetButton();
            tb_chitietHD.DataSource = null;
        }
        private void tb_hoadon_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_taoHD.Enabled = false;
            btn_them.Enabled = true;
            btn_xuat.Enabled = true;
            btn_xoa.Enabled = true;

            int maHD = Convert.ToInt32(tb_hoadon.CurrentRow.Cells["MAHD"].Value);
            cb_mahd.Text = maHD.ToString();
            cb_makh.Text = tb_hoadon.CurrentRow.Cells["MAKH"].Value.ToString();
            cb_manv.Text = tb_hoadon.CurrentRow.Cells["MANV"].Value.ToString();
            txt_tongtien.Text = tb_hoadon.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            showGVChiTietHoaDon(maHD);
        }

        private void cb_masp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_giasp.Text = sv.getGiaTien(Convert.ToInt32(cb_masp.SelectedValue));
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            if (txt_giasp.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_giasp.Text);
            tt = sl * dg;
            txt_thanhtien.Text = tt.ToString();
        }

        private void txt_giasp_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            if (txt_giasp.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_giasp.Text);
            tt = sl * dg;
            txt_thanhtien.Text = tt.ToString();
        }

        

        private void btn_them_Click(object sender, EventArgs e)
        {
            double sl, sl_edit, tong, tong_edit;
            int masp = Convert.ToInt32(cb_masp.SelectedValue);
            int mahd = Convert.ToInt32(cb_mahd.Text);
            if (cb_mahd.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã hoá đơn cần thêm sản phẩm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_mahd.Focus();
                return;
            }
            else if (cb_masp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_masp.Focus();
                return;
            }
            else if (txt_soluong.Text == "0")
            {
                MessageBox.Show("Vui lòng thêm số lượng số lượng của sản phẩm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soluong.Focus();
                return;
            }
            else if (sv.checkSanPham(mahd, masp) == true)
            {
                MessageBox.Show("Sản phẩm này đã có trong danh sách !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_masp.Focus();
                return;
            }
            sl = Convert.ToDouble(sv.getSoLuong(masp));
            if (Convert.ToDouble(txt_soluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Text = "0";
                txt_soluong.Focus();
                return;
            }
            sv.InsertChiTietHoaDon(mahd, masp, Convert.ToInt32(txt_soluong.Text), float.Parse(txt_giasp.Text), float.Parse(txt_thanhtien.Text));
            showGVChiTietHoaDon(mahd);
            // Cập nhật lại số lượng của sản phẩm vào bảng SANPHAM
            sl_edit = sl - Convert.ToDouble(txt_soluong.Text);
            sv.UpdateSoLuong(masp, sl_edit);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(sv.getTongTien(mahd));
            tong_edit = tong + Convert.ToDouble(txt_thanhtien.Text);
            sv.UpdateTongTien(mahd, tong_edit);
            txt_tongtien.Text = tong_edit.ToString();
            showGVHoaDon();
        }
        private void tb_chitietHD_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_xoa.Enabled = true;
            cb_masp.SelectedIndex = -1;
            txt_soluong.Clear();
            txt_giasp.Clear();
            txt_thanhtien.Clear();
            id_bak = tb_chitietHD.CurrentRow.Cells["ID"].Value.ToString();
            sp_bak = tb_chitietHD.CurrentRow.Cells["MASP"].Value.ToString();
            sl_bak = tb_chitietHD.CurrentRow.Cells["SL"].Value.ToString();
            thanhtien_bak = tb_chitietHD.CurrentRow.Cells["THANHTIEN"].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                double sl, sl_edit, tong, tong_edit;
                int masp = Convert.ToInt32(sp_bak);
                int mahd = Convert.ToInt32(cb_mahd.Text);
                int macthd = Convert.ToInt32(id_bak);
                // Cập nhật lại số lượng của sản phẩm vào bảng SANPHAM
                sl = Convert.ToDouble(sv.getSoLuong(masp));
                sl_edit = sl + Convert.ToDouble(sl_bak);
                sv.UpdateSoLuong(masp, sl_edit);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(sv.getTongTien(mahd));
                tong_edit = tong - Convert.ToDouble(thanhtien_bak);
                sv.UpdateTongTien(mahd, tong_edit);
                txt_tongtien.Text = tong_edit.ToString();
                // Xoá 1 sản phẩm trong Chi Tiết Hoá Đơn
                sv.DelOne_ChiTietHoaDon(macthd);
                showGVChiTietHoaDon(mahd);
                showGVHoaDon();
            }
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            int mahd = Convert.ToInt32(cb_mahd.Text);
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "TIỆM BÁNH CỐI XAY GIÓ";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Phú Diễn - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (09)65428771";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            tblThongtinHD = sv.getThongTinHD(mahd);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            tblThongtinHang = sv.getThongTinSP(mahd);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }
    }
}
