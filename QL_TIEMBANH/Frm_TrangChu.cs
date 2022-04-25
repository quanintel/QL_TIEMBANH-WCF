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
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien form = new Frm_NhanVien();
            form.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SanPham form = new Frm_SanPham();
            form.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang form = new Frm_KhachHang();
            form.Show();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HoaDon form = new Frm_HoaDon();
            form.Show();
        }
    }
}
