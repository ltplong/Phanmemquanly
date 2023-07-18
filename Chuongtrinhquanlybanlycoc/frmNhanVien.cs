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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            
                dgvNhanVien.DataSource = dtbase.DataReader("select * from tblNhanVien");
            //kết nối với bảng khác bằng cbo
            
        }
        void xoatrangdulieu()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDienThoai.Text = "";
            txtPass.Text = "";
            cboMaCV.Text = "";
            txtDiaChi.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_baitaplonC_DataSet3.tblCongViec' table. You can move, or remove it, as needed.
            this.tblCongViecTableAdapter.Fill(this._baitaplonC_DataSet3.tblCongViec);
            //load dữ liệu lên gridview
            LoadData();

            dgvNhanVien.Columns[0].HeaderText = " Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = " Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = " Giới tính";
            dgvNhanVien.Columns[3].HeaderText = " Ngày sinh ";
            dgvNhanVien.Columns[4].HeaderText = " Điện thoại";
            dgvNhanVien.Columns[5].HeaderText = " Địa chỉ ";
            dgvNhanVien.Columns[6].HeaderText = " Mã công việc";
            dgvNhanVien.Columns[7].HeaderText = " Mật khẩu";
           
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra nếu trống thì phải nhập
            if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" ||
                (rdoNam.Checked == false && rdoNu.Checked == false) ||
                cboMaCV.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text =="" || dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            string maNV = txtMaNV.Text;
            DataTable dtNhanVien = dtbase.DataReader("Select * from tblNhanVien where MaNV ='" + maNV + "'");
            if (dtNhanVien.Rows.Count > 0)//đã tồn tại mã rồi 
            {
                MessageBox.Show("Mã NV đã có, bạn phải nhập mã khác");
                txtMaNV.Focus();
                return;

            }
            //THÊM NHÂN VIÊN
            string gioitinh = "";
            if (rdoNam.Checked == true)
                gioitinh = "Nam";
            if (rdoNu.Checked == true)
                gioitinh = "Nữ";
            dtbase.DataChange("Insert into  tblNhanVien values ('"+maNV+"', N'"+txtTenNV.Text+"',N'" +gioitinh+
                "', N'"+dtpNgaySinh.Value.Date +"', N'" + txtDienThoai.Text + "', N'"+txtDiaChi.Text+"' ,'"+cboMaCV.Text+"', '"+txtPass.Text+"')");
            LoadData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ấn vào gridview thì hiện lên
            try
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                if (dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dtpNgaySinh.Value = (DateTime)dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value;
                txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
                cboMaCV.Text = dgvNhanVien.CurrentRow.Cells["MaCV"].Value.ToString();
                txtPass.Text = dgvNhanVien.CurrentRow.Cells["PassWord"].Value.ToString();
            }
            catch { }
            
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" ||
                (rdoNam.Checked == false && rdoNu.Checked == false) ||
                cboMaCV.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "" || dtpNgaySinh.Text == ""|| txtPass.Text =="")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu","Thông báo");
                return;
            }
            string gioitinh = "";
            if (rdoNam.Checked == true)
                gioitinh = "Nam";
            if (rdoNu.Checked == true)
                gioitinh = "Nữ";
            dtbase.DataChange("update tblNhanVien set TenNV = N'"+txtTenNV.Text+"',GioiTinh = N'"+gioitinh+
                "', NgaySinh = '"+dtpNgaySinh.Value.Date+"', DienThoai='"+txtDienThoai.Text+"', DiaChi =N'"+txtDiaChi.Text+
                "',PassWord =N'"+txtPass.Text+"', MaCV = '"+cboMaCV.Text+"' where MaNV = '" + txtMaNV.Text + "'");
            MessageBox.Show("Thành công!");
            LoadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            xoatrangdulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            string gioitinh = "";
            if (rdoNam.Checked == true)
                gioitinh = "Nam";
            if (rdoNu.Checked == true)
                gioitinh = "Nữ";

            if (MessageBox.Show("Bạn có muốn xóa không", "Lựa chọn",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.DataChange("delete tblNhanVien where MaNV= '" + txtMaNV.Text + "'");
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            LoadData();
            xoatrangdulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
