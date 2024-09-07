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
    public partial class frm_DocComis : Form
    {
        public frm_DocComis()
        {
            InitializeComponent();
        }

        private void frm_DocComis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                // Create an instance of Mysqlconnect
                Mysqlconnect db = new Mysqlconnect();

                // Get the selected month and year from DateTimePicker
                DateTime selectedDate = dateTimePicker1.Value;
                int month = selectedDate.Month;
                int year = selectedDate.Year;

                // Create SQL query to calculate the total commission for each doctor
                string query = $@"
        SELECT 
            i.doctor_id AS 'Doctor ID',
            CONCAT_WS(' ', a.first_name, a.last_name) AS 'Doctor Name',
            SUM(i.price * 0.10) AS 'Total Commission'
        FROM invoice i
        JOIN admin a ON i.doctor_id = a.id
        WHERE a.role = 'doctor'
        AND MONTH(i.issued_date) = {month}
        AND YEAR(i.issued_date) = {year}
        GROUP BY i.doctor_id
        ORDER BY i.doctor_id";

                // Execute the query
                db.Select(query);

                // Bind the result to DataGridView1
                dataGridView1.DataSource = db.dtable;
            

        }
    }
}
