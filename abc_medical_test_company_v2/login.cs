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
    public partial class frmlogin : Form
    {
        private frmregister uregister;

        public frmlogin()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            if (uregister == null || uregister.IsDisposed)
            {
                uregister = new frmregister(this);
            }
            uregister.Show();
            this.Hide();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

