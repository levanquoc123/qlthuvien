using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class thongtinuser : Form
    {
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        int r = 0;
        public thongtinuser()
        {
            InitializeComponent();
            loaddata();
            xuat();
        }

        private void Sửa_Click(object sender, EventArgs e)
        {
            r++;

            if (r == 1)
            {
                textBox2.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
            if (r == 2)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("suataikhoan", conn);
                    SqlCommand cma = new SqlCommand("chinhsuathongtinuser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenDN", SqlDbType.VarChar).Value = textBox1.Text;
                    cmd.Parameters.AddWithValue("@Matkhau", SqlDbType.VarChar).Value = textBox2.Text;
                    cmd.ExecuteNonQuery();
                    cma.CommandType = CommandType.StoredProcedure;
                    cma.Parameters.AddWithValue("@tendangnhap", SqlDbType.VarChar).Value = textBox1.Text;
                    cma.Parameters.AddWithValue("@Manhanvien", SqlDbType.VarChar).Value = textBox3.Text;
                    cma.Parameters.AddWithValue("@SDT", SqlDbType.Int).Value = textBox5.Text;
                    cma.Parameters.AddWithValue("@Hoten", SqlDbType.VarChar).Value = textBox4.Text;
                    cma.Parameters.AddWithValue("@NgSinh", SqlDbType.Date).Value = textBox6.Text;
                    conn.Close();
                    MessageBox.Show("Sửa Thành Công!");
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại!");
                }
            }
        }
        void loaddata()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("xemttuser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", SqlDbType.VarChar).Value = User.manhanvien;
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;
            conn.Close();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }
        void xuat()
        {
            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
        }
    }
}
