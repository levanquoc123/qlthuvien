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
    public partial class qlsach : Form
    {
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        int r = 0;
        public qlsach()
        {
            InitializeComponent();
            reload();
        }

        private void quaylai_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {

        }
        private void timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (comboBox1.Text == "Mã Sách")
            {
                SqlCommand cmd = new SqlCommand("timkiemsachmasach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", SqlDbType.VarChar).Value = textBox1.Text;
                DataTable dta = new DataTable();
                dta.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dta;
            }
            if (comboBox1.Text == "Tên Sách")
            {
                SqlCommand cmd = new SqlCommand("timkiemsachtensach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tensach", SqlDbType.VarChar).Value = textBox1.Text;
                DataTable dta = new DataTable();
                dta.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dta;
            }
            if (comboBox1.Text == "Thể Loại")
            {
                SqlCommand cmd = new SqlCommand("timkiemsachtheloai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@theloai", SqlDbType.VarChar).Value = textBox1.Text;
                DataTable dta = new DataTable();
                dta.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dta;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;

            if (r == 2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("themsach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@tensach", SqlDbType.NVarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                cmd.Parameters.AddWithValue("@theloai", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                cmd.Parameters.AddWithValue("@matg", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[3].Value;
                cmd.Parameters.AddWithValue("@manxb", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[4].Value;
                cmd.Parameters.AddWithValue("@namxb", SqlDbType.Int).Value = dataGridView1.Rows[t].Cells[5].Value;
                cmd.Parameters.AddWithValue("@soluong", SqlDbType.Int).Value = dataGridView1.Rows[t].Cells[6].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công!");
                conn.Close();
                r = 0;
                reload();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;

            if (r == 1)
            {
                dataGridView1.Rows[t].Cells[0].ReadOnly = true;
            }
            if (r == 2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("updatesach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tensach", SqlDbType.NVarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                cmd.Parameters.AddWithValue("@matl", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                cmd.Parameters.AddWithValue("@matg", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[3].Value;
                cmd.Parameters.AddWithValue("@manxb", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[4].Value;
                cmd.Parameters.AddWithValue("@namxb", SqlDbType.Int).Value = dataGridView1.Rows[t].Cells[5].Value;
                cmd.Parameters.AddWithValue("@Soluong", SqlDbType.Int).Value = dataGridView1.Rows[t].Cells[6].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Thành Công!");
                conn.Close();
                r = 0;
                reload();
            }
        }
        public void reload()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("ttsach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;
            conn.Close();
        }

        private void xoa_Click_1(object sender, EventArgs e)
        {

        }

        private void quaylai_Click_1(object sender, EventArgs e)
        {

        }
    }
}
