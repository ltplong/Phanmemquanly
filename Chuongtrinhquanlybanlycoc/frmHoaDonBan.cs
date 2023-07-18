using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuongtrinhquanlybanlycoc
{
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvHoaDonBan.DataSource = dtbase.DataReader("select * from tblChiTietHDB");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            
        
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_baitaplonC_DataSet2.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this._baitaplonC_DataSet2.tblNhanVien);
            // TODO: This line of code loads data into the '_baitaplonC_DataSet1.tblKhachHang' table. You can move, or remove it, as needed.
            this.tblKhachHangTableAdapter.Fill(this._baitaplonC_DataSet1.tblKhachHang);
            // TODO: This line of code loads data into the '_baitaplonC_DataSet.tblDMHangHoa' table. You can move, or remove it, as needed.
            this.tblDMHangHoaTableAdapter.Fill(this._baitaplonC_DataSet.tblDMHangHoa);
            LoadData();
            
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvHoaDonBan.Columns[0].HeaderText = "Số HDB";
            dgvHoaDonBan.Columns[1].HeaderText = "Mã hàng";
            dgvHoaDonBan.Columns[2].HeaderText = "Số lượng";
            dgvHoaDonBan.Columns[3].HeaderText = "Giảm giá %";
            dgvHoaDonBan.Columns[4].HeaderText = "Thành tiền";


        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboMaNV_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
           
           try
            {
                txtSoHDB.Text = dgvHoaDonBan.CurrentRow.Cells[0].Value.ToString();
                cboMaHang.Text = dgvHoaDonBan.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dgvHoaDonBan.CurrentRow.Cells[2].Value.ToString();
                txtGiamGia.Text = dgvHoaDonBan.CurrentRow.Cells[3].Value.ToString();
                txtThanhTien.Text = dgvHoaDonBan.CurrentRow.Cells[4].Value.ToString();
            }
            catch { }
    
        }
        private void XoaTrangChiTiet()
        {
            txtSoHDB.Text = "";
            txtTenHang.Text = "";
            cboMaHang.Text = "";
            cboMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtTenNV.Text = "";
            cboMaNV.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            double SoLuong = Convert.ToDouble(txtSoLuong.Text);
            double DonGiaBan = Convert.ToDouble(txtDonGiaBan.Text);
            double giamgia = Convert.ToDouble(txtGiamGia.Text);
            double ThanhTien = ((double)DonGiaBan * (double)SoLuong) - ((double)DonGiaBan * (double)SoLuong) * ((giamgia)/100);
            txtThanhTien.Text = ThanhTien.ToString();

            int sc = dgvHoaDonBan.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHoaDonBan.Rows[i].Cells[4].Value.ToString());
            txtTongTien.Text = thanhtien.ToString();
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            string SoHDB = txtSoHDB.Text;
            DataTable dtHDB = dtbase.DataReader("select * from tblChiTietHDB where SoHDB = '" + SoHDB + "'");
            if (dtHDB.Rows.Count > 0)//đã tồn tại mã rồi 
            {
                MessageBox.Show(" Số HDB đã có, bạn phải nhập mã khác");
                txtSoHDB.Focus();
                return;
            }
            if (dtpNgayBan.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayBan.Focus();
                return;
            }
            if (cboMaNV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNV.Focus();
                return;
            }
            if (cboMaKhach.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaKhach.Focus();
                return;
            }
            
            dtbase.DataChange("Insert into tblChiTietHDB values ('" + txtSoHDB.Text + "','" + cboMaHang.Text + "', '" + txtSoLuong.Text + "', '" + txtGiamGia.Text + "', '" + txtThanhTien.Text + "')");
          
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Ẩn hai nút Thêm và Xóa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            int SoLuong = Convert.ToInt32(txtSoLuong.Text);
            int DonGiaBan = Convert.ToInt32(txtDonGiaBan.Text);
            double giamgia = Convert.ToDouble(txtGiamGia.Text);
            double ThanhTien = ((double)DonGiaBan * (double)SoLuong) - ((double)DonGiaBan * (double)SoLuong) * ((giamgia) / 100);
            txtThanhTien.Text = ThanhTien.ToString();
            int sc = dgvHoaDonBan.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHoaDonBan.Rows[i].Cells[4].Value.ToString());
            txtTongTien.Text = thanhtien.ToString();

            //Sửa
            if (txtSoHDB.Text == "" || cboMaHang.Text == "" || txtSoLuong.Text == "" || txtGiamGia.Text =="") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }


            dtbase.DataChange("update tblChiTietHDB set MaHang = N'" + cboMaHang.Text + "', SoLuong = '"+txtSoLuong.Text+
                "', GiamGia = '"+txtGiamGia.Text+"', ThanhTien = '"+txtThanhTien.Text+"' where SoHDB = '" + txtSoHDB.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //CẤM NÚT XÓA VÀ SỬA
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //viết câu lệnh sql cho tìm kiếm
            string sql = "SELECT * FROM tblChiTietHDB where SoHDB is not null";
            //tìm theo mã sp khác
            if (txtTKHoaDonBan.Text.Trim() != "")
            {
                sql += " and  SoHDB like '%" + txtTKHoaDonBan.Text + "%'";
            }
            LoadData();
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Lựa chọn",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.DataChange("delete tblChiTietHDB where SoHDB= '" + txtSoHDB.Text + "'");
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
