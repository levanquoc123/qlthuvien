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
    public partial class Form1 : Form
    {
        public static string tenhienthi = "";
        SqlConnection conn = new SqlConnection(QLTV.Properties.Settings.Default.qltvConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void dangnhapnd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dangnhap", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tentaikhoan", SqlDbType.VarChar).Value = taikhoan.Text;
            cmd.Parameters.AddWithValue("@Matkhau", SqlDbType.VarChar).Value = matkhau.Text;
            cmd.Parameters.AddWithValue("@quyen", SqlDbType.VarChar).Value = quyen.Text;
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter spd = new SqlDataAdapter();
            spd.SelectCommand = cmd;
            spd.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                if (quyen.Text == "admin")
                {
                    tenhienthi = taikhoan.Text;
                    Admin qladmin = new Admin();
                    qladmin.Visible = true;
                    this.Visible = false;
                   
                }
                else
                {
                    tenhienthi = taikhoan.Text;
                    User qluser = new User();
                    qluser.Visible = true;
                    this.Visible = false;
                }
            }
        }

        private void xemmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (xemmatkhau.Checked == true)
            {
                matkhau.UseSystemPasswordChar = true;
            }
            else
                matkhau.UseSystemPasswordChar = false;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                this.Close();
        }
    }
}
