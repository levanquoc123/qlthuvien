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
    public partial class qldocgia : Form
    {
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        int r = 0;
        string x = "";
        public qldocgia()
        {
            InitializeComponent();
            reload();
        }

        public void reload()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("thongtindocgia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;
            conn.Close();
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentRow.Index;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("xoadocgia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Madocgia", SqlDbType.VarChar).Value = dataGridView1.Rows[r].Cells[0].Value.ToString();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa Thành Công!!");
                reload();
            }
            catch
            {
                MessageBox.Show("Lỗi Rồi!!!");
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            reload();
        }
        private void sua_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;
            if (r == 1)
            {
                dataGridView1.Rows[t].Cells[0].ReadOnly = true;
                dataGridView1.Rows[t].Cells[1].ReadOnly = true;
                dataGridView1.Rows[t].Cells[4].ReadOnly = true;
            }
            if(r ==2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("updatedocgia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@madocgia", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                cmd.Parameters.AddWithValue("@sdt", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[3].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Thành Công");
                conn.Close();
                r = 0;
                reload();
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;
            if (r == 1)
            {
                
            }
            else if (r == 2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("themdocgia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@madocgia", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@tendocgia", SqlDbType.NVarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                cmd.Parameters.AddWithValue("@sothe", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[4].Value;
                cmd.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = dataGridView1.Rows[t].Cells[2].Value;
                cmd.Parameters.AddWithValue("@sdt", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[3].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công!");
                conn.Close();
                r = 0;
                reload();
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã Độc Giả")
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
            if (comboBox1.Text == "Tên Độc Giả")
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
            if (comboBox1.Text == "Số Thẻ")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("timkiemdocgia3", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sothe", SqlDbType.VarChar).Value = tencantim.Text;
                DataTable dta = new DataTable();
                dta.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dta;
                conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Độc Giả Đang Mượn Sách")
            {
                x = "docgiamuonsach";
            }
            if (comboBox2.Text == "Độc Giả Trả Sách Quá Hạn")
            {
                x = "docgiaquahan";
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
            {
                User qluser = new User();
                qluser.Visible = true;
                this.Close();
            }
        }
    }
}
