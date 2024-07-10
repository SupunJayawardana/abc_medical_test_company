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
    public partial class frmlogin : Form
    {
        private frmregister uregister;
        Mysqlconnect dbObj=new Mysqlconnect();
        public static string user;
        public static string name;
        public static string userid;

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

        private void btn_login_Click(object sender, EventArgs e)
        {
            CheckAuthentication();
        }
        private void CheckAuthentication()
        {
            frm_main mainform = new frm_main(); 

            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string sql1;
            string sql2;
            string sql3;
            string sql4;
            string sql5;
            string check1 = "";
            string check2 = "";
            string fname;
            string lname;
            string active="";



            sql1 = "SELECT userName FROM Admin WHERE userName = ('" + username + "')";

            dbObj.Select(sql1);
            if (dbObj.dtable.Rows.Count > 0)
            {
                check1 = dbObj.dtable.Rows[0]["userName"].ToString();
            }

            sql2 = "SELECT password FROM Admin WHERE password = ('" + password + "')";

            dbObj.Select(sql2);
            if (dbObj.dtable.Rows.Count > 0)
            {
                check2 = dbObj.dtable.Rows[0]["password"].ToString();
            }

            sql3 = "SELECT role,id FROM Admin WHERE userName = ('" + username + "')";

            dbObj.Select(sql3);
            if (dbObj.dtable.Rows.Count > 0)
            {
                user = dbObj.dtable.Rows[0]["role"].ToString();
                userid = dbObj.dtable.Rows[0]["id"].ToString();

            }

            sql4 = "SELECT first_name,last_name FROM Admin WHERE userName = ('" + username + "')";

            dbObj.Select(sql4);
            if (dbObj.dtable.Rows.Count > 0)
            {
                fname = dbObj.dtable.Rows[0]["first_name"].ToString();
                lname = dbObj.dtable.Rows[0]["last_name"].ToString();
                name = fname +" "+ lname;
            }

            sql5 = "SELECT status_id FROM Admin WHERE userName = ('" + username + "')";

            dbObj.Select(sql5);
            if (dbObj.dtable.Rows.Count > 0)
            {
                active = dbObj.dtable.Rows[0]["status_id"].ToString();
            }

            // MessageBox for debugging purposes
            MessageBox.Show("Username from DB: " + check1 + "\nPassword from DB: " + check2);

            if (check1 == username && check2 == password )
            {
                if (active == "2")
                {
                    mainform.Show(); // public variables should be data assigned before opening another form
                    this.Hide();
                }
                else if (active == "1") 
                { 
                    MessageBox.Show("Access Denied. Contact Administrater"); 
                }
            }
            else
            {
                MessageBox.Show("Invalid Name or Password");
                txt_Username.Clear();
                txt_Password.Clear();
            }

        }
    }
}

