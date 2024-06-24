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
    public partial class frm_invoice : Form
    {
        private readonly Mysqlconnect dbObj1;
        int rowcount = 0;
        int rowcountmax = 0;

        public frm_invoice()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();
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
        }

        private void PopulateTestsComboBox()
        {
            try
            {
                string sql = "SELECT test_id, test_name FROM tests ";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    cmbtests.DisplayMember = "test_name";
                    cmbtests.ValueMember = "test_id";
                    cmbtests.DataSource = dbObj1.dtable;

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
    }
}