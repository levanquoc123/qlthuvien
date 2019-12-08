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
    public partial class qlnxb : Form
    {
        int r = 0;
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        public qlnxb()
        {
            InitializeComponent();
            reload(); 
        }

        private void qlnxb_Load(object sender, EventArgs e)
        {
            reload();
        }
        public void reload()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("ttnxb", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void them_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;

            if (r == 2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("themnxb", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNXB", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@TenNXB", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                cmd.Parameters.AddWithValue("@Dchi", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[3].Value;
                cmd.Parameters.AddWithValue("@sothe", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[4].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công!");
                conn.Close();
                r = 0;
                reload();
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;

            if (r == 1)
            {
                dataGridView1.Rows[t].Cells[0].ReadOnly = true;
                dataGridView1.Rows[t].Cells[1].ReadOnly = true;
            }
            if (r == 2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("suanxb", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNXB", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@Dchi", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[3].Value;
                cmd.Parameters.AddWithValue("@SDT", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[4].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Thành Công!");
                conn.Close();
                r = 0;
                reload();
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã NXB")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("timkiemdocgia2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Madocgia", SqlDbType.VarChar).Value = tencantim.Text;
                DataTable dta = new DataTable();
                dta.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dta;
                conn.Close();
            }
            if (comboBox1.Text == "Tên NXB")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("timkiemdocgia1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tendocgia", SqlDbType.VarChar).Value = tencantim.Text;
                DataTable dta = new DataTable();
                dta.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dta;
                conn.Close();
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
