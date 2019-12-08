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
    public partial class qlmuontra : Form
    {
        public qlmuontra()
        {
            InitializeComponent();
            label8.Text = User.manhanvien;
            reload();
        }
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        int r = 0;
        string x = "";

        public void reload()       
        {
            if (comboBox1.Text == "xem chi tiết mượn trả")
            {
                x = "ttmuontrasach";
            }
            else if (comboBox1.Text == "Xem thông tin mượn")
            {
                x = "xemmuontra";
            }
            else
            {
                x = "ttctmuontra";
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand(x, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;

            conn.Close();
            x = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;
            if (r == 1)
            {
                comboBox1.Text = "Xem thông tin mượn";
                reload();
                comboBox1.Text = "xem chi tiết mượn trả";
                reload();
            }
            if (r==2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("themview", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mamt", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@sothe", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                cmd.Parameters.AddWithValue("@manv", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                cmd.Parameters.AddWithValue("@Ngmuon", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.AddWithValue("@Ngtra", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.AddWithValue("@masach", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[4].Value;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công!");
                conn.Close();
                r = 0;
                x = "ttmuontrasach";
                reload();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t = dataGridView1.CurrentRow.Index;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("trasach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mamt", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@NgTra", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Trả Thành Công");
                comboBox1.Text = "xem chi tiết mượn trả";
                reload();
            }
            catch
            {
                MessageBox.Show("Trả Thất Bại");
                conn.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reload();
        }
    }
}
