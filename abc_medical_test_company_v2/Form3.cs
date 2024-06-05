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
    public partial class frm_patient : Form
    {
        private frm_main mainForm;
        private readonly Mysqlconnect dbObj1;
        

        public frm_patient(frm_main main)
        {
            InitializeComponent();
            mainForm = main;
            dbObj1 = new Mysqlconnect();

            dgv_userReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_userReg.MultiSelect = false;
            dgv_userReg.SelectionChanged += dgv_userReg_SelectionChanged;
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new frm_invoice());
        }

        private void frm_patient_Load(object sender, EventArgs e)
        {
            CustomizeDesign();
            RefreshDataGridView();
        }

        private void CustomizeDesign()
        {
            panel_footer.Visible = false;
        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM patient";
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void btnAddpanel_Click(object sender, EventArgs e)
        {
            panel_footer.Visible = true;
            panel_edit.Visible = false;


        }

        DataGridViewRow selectedRow;


        private void dgv_userReg_SelectionChanged(object sender, EventArgs e)
         {
             if (dgv_userReg.SelectedRows.Count > 0)
             {
                 selectedRow = dgv_userReg.SelectedRows[0];              
             }
         }

        private void Btnedit(object sender, EventArgs e)
        {
            panel_footer.Visible = true;
            panel_edit.Visible = false;
            EditLoad();
        }
        private void EditLoad()
        {

            txtfname.Text = selectedRow.Cells["name"].Value?.ToString() ?? string.Empty;
            txtemail.Text = selectedRow.Cells["email"].Value?.ToString() ?? string.Empty;
            txttelno.Text = selectedRow.Cells["mobile"].Value?.ToString() ?? string.Empty;
            txtaddress.Text = selectedRow.Cells["address"].Value?.ToString() ?? string.Empty;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel_footer.Visible = false;
            panel_edit.Visible = true;
        }

        private void btnSearchpatient_Click(object sender, EventArgs e)
        {

        }
    }
}
   
