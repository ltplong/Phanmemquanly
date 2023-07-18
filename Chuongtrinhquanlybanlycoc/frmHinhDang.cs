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
    public partial class frmHinhDang : Form
    {
        public frmHinhDang()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvHinhDang.DataSource = dtbase.DataReader("select * from tblHinhDang");
        }
        void xoadulieu()
        {
            txtMaHinhDang.Text = "";
            txtHinhDang.Text = "";
        }
        private void frmHinhDang_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvHinhDang.Columns[0].HeaderText = " Mã hình dạng";
            dgvHinhDang.Columns[1].HeaderText = " hình dạng (Tròn, vuông,...)";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvHinhDang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ấn vào gridview hiện lên txt
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                txtMaHinhDang.Text = dgvHinhDang.CurrentRow.Cells[0].Value.ToString();
                txtHinhDang.Text = dgvHinhDang.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra trống thì phải nhập
            if (txtMaHinhDang.Text == "" || txtHinhDang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string maHinhDang = txtMaHinhDang.Text;
            DataTable dtHinhDang = dtbase.DataReader("Select * from tblHinhDang where MaHinhDang ='" + maHinhDang + "'");
            if (dtHinhDang.Rows.Count > 0)
            {
                MessageBox.Show("đã có hình dạng với mã" + maHinhDang + "Bạn hãy nhập mã khác");
                txtMaHinhDang.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblHinhDang values ('" + maHinhDang + "', N'" + txtHinhDang.Text + "')");
            //load lại dữ liệu
            LoadData();
            xoadulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHinhDang.Text == "" || txtHinhDang.Text == "") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }
            //Cập nhật tiêu đề
            lblHinhDang.Text = "CẬP NHẬT HÌNH DẠNG";

            dtbase.DataChange("update tblHinhDang set HinhDang = N'" + txtHinhDang.Text + "' where MaHinhDang = '" + txtMaHinhDang.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa hình dạng có mã " + txtMaHinhDang.Text + " không",
              "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblHinhDang where MaHinhDang =('" + txtMaHinhDang.Text + "')";
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
