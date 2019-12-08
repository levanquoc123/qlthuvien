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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            reload();
            label8.Text = Form1.tenhienthi;
        }
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        int r = 0;

        private void them_Click(object sender, EventArgs e)
        {
            r++;
            int t = dataGridView1.CurrentRow.Index;

            if (r==2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("themtaikhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDN", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@Matkhau", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                cmd.Parameters.AddWithValue("@quyen", SqlDbType.VarChar).Value = "user";
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
                dataGridView1.Rows[t].Cells[2].ReadOnly = true;
            }
            if (r==2)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("suataikhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDN", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[0].Value;
                cmd.Parameters.AddWithValue("@Matkhau", SqlDbType.VarChar).Value = dataGridView1.Rows[t].Cells[1].Value;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Thành Công!");
                conn.Close();
                r = 0;
                reload();
            }
        }
        private void Reload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentRow.Index;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("xoataikhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDN", SqlDbType.VarChar).Value = dataGridView1.Rows[r].Cells[0].Value.ToString() ;
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

        private void timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("timkiemtaikhoan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenDN", SqlDbType.VarChar).Value = tencantim.Text;
            //cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;
            conn.Close();
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }
        public void reload()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("thongtintaikhoan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dta;
            conn.Close();
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }
    }
}
