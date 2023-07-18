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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvKhachHang.DataSource = dtbase.DataReader("select * from tblKhachHang");
        }
        void xoadulieu()
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvKhachHang.Columns[0].HeaderText = " Mã Khách hàng";
            dgvKhachHang.Columns[1].HeaderText = " Tên Khách hàng";
            dgvKhachHang.Columns[2].HeaderText = " Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = " Điện thoại";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ấn vào gridview thì hiện lên
            try//cấm ấn linh tinh ko hiện lỗi
            {
                txtMaKhach.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKhach.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra nếu trống thì phải nhập
            if (txtMaKhach.Text.Trim() == "" || txtTenKhach.Text.Trim() == "" ||
                txtDiaChi.Text.Trim() =="" || txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            string makhach = txtMaKhach.Text;
            DataTable dtKhachHang = dtbase.DataReader("Select * from tblKhachHang where MaKhach ='" + makhach + "'");
            if (dtKhachHang.Rows.Count > 0)//đã tồn tại mã rồi 
            {
                MessageBox.Show("Mã khách đã có, bạn phải nhập mã khác", "Thông báo");
                txtMaKhach.Focus();
                return;

            }
            //THÊM NHÂN VIÊN
            dtbase.DataChange("Insert into  tblKhachHang values ('" + makhach + "', N'"+txtTenKhach.Text+"', N'"+txtDiaChi.Text+"', N'" + txtDienThoai.Text + "')");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text.Trim() == "" || txtTenKhach.Text.Trim() == ""
                || txtDiaChi.Text.Trim() == "" || txtDienThoai.Text.Trim() =="") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn phải nhập dữ liệu", "Thông báo");
                return;

            }

            dtbase.DataChange("update tblKhachHang set TenKhach = N'" + txtTenKhach.Text
                + "',DiaChi = N'"+txtDiaChi.Text+"',DienThoai = N'"+txtDienThoai.Text+"' where MaKhach = '" + txtMaKhach.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa khách hàng có mã " + txtMaKhach.Text + " không",
    "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblKhachHang where MaKhach =('" + txtMaKhach.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoadulieu();
            }
        }

        private void btnTHoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
