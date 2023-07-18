
namespace Chuongtrinhquanlybanlycoc
{
    partial class frmHoaDonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.tblKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._baitaplonC_DataSet1 = new Chuongtrinhquanlybanlycoc._baitaplonC_DataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._baitaplonC_DataSet2 = new Chuongtrinhquanlybanlycoc._baitaplonC_DataSet2();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoHDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTKHoaDonBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.tblDMHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._baitaplonC_DataSet = new Chuongtrinhquanlybanlycoc._baitaplonC_DataSet();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tblDMHangHoaTableAdapter = new Chuongtrinhquanlybanlycoc._baitaplonC_DataSetTableAdapters.tblDMHangHoaTableAdapter();
            this.frmDMHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKhachHangTableAdapter = new Chuongtrinhquanlybanlycoc._baitaplonC_DataSet1TableAdapters.tblKhachHangTableAdapter();
            this.tblNhanVienTableAdapter = new Chuongtrinhquanlybanlycoc._baitaplonC_DataSet2TableAdapters.tblNhanVienTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._baitaplonC_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._baitaplonC_DataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._baitaplonC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDMHangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboMaKhach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoHDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKhachHangBindingSource, "DienThoai", true));
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Location = new System.Drawing.Point(700, 152);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(152, 22);
            this.txtDienThoai.TabIndex = 15;
            // 
            // tblKhachHangBindingSource
            // 
            this.tblKhachHangBindingSource.DataMember = "tblKhachHang";
            this.tblKhachHangBindingSource.DataSource = this._baitaplonC_DataSet1;
            // 
            // _baitaplonC_DataSet1
            // 
            this._baitaplonC_DataSet1.DataSetName = "_baitaplonC_DataSet1";
            this._baitaplonC_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKhachHangBindingSource, "DiaChi", true));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(700, 115);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(152, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Địa chỉ:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKhachHangBindingSource, "TenKhach", true));
            this.txtTenKhach.Enabled = false;
            this.txtTenKhach.Location = new System.Drawing.Point(700, 79);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(152, 22);
            this.txtTenKhach.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên khách hàng:";
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.DataSource = this.tblKhachHangBindingSource;
            this.cboMaKhach.DisplayMember = "MaKhach";
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(700, 39);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(152, 24);
            this.cboMaKhach.TabIndex = 9;
            this.cboMaKhach.ValueMember = "TenKhach";
            this.cboMaKhach.SelectedIndexChanged += new System.EventHandler(this.cboMaKhach_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã Khách hàng:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNhanVienBindingSource, "TenNV", true));
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(116, 157);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(152, 22);
            this.txtTenNV.TabIndex = 7;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this._baitaplonC_DataSet2;
            // 
            // _baitaplonC_DataSet2
            // 
            this._baitaplonC_DataSet2.DataSetName = "_baitaplonC_DataSet2";
            this._baitaplonC_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên NV:";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DataSource = this.tblNhanVienBindingSource;
            this.cboMaNV.DisplayMember = "MaNV";
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(116, 117);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(152, 24);
            this.cboMaNV.TabIndex = 5;
            this.cboMaNV.ValueMember = "TenNV";
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            this.cboMaNV.DisplayMemberChanged += new System.EventHandler(this.cboMaNV_DisplayMemberChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã NV:";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(116, 79);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(152, 22);
            this.dtpNgayBan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bán:";
            // 
            // txtSoHDB
            // 
            this.txtSoHDB.Location = new System.Drawing.Point(116, 41);
            this.txtSoHDB.Name = "txtSoHDB";
            this.txtSoHDB.Size = new System.Drawing.Size(152, 22);
            this.txtSoHDB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số HDB:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTKHoaDonBan);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 660);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 60);
            this.panel2.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(341, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(117, 34);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTKHoaDonBan
            // 
            this.txtTKHoaDonBan.Location = new System.Drawing.Point(116, 18);
            this.txtTKHoaDonBan.Name = "txtTKHoaDonBan";
            this.txtTKHoaDonBan.Size = new System.Drawing.Size(152, 22);
            this.txtTKHoaDonBan.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số HDB:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.dgvHoaDonBan);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtDonGiaBan);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboMaHang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 402);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết HDB";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(776, 271);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(152, 22);
            this.txtTongTien.TabIndex = 16;
            this.txtTongTien.Text = " ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(681, 271);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Tổng tiền:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(735, 324);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 34);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(517, 324);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 34);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(302, 324);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 34);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(95, 324);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 34);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(26, 105);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.RowHeadersWidth = 51;
            this.dgvHoaDonBan.RowTemplate.Height = 24;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(902, 163);
            this.dgvHoaDonBan.TabIndex = 24;
            this.dgvHoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonBan_CellClick);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(776, 55);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(152, 22);
            this.txtThanhTien.TabIndex = 23;
            this.txtThanhTien.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(682, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "Thành tiền:";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHangHoaBindingSource, "DonGiaBan", true));
            this.txtDonGiaBan.Enabled = false;
            this.txtDonGiaBan.Location = new System.Drawing.Point(776, 27);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(152, 22);
            this.txtDonGiaBan.TabIndex = 21;
            // 
            // tblDMHangHoaBindingSource
            // 
            this.tblDMHangHoaBindingSource.DataMember = "tblDMHangHoa";
            this.tblDMHangHoaBindingSource.DataSource = this._baitaplonC_DataSet;
            // 
            // _baitaplonC_DataSet
            // 
            this._baitaplonC_DataSet.DataSetName = "_baitaplonC_DataSet";
            this._baitaplonC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(682, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Đơn giá bán:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(465, 58);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(152, 22);
            this.txtGiamGia.TabIndex = 16;
            this.txtGiamGia.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Giảm giá:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHangHoaBindingSource, "TenHang", true));
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Location = new System.Drawing.Point(465, 29);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(152, 22);
            this.txtTenHang.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tên hàng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(116, 60);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(152, 22);
            this.txtSoLuong.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Số lượng:";
            // 
            // cboMaHang
            // 
            this.cboMaHang.DataSource = this.tblDMHangHoaBindingSource;
            this.cboMaHang.DisplayMember = "MaHang";
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(116, 25);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(152, 24);
            this.cboMaHang.TabIndex = 16;
            this.cboMaHang.ValueMember = "TenHang";
            this.cboMaHang.SelectedIndexChanged += new System.EventHandler(this.cboMaHang_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mã hàng:";
            // 
            // tblDMHangHoaTableAdapter
            // 
            this.tblDMHangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmDMHangHoaBindingSource
            // 
            this.frmDMHangHoaBindingSource.DataSource = typeof(Chuongtrinhquanlybanlycoc.frmDMHangHoa);
            // 
            // tblKhachHangTableAdapter
            // 
            this.tblKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonBan";
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._baitaplonC_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._baitaplonC_DataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._baitaplonC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDMHangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoHDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTKHoaDonBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label17;
        private _baitaplonC_DataSet _baitaplonC_DataSet;
        private System.Windows.Forms.BindingSource tblDMHangHoaBindingSource;
        private _baitaplonC_DataSetTableAdapters.tblDMHangHoaTableAdapter tblDMHangHoaTableAdapter;
        private System.Windows.Forms.BindingSource frmDMHangHoaBindingSource;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private _baitaplonC_DataSet1 _baitaplonC_DataSet1;
        private System.Windows.Forms.BindingSource tblKhachHangBindingSource;
        private _baitaplonC_DataSet1TableAdapters.tblKhachHangTableAdapter tblKhachHangTableAdapter;
        private _baitaplonC_DataSet2 _baitaplonC_DataSet2;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private _baitaplonC_DataSet2TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
    }
}