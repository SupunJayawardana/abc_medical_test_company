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
        private readonly Mysqlconnect dbObj2;
                    private readonly Mysqlconnect dbObj3;

        int rowcount = 0;
        int rowcountmax = 0;
        int tprice = 0;

        public frm_invoice()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();
            dbObj2 = new Mysqlconnect();
            dbObj3 = new Mysqlconnect();


            cmbtests.SelectedIndexChanged += new EventHandler(cmbtests_SelectedIndexChanged);
        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadPatientDetails();
            RefreshDataGridView();
        }

        private void PopulateComboBox()
        {
            PopulateComboBoxWithData("Doctor", cmbDoctorName);
            PopulateComboBoxWithData("Technologist", cmbTechnologistID);
            PopulateComboBoxWithData("Cashier", cmbCashierID);
            PopulateTestsComboBox();
        }

        private void PopulateComboBoxWithData(string role, ComboBox comboBox)
        {
            try
            {
                string sql = $"SELECT id, first_name, last_name FROM admin WHERE role = '{role}' AND status_id = '2'";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    comboBox.DisplayMember = "FullName";
                    comboBox.ValueMember = "id";
                    comboBox.DataSource = AddFullNameColumn(dbObj1.dtable);
                }
                else
                {
                    MessageBox.Show($"No data found for {role} ComboBox.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

            if (role == "Cashier")
            {
                comboBox.Text = frmlogin.name;
                comboBox.Enabled = false;
            }
        }

        private void PopulateTestsComboBox()
        {
            try
            {
                string sql = "SELECT test_id, test_name, test_description, price FROM tests";
                dbObj3.Select(sql);

                if (dbObj3.dtable != null && dbObj3.dtable.Rows.Count > 0)
                {
                    cmbtests.DisplayMember = "test_name";
                    cmbtests.ValueMember = "test_id";
                    cmbtests.DataSource = dbObj3.dtable;

                    if (cmbtests.SelectedIndex >= 0)
                    {
                        UpdateTestDescriptionAndPrice(dbObj3.dtable.Rows[0]);
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

        private void UpdateTestDescriptionAndPrice(DataRow row)
        {
            txttestdescrip.Text = row["test_description"].ToString();
            tprice = Convert.ToInt32(row["price"].ToString());
        }

        private DataTable AddFullNameColumn(DataTable dataTable)
        {
            dataTable.Columns.Add("FullName", typeof(string), "first_name + ' ' + last_name");
            return dataTable;
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            ListPopulate();

            SetTextBoxFromComboBoxSelection(cmbCashierID, txtCashierID);
            SetTextBoxFromComboBoxSelection(cmbTechnologistID, txtTechnologistID);
            SetTextBoxFromComboBoxSelection(cmbDoctorName, txtDoctorName, "FullName");
        }

        private void SetTextBoxFromComboBoxSelection(ComboBox comboBox, TextBox textBox, string displayMember = "id")
        {
            if (comboBox.SelectedItem != null)
            {
                DataRowView selectedRow = comboBox.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    textBox.Text = selectedRow[displayMember].ToString();
                    panel_ChooseInvoice.Visible = false;
                }
            }
            else
            {
                MessageBox.Show($"Please select a {comboBox.Name.Replace("cmb", "")}.");
            }
        }

        private void LoadPatientDetails()
        {
            string sql = $"SELECT name, address, email, mobile FROM Patient WHERE nic = '{frm_patient.patient}'";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    txtPatientName.Text = dbObj1.dtable.Rows[0]["name"].ToString();
                    txtPatientAddress.Text = $"{dbObj1.dtable.Rows[0]["address"]}\n{dbObj1.dtable.Rows[0]["email"]}\n{dbObj1.dtable.Rows[0]["mobile"]}";
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
                DataRowView selectedRow = (DataRowView)cmbtests.SelectedItem;
                UpdateTestDescriptionAndPrice(selectedRow.Row);
            }
        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM invoice";
            dbObj2.Select(sql);

            if (dbObj2.dtable != null && dbObj2.dtable.Rows.Count > 0)
            {
                txtIssuedDate.Text = dbObj2.dtable.Rows[0]["issued_date"].ToString();
                txtInvoiceNo.Text = dbObj2.dtable.Rows[0]["id"].ToString();
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            SetNewInvoiceID();
        }

        private void SetNewInvoiceID()
        {
            string sqlMaxId = "SELECT MAX(id) FROM invoice";
            dbObj2.Select(sqlMaxId);

            if (dbObj2.dtable != null && dbObj2.dtable.Rows.Count > 0 && dbObj2.dtable.Rows[0][0] != DBNull.Value)
            {
                int newId = Convert.ToInt32(dbObj2.dtable.Rows[0][0]) + 1;
                txtInvoiceNo.Text = newId.ToString();
            }
            else
            {
                txtInvoiceNo.Text = "1";
            }
        }

        private void ListPopulate()
        {
            AddItemToListBox(cmbtests.Text, lbxtest);
            AddItemToListBox(txttestdescrip.Text, lbxtestdesc);
            AddItemToListBox(tprice.ToString(), lbxtestprice);
        }

        private void AddItemToListBox(string text, ListBox listBox)
        {
            if (!string.IsNullOrEmpty(text))
            {
                listBox.Items.Add(text);
            }
            else
            {
                MessageBox.Show("Please enter some text.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
