namespace QL_TIEMBANH
{
    partial class Frm_NhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.RichTextBox();
            this.txt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tb_nhanvien = new System.Windows.Forms.DataGridView();
            this.txt_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_gioitinh);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_ngaysinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(82, 56);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(100, 20);
            this.txt_manv.TabIndex = 75;
            this.txt_manv.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reset.Image = global::QL_TIEMBANH.Properties.Resources.refresh;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(273, 293);
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
            this.btn_xoa.Location = new System.Drawing.Point(186, 293);
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
            this.btn_sua.Location = new System.Drawing.Point(99, 293);
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
            this.btn_them.Location = new System.Drawing.Point(12, 293);
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
            this.txt_diachi.Location = new System.Drawing.Point(82, 186);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(237, 86);
            this.txt_diachi.TabIndex = 16;
            this.txt_diachi.Text = "";
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(82, 160);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(237, 20);
            this.txt_ngaysinh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giới tính";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(82, 82);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(237, 20);
            this.txt_tennv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TênNV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.tb_nhanvien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(366, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 462);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(283, 19);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(237, 20);
            this.txt_timkiem.TabIndex = 3;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.Image = global::QL_TIEMBANH.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.Location = new System.Drawing.Point(233, 19);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(44, 20);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // tb_nhanvien
            // 
            this.tb_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.GIOITINH,
            this.DIENTHOAI,
            this.NGAYSINH,
            this.DIACHI});
            this.tb_nhanvien.Location = new System.Drawing.Point(6, 48);
            this.tb_nhanvien.Name = "tb_nhanvien";
            this.tb_nhanvien.Size = new System.Drawing.Size(639, 408);
            this.tb_nhanvien.TabIndex = 0;
            this.tb_nhanvien.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_nhanvien_RowHeaderMouseDoubleClick);
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.FormattingEnabled = true;
            this.txt_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txt_gioitinh.Location = new System.Drawing.Point(82, 108);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(237, 21);
            this.txt_gioitinh.TabIndex = 77;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(82, 134);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(237, 20);
            this.txt_sdt.TabIndex = 78;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên NV";
            this.TENNV.Name = "TENNV";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NGAYSINH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DIACHI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_NhanVien";
            this.Text = "Quản Lí Nhân Viên";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.RichTextBox txt_diachi;
        private System.Windows.Forms.DateTimePicker txt_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridView tb_nhanvien;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.ComboBox txt_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}