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
    public partial class frm_DayIncome : Form
    {
        public frm_DayIncome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Create an instance of Mysqlconnect
                Mysqlconnect db = new Mysqlconnect();

                // Get the selected date from DateTimePicker
                DateTime selectedDate = dateTimePicker1.Value.Date;

                // Create SQL query to get daily income report
                // Use string interpolation to safely insert the date
                string query = $@"SELECT 
                        issued_date AS 'Date', 
                        SUM(price) AS 'Total Income' 
                     FROM invoice 
                     WHERE DATE(issued_date) = '{selectedDate:yyyy-MM-dd}' 
                     GROUP BY DATE(issued_date)";

                // Execute the query
                db.Select(query);

                // Bind the result to DataGridView1
                dataGridView1.DataSource = db.dtable;
          



        }

        private void frm_DayIncome_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
