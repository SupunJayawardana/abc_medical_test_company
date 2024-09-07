using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication11;

namespace abc_medical_test_company_v2
{
    public partial class frm_addtrslt : Form
    {
        private readonly Mysqlconnect dbObj1;

        public frm_addtrslt()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();


        }

        private void btnCreateTestReport_Click(object sender, EventArgs e)
        {
            panel_footer.Visible = false;


        }
       private void ReportDetails()
        {
            cmbPatientName.Text= frm_trsltview.pname;
            cmbtests.Text=frm_trsltview.testname;
            cmbTechnologistID.Text = frmlogin.name;
            lblTestName.Text= frm_trsltview.testname; ;

        }

        private void frm_addtrslt_Load(object sender, EventArgs e)
        {
            ReportDetails();
            LoadPatientDetails();
            OtherDetails();
        }

        private void LoadPatientDetails()
        {
            string sql = $"SELECT name, address, email, mobile FROM Patient WHERE nic = '{frm_trsltview.pnic}'";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    txtpname.Text = dbObj1.dtable.Rows[0]["name"].ToString();
                    txtaddress.Text = $"{dbObj1.dtable.Rows[0]["address"]}\n{dbObj1.dtable.Rows[0]["email"]}\n{dbObj1.dtable.Rows[0]["mobile"]}";
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void OtherDetails()
        {
            txtInvoiceNo.Text = Convert.ToString(frm_trsltview.id);

            string issuedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtIssuedDate.Text = issuedate;

           

            string sql = $"SELECT issued_date, cashier_id, technologist_id FROM invoice WHERE id = '{frm_trsltview.id}'";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    txtReceivedDate.Text = dbObj1.dtable.Rows[0]["issued_date"].ToString();
                    txtCashierID.Text = dbObj1.dtable.Rows[0]["cashier_id"].ToString();
                    txtTechnologistID.Text = dbObj1.dtable.Rows[0]["technologist_id"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void btnAddResults_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            // Check if the ListBox already has 3 entries
            if (listBoxCResult.Items.Count < 3 && listBoxCritiria.Items.Count < 3)
            {
                // Check if both text boxes have text
                if (!string.IsNullOrEmpty(txttestCResults.Text) && !string.IsNullOrEmpty(txtCritiria.Text))
                {
                    // Add the text from txttestCResults.Text to listBoxCResult
                    listBoxCResult.Items.Add(txttestCResults.Text);

                    // Add the text from txtCritiria.Text to listBoxCritiria
                    listBoxCritiria.Items.Add(txtCritiria.Text);

                    // Clear the textboxes after adding the items (optional)
                    txttestCResults.Clear();
                    txtCritiria.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter both test results and criteria before adding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Show a message that only 3 entries are allowed
                MessageBox.Show("You can only add up to 3 entries.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
