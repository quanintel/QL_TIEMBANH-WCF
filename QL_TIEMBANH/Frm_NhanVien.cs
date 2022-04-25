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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        Services.ServicesClient sv = new Services.ServicesClient();
        private void LoadDataGV()
        {
            DataTable data = new DataTable();
            data = sv.showGVNhanVien();
            tb_nhanvien.DataSource = data;
        }
        private void Reset()
        {
            txt_manv.Clear();
            txt_tennv.Clear();
            txt_gioitinh.SelectedIndex = -1;
            txt_sdt.Clear();
            txt_ngaysinh.Value = DateTime.Now;
            txt_diachi.Clear();
        }
        private void ResetButton()
        {
            txt_manv.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGV();
            ResetButton();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên !");
            }
            else if (txt_gioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn giới tính !");
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại !");
            }
            else if (txt_ngaysinh.Value == DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ !");
            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ !");
            }
            else
            {
                try
                {
                    sv.InsertNhanVien(txt_tennv.Text, txt_gioitinh.Text, txt_sdt.Text, txt_ngaysinh.Value, txt_diachi.Text);
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
            txt_manv.Text = tb_nhanvien.CurrentRow.Cells["MANV"].Value.ToString();
            txt_tennv.Text = tb_nhanvien.CurrentRow.Cells["TENNV"].Value.ToString();
            txt_gioitinh.Text = tb_nhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            txt_sdt.Text = tb_nhanvien.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            txt_ngaysinh.Text = tb_nhanvien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_diachi.Text = tb_nhanvien.CurrentRow.Cells["DIACHI"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên !");
            }
            else if (txt_gioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn giới tính !");
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại !");
            }
            else if (txt_ngaysinh.Value == DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ !");
            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ !");
            }
            else
            {
                try
                {
                    sv.UpdateNhanVien(Convert.ToInt32(txt_manv.Text) ,txt_tennv.Text, txt_gioitinh.Text, txt_sdt.Text, txt_ngaysinh.Value, txt_diachi.Text);
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
                    sv.DelNhanVien(Convert.ToInt32(txt_manv.Text));
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
            data = sv.SearchNhanVien(txt_timkiem.Text);
            tb_nhanvien.DataSource = data;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetButton();
            Reset();
        }

       
    }
}
