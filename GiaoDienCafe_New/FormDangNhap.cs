using GiaoDienCafe_New.DAO;
using GiaoDienCafe_New.DTO;
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

namespace GiaoDienCafe_New
{
    public partial class FormDangNhap : Form
    {
      
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
           

        }

        private void FormDangNhap_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void FormDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string userName = txtbUserName.Text;
            string passWord = txtbPassWord.Text;

            if (Login(userName, passWord))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                FormGiaodien f = new FormGiaodien();
                this.Hide();
                f.ShowDialog();

               
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
        private void checkboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShow.Checked)
            {
                txtbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtbPassWord.UseSystemPasswordChar = true;
            }
        }

        private void lbIncorrect_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
