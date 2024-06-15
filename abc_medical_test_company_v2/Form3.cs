using MySql.Data.MySqlClient;
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

        int rowcount = 0;
        int rowcountmax = 0;

        public frm_patient(frm_main main)
        {
            InitializeComponent();
            mainForm = main;
            dbObj1 = new Mysqlconnect();

            dgv_userReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_userReg.MultiSelect = false;
            dgv_userReg.SelectionChanged += dgv_userReg_SelectionChanged;

            UserPrivilages();
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new frm_invoice());
        }

        private void frm_patient_Load(object sender, EventArgs e)
        {
            CustomizeDesign();
            RefreshDataGridView();
        //    PopulateComboBox();
        }

        private void UserPrivilages()
        {
            if (frmlogin.user == "Doctor" || frmlogin.user == "Technologist")
            {
                btnAddpanel.Visible = false;
                btnedit.Visible = false;
            }
        }

        private void CustomizeDesign()
        {
            panel_footer.Visible = false;
        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT nic,name,email, mobile,address FROM patient WHERE status_id ='2'";
            try
            {
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    dgv_userReg.DataSource = dbObj1.dtable;
                    rowcountmax = dbObj1.dtable.Rows.Count;
                    rowcount = 0; // Reset to the first row
                    LoadSelectedRow();
                }
                else
                {
                    dgv_userReg.DataSource = null;
                    rowcountmax = 0;
                    rowcount = -1; // No valid row
                    ClearFields();
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }


        private void LoadSelectedRow()
        {
            if (dbObj1.dtable != null && rowcount >= 0 && rowcount < dbObj1.dtable.Rows.Count)
            {
                DataRow selectedRow = dbObj1.dtable.Rows[rowcount];
                txtfname.Text = selectedRow["name"].ToString();
                txtemail.Text = selectedRow["email"].ToString();
                txttelno.Text = selectedRow["mobile"].ToString();
                txtaddress.Text = selectedRow["address"].ToString();
                txtnic.Text = selectedRow["nic"].ToString();
            }
            else
            {
                ClearFields();
            }
        }
        private void ClearFields()
        {
            txtfname.Clear();
            txtemail.Clear();
            txttelno.Clear();
            txtaddress.Clear();
            txtnic.Clear();
        }


        private void btnAddpanel_Click(object sender, EventArgs e)
        {
            ClearFields();
            panel_footer.Visible = true;
            panel_edit.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = true;
            txtnic.Enabled = true;
        }

        private void dgv_userReg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_userReg.SelectedRows.Count > 0)
            {
                int selectedIndex = dgv_userReg.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < rowcountmax)
                {
                    rowcount = selectedIndex;
                    LoadSelectedRow();
                }
            }
        }


        private void Btnedit(object sender, EventArgs e)
        {
            panel_footer.Visible = true;
            panel_edit.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Visible = false;
            txtnic.Enabled = false;

            //LoadSelectedRow();
            EditLoad();
            PopulateComboBox();
        }

        private void EditLoad()
        {
            if (dgv_userReg.SelectedRows.Count > 0)
            {
                DataGridViewRow SelectedRow = dgv_userReg.SelectedRows[0];
                txtfname.Text = SelectedRow.Cells["name"].Value.ToString();
                txtemail.Text = SelectedRow.Cells["email"].Value.ToString();
                txttelno.Text = SelectedRow.Cells["mobile"].Value.ToString();
                txtaddress.Text = SelectedRow.Cells["address"].Value.ToString();
                txtnic.Text = SelectedRow.Cells["nic"].Value.ToString();

            }
            /*f (dgv_userReg.SelectedRows.Count > 0)
             {
                 DataGridViewRow selectedRow = dgv_userReg.SelectedRows[0];



                 txtfname.Text = selectedRow["name"].ToString();
                 txtemail.Text = selectedRow["email"].ToString();
                 txttelno.Text = selectedRow["mobile"].ToString();
                 txtaddress.Text = selectedRow["address"].ToString();
                 txtnic.Text = selectedRow["nic"].ToString();

             }*/
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel_footer.Visible = false;
            panel_edit.Visible = true;
            txtnic.Clear();
            txtfname.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txttelno.Clear();
        }

        private void btnSearchpatient_Click(object sender, EventArgs e)
        {

            string nic = txtsearch.Text.Trim();
            string sql = "SELECT nic,name,email, mobile,address FROM Patient WHERE nic = ('" + nic + "') and status_id='2'";
            try
            {
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    dgv_userReg.DataSource = dbObj1.dtable;
                    rowcountmax = dbObj1.dtable.Rows.Count;
                    rowcount = 0;
                    LoadSelectedRow();
                }
                else
                {
                    MessageBox.Show("No data found.");
                    CheckIDSearch();
                    txtsearch.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckID();
            AddPatient();
            RefreshDataGridView();
            btncancel.PerformClick();
        }
        private void AddPatient()
        {
            string nic = txtnic.Text;
            string name = txtfname.Text;
            string email = txtemail.Text;
            string telno = txttelno.Text;
            string address = txtaddress.Text;
            string status = "2";


            string sql = "INSERT INTO patient (nic,name,email, mobile,address,status_id) VALUES ('" + nic + "','" + name + "','" + email + "','" + telno + "','" + address + "','" + status + "')";
            dbObj1.Insert(sql);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePatient();
            RefreshDataGridView();
            btncancel.PerformClick();

        }

        private void UpdatePatient()
        {
            string nic = txtnic.Text;
            string name = txtfname.Text;
            string email = txtemail.Text;
            string telno = txttelno.Text;
            string address = txtaddress.Text;


            string sql = " UPDATE patient set name  = ('" + name + "'),email  = ('" + email + "') ,mobile  = ('" + telno + "') ,address  = ('" + address + "')   where nic ='" + nic + "'";
            dbObj1.Update(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();

        }

        private void DeletePatient()
        {
            string nic = txtnic.Text;
            string status = "1";
            string sql = "UPDATE patient SET status_id = ('" + status + "') where nic =('" + nic + "') ";
            dbObj1.Update(sql);
        }

        private void CheckID()
        {
            string nic = "";
            string check2 = "";
            string check = "";
            string sql;
            string sql2;

            nic = txtnic.Text;

            sql = "SELECT nic FROM Patient WHERE nic = ('" + nic + "') ";
            sql2 = "SELECT status_id FROM Patient WHERE nic = ('" + nic + "')";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    check = dbObj1.dtable.Rows[0]["nic"].ToString();

                }
                dbObj1.Select(sql2);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    check2 = dbObj1.dtable.Rows[0]["status_id"].ToString();
                }

                if (check == nic && check2 == "1")
                {
                    DialogResult result = MessageBox.Show("Deleted Record. Do You Want To Reactivate?",
                                                          "Deleted Record",
                                                          MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Code to reactivate the patient record
                        ReactivatePatient(nic);
                    }
                    else if (result == DialogResult.No)
                    {
                        // Code to handle 'No' response if needed
                        MessageBox.Show("Patient reactivation canceled.");
                        txtnic.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

        }

        private void ReactivatePatient(string nic)
        {
            string status = "2"; // Assuming '2' is the active status
            string sql = "UPDATE patient SET status_id = '" + status + "' WHERE nic = '" + nic + "'";

            try
            {
                dbObj1.Update(sql);
                MessageBox.Show("Patient reactivated successfully.");
                RefreshDataGridView(); // Refresh the data grid view to show updated data
                btnedit.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reactivating patient: " + ex.Message);

            }
        }

        private void CheckIDSearch()
        {
            string nic = "";
            string check2 = "";
            string check = "";
            string sql;
            string sql2;

            nic = txtsearch.Text;

            sql = "SELECT nic FROM Patient WHERE nic = ('" + nic + "') ";
            sql2 = "SELECT status_id FROM Patient WHERE nic = ('" + nic + "')";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    check = dbObj1.dtable.Rows[0]["nic"].ToString();

                }
                dbObj1.Select(sql2);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    check2 = dbObj1.dtable.Rows[0]["status_id"].ToString();
                }

                if (check == nic && check2 == "1")
                {
                    DialogResult result = MessageBox.Show("Deleted Record. Do You Want To Reactivate?",
                                                          "Deleted Record",
                                                          MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Code to reactivate the patient record
                        ReactivatePatient(nic);
                    }
                    else if (result == DialogResult.No)
                    {
                        // Code to handle 'No' response if needed
                        MessageBox.Show("Patient reactivation canceled.");
                        txtnic.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {

        }
        private void PopulateComboBox()
        {
            try
            {
                string sql = "SELECT test_id, test_name FROM tests";
                dbObj1.Select(sql);

                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    cmbtests.DisplayMember = "test_name";
                    cmbtests.ValueMember = "test_id";
                    cmbtests.DataSource = dbObj1.dtable;
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


    }
}
