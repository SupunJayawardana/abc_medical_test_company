using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication11;

namespace abc_medical_test_company_v2
{
    public partial class frm_addTest : Form
    {
        private readonly Mysqlconnect dbObj1;

        public frm_addTest()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();

            // Set up the selection mode for the DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;  // Only allow single row selection
            dataGridView1.SelectionChanged += dgv_userReg_SelectionChanged;  // Hook up the event handler
        }

        // Refresh DataGridView with the latest data from the database
        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM tests";
            dbObj1.Select(sql);

            if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dbObj1.dtable;
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }

        // On form load, set up the DataGridView and populate it
        private void frm_addTest_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;  // Disable adding rows directly in DataGridView
            dataGridView1.AllowUserToDeleteRows = false;  // Disable row deletion directly in DataGridView
            dataGridView1.ReadOnly = true;  // Set to read-only
            RefreshDataGridView();
        }

        // Insert new test record from textboxes
        private void btnInsert_Click(object sender, EventArgs e)
        {
           
        }

        // Update selected test record from textboxes
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        // Delete selected test record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int testId = Convert.ToInt32(selectedRow.Cells["test_id"].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the test with ID {testId}?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string deleteQuery = $"DELETE FROM tests WHERE test_id = {testId}";
                dbObj1.Delete(deleteQuery);
                MessageBox.Show($"Test with ID {testId} deleted successfully.");

                // Refresh the DataGridView
                RefreshDataGridView();
                ClearTextBoxes();
            }
        }

        // Event handler for row selection change in DataGridView
        private void dgv_userReg_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txttestname.Text = selectedRow.Cells["test_name"].Value?.ToString();
                txttestprice.Text = selectedRow.Cells["test_price"].Value?.ToString();
                txttestdescription.Text = selectedRow.Cells["test_description"].Value?.ToString();
            }
        }

        // Clear the textboxes after an operation
        private void ClearTextBoxes()
        {
            txttestname.Clear();
            txttestprice.Clear();
            txttestdescription.Clear();
        }

        // Button to clear form inputs
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        // Cell click event to populate textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txttestname.Text = selectedRow.Cells["test_name"].Value?.ToString();
                txttestprice.Text = selectedRow.Cells["test_price"].Value?.ToString();
                txttestdescription.Text = selectedRow.Cells["test_description"].Value?.ToString();
            }
        }

        // Text changed events for the textboxes (optional)
        private void txtTestName_TextChanged(object sender, EventArgs e) { }
        private void txtTestPrice_TextChanged(object sender, EventArgs e) { }
        private void txtTestDescription_TextChanged(object sender, EventArgs e) { }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            string testName = txttestname.Text;
            double testPrice = Convert.ToDouble(txttestprice.Text);
            string testDescription = txttestdescription.Text;

            // Validation
            if (string.IsNullOrEmpty(testName) || string.IsNullOrEmpty(testDescription))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Fetch the last test_id
            string lastIdQuery = "SELECT MAX(test_id) FROM tests";
            int newTestId = 1; // Default value if no records exist

            try
            {
                dbObj1.Select(lastIdQuery); // Execute query to get the last test_id
                if (dbObj1.dtable != null && dbObj1.dtable.Rows.Count > 0)
                {
                    object result = dbObj1.dtable.Rows[0][0];
                    if (result != DBNull.Value)
                    {
                        int lastTestId = Convert.ToInt32(result);
                        newTestId = lastTestId + 1; // Increment the last test_id
                    }
                }

                // Insert query with manually set test_id
                string insertQuery = $"INSERT INTO tests (test_id, test_name, test_price, test_description) VALUES ({newTestId}, '{testName}', {testPrice}, '{testDescription}')";
                dbObj1.Insert(insertQuery);
                MessageBox.Show($"New test added successfully with ID: {newTestId}");

                // Refresh the DataGridView
                RefreshDataGridView();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding test: " + ex.Message);
            }
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int testId = Convert.ToInt32(selectedRow.Cells["test_id"].Value);

            string testName = txttestname.Text;
            double testPrice = Convert.ToDouble(txttestprice.Text);
            string testDescription = txttestdescription.Text;

            // Validation
            if (string.IsNullOrEmpty(testName) || string.IsNullOrEmpty(testDescription))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Update query
            string updateQuery = $"UPDATE tests SET test_name = '{testName}', test_price = {testPrice}, test_description = '{testDescription}' WHERE test_id = {testId}";
            dbObj1.Update(updateQuery);
            MessageBox.Show($"Test with ID {testId} updated successfully.");

            // Refresh the DataGridView
            RefreshDataGridView();
            ClearTextBoxes();
        }
    }
}
