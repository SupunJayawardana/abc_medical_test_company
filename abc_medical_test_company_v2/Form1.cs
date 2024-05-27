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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void customizeDesign()
        {
            panel_userSubmenu.Visible = false;
            panel_patientSubmenu.Visible = false;
            panel_testSubmenu.Visible = false;
            panel_paymentSubmenu.Visible = false;
            panel_reportsSubmenu.Visible = false;
            panel_notificationSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_userSubmenu.Visible == true)
                panel_userSubmenu.Visible = false;

            if (panel_patientSubmenu.Visible == true)
                panel_patientSubmenu.Visible = false;

            if (panel_testSubmenu.Visible == true)
                panel_testSubmenu.Visible = false;

            if (panel_paymentSubmenu.Visible == true)
                panel_paymentSubmenu.Visible = false;

            if (panel_reportsSubmenu.Visible == true)
                panel_reportsSubmenu.Visible = false;

            if (panel_notificationSubmenu.Visible == true)
                panel_notificationSubmenu.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else submenu.Visible = false;
        }

        private void btn_userReg_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_userReg());
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_patientReg_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_patient());
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_patientView_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_patientview());
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_addResult_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_addtrslt());
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_testView_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_trsltview());
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_paymentView_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_paymentview());
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_rptDIncome_Click(object sender, EventArgs e)
        {
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_rptDocCom_Click(object sender, EventArgs e)
        {
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_rptTestAnlz_Click(object sender, EventArgs e)
        {
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_notifySms_Click(object sender, EventArgs e)
        {
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_notifyEmail_Click(object sender, EventArgs e)
        {
            //.....
            //mycode

            hideSubmenu();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_userSubmenu);
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_patientSubmenu);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_testSubmenu);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_paymentSubmenu);
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_reportsSubmenu);
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_notificationSubmenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

    }
}
