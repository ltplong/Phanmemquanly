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
    public partial class frmDacDiem : Form
    {
        public frmDacDiem()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
                dgvDacDiem.DataSource = dtbase.DataReader("select * from tblDacDiem");
        }
        void xoadulieu()
        {
            txtMaDacDiem.Text = "";
            txtTenDacDiem.Text = "";
            txtMaDacDiem.Focus();
        }
        private void frmDacDiem_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvDacDiem.Columns[0].HeaderText = " Mã đặc điểm";
            dgvDacDiem.Columns[1].HeaderText = " Tên đặc điểm";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDacDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
            try
            {
                txtMaDacDiem.Text = dgvDacDiem.CurrentRow.Cells[0].Value.ToString();
                txtTenDacDiem.Text = dgvDacDiem.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra trống thì phải nhập
            if (txtMaDacDiem.Text == "" || txtTenDacDiem.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string madacdiem = txtMaDacDiem.Text;
            DataTable dtChatLieu = dtbase.DataReader("Select * from tblDacDiem where MaDacDiem ='" + madacdiem + "'");
            if (dtChatLieu.Rows.Count > 0)
            {
                MessageBox.Show("đã có đặc điểm với mã" + madacdiem + " Bạn hãy nhập mã khác");
                txtMaDacDiem.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblDacDiem values ('" + madacdiem + "', N'" + txtTenDacDiem.Text + "')");
            //load lại dữ liệu
            LoadData();
            xoadulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDacDiem.Text == "" || txtTenDacDiem.Text == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }

            dtbase.DataChange("update tblDacDiem set TenDacDiem = N'" + txtTenDacDiem.Text + "' where MaDacDiem = '" + txtMaDacDiem.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa đặc điểm có mã " + txtMaDacDiem.Text + " không",
               "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblDacDiem where MaDacDiem =('" + txtMaDacDiem.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoadulieu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
