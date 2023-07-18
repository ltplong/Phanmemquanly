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
    public partial class frmNhaCC : Form
    {
        public frmNhaCC()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvNhaCC.DataSource = dtbase.DataReader("select * from tblNhaCungCap ");
        }
        void xoadulieu()
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvNhaCC.Columns[0].HeaderText = " Mã NCC";
            dgvNhaCC.Columns[1].HeaderText = " Tên NCC ";
            dgvNhaCC.Columns[2].HeaderText = " Địa chỉ";
            dgvNhaCC.Columns[3].HeaderText = " Điện thoại";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ấn vào gridview thì hiện lên
            try//cấm ấn linh tinh ko hiện lỗi
            {
                txtMaNCC.Text = dgvNhaCC.CurrentRow.Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNhaCC.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaCC.CurrentRow.Cells[2].Value.ToString();
                txtDienThoai.Text = dgvNhaCC.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra nếu trống thì phải nhập
            if (txtMaNCC.Text.Trim() == "" || txtTenNCC.Text.Trim() == "" ||
                txtDiaChi.Text.Trim() == "" || txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            string mancc = txtMaNCC.Text;
            DataTable dtnhaCC = dtbase.DataReader("Select * from tblNhaCungCap where MaNCC ='" + mancc + "'");
            if (dtnhaCC.Rows.Count > 0)//đã tồn tại mã rồi 
            {
                MessageBox.Show("Mã nhà cung cấp đã có, bạn phải nhập mã khác", "Thông báo");
                txtMaNCC.Focus();
                return;

            }
            //THÊM NHÂN VIÊN
            dtbase.DataChange("Insert into  tblNhaCungCap values ('" + mancc + "', N'" + txtTenNCC.Text + "', N'" + txtDiaChi.Text + "', N'" + txtDienThoai.Text + "')");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() == "" || txtTenNCC.Text.Trim() == ""
                || txtDiaChi.Text.Trim() == "" || txtDienThoai.Text.Trim() == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn phải nhập dữ liệu", "Thông báo");
                return;

            }

            dtbase.DataChange("update tblNhaCungCap set TenNCC = N'" + txtTenNCC.Text
                + "',DiaChi = N'" + txtDiaChi.Text + "',DienThoai = N'" + txtDienThoai.Text + "' where MaNCC = '" + txtMaNCC.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" bạn có muốn xóa nhà cung cấp có mã " + txtMaNCC.Text + " không",
    "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblNhaCungCap where MaNCC =('" + txtMaNCC.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoadulieu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
