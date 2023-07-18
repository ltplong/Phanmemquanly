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
    public partial class frmDMHangHoa : Form
    {
        public frmDMHangHoa()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        void LoadData()
        {
            dgvHangHoa.DataSource = dtbase.DataReader("select * from tblDMHangHoa");

            cboCongDung.DataSource = dtbase.DataReader("select * from tblCongDung");
            cboCongDung.DisplayMember = "TenCongDung";
            cboCongDung.ValueMember = "MaCongDung";

            cboMaChatLieu.DataSource = dtbase.DataReader("select * from tblChatLieu");
            cboMaChatLieu.DisplayMember = "MaChatLieu";
            cboMaChatLieu.ValueMember = "TenChatLieu";

            cboMaDacDiem.DataSource = dtbase.DataReader("select * from tblDacDiem");
            cboMaDacDiem.DisplayMember = "MaDacDiem";
            cboMaDacDiem.ValueMember = "TenDacDiem";

            cboMaHinhDang.DataSource = dtbase.DataReader("select * from tblHinhDang");
            cboMaHinhDang.DisplayMember = "MaHinhDang";
            cboMaHinhDang.ValueMember = "HinhDang";

            cboMaLoai.DataSource = dtbase.DataReader("select * from tblLoai");
            cboMaLoai.DisplayMember = "MaLoai";
            cboMaLoai.ValueMember = "TenLoai";

            cboMaMau.DataSource = dtbase.DataReader("select * from tblMau");
            cboMaMau.DisplayMember = "MaMau";
            cboMaMau.ValueMember = "TenMau";

            cboMaNoiSX.DataSource = dtbase.DataReader("select *from tblNoiSX");
            cboMaNoiSX.DisplayMember = "MaNoiSX";
            cboMaNoiSX.ValueMember = "TenNoiSX";
        }
        private void HienChiTiet(bool hien)
        {
            txtMaHang.Enabled = hien;
            txtTenHang.Enabled = hien;
            cboMaLoai.Enabled = hien;
            cboMaHinhDang.Enabled = hien;
            cboMaChatLieu.Enabled = hien;
            cboCongDung.Enabled = hien;
            cboMaDacDiem.Enabled = hien;
            cboMaMau.Enabled = hien;
            cboMaNoiSX.Enabled = hien;
            txtDonGiaNhap.Enabled = hien;
            txtDonGiaBan.Enabled = hien;
            txtThoiGianBH.Enabled = hien;
            txtAnh.Enabled = hien;
            txtGhiChu.Enabled = hien;

            // ẩn hiện 2 nút lưu và hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }
        private void frmDMHangHoa_Load(object sender, EventArgs e)
        {
            //load dữ liệu lên gridview
            LoadData();

            dgvHangHoa.Columns[0].HeaderText = " Mã hàng";
            dgvHangHoa.Columns[1].HeaderText = " Tên hàng";
            dgvHangHoa.Columns[2].HeaderText = " Tên loại";
            dgvHangHoa.Columns[3].HeaderText = " Mã hình dạng ";
            dgvHangHoa.Columns[4].HeaderText = " Mã chất liệu";
            dgvHangHoa.Columns[5].HeaderText = " Công dụng";
            dgvHangHoa.Columns[6].HeaderText = " Mã đặc điểm";
            dgvHangHoa.Columns[7].HeaderText = "Mã màu";
            dgvHangHoa.Columns[8].HeaderText = "Mã nơi SX";
            dgvHangHoa.Columns[9].HeaderText = "Số lượng";
            dgvHangHoa.Columns[10].HeaderText = "Đơn giá nhập";
            dgvHangHoa.Columns[11].HeaderText = "Đơn giá bán";
            dgvHangHoa.Columns[12].HeaderText = "Thời gian BH";
            dgvHangHoa.Columns[13].HeaderText = "Ảnh";
            dgvHangHoa.Columns[14].HeaderText = "Ghi chú";
            HienChiTiet(false);
            //ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                txtMaHang.Text = dgvHangHoa.CurrentRow.Cells[0].Value.ToString();
                txtTenHang.Text = dgvHangHoa.CurrentRow.Cells[1].Value.ToString();
                cboMaLoai.Text = dgvHangHoa.CurrentRow.Cells[2].Value.ToString();
                cboMaHinhDang.Text = dgvHangHoa.CurrentRow.Cells[3].Value.ToString();
                cboMaChatLieu.Text = dgvHangHoa.CurrentRow.Cells[4].Value.ToString();
                cboCongDung.Text = dgvHangHoa.CurrentRow.Cells[5].Value.ToString();
                cboMaDacDiem.Text = dgvHangHoa.CurrentRow.Cells[6].Value.ToString();
                cboMaMau.Text = dgvHangHoa.CurrentRow.Cells[7].Value.ToString();
                cboMaNoiSX.Text = dgvHangHoa.CurrentRow.Cells[8].Value.ToString();
                txtSoLuong.Text = dgvHangHoa.CurrentRow.Cells[9].Value.ToString();
                txtDonGiaBan.Text = dgvHangHoa.CurrentRow.Cells[10].Value.ToString();
                txtDonGiaNhap.Text = dgvHangHoa.CurrentRow.Cells[11].Value.ToString();
                txtThoiGianBH.Text = dgvHangHoa.CurrentRow.Cells[12].Value.ToString();
                txtAnh.Text = dgvHangHoa.CurrentRow.Cells[13].Value.ToString();
                picAnh.Image = Image.FromFile(txtAnh.Text);
                txtGhiChu.Text = dgvHangHoa.CurrentRow.Cells[14].Value.ToString();

            }
            catch
            { }
        }
        private void XoaTrangChiTiet()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboMaLoai.Text = "";
            cboMaHinhDang.Text = "";
            cboMaChatLieu.Text = "";
            cboCongDung.Text = "";
            cboMaDacDiem.Text = "";
            cboMaMau.Text = "";
            cboMaNoiSX.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            txtThoiGianBH.Text = "";
            txtAnh.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //CẤM NÚT XÓA VÀ SỬA
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //viết câu lệnh sql cho tìm kiếm
            string sql = "SELECT * FROM tblDMHangHoa where MaHang is not null";
            //tìm theo mã sp khác
            if (txtTKMaHang.Text.Trim() != "")
            {
                sql += " and  MaHang like '%" + txtTKMaHang.Text + "%'";
            }        
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Xoa trang GroupBox chi tiết sản phẩm
            XoaTrangChiTiet();
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Ẩn hai nút Thêm và Xóa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện gropbox chi tiết
           
            HienChiTiet(true);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Lựa chọn",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.DataChange("delete tblDMHangHoa where MaHang= '" + txtMaHang.Text + "'");
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            LoadData();
            HienChiTiet(false);


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Trim() =="" )
            {
                errHangHoa.SetError(txtTenHang, "Bạn không được để trống mã Hàng ");
                return;
            } 
            else
            {
                errHangHoa.Clear(); 
            }

            if (txtTenHang.Text.Trim() =="")
            {
                errHangHoa.SetError(txtTenHang, "Bạn không được để trống tên Hàng ");
            }
            else
            {
                errHangHoa.Clear();
            }

            if (cboMaLoai.Text.Trim() == "")
            {
                errHangHoa.SetError(cboMaLoai, "Bạn không được để trống mã loại ");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (cboMaHinhDang.Text.Trim() == "")
            {
                errHangHoa.SetError(cboMaHinhDang, "Bạn không được để trống mã hình dạng ");
            }
            else
            {
                errHangHoa.Clear();
            }

            if (cboMaChatLieu.Text.Trim() == "")
            {
                errHangHoa.SetError(txtTenHang, "Bạn không được để trống mã chất liệu ");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (cboCongDung.Text.Trim() == "")
            {
                errHangHoa.SetError(txtTenHang, "Bạn không được để trống công dụng ");
            }
            else
            {
                errHangHoa.Clear();
            }

            if (cboMaDacDiem.Text.Trim() == "")
            {
                errHangHoa.SetError(cboMaLoai, "Bạn không được để trống mã đặc điểm ");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (cboMaMau.Text.Trim() == "")
            {
                errHangHoa.SetError(cboMaMau, "Bạn không được để trống mã màu ");
            }
            else
            {
                errHangHoa.Clear();
            }

            if (cboMaNoiSX.Text.Trim() == "")
            {
                errHangHoa.SetError(cboMaNoiSX, "Bạn không được để trống mã nơi SX ");
            }
            else
            {
                errHangHoa.Clear();
            }

            if (txtSoLuong.Text.Trim() == "")
            {
                errHangHoa.SetError(txtSoLuong, "Bạn không được để trống số lượng ");
                return;
            }
            else
            {
                errHangHoa.Clear();
            }

            if (txtDonGiaNhap.Text.Trim() == "")
            {
                errHangHoa.SetError(txtDonGiaNhap, "Bạn không được để trống đơn giá nhập ");
            }
            else
            {
                errHangHoa.Clear();
            }

            if (txtDonGiaBan.Text.Trim()=="")
            {
                errHangHoa.SetError(txtDonGiaBan, "Bạn không được để trống đơn giá bán");
            }    
            else
            {
                errHangHoa.Clear();
            }    

            if(txtThoiGianBH.Text.Trim()=="")
            {
                errHangHoa.SetError(txtThoiGianBH, "Bạn không được để trống thời gian bảo hành");
            }    
            else
            {
                errHangHoa.Clear();
            }  
            
            if(txtAnh.Text.Trim()=="")
            {
                errHangHoa.SetError(txtAnh, "Bạn phải chọn ảnh minh họa cho hàng");
                btnOpen.Focus();
            }    
            else
            {
                errHangHoa.Clear();
            }    

            if(txtGhiChu.Text.Trim()=="")
            {
                errHangHoa.SetError(txtGhiChu, "bạn không được để trống ghi chú");
            }    
            else
            {
                errHangHoa.Clear();
            }
            //Thêm
            if (btnThem.Enabled == true)
            {  //Kiểm  tra  xem  ô  nhập  MaSP  có  bị  trống  không  if
                if (txtMaHang.Text.Trim() == "")
                {
                    errHangHoa.SetError(txtMaHang, "Bạn  không  để  trống  mã  hàng  trường  này!");
                    return;
                }
                string maHang = txtMaHang.Text;
                DataTable dtHangHoa = dtbase.DataReader("Select * from tblDMHangHoa where MaHang ='" + maHang + "'");
                if (dtHangHoa.Rows.Count > 0)//đã tồn tại mã rồi 
                {
                    MessageBox.Show("Mã hàng đã có, bạn phải nhập mã khác");
                    txtMaHang.Focus();
                    return;

                }

                //Insert vao CSDL
                dtbase.DataChange("Insert into tblDMHangHoa values ('" + txtMaHang.Text + "' , N'" + txtTenHang.Text +
                    "', '" + cboMaLoai.Text + "', '" + cboMaHinhDang.Text + "', '" + cboMaChatLieu.Text + "',N '" + cboCongDung.Text +
                    "', '" + cboMaDacDiem.Text + "', '" + cboMaMau.Text + "', '" + cboMaNoiSX.Text +
                    "', '" + txtSoLuong.Text + "', '" + txtDonGiaNhap.Text + "', '" + txtDonGiaBan.Text + "', N'" + txtThoiGianBH.Text +
                    "', '" + txtAnh.Text + "', N'" + txtGhiChu.Text+"')");
            }
            //sửa
            if (btnSua.Enabled == true)
            {
                dtbase.DataChange("UPDATE tblDMHangHoa set TenHang = N'" + txtTenHang.Text + "', MaLoai = '" + cboMaLoai.Text +
                    "', MaHinhDang ='" + cboMaHinhDang.Text + "', MaChatLieu='" + cboMaChatLieu.Text + "', CongDung =N'" + cboCongDung.Text +
                    "', MaDacDiem='" + cboMaDacDiem.Text + "', MaMau='" + cboMaMau.Text + "', MaNoiSX='" + cboMaNoiSX.Text + "', SoLuong='" + txtSoLuong.Text + "', DonGiaNhap='" + txtDonGiaNhap.Text +
                    "', DonGiaBan='" + txtDonGiaBan.Text + "',ThoiGianBH=N'" + txtThoiGianBH.Text + "', Anh='" + txtAnh.Text + "', GhiChu=N'" + txtGhiChu.Text + "' where MaHang = '" + txtMaHang.Text + "'");
            }
            LoadData();
            XoaTrangChiTiet();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            //xoa trang chi tiết
            XoaTrangChiTiet();
            //Cam nhap vào groupBox chi tiết
            HienChiTiet(false);
        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenLoai.Text = cboMaLoai.SelectedValue.ToString();
        }

        private void cboMaHinhDang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHinhDang.Text = cboMaHinhDang.SelectedValue.ToString();
        }

        private void cboMaChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChatLieu.Text = cboMaChatLieu.SelectedValue.ToString();
        }

        private void cboMaDacDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDacDiem.Text = cboMaDacDiem.SelectedValue.ToString();
        }

        private void cboMaMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMau.Text = cboMaMau.SelectedValue.ToString();
        }

        private void cboMaNoiSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoiSX.Text = cboMaNoiSX.SelectedValue.ToString();
        }

        private void txtNoiSX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
