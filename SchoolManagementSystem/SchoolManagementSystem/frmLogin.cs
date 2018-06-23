using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SchoolManagementSystem
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            string co = ConfigurationSettings.AppSettings["connString"];
            SqlConnection con = new SqlConnection(co);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM userDetails WHERE userName='" + txt_userName.Text + "' AND userPassword='" + txt_password.Text + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT userName, userRole FROM userDetails WHERE userName='" + txt_userName.Text + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                frm_Main.userName = dt2.Rows[0][0].ToString();
                frm_Main.userRole = dt2.Rows[0][1].ToString();
                MessageBox.Show("Success");
                this.Hide();
                new frm_Main().Show();
            }
            else
                MessageBox.Show("Invalid username or password");


        }
    }
}
