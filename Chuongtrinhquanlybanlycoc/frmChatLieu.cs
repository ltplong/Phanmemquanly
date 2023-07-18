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
    public partial class frmChatLieu : Form
    {
        public frmChatLieu()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvChatLieu.Columns[0].HeaderText = " Mã chất liệu";
            dgvChatLieu.Columns[1].HeaderText = " Tên chất liệu (thủy tinh, nhựa,...)";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                )==DialogResult.Yes)
            {
                this.Close();
            }    
        }
        void LoadData()
        {
            dgvChatLieu.DataSource = dtbase.DataReader("select * from tblChatLieu");
        }
        void xoadulieu()
        {
            txtMaCL.Text = "";
            txtTenCL.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra trống thì phải nhập
            if (txtMaCL.Text == "" || txtTenCL.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string maCL = txtMaCL.Text;
            DataTable dtChatLieu = dtbase.DataReader("Select * from tblChatLieu where MaChatLieu ='" + maCL + "'");
            if (dtChatLieu.Rows.Count > 0)
            {
                MessageBox.Show("đã có chất liệu với mã " + maCL + " Bạn hãy nhập mã khác");
                txtMaCL.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblChatLieu values ('" + maCL + "', N'" + txtTenCL.Text + "')");
            //load lại dữ liệu
            LoadData();
            xoadulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaCL.Text == "" || txtTenCL.Text == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }
            

            dtbase.DataChange("update tblChatLieu set TenChatLieu = N'" + txtTenCL.Text + "' where MaChatLieu = '" + txtMaCL.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            try
            {
                txtMaCL.Text = dgvChatLieu.CurrentRow.Cells[0].Value.ToString();
                txtTenCL.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa chất liệu có mã " + txtMaCL.Text + "không",
                "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblChatLieu where MaChatLieu =('" + txtMaCL.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoadulieu();
            }
        }
    }
}
