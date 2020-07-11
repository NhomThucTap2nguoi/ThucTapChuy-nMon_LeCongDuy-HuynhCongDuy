using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GiaoDienCafe_New
{
    public partial class UserDouong : UserControl
    {
        string conString = @"Data Source=DESKTOP-GISFHHL;Initial Catalog=coffee;Integrated Security=True";
        public UserDouong()
        {
            InitializeComponent();
        }
        public DataTable ketNoi(string query)
        {
            DataTable data = new DataTable();
            SqlConnection sql = new SqlConnection(conString);
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            sql.Close();
            return data;
        }
        SqlConnection conn;
        public void Hienthi()
        {
            string sqlSELECT = "select *from Food ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgvDouong.DataSource = dt;
        }

        public void loadDl()
        {

            string query = "select *from Food ";
            DataTable data = ketNoi(query);
            dtgvDouong.DataSource = data;

        }

        private void UserDouong_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-GISFHHL;Initial Catalog=coffee;Integrated Security=True";
            conn = new SqlConnection(conString);
            conn.Open();
            loadDl();
        }

        private void dtgvDouong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txtID.Text = dtgvDouong.Rows[row].Cells["id"].Value.ToString();
                txtTenmon.Text = dtgvDouong.Rows[row].Cells["name"].Value.ToString();
                cbDanhmuc.Text = dtgvDouong.Rows[row].Cells["idCategory"].Value.ToString();
                txtPrice.Text = dtgvDouong.Rows[row].Cells["price"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO Food values(@name,@idCategory,@price)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("name", txtTenmon.Text);
            cmd.Parameters.AddWithValue("idCategory", cbDanhmuc.GetItemText(this.cbDanhmuc.SelectedItem));
            cmd.Parameters.AddWithValue("price", txtPrice.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công!");

            Hienthi();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            string sqlEdit = "UPDATE Food SET name='" + txtTenmon.Text + "',price='" + txtPrice.Text + "'," +
               "idCategory='" + cbDanhmuc.Text + "' WHERE id='" + txtID.Text + "'";

            DataTable data = ketNoi(sqlEdit);
            loadDl();
            MessageBox.Show("Đã sửa thông tin thành công !", "Thông báo");

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Chọn dòng cần xóa :", "Thông báo");
            }
            else
            {
                string sqlDelete = "Delete Food  WHERE id='" + txtID.Text + "'";
                DataTable data = ketNoi(sqlDelete);
                loadDl();
                MessageBox.Show("Đã Xóa Thành Công !", "Thông Báo:");
            }
        }
    }
}
