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
    public partial class frmNoiSXcs : Form
    {
        public frmNoiSXcs()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData ()
        {
            dgvNoiSx.DataSource = dtbase.DataReader("select * from tblNoiSX");
        }
        void xoadulieu ()
        {
            txtMaNoiSX.Text = "";
            txtNoiSX.Text = "";
        }
        private void frmNoiSXcs_Load(object sender, EventArgs e)
        {

            //load dữ liệu lên gridview
            LoadData();
            dgvNoiSx.Columns[0].HeaderText = " Mã nơi SX";
            dgvNoiSx.Columns[1].HeaderText = " Nơi SX";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvNoiSx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                txtMaNoiSX.Text = dgvNoiSx.CurrentRow.Cells[0].Value.ToString();
                txtNoiSX.Text = dgvNoiSx.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //kiểm tra trống thì phải nhập
            if (txtMaNoiSX.Text == "" || txtNoiSX.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string maNoiSX = txtMaNoiSX.Text;
            DataTable dtNoiSX = dtbase.DataReader("Select * from tblNoiSX where MaNoiSX ='" + maNoiSX + "'");
            if (dtNoiSX.Rows.Count > 0)
            {
                MessageBox.Show("đã có nơi sản suất với mã " + maNoiSX + " Bạn hãy nhập mã khác");
                txtMaNoiSX.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblNoiSX values ('" + maNoiSX + "', N'" + txtNoiSX.Text + "')");
            //load lại dữ liệu
            LoadData();
            xoadulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNoiSX.Text == "" || txtNoiSX.Text == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }
            dtbase.DataChange("update tblNoiSX set TenNoiSX = N'" + txtNoiSX.Text + "' where MaNoiSX = '" + txtMaNoiSX.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa nơi sản xuất có mã " + txtMaNoiSX.Text + " không",
               "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblNoiSX where MaNoiSX =('" + txtMaNoiSX.Text + "')";
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
