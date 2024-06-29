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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace abc_medical_test_company_v2
{
    public partial class frm_invoice : Form
    {
        private readonly Mysqlconnect dbObj1;
        int rowcount = 0;
        int rowcountmax = 0;

        public frm_invoice()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();

            cmbtests.SelectedIndexChanged += new EventHandler(cmbtests_SelectedIndexChanged);

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            PatientDetails();
            RefreshDataGridView();
        }

        private void PopulateComboBox()
        {
            PopulateDoctorComboBox();
            PopulateTechnologistComboBox();
            PopulateCashierComboBox();
            PopulateTestsComboBox();
        }

        private void PopulateDoctorComboBox()
        {
            try
            {
                string sql = "SELECT id, first_name, last_name FROM admin WHERE role = 'Doctor' AND status_id = '2'";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    cmbDoctorName.DisplayMember = "FullName";
                    cmbDoctorName.ValueMember = "id";
                    cmbDoctorName.DataSource = AddFullNameColumn(dbObj1.dtable);
                }
                else
                {
                    MessageBox.Show("No data found for ComboBox.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void PopulateTechnologistComboBox()
        {
            try
            {
                string sql = "SELECT id, first_name, last_name FROM admin WHERE role = 'Technologist' AND status_id = '2'";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    cmbTechnologistID.DisplayMember = "FullName";
                    cmbTechnologistID.ValueMember = "id";
                    cmbTechnologistID.DataSource = AddFullNameColumn(dbObj1.dtable);
                }
                else
                {
                    MessageBox.Show("No data found for ComboBox.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void PopulateCashierComboBox()
        {
            try
            {
                string sql = "SELECT id, first_name, last_name FROM admin WHERE role = 'Cashier' AND status_id = '2'";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    cmbCashierID.DisplayMember = "FullName";
                    cmbCashierID.ValueMember = "id";
                    cmbCashierID.DataSource = AddFullNameColumn(dbObj1.dtable);
                }
                else
                {
                    MessageBox.Show("No data found for ComboBox.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

            cmbCashierID.Text = frmlogin.name;
            cmbCashierID.Enabled = false;
        }


        int tprice = 0;
        private void PopulateTestsComboBox()
        {
            try
            {
                string sql = "SELECT test_id, test_name, test_description, price FROM tests ";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    cmbtests.DisplayMember = "test_name";
                    cmbtests.ValueMember = "test_id";
                    cmbtests.DataSource = dbObj1.dtable;

                    if (cmbtests.SelectedIndex >= 0)
                    {
                        // Update the text box with the test description of the first item
                        txttestdescrip.Text = dbObj1.dtable.Rows[0]["test_description"].ToString();
                        tprice = Convert.ToInt32( dbObj1.dtable.Rows[0]["test_price"].ToString());
                    }
                }
                else
                {

                    MessageBox.Show("No data found for ComboBox.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private DataTable AddFullNameColumn(DataTable dataTable)
        {
            dataTable.Columns.Add("FullName", typeof(string), "first_name + ' ' + last_name");
            return dataTable;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            ListPopulate();


            if (cmbCashierID.SelectedItem != null)
            {
                DataRowView selectedRow = cmbCashierID.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    txtCashierID.Text = selectedRow["id"].ToString();
                    panel_ChooseInvoice.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please select a cashier.");
            }

            if (cmbTechnologistID.SelectedItem != null)
            {
                DataRowView selectedRow = cmbTechnologistID.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    txtTechnologistID.Text = selectedRow["id"].ToString();
                    panel_ChooseInvoice.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please select a Technologist.");
            }

            if (cmbDoctorName.SelectedItem != null)
            {
                DataRowView selectedRow = cmbDoctorName.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    txtDoctorName.Text = selectedRow["FullName"].ToString();
                    panel_ChooseInvoice.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please select a Doctor.");
            }

        }
        private void PatientDetails()
        {
            string sql;

            sql = "SELECT name,address,email,mobile FROM Patient WHERE nic = ('" + frm_patient.patient + "')";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    txtPatientName.Text = dbObj1.dtable.Rows[0]["name"].ToString();
                    string address = dbObj1.dtable.Rows[0]["address"].ToString();
                    string mobile = dbObj1.dtable.Rows[0]["mobile"].ToString();
                    string email = dbObj1.dtable.Rows[0]["email"].ToString();
                    txtPatientAddress.Text = address + " \n " + email + " \n " + mobile;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }
        private void cmbtests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtests.SelectedIndex >= 0)
            {
                // Get the selected row
                DataRowView selectedRow = (DataRowView)cmbtests.SelectedItem;

                // Update the text box with the description of the selected item
                txttestdescrip.Text = selectedRow["test_description"].ToString();
                tprice =Convert.ToInt32( selectedRow["test_price"].ToString());

            }
        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM invoice";
            dbObj1.Select(sql);

            if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
            {
                //  DgvInvoice.DataSource = dbObj1.dtable;

                // Display the last invoice's issued date and ID
                txtIssuedDate.Text = dbObj1.dtable.Rows[0]["issued_date"].ToString();
                txtInvoiceNo.Text = dbObj1.dtable.Rows[0]["id"].ToString();
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            // Generate a new ID
            string sqlMaxId = "SELECT MAX(id) FROM invoice";
            dbObj1.Select(sqlMaxId);

            if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0 && dbObj1.dtable.Rows[0][0] != DBNull.Value)
            {
                int newId = Convert.ToInt32(dbObj1.dtable.Rows[0][0]) + 1;
                txtInvoiceNo.Text = newId.ToString();
            }
            else
            {
                // If there are no existing records, start with ID 1
                txtInvoiceNo.Text = "1";
            }
        }
        private void LoadTestsDGV()
        {
            string sql = "SELECT * FROM invoice";
            dbObj1.Select(sql);

            if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
            {
                //  DgvInvoice.DataSource = dbObj1.dtable;

                // Display the last invoice's issued date and ID
                txtIssuedDate.Text = dbObj1.dtable.Rows[0]["issued_date"].ToString();
                txtInvoiceNo.Text = dbObj1.dtable.Rows[0]["id"].ToString();
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }
        private void ListPopulate()
        {
            string text1 = cmbtests.Text;
            string text2 = txttestdescrip.Text;
            string text3 = Convert.ToString(tprice);

            if (!string.IsNullOrEmpty(text1))
            {
                // Add the text to the ListBox
                lbxtest.Items.Add(text1);

                // Clear the TextBox
                //textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter some text.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!string.IsNullOrEmpty(text2))
            {
                // Add the text to the ListBox
                lbxtestdesc.Items.Add(text2);

                // Clear the TextBox
                //textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter some text.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!string.IsNullOrEmpty(text3))
            {
                // Add the text to the ListBox
                lbxtestprice.Items.Add(text3);

                // Clear the TextBox
                //textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter some text.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}