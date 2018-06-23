using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        public static String userName = "";
        public static String userRole = "";
        private void frmMain_Load(object sender, EventArgs e)
        {
            rpan_editStudent.Enabled = false;
        }

        private void rpan_newStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
            Form form1 = new frm_login();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
