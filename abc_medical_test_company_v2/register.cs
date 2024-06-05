using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication11;


namespace abc_medical_test_company_v2
{
    public partial class frmregister : Form
    {
        private readonly Mysqlconnect dbObj1;
        private frmlogin LogForm;

        public frmregister(frmlogin loginForm)
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();
            LogForm = loginForm;

            InitializeComboBoxItems();
        }

        private void InitializeComboBoxItems()
        {
            cmbrole.Items.Clear();
            cmbrole.Items.Add("Admin");
            cmbrole.Items.Add("Doctor");
            cmbrole.Items.Add("Technologist");
            cmbrole.Items.Add("Cashier");
            cmbrole.SelectedIndex = 0;
        }

        private void RegisterUserToSystem()
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string email = txtemail.Text;
            string telno = txttelno.Text;
            string role = cmbrole.Text;
            string status = "2";

            string sql = $"INSERT INTO admin (username, password, first_name, last_name, email, mobile, role, status_id) VALUES ('{username}', '{password}', '{fname}', '{lname}', '{email}', '{telno}', '{role}', '{status}')";
            dbObj1.Insert(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterUserToSystem();
            MessageBox.Show("Register Complete. Wait till Admin Confirmation to Login");

            LogForm.Show();
            this.Hide();
        }
    }
}

