using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuongtrinhquanlybanlycoc
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvHoaDonNhap.DataSource = dtbase.DataReader("select * from tblChiTietHDN ");
        }
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_baitaplonC_DataSet8.tblDMHangHoa' table. You can move, or remove it, as needed.
            this.tblDMHangHoaTableAdapter.Fill(this._baitaplonC_DataSet8.tblDMHangHoa);
            // TODO: This line of code loads data into the '_baitaplonC_DataSet7.tblNhaCungCap' table. You can move, or remove it, as needed.
            this.tblNhaCungCapTableAdapter.Fill(this._baitaplonC_DataSet7.tblNhaCungCap);
            // TODO: This line of code loads data into the '_baitaplonC_DataSet6.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this._baitaplonC_DataSet6.tblNhanVien);
            // TODO: This line of code loads data into the '_baitaplonC_DataSet4.tblCHiTietHDN' table. You can move, or remove it, as needed.
            this.tblCHiTietHDNTableAdapter.Fill(this._baitaplonC_DataSet4.tblCHiTietHDN);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvHoaDonNhap.Columns[0].HeaderText = "Số HDN";
            dgvHoaDonNhap.Columns[1].HeaderText = "Mã hàng";
            dgvHoaDonNhap.Columns[2].HeaderText = "Số lượng";
            dgvHoaDonNhap.Columns[3].HeaderText = "Đơn giá";
            dgvHoaDonNhap.Columns[4].HeaderText = "Giảm giá";
            dgvHoaDonNhap.Columns[5].HeaderText = "Thành Tiền";
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;

            try
            {
                txtSoHDN.Text = dgvHoaDonNhap.CurrentRow.Cells[0].Value.ToString();
                cboMaHang.Text = dgvHoaDonNhap.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dgvHoaDonNhap.CurrentRow.Cells[2].Value.ToString();
                txtDonGiaNhap.Text = dgvHoaDonNhap.CurrentRow.Cells[3].Value.ToString();
                txtGiamGia.Text = dgvHoaDonNhap.CurrentRow.Cells[4].Value.ToString();
                txtThanhTien.Text = dgvHoaDonNhap.CurrentRow.Cells[5].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int DonGia = Convert.ToInt32(txtSoLuong.Text);
            double giamgia = Convert.ToDouble(txtGiamGia.Text);
            double thanhtien = ((double)DonGia * (double)soluong) - ((double)DonGia * (double)soluong) * ((giamgia) / 100);
            txtThanhTien.Text = thanhtien.ToString();

            int sc = dgvHoaDonNhap.Rows.Count;
            float Tongtien = 0;
            for (int i = 0; i < sc - 1; i++)
                Tongtien += float.Parse(dgvHoaDonNhap.Rows[i].Cells[5].Value.ToString());
            txtTongTien.Text = Tongtien.ToString();
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
           
            //kiểm tra nếu trống thì phải nhập
            if (txtSoHDN.Text.Trim() == "" || cboMaHang.Text.Trim() == "" )
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            string SoHDN = txtSoHDN.Text;
            DataTable dtHDN = dtbase.DataReader("Select * from tblChiTietHDN where SoHDN ='" + SoHDN + "'");
            if (dtHDN.Rows.Count > 0)//đã tồn tại mã rồi 
            {
                MessageBox.Show("Số HDN đã có, bạn phải nhập mã khác", "Thông báo");
                txtSoHDN.Focus();
                return;

            }
            //THÊM
            dtbase.DataChange("insert into tblChiTietHDN values ('" + SoHDN + "', '" + cboMaHang.Text + "', '" + txtSoLuong.Text + "', '" + txtDonGiaNhap.Text + "', '" + txtGiamGia.Text + "', '" + txtThanhTien.Text + "' )");

            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Ẩn hai nút Thêm và Xóa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            int SoLuong = Convert.ToInt32(txtSoLuong.Text);
            int DonGiaBan = Convert.ToInt32(txtDonGiaNhap.Text);
            double giamgia = Convert.ToDouble(txtGiamGia.Text);
            double ThanhTien = ((double)DonGiaBan * (double)SoLuong) - ((double)DonGiaBan * (double)SoLuong) * ((giamgia) / 100);
            txtThanhTien.Text = ThanhTien.ToString();

            int sc = dgvHoaDonNhap.Rows.Count;
            float tongtien = 0;
            for (int i = 0; i < sc - 1; i++)
                tongtien += float.Parse(dgvHoaDonNhap.Rows[i].Cells[5].Value.ToString());
            txtTongTien.Text = tongtien.ToString();
            //SỬA
            if (txtSoHDN.Text == "" || cboMaHang.Text == "" || txtSoLuong.Text == "" || txtGiamGia.Text == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }

            dtbase.DataChange("update tblChiTietHDN set MaHang ='" + cboMaHang.Text + "', SoLuong = '" + txtSoLuong.Text +
      "', DonGia = '" + txtDonGiaNhap.Text + "', GiamGia = '" + txtGiamGia.Text + "', ThanhTien = '" + txtThanhTien.Text + "' where SoHDN = '" + txtSoHDN.Text + "' ");

            MessageBox.Show("Thành công");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Lựa chọn",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.DataChange("delete tblChiTietHDN where SoHDN= '" + txtSoHDN.Text + "'");
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            LoadData();
            xoatrangdulieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //CẤM NÚT XÓA VÀ SỬA
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //viết câu lệnh sql cho tìm kiếm
            string sql = "SELECT * FROM tblChiTietHDN where SoHDN is not null";
            //tìm theo mã sp khác
            if (txtTKHoaDonNhap.Text.Trim() != "")
            {
                sql += " and  SoHDN like '%" + txtTKHoaDonNhap.Text + "%'";
            }
            LoadData();
        }
        void xoatrangdulieu()
        {
            txtSoHDN.Text = "";
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            cboMaNV.Text = "";
            dtpNgayNhap.Text = "";
            cboMaNCC.Text = "";
            txtTongTien.Text = "";
        }
    }
}
