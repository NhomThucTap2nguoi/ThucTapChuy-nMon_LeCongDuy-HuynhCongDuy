using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienCafe_New
{
    public partial class FormGiaodien : Form
    {


        public FormGiaodien()
        {

            InitializeComponent();
        }

        private void FormGiaodien_Load(object sender, EventArgs e)
        {
            //Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            userBanhang11.BringToFront();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            userHoadon1.BringToFront();

        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            userDouong1.BringToFront();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            userAccount1.BringToFront();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            FormPaint f = new FormPaint();
            this.Hide();
            f.ShowDialog();
        }
    }
}
