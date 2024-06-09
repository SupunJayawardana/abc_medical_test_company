using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApplication11;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    int id =0;
        private void dgv_userReg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_userReg.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_userReg.SelectedRows[0];
                
             id = Convert.ToInt32(selectedRow.Cells["id"].Value); // Assuming you have an 'id' column for unique identification

                
                cmbrole.Text = selectedRow.Cells["role"].Value.ToString();
                cmbstatus.Text = selectedRow.Cells["status_id"].Value.ToString();

                // Convert status_id to text representation
                string statusId = selectedRow.Cells["status_id"].Value.ToString();
                cmbstatus.Text = statusId == "2" ? "Active" : statusId == "1" ? "Inactive" : "";

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
            //cmbrole.SelectedIndex = 0;

            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Active");
            cmbstatus.Items.Add("Inactive");
            //cmbstatus.SelectedIndex = 0;

           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           
            cmbrole.SelectedIndex = -1;
            
            cmbstatus.SelectedIndex = -1;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDatatoAdmin();
        }
        private void UpdateDatatoAdmin()
        {
            if (dgv_userReg.SelectedRows.Count > 0)
            {
               
                string role = cmbrole.Text;
                int status = cmbstatus.Text == "Active" ? 2 : 1;

                string sql = "UPDATE admin SET role = '" + role + "' , status_id = '" + status + "' WHERE id = ('" + id + "')";
                dbObj1.Update(sql);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }
    }
}
