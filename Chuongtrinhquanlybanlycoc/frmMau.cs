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
    public partial class frmMau : Form
    {
        public frmMau()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvMauSac.DataSource = dtbase.DataReader("select * from tblMau");
        }
        void xoadulieu()
        {
            txtMaMau.Text = "";
            txtMauSac.Text = "";
        }
        private void frmMau_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvMauSac.Columns[0].HeaderText = " Mã màu ";
            dgvMauSac.Columns[1].HeaderText = " Màu sắc )";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvMauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                txtMaMau.Text = dgvMauSac.CurrentRow.Cells[0].Value.ToString();
                txtMauSac.Text = dgvMauSac.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            //kiểm tra trống thì phải nhập
            if (txtMaMau.Text == "" || txtMauSac.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string maMau = txtMaMau.Text;
            DataTable dtMauSac = dtbase.DataReader("Select * from tblMau where MaMau ='" + maMau + "'");
            if (dtMauSac.Rows.Count > 0)
            {
                MessageBox.Show("đã có màu với mã " + maMau + " Bạn hãy nhập mã khác");
                txtMaMau.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblMau values ('" + maMau + "', N'" + txtMauSac.Text + "')");
            //load lại dữ liệu
            LoadData();
            xoadulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaMau.Text == "" || txtMauSac.Text == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }

            dtbase.DataChange("update tblMau set TenMau = N'" + txtMauSac.Text + "' where MaMau = '" + txtMaMau.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa màu có mã " + txtMaMau.Text + " không",
                "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblMau where MaMau =('" + txtMaMau.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoadulieu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
