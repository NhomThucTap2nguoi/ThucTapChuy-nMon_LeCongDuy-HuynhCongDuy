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
       /* string strConnection = @"Data Source=LAPTOP-PCEQUR9I\SQLEXPRESS;Initial Catalog=CAFE1;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;*/

        int mov;
        int movX;
        int movY;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }

        private void FormDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if ( mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void FormDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /* try
             {
                 conn = new SqlConnection(strConnection);
                 conn.Open();
                 string sql = "Select Count(*) from [CAFE1].[dbo].[Account] Where UserName =@account and PassWord=@pwd";
                 cmd.Parameters.Add(new SqlParameter("@account", txbUserName.Text));
                 cmd.Parameters.Add(new SqlParameter("@pwd", txbPassWord.Text));
                 int x = (int)cmd.ExecuteScalar();

                 if (x == 1)
                 {
                     // Login Success
                     MessageBox.Show("Đăng nhập Thành công!", "Thông Báo");
                     lbIncorrect.Text = "";
                     txbUserName.Focus();

                     //Open new Form
                     this.Hide();
                     FormGiaodien f1 = new FormGiaodien();
                     f1.Show();

                 }
                 else
                 {
                    lbIncorrect.Text = "Thông tin bị Trống hoặc Không chính xác !";
                 }
             }


             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private void checkboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShow.Checked)
            {
                txbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassWord.UseSystemPasswordChar = true;
            }
        }

        private void lbIncorrect_Click(object sender, EventArgs e)
        {

        }
    }
}
