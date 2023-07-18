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
    public partial class frmCongViec : Form
    {
        public frmCongViec()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvCongViec.DataSource = dtbase.DataReader("select * from tblCongViec");
        }
        void xoadulieu()
        {
            txtMaCongViec.Text = "";
            txtMucLuong.Text = "";
            cbbCongViec.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra trống thì phải nhập
            if (txtMaCongViec.Text == "" || cbbCongViec.Text == "" || txtMucLuong.Text=="")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            //kiểm tra mã có trùng không trc khi thêm vào csdl
            string maCV = txtMaCongViec.Text;
            DataTable dtChatLieu = dtbase.DataReader("Select * from tblCongViec where MaCongViec ='" + maCV + "'");
            if (dtChatLieu.Rows.Count > 0)
            {
                MessageBox.Show("đã có công việc với mã" + maCV + "Bạn hãy nhập mã khác");
                txtMaCongViec.Focus();
                return;
            }
            //taoh câu lệnh sql
            dtbase.DataChange("Insert into tblCongViec values ('" + maCV + "', N'" + cbbCongViec.Text + "', '"+txtMucLuong.Text+"')");
            //load lại dữ liệu
            LoadData();
            xoadulieu();
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();
            dgvCongViec.Columns[0].HeaderText = " Mã công việc ";
            dgvCongViec.Columns[1].HeaderText = " Công việc ";
            dgvCongViec.Columns[2].HeaderText = " Mức lương ";
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ấn vào datagridview thì hiện lên txt
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                txtMaCongViec.Text = dgvCongViec.CurrentRow.Cells[0].Value.ToString();
                cbbCongViec.Text = dgvCongViec.CurrentRow.Cells[1].Value.ToString();
                txtMucLuong.Text = dgvCongViec.CurrentRow.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCongViec.Text == "" || cbbCongViec.Text == "" || txtMucLuong.Text =="") //chưa chọn thì báo lỗi
            {
                MessageBox.Show("bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;

            }
            dtbase.DataChange("update tblCongViec set TenCongViec = N'" + cbbCongViec.Text 
                + "', MucLuong = N'"+txtMucLuong.Text+"' where MaCongViec = '" + txtMaCongViec.Text + "'");
            MessageBox.Show("Thành công");
            LoadData();
            //Ẩn hai nút Thêm và Xóa

            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            xoadulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" bạn có muốn xóa công việc có mã " + txtMaCongViec.Text + " không ",
               "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "delete tblCongViec where MaCongViec =('" + txtMaCongViec.Text + "')";
                dtbase.DataChange(sqlDelete);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                LoadData();
                xoadulieu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            this.Close();
        }
    }
}
