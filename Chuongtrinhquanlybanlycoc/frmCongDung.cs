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
    public partial class frmCongDung : Form
    {
        public frmCongDung()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            {
                dgvCongdung.DataSource = dtbase.DataReader("select * from tblCongDung");
            }
        }
        void xoatrangdulieu()
        {
            txtMaCongDung.Text = "";
            txtCongDung.Text = "";
        }
        private void frmCongDung_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvCongdung.Columns[0].HeaderText = " Mã công dụng";
            dgvCongdung.Columns[1].HeaderText = " Tên công dụng";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra trống thì phải nhập
            if (txtMaCongDung.Text == "" || txtCongDung.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string macongdung = txtMaCongDung.Text;
            DataTable dtChatLieu = dtbase.DataReader("Select * from tblCongDung where MaCongDung ='" + macongdung + "'");
            if (dtChatLieu.Rows.Count > 0)
            {
                MessageBox.Show("đã có công dụng với mã" + macongdung + "Bạn hãy nhập mã khác");
                txtMaCongDung.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblCongDung values ('" + macongdung + "', N'" + txtCongDung.Text + "')");
            //load lại dữ liệu
            LoadData();
            xoatrangdulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCongDung.Text == "" || txtCongDung.Text == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }
            //Cập nhật tiêu đề
            lblCapNhat.Text = "CẬP NHẬT CÔNG DỤNG";

            dtbase.DataChange("update tblCongDung set TenCongDung = N'" + txtCongDung.Text + "' where MaCongDung = '" + txtMaCongDung.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoatrangdulieu();
        }

        private void dgvCongdung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
            try
            {
                txtMaCongDung.Text = dgvCongdung.CurrentRow.Cells[0].Value.ToString();
                txtCongDung.Text = dgvCongdung.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa công dụng có mã " + txtMaCongDung.Text + " không ",
                "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblCongDung where MaCongDung =('" + txtMaCongDung.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoatrangdulieu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
