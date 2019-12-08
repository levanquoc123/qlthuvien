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
    public partial class qlthethuvien : Form
    {
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        int r = 0;
        public qlthethuvien()
        {
            InitializeComponent();
        }

        void reload()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("thongtinthe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;
            conn.Close();
        }
        private void xoa_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;
            try
            {
                if (r == 2)
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("themthe", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sothe", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gia Hạn Thành Công!");
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Gia Hạn Thất Bại!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;

            if (r == 2)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("themthe", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sothe", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                    cmd.Parameters.AddWithValue("@NgBD", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                    cmd.Parameters.AddWithValue("@NgKT", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công!");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Thêm Lỗi!");
                }
                r = 0;
                reload();
            }
        }
    }
}
