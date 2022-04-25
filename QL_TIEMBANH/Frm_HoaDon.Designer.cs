namespace QL_TIEMBANH
{
    partial class Frm_HoaDon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_chitietHD = new System.Windows.Forms.DataGridView();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_giasp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_masp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_mahd = new System.Windows.Forms.TextBox();
            this.btn_resetHD = new System.Windows.Forms.Button();
            this.btn_taoHD = new System.Windows.Forms.Button();
            this.txt_ngayban = new System.Windows.Forms.DateTimePicker();
            this.cb_makh = new System.Windows.Forms.ComboBox();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_hoadon = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_chitietHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xuat);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_tongtien);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tb_chitietHD);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_giasp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_masp);
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 349);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các sản phẩm";
            // 
            // btn_xuat
            // 
            this.btn_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xuat.Image = global::QL_TIEMBANH.Properties.Resources.excel;
            this.btn_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuat.Location = new System.Drawing.Point(238, 286);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(81, 27);
            this.btn_xuat.TabIndex = 62;
            this.btn_xuat.Text = "Xuất";
            this.btn_xuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.Image = global::QL_TIEMBANH.Properties.Resources.delete16x16;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(153, 286);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 27);
            this.btn_xoa.TabIndex = 61;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_them.Image = global::QL_TIEMBANH.Properties.Resources.add16x16;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(68, 286);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 27);
            this.btn_them.TabIndex = 60;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(260, 77);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(118, 20);
            this.txt_soluong.TabIndex = 58;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(626, 293);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(118, 20);
            this.txt_tongtien.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(549, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Tổng tiền";
            // 
            // tb_chitietHD
            // 
            this.tb_chitietHD.AllowUserToAddRows = false;
            this.tb_chitietHD.AllowUserToDeleteRows = false;
            this.tb_chitietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_chitietHD.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tb_chitietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_chitietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MASP,
            this.TENSP,
            this.SL,
            this.GIABAN,
            this.THANHTIEN});
            this.tb_chitietHD.Location = new System.Drawing.Point(42, 109);
            this.tb_chitietHD.Name = "tb_chitietHD";
            this.tb_chitietHD.ReadOnly = true;
            this.tb_chitietHD.Size = new System.Drawing.Size(702, 172);
            this.tb_chitietHD.TabIndex = 49;
            this.tb_chitietHD.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_chitietHD_RowHeaderMouseDoubleClick);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(472, 77);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(152, 20);
            this.txt_thanhtien.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Thành tiền";
            // 
            // txt_giasp
            // 
            this.txt_giasp.Enabled = false;
            this.txt_giasp.Location = new System.Drawing.Point(472, 50);
            this.txt_giasp.Name = "txt_giasp";
            this.txt_giasp.Size = new System.Drawing.Size(152, 20);
            this.txt_giasp.TabIndex = 46;
            this.txt_giasp.TextChanged += new System.EventHandler(this.txt_giasp_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Giá bán SP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Số lượng";
            // 
            // cb_masp
            // 
            this.cb_masp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_masp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_masp.FormattingEnabled = true;
            this.cb_masp.Location = new System.Drawing.Point(260, 50);
            this.cb_masp.Name = "cb_masp";
            this.cb_masp.Size = new System.Drawing.Size(118, 21);
            this.cb_masp.TabIndex = 7;
            this.cb_masp.SelectionChangeCommitted += new System.EventHandler(this.cb_masp_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_mahd);
            this.groupBox1.Controls.Add(this.btn_resetHD);
            this.groupBox1.Controls.Add(this.btn_taoHD);
            this.groupBox1.Controls.Add(this.txt_ngayban);
            this.groupBox1.Controls.Add(this.cb_makh);
            this.groupBox1.Controls.Add(this.cb_manv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 228);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn";
            // 
            // cb_mahd
            // 
            this.cb_mahd.Enabled = false;
            this.cb_mahd.Location = new System.Drawing.Point(131, 38);
            this.cb_mahd.Name = "cb_mahd";
            this.cb_mahd.Size = new System.Drawing.Size(228, 20);
            this.cb_mahd.TabIndex = 58;
            // 
            // btn_resetHD
            // 
            this.btn_resetHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetHD.Image = global::QL_TIEMBANH.Properties.Resources.refresh;
            this.btn_resetHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resetHD.Location = new System.Drawing.Point(194, 162);
            this.btn_resetHD.Name = "btn_resetHD";
            this.btn_resetHD.Size = new System.Drawing.Size(80, 30);
            this.btn_resetHD.TabIndex = 57;
            this.btn_resetHD.Text = "Làm mới";
            this.btn_resetHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_resetHD.UseVisualStyleBackColor = true;
            this.btn_resetHD.Click += new System.EventHandler(this.btn_resetHD_Click);
            // 
            // btn_taoHD
            // 
            this.btn_taoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taoHD.Image = global::QL_TIEMBANH.Properties.Resources.bill;
            this.btn_taoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taoHD.Location = new System.Drawing.Point(105, 162);
            this.btn_taoHD.Name = "btn_taoHD";
            this.btn_taoHD.Size = new System.Drawing.Size(83, 30);
            this.btn_taoHD.TabIndex = 54;
            this.btn_taoHD.Text = "Tạo HĐ";
            this.btn_taoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taoHD.UseVisualStyleBackColor = true;
            this.btn_taoHD.Click += new System.EventHandler(this.btn_taoHD_Click);
            // 
            // txt_ngayban
            // 
            this.txt_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngayban.Location = new System.Drawing.Point(131, 64);
            this.txt_ngayban.Name = "txt_ngayban";
            this.txt_ngayban.Size = new System.Drawing.Size(228, 20);
            this.txt_ngayban.TabIndex = 2;
            // 
            // cb_makh
            // 
            this.cb_makh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_makh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_makh.FormattingEnabled = true;
            this.cb_makh.Location = new System.Drawing.Point(131, 121);
            this.cb_makh.Name = "cb_makh";
            this.cb_makh.Size = new System.Drawing.Size(228, 21);
            this.cb_makh.TabIndex = 5;
            // 
            // cb_manv
            // 
            this.cb_manv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_manv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(131, 94);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(228, 21);
            this.cb_manv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã hoá đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_hoadon);
            this.groupBox3.Location = new System.Drawing.Point(409, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 228);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hoá đơn";
            // 
            // tb_hoadon
            // 
            this.tb_hoadon.AllowUserToAddRows = false;
            this.tb_hoadon.AllowUserToDeleteRows = false;
            this.tb_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.MANV,
            this.MAKH,
            this.NGAYBAN,
            this.TONGTIEN});
            this.tb_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_hoadon.Location = new System.Drawing.Point(3, 16);
            this.tb_hoadon.Name = "tb_hoadon";
            this.tb_hoadon.ReadOnly = true;
            this.tb_hoadon.Size = new System.Drawing.Size(381, 209);
            this.tb_hoadon.TabIndex = 0;
            this.tb_hoadon.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_hoadon_RowHeaderMouseDoubleClick);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.Frozen = true;
            this.MAHD.HeaderText = "Mã HĐ";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // NGAYBAN
            // 
            this.NGAYBAN.DataPropertyName = "NGAYBAN";
            this.NGAYBAN.HeaderText = "Ngày Bán";
            this.NGAYBAN.Name = "NGAYBAN";
            this.NGAYBAN.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // Frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_HoaDon";
            this.Text = "Quản Lí Hoá Đơn";
            this.Load += new System.EventHandler(this.Frm_HoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_chitietHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tb_chitietHD;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_giasp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_masp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_resetHD;
        private System.Windows.Forms.Button btn_taoHD;
        private System.Windows.Forms.DateTimePicker txt_ngayban;
        private System.Windows.Forms.ComboBox cb_makh;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tb_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.TextBox cb_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}