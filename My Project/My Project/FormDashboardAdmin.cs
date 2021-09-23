using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project
{
    public partial class FormDashboardAdmin : Form
    {
        private FormLogin FormLogin1 { get; set; }
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }


        public FormDashboardAdmin(FormLogin formLogin1, string info) : this()
        {
            this.FormLogin1 = formLogin1;
            this.lblNameInfo.Text = info;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout Successful");
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        private void FormCategoryAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Do you want to Close this App?");
            Application.Exit();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s3;
            FormInvoice inv = new FormInvoice(this, s3 = "Admin");
            inv.Show();
        }

        private void btnIPD_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s4, sa;
            FormAdmission adm = new FormAdmission(this, s4 = "Admin", sa = "");
            adm.Show();
        }

        private void btnEmpManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployee_Management emp = new FormEmployee_Management(this);
            emp.Show();
        }

        private void btnExamAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s5, sa, ss;
            FormAddExam ae = new FormAddExam(this, s5 = "Admin", sa = "", ss = "");
            ae.Show();
        }

        private void btnMatManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s6, sa, ss, sd;
            FormMaterial_Management fma = new FormMaterial_Management(this, s6 = "Admin", sa = "", ss = "", sd = "");
            fma.Show();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s6, sa, ss, sd, sf;
            FormMedicineInfo fmi = new FormMedicineInfo(this, s6 = "Admin", sa = "", ss = "", sd = "", sf = "");
            fmi.Show();
        }
    }
}
