using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_medical_test_company_v2
{
    public partial class frm_patient : Form
    {
        private frm_main mainForm;
        public frm_patient(frm_main main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new frm_invoice());
        }
    }
}
