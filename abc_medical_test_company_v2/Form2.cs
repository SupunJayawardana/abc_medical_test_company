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
    public partial class frm_userReg : Form
    {
        private readonly Mysqlconnect dbObj1;

        public frm_userReg()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();
            dgv_userReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_userReg.MultiSelect = false;
            dgv_userReg.SelectionChanged += dgv_userReg_SelectionChanged;

            InitializeComboBoxItems();
        }

        private void frm_userReg_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM admin";
            dbObj1.Select(sql);

            if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
            {
                dgv_userReg.DataSource = dbObj1.dtable;
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }

        private void dgv_userReg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_userReg.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_userReg.SelectedRows[0];

                txtusername.Text = selectedRow.Cells["username"].Value.ToString();
                txtpassword.Text = selectedRow.Cells["password"].Value.ToString();
                txtfname.Text = selectedRow.Cells["first_name"].Value.ToString();
                txtlname.Text = selectedRow.Cells["last_name"].Value.ToString();
                txtemail.Text = selectedRow.Cells["email"].Value.ToString();
                txttelno.Text = selectedRow.Cells["mobile"].Value.ToString();
                cmbrole.Text = selectedRow.Cells["role"].Value.ToString();
                cmbstatus.Text = selectedRow.Cells["status_id"].Value.ToString();
            }
        }

        private void panel_footer_Click(object sender, EventArgs e)
        {
            // Not implemented
        }

        private void InitializeComboBoxItems()
        {
            cmbrole.Items.Clear();
            cmbrole.Items.Add("Admin");
            cmbrole.Items.Add("Doctor");
            cmbrole.Items.Add("Technologist");
            cmbrole.Items.Add("Cashier");
            cmbrole.SelectedIndex = 0;

            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Active");
            cmbstatus.Items.Add("Inactive");
            cmbstatus.SelectedIndex = 0;

            /*cmbsearch.Items.Clear();
            cmbsearch.Items.Add("username");
            cmbsearch.Items.Add("password");
            cmbsearch.Items.Add("first name");
            cmbsearch.Items.Add("last name");
            cmbsearch.Items.Add("role");
            cmbsearch.Items.Add("email");
            cmbsearch.Items.Add("tel no");
            cmbsearch.Items.Add("status");
            cmbsearch.SelectedIndex = 0;*/
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtemail.Clear();
            txttelno.Clear();
            cmbrole.SelectedIndex = -1;
            //cmbsearch.SelectedIndex = -1;
            cmbstatus.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDataToAdmin();
        }

        private void AddDataToAdmin()
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string email = txtemail.Text;
            string telno = txttelno.Text;
            string role = cmbrole.Text;
            string status = cmbstatus.Text;

            string sql = $"INSERT INTO admin (username, password, first_name, last_name, email, mobile, role, status_id) VALUES ('{username}', '{password}', '{fname}', '{lname}', '{email}', '{telno}', '{role}', '{status}')";
            dbObj1.Insert(sql);
            RefreshDataGridView();
        }
    }
}
