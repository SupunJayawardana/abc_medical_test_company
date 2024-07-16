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
        }

        private void frm_addtrslt_Load(object sender, EventArgs e)
        {
            ReportDetails();
        }
    }
}
