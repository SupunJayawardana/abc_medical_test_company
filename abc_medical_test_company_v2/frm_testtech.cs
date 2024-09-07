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
    public partial class frm_testtech : Form
    {
        public frm_testtech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                // Create an instance of Mysqlconnect
                Mysqlconnect db = new Mysqlconnect();

                // Get the selected month and year from DateTimePicker
                DateTime selectedDate = dateTimePicker1.Value;
                int month = selectedDate.Month;
                int year = selectedDate.Year;

                // Create SQL query to count the number of tests done by each technologist
                string query = $@"
        SELECT 
            i.technologist_id AS 'Technologist ID',
            CONCAT_WS(' ', a.first_name, a.last_name) AS 'Technologist Name',
            COUNT(*) AS 'Tests Completed'
        FROM invoice i
        JOIN admin a ON i.technologist_id = a.id
        WHERE a.role = 'technologist'
        AND i.report_status_id = 1
        AND MONTH(i.issued_date) = {month}
        AND YEAR(i.issued_date) = {year}
        GROUP BY i.technologist_id
        ORDER BY i.technologist_id";

                // Execute the query
                db.Select(query);

                // Bind the result to DataGridView1
                dataGridView1.DataSource = db.dtable;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of Mysqlconnect
            Mysqlconnect db = new Mysqlconnect();

            // Create SQL query to find pending tests with invoice number
            string query = @"
        SELECT 
            i.id AS 'Invoice ID',
            p.nic AS 'Patient NIC',
            p.name AS 'Patient Name',
            CONCAT_WS(' ', a.first_name, a.last_name) AS 'Technologist Name',
            t.test_name AS 'Test Name',
            i.issued_date AS 'Issued Date'
        FROM invoice i
        JOIN patient p ON i.patient_nic = p.nic
        JOIN admin a ON i.technologist_id = a.id
        JOIN tests t ON i.tests_test_id = t.test_id
        WHERE i.report_status_id = 2";

            // Execute the query
            db.Select(query);

            // Bind the result to DataGridView1
            dataGridView1.DataSource = db.dtable;
        }


    }
}
