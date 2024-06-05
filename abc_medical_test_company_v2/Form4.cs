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
    public partial class frm_patientview : Form
    {
        private readonly Mysqlconnect dbObj1;
       // private int niid;

        public frm_patientview()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();

           /* dgv_userReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_userReg.MultiSelect = false;
            dgv_userReg.SelectionChanged += dgv_userReg_SelectionChanged;*/
        }

        private void frm_patientview_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
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

       /* private void dgv_userReg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_userReg.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_userReg.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["nic"].Value);

                txtsearchby.Text = selectedRow.Cells["username"].Value?.ToString() ?? string.Empty;
            }
        }*/
    }
}
