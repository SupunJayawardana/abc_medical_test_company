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
            lblusername.Text = frmlogin.name;
            lblUserrole.Text = frmlogin.user;
            
        }
        private void UserPrivilages()
        {
            if (frmlogin.user == "Doctor" || frmlogin.user == "Technologist")
            {
               panel_userSubmenu.Visible = false;
                
            }
        }
        private void customizeDesign()
        {
            panel_userSubmenu.Visible = false;
            panel_patientSubmenu.Visible = false;
            panel_testSubmenu.Visible = false;
            panel_reportsSubmenu.Visible = false;
            
        }

        private void hideSubmenu()
        {
            if (panel_userSubmenu.Visible)
                panel_userSubmenu.Visible = false;

            if (panel_patientSubmenu.Visible)
                panel_patientSubmenu.Visible = false;

            if (panel_testSubmenu.Visible)
                panel_testSubmenu.Visible = false;

           

            if (panel_reportsSubmenu.Visible)
                panel_reportsSubmenu.Visible = false;

        }

        private void showSubmenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_userReg_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_userReg());
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_patientReg_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_patient(this));
            panel_header.Visible = false;
            hideSubmenu();
        }

    

        private void btn_addResult_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_addtrslt());
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_testView_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_trsltview(this)); // Pass the instance of frm_main
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_rptDIncome_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_DayIncome());
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_rptDocCom_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_DocComis());
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_rptTestAnlz_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_testtech());
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_notifySms_Click(object sender, EventArgs e)
        {
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_notifyEmail_Click(object sender, EventArgs e)
        {
            panel_header.Visible = false;
            hideSubmenu();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_userSubmenu);
            panel_header.Visible = false;
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_patientSubmenu);
            panel_header.Visible = false;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_testSubmenu);
            panel_header.Visible = false;
        }

    

        private void btn_reports_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_reportsSubmenu);
            panel_header.Visible = false;
        }

      

        public Form activeForm = null;
        public void openChildForm(Form childForm)
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
