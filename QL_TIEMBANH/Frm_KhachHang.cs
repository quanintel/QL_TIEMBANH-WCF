using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TIEMBANH
{
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        Services.ServicesClient sv = new Services.ServicesClient();
        private void LoadDataGV()
        {
            DataTable data = new DataTable();
            data = sv.showGVKhachHang();
            tb_khachhang.DataSource = data;
        }
        private void Reset()
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
        }
        private void ResetButton()
        {
            txt_makh.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGV();
            ResetButton();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tenkh.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng !");
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại !");
            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ !");
            }
            else
            {
                try
                {
                    sv.InsertKhachHang(txt_tenkh.Text, txt_sdt.Text, txt_diachi.Text);
                    MessageBox.Show("Thêm thành công !");
                    LoadDataGV();
                    Reset();
                    ResetButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private void tb_nhanvien_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            Reset();
            txt_makh.Text = tb_khachhang.CurrentRow.Cells["MAKH"].Value.ToString();
            txt_tenkh.Text = tb_khachhang.CurrentRow.Cells["TENKH"].Value.ToString();
            txt_sdt.Text = tb_khachhang.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            txt_diachi.Text = tb_khachhang.CurrentRow.Cells["DIACHI"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenkh.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng !");
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại !");
            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ !");
            }
            else
            {
                try
                {
                    sv.UpdateKhachHang(Convert.ToInt32(txt_makh.Text), txt_tenkh.Text, txt_sdt.Text, txt_diachi.Text);
                    MessageBox.Show("Sửa thành công !");
                    LoadDataGV();
                    Reset();
                    ResetButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sv.DelKhachHang(Convert.ToInt32(txt_makh.Text));
                    LoadDataGV();
                    ResetButton();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = sv.SearchKhachHang(txt_timkiem.Text);
            tb_khachhang.DataSource = data;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetButton();
            Reset();
        }
    }
}
