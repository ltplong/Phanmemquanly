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
    public partial class frmChuongTrinhQuanLy : Form
    {
        public frmChuongTrinhQuanLy()
        {
            InitializeComponent();
        }

        private void mnuLoai_Click(object sender, EventArgs e)
        {
            frmLoai form = new frmLoai();
            form.Show();
        }

        private void frmChuongTrinhQuanLy_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmChatLieu formCL = new frmChatLieu();
            formCL.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien formNV = new frmNhanVien();
            formNV.Show();
        }

        private void mnuCongDung_Click(object sender, EventArgs e)
        {
            frmCongDung formCongDung = new frmCongDung();
            formCongDung.Show();
        }

        private void mnuDacDiem_Click(object sender, EventArgs e)
        {
            frmDacDiem formDacDiem = new frmDacDiem();
            formDacDiem.Show();
        }

        private void mnuCongViec_Click(object sender, EventArgs e)
        {
            frmCongViec formCV = new frmCongViec();
            formCV.Show();
        }

        private void mnHinhDang_Click(object sender, EventArgs e)
        {
            frmHinhDang formHinhDang = new frmHinhDang();
            formHinhDang.Show();
        }

        private void mnuMauSac_Click(object sender, EventArgs e)
        {
            frmMau formMauSac = new frmMau();
            formMauSac.Show();
        }

        private void mnuNoiSanXuat_Click(object sender, EventArgs e)
        {
            frmNoiSXcs formNoiSX = new frmNoiSXcs();
            formNoiSX.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang formKhachHang = new frmKhachHang();
            formKhachHang.Show();
        }

        private void mnuNCC_Click(object sender, EventArgs e)
        {
            frmNhaCC formNCC = new frmNhaCC();
            formNCC.Show();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa formHangHoa = new frmDMHangHoa();
            formHangHoa.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan formHoaDonBan = new frmHoaDonBan();
            formHoaDonBan.Show();
        }

        private void mnuHoaDonNhap_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap formHoaDonNhapp = new frmHoaDonNhap();
            formHoaDonNhapp.Show();
        }

        private void mnuChiTietHoaDonBan_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuChiTietHoaDonNhap_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
