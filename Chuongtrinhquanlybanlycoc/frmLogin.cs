using Chuongtrinhquanlybanlycoc.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Chuongtrinhquanlybanlycoc
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection connect = ketnoidelogin.connect;


        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            string querynv = "Select * From tblNhanVien where MaNV ='" + txtUserName.Text + "' and PassWord ='" + txtPassWord.Text + "' ";
            SqlDataAdapter sqldata = new SqlDataAdapter(querynv, connect);
            DataTable datatb1 = new DataTable();
            sqldata.Fill(datatb1);
            if (datatb1.Rows.Count == 1)
            {
                frmChuongTrinhQuanLy mainmenu = new frmChuongTrinhQuanLy();
                this.Hide();
                mainmenu.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }



        }
    

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question
               ) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
        }

        private void rdoShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoShowPass.Checked)
            {
                txtPassWord.PasswordChar = (char)0;

            }
            else
            {
                txtPassWord.PasswordChar = '*';
            }    
        }
    }
}
