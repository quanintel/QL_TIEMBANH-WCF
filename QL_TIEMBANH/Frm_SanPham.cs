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
    public partial class Frm_SanPham : Form
    {
        public Frm_SanPham()
        {
            InitializeComponent();
        }
        Services.ServicesClient sv = new Services.ServicesClient();
        private void LoadDataGV()
        {
            DataTable data = new DataTable();
            data = sv.showGVSanPham();
            tb_sanpham.DataSource = data;
        }
        private void Reset()
        {
            txt_masp.Clear();
            txt_tensp.Clear();
            txt_soluong.Value = 0;
            txt_giaban.Value = 0;
            txt_ngaynhap.Value = DateTime.Now;
            txt_anh.Clear();
            viewAnh.Image = null;
            txt_ghichu.Clear();
        }
        private void ResetButton()
        {
            txt_masp.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadDataGV();
            ResetButton();
        }

        private void btn_addAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                viewAnh.Image = Image.FromFile(dlgOpen.FileName);
                txt_anh.Text = dlgOpen.FileName;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tensp.Text == "")
            {
                MessageBox.Show("Chưa nhập tên loại !");
            }
            else if (txt_soluong.Value == 0)
            {
                MessageBox.Show("Chưa nhập số lượng !");
            }
            else if (txt_giaban.Value == 0)
            {
                MessageBox.Show("Chưa nhập giá bán !");
            }
            else if (txt_anh.Text == "" || viewAnh.Image == null)
            {
                MessageBox.Show("Chưa chọn ảnh!");
            }
            else if (txt_ghichu.Text == "")
            {
                MessageBox.Show("Chưa nhập ghi chú !");
            }
            else
            {
                try
                {
                    sv.InsertSanPham(txt_tensp.Text, (int)txt_soluong.Value, (float)txt_giaban.Value, txt_ngaynhap.Value, txt_anh.Text, txt_ghichu.Text);
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

        private void tb_sanpham_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            Reset();
            txt_masp.Text = tb_sanpham.CurrentRow.Cells["MASP"].Value.ToString();
            txt_tensp.Text = tb_sanpham.CurrentRow.Cells["TENSP"].Value.ToString();
            txt_soluong.Text = tb_sanpham.CurrentRow.Cells["SL"].Value.ToString();
            txt_giaban.Text = tb_sanpham.CurrentRow.Cells["GIABAN"].Value.ToString();
            txt_ngaynhap.Text = tb_sanpham.CurrentRow.Cells["NGAYNHAP"].Value.ToString();
            txt_ghichu.Text = tb_sanpham.CurrentRow.Cells["GHICHU"].Value.ToString();
            try
            {
                txt_anh.Text = tb_sanpham.CurrentRow.Cells["ANH"].Value.ToString();
                viewAnh.Image = Image.FromFile(txt_anh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tensp.Text == "")
            {
                MessageBox.Show("Chưa nhập tên loại !");
            }
            else if (txt_soluong.Value == 0)
            {
                MessageBox.Show("Chưa nhập số lượng !");
            }
            else if (txt_giaban.Value == 0)
            {
                MessageBox.Show("Chưa nhập giá bán !");
            }
            else if (txt_anh.Text == "" || viewAnh.Image == null)
            {
                MessageBox.Show("Chưa chọn ảnh!");
            }
            else if (txt_ghichu.Text == "")
            {
                MessageBox.Show("Chưa nhập ghi chú !");
            }
            else
            {
                try
                {
                    sv.UpdateSanPham(Convert.ToInt32(txt_masp.Text), txt_tensp.Text, (int)txt_soluong.Value, (float)txt_giaban.Value, txt_ngaynhap.Value, txt_anh.Text, txt_ghichu.Text);
                    MessageBox.Show("Sửa thành công !");
                    LoadDataGV();
                    ResetButton();
                    Reset();
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
                    sv.DelSanPham(Convert.ToInt32(txt_masp.Text));
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
            data = sv.SearchSanPham(txt_timkiem.Text);
            tb_sanpham.DataSource = data;
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetButton();
            Reset();
        }
    }
}
