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
    public partial class frmLoai : Form
    {
        public frmLoai()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        private void frmLoai_Load(object sender, EventArgs e)
        {
            
            //load dữ liệu lên gridview
            LoadData();
            dgvLoai.Columns[0].HeaderText = " Mã loại";
            dgvLoai.Columns[1].HeaderText = " Tên loại (ly,cốc,...)";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //CẬP NHẬT TIÊU ĐỀ
            lblTieuDefrmLoai.Text = "TÌM KIẾM LOẠI HÀNG";
            //CẤM NÚT SỬA VÀ XÓA
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //VIẾT CÂU LỆNH CHO SQL TÌM LOẠI
            string sql = " Select * from tblLoai where MaLoai is not null";
            //tim theo MaLoai khac rong
            if (txtMaLoai.Text.Trim() != "")
            {
                sql += " and MaLoai like '%" + txtMaLoai.Text + "'%";
            }    
            //kiểm tra tên loại
            if (txtTenLoai.Text.Trim() != "")
            {
                sql += "and TenLoai like  N'%" + txtTenLoai.Text + "'%";
            }
            //load dữ liệu lên gridview
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra trống thì phải nhập
            if (txtMaLoai.Text == "" || txtTenLoai.Text=="" )
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }    
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string maLoai = txtMaLoai.Text;
            DataTable dtChatLieu = dtbase.DataReader("Select * from tblLoai where MaLoai ='" + maLoai + "'");
            if (dtChatLieu.Rows.Count > 0)
            {
                MessageBox.Show("đã có loại với mã" + maLoai + "Bạn hãy nhập mã khác");
                txtMaLoai.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblLoai values ('" + maLoai + "', N'" + txtTenLoai.Text + "')");
            //load lại dữ liệu
            LoadData();
            xoadulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text==""||txtTenLoai.Text =="") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   return;

            }    
            //Cập nhật tiêu đề
            lblTieuDefrmLoai.Text = "CẬP NHẬT MẶT HÀNG";
          
            dtbase.DataChange("update tblLoai set TenLoai = N'" + txtTenLoai.Text + "' where MaLoai = '" + txtMaLoai.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }


        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                txtMaLoai.Text = dgvLoai.CurrentRow.Cells[0].Value.ToString();
                txtTenLoai.Text = dgvLoai.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa loại có mã " + txtMaLoai.Text + " không",
                "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblLoai where MaLoai =('" + txtMaLoai.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoadulieu();
            }
        }
        void LoadData ()
        {
            dgvLoai.DataSource = dtbase.DataReader("select * from tblLoai");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.Yes) 
            this.Close(); 
        }
        void xoadulieu()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
