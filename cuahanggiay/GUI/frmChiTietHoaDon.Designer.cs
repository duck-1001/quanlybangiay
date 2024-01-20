namespace GUI
{
    partial class frmChiTietHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMacthd = new System.Windows.Forms.TextBox();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.txtMagiay = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtGiagoc = new System.Windows.Forms.TextBox();
            this.txtKhuyenmai = new System.Windows.Forms.TextBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuahang_bangiayDataSet4 = new GUI.cuahang_bangiayDataSet4();
            this.chiTietHoaDonTableAdapter = new GUI.cuahang_bangiayDataSet4TableAdapters.ChiTietHoaDonTableAdapter();
            this.btnTong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CTHD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Giày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá Gốc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khuyến Mãi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thành Tiền";
            // 
            // txtMacthd
            // 
            this.txtMacthd.Location = new System.Drawing.Point(76, 18);
            this.txtMacthd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMacthd.Name = "txtMacthd";
            this.txtMacthd.Size = new System.Drawing.Size(163, 22);
            this.txtMacthd.TabIndex = 1;
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(76, 70);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(163, 22);
            this.txtMahd.TabIndex = 1;
            // 
            // txtMagiay
            // 
            this.txtMagiay.Location = new System.Drawing.Point(76, 128);
            this.txtMagiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMagiay.Name = "txtMagiay";
            this.txtMagiay.Size = new System.Drawing.Size(163, 22);
            this.txtMagiay.TabIndex = 1;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(323, 18);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(163, 22);
            this.txtSize.TabIndex = 1;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(323, 70);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(163, 22);
            this.txtSoluong.TabIndex = 1;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(323, 130);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(163, 22);
            this.txtDongia.TabIndex = 1;
            // 
            // txtGiagoc
            // 
            this.txtGiagoc.Location = new System.Drawing.Point(572, 17);
            this.txtGiagoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiagoc.Name = "txtGiagoc";
            this.txtGiagoc.Size = new System.Drawing.Size(163, 22);
            this.txtGiagoc.TabIndex = 1;
            // 
            // txtKhuyenmai
            // 
            this.txtKhuyenmai.Location = new System.Drawing.Point(572, 74);
            this.txtKhuyenmai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhuyenmai.Name = "txtKhuyenmai";
            this.txtKhuyenmai.Size = new System.Drawing.Size(163, 22);
            this.txtKhuyenmai.TabIndex = 1;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(572, 130);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(163, 22);
            this.txtThanhtien.TabIndex = 1;
            this.txtThanhtien.TextChanged += new System.EventHandler(this.txtThanhtien_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThem.Location = new System.Drawing.Point(926, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoa.Location = new System.Drawing.Point(926, 55);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSua.Location = new System.Drawing.Point(926, 91);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTim.Location = new System.Drawing.Point(892, 164);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(97, 31);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(1012, 169);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(163, 22);
            this.txtTim.TabIndex = 1;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoGenerateColumns = false;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTHD,
            this.MaHD,
            this.MaGiay,
            this.Size,
            this.SoLuong,
            this.DonGia,
            this.GiaGoc,
            this.KhuyenMai,
            this.ThanhTien});
            this.dgvCTHD.DataSource = this.chiTietHoaDonBindingSource;
            this.dgvCTHD.Location = new System.Drawing.Point(21, 221);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 62;
            this.dgvCTHD.RowTemplate.Height = 28;
            this.dgvCTHD.Size = new System.Drawing.Size(1233, 180);
            this.dgvCTHD.TabIndex = 3;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // MaCTHD
            // 
            this.MaCTHD.DataPropertyName = "MaCTHD";
            this.MaCTHD.HeaderText = "Mã CTHD";
            this.MaCTHD.MinimumWidth = 8;
            this.MaCTHD.Name = "MaCTHD";
            this.MaCTHD.Width = 150;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 150;
            // 
            // MaGiay
            // 
            this.MaGiay.DataPropertyName = "MaGiay";
            this.MaGiay.HeaderText = "Mã Giày";
            this.MaGiay.MinimumWidth = 8;
            this.MaGiay.Name = "MaGiay";
            this.MaGiay.Width = 150;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 8;
            this.Size.Name = "Size";
            this.Size.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // GiaGoc
            // 
            this.GiaGoc.DataPropertyName = "GiaGoc";
            this.GiaGoc.HeaderText = "Giá Gốc";
            this.GiaGoc.MinimumWidth = 8;
            this.GiaGoc.Name = "GiaGoc";
            this.GiaGoc.Width = 150;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.MinimumWidth = 8;
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.cuahang_bangiayDataSet4;
            // 
            // cuahang_bangiayDataSet4
            // 
            this.cuahang_bangiayDataSet4.DataSetName = "cuahang_bangiayDataSet4";
            this.cuahang_bangiayDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTong.Location = new System.Drawing.Point(754, 115);
            this.btnTong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(101, 39);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tính";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GUI.Properties.Resources.a858cbe1870aefa51bc6785df6c4560f;
            this.ClientSize = new System.Drawing.Size(1264, 401);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtMagiay);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtKhuyenmai);
            this.Controls.Add(this.txtGiagoc);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.txtMacthd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuahang_bangiayDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMacthd;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.TextBox txtMagiay;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtGiagoc;
        private System.Windows.Forms.TextBox txtKhuyenmai;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private cuahang_bangiayDataSet4 cuahang_bangiayDataSet4;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private cuahang_bangiayDataSet4TableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnTong;
    }
}