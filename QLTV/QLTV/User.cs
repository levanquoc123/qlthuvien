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
    public partial class User : Form
    {
        SqlConnection conn1 = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        public static string manhanvien = "";
        public User()
        {
            InitializeComponent();

            label8.Text = Form1.tenhienthi;
            laymanhanvien();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qldocgia qldocgia = new qldocgia();
            qldocgia.ShowDialog();
            this.Visible = false;
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlsach qlsach = new qlsach();
            qlsach.ShowDialog();
            this.Visible = false;
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qlnxb qlnxb= new qlnxb();
            qlnxb.ShowDialog();
            this.Visible = false;
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlmuontra qlmuontra = new qlmuontra();
            qlmuontra.ShowDialog();
            this.Visible = false;
        }
        public void laymanhanvien()
        {
            conn1.Open();
            SqlCommand cmd = new SqlCommand("manvtheouser", conn1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", SqlDbType.VarChar).Value = label8.Text;
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter spd = new SqlDataAdapter();
            spd.SelectCommand = cmd;
            spd.Fill(ds);
            conn1.Close();
            manhanvien = ds.Rows[0][0].ToString();   
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinuser thongtin = new thongtinuser();
            thongtin.ShowDialog();
            this.Visible = false;
        }

    }
}
