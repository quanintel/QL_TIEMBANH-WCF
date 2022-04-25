namespace QL_TIEMBANH
{
    partial class Frm_KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_khachhang = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_khachhang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.Image = global::QL_TIEMBANH.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.Location = new System.Drawing.Point(94, 19);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(44, 20);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(82, 129);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(237, 20);
            this.txt_sdt.TabIndex = 78;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(82, 77);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(100, 20);
            this.txt_makh.TabIndex = 75;
            this.txt_makh.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reset.Image = global::QL_TIEMBANH.Properties.Resources.refresh;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(273, 262);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(87, 27);
            this.btn_reset.TabIndex = 74;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.Image = global::QL_TIEMBANH.Properties.Resources.delete16x16;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(186, 262);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 27);
            this.btn_xoa.TabIndex = 73;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_sua.Image = global::QL_TIEMBANH.Properties.Resources.edit16x16;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(99, 262);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 27);
            this.btn_sua.TabIndex = 72;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_them.Image = global::QL_TIEMBANH.Properties.Resources.add16x16;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(12, 262);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 27);
            this.btn_them.TabIndex = 71;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(82, 155);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(237, 86);
            this.txt_diachi.TabIndex = 16;
            this.txt_diachi.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Địa chỉ";
            // 
            // tb_khachhang
            // 
            this.tb_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.DIENTHOAI,
            this.DIACHI});
            this.tb_khachhang.Location = new System.Drawing.Point(6, 48);
            this.tb_khachhang.Name = "tb_khachhang";
            this.tb_khachhang.Size = new System.Drawing.Size(448, 408);
            this.tb_khachhang.TabIndex = 0;
            this.tb_khachhang.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_nhanvien_RowHeaderMouseDoubleClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.Name = "MAKH";
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên KH";
            this.TENKH.Name = "TENKH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DIACHI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điện thoại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.tb_khachhang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(366, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 464);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(144, 19);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(237, 20);
            this.txt_timkiem.TabIndex = 3;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(82, 103);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(237, 20);
            this.txt_tenkh.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TênNV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 464);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_KhachHang";
            this.Text = "Quản Lí Khách Hàng";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_khachhang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.RichTextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tb_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}