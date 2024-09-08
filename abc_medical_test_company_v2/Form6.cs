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
using static System.Net.Mime.MediaTypeNames;

namespace abc_medical_test_company_v2
{
    public partial class frm_trsltview : Form
    {
        private frm_main mainForm;
        private readonly Mysqlconnect dbObj1;

        public frm_trsltview(frm_main form)
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();
            mainForm = form;
            dgv_userReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_userReg.MultiSelect = false;
            dgv_userReg.SelectionChanged += dgv_userReg_SelectionChanged;
        }

        private void frm_trsltview_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM invoice WHERE technologist_id = '" + frmlogin.userid + "'";
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

        public static int id = 0;
        public static string pnic;
        public static string testid;
        public static string statusid;


        private void dgv_userReg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_userReg.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_userReg.SelectedRows[0];

                id = Convert.ToInt32(selectedRow.Cells["id"].Value); 
                pnic = selectedRow.Cells["patient_nic"].Value.ToString();
                testid = selectedRow.Cells["tests_test_id"].Value.ToString();
                statusid = selectedRow.Cells["report_status_id"].Value.ToString();
                PatientName();
                TestName();
                StatusReport();
            }
        }

        public static string pname;
        public static string testname;


        private void PatientName()
        {
            try
            {
                string sql = "SELECT name FROM Patient WHERE nic = '" + pnic + "'";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    pname = txtpatientname.Text = dbObj1.dtable.Rows[0]["name"].ToString();
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

        private void TestName()
        {
            try
            {
                string sql = "SELECT test_name FROM Tests WHERE test_id = '" + testid + "'";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    testname = txttest.Text = dbObj1.dtable.Rows[0]["test_name"].ToString();
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

        private void StatusReport()
        {
            
                     {
                         lblrepostats.Text = statusid == "2" ? "Pending" : "Sent";
                     }
                    
           
        }



        private void btnaddresult_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new frm_addtrslt());
        }
    }
}
