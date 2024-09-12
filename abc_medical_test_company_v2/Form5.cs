using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication11;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Xml.Linq;

namespace abc_medical_test_company_v2
{
    public partial class frm_addtrslt : Form
    {
        private readonly Mysqlconnect dbObj1;

        public frm_addtrslt()
        {
            InitializeComponent();
            dbObj1 = new Mysqlconnect();


        }

        private void btnCreateTestReport_Click(object sender, EventArgs e)
        {
            panel_footer.Visible = false;


        }
       private void ReportDetails()
        {
            cmbPatientName.Text= frm_trsltview.pname;
            cmbtests.Text=frm_trsltview.testname;
            cmbTechnologistID.Text = frmlogin.name;
            lblTestName.Text= frm_trsltview.testname; ;

        }

        private void frm_addtrslt_Load(object sender, EventArgs e)
        {
            ReportDetails();
            LoadPatientDetails();
            OtherDetails();
        }

        private void LoadPatientDetails()
        {
            string sql = $"SELECT name, address, email, mobile FROM Patient WHERE nic = '{frm_trsltview.pnic}'";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    txtpname.Text = dbObj1.dtable.Rows[0]["name"].ToString();
                    txtaddress.Text = $"{dbObj1.dtable.Rows[0]["address"]}\n{dbObj1.dtable.Rows[0]["email"]}\n{dbObj1.dtable.Rows[0]["mobile"]}";
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void OtherDetails()
        {
            txtInvoiceNo.Text = Convert.ToString(frm_trsltview.id);

            string issuedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtIssuedDate.Text = issuedate;

           

            string sql = $"SELECT issued_date, cashier_id, technologist_id FROM invoice WHERE id = '{frm_trsltview.id}'";
            try
            {
                dbObj1.Select(sql);
                if (dbObj1.dtable.Rows.Count > 0)
                {
                    txtReceivedDate.Text = dbObj1.dtable.Rows[0]["issued_date"].ToString();
                    txtCashierID.Text = dbObj1.dtable.Rows[0]["cashier_id"].ToString();
                    txtTechnologistID.Text = dbObj1.dtable.Rows[0]["technologist_id"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void btnAddResults_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            // Check if the ListBox already has 3 entries
            if (listBoxCResult.Items.Count < 3 && listBoxCritiria.Items.Count < 3)
            {
                // Check if both text boxes have text
                if (!string.IsNullOrEmpty(txttestCResults.Text) && !string.IsNullOrEmpty(txtCritiria.Text))
                {
                    // Add the text from txttestCResults.Text to listBoxCResult
                    listBoxCResult.Items.Add(txttestCResults.Text);

                    // Add the text from txtCritiria.Text to listBoxCritiria
                    listBoxCritiria.Items.Add(txtCritiria.Text);

                    // Clear the textboxes after adding the items (optional)
                    txttestCResults.Clear();
                    txtCritiria.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter both test results and criteria before adding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Show a message that only 3 entries are allowed
                MessageBox.Show("You can only add up to 3 entries.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string pdfPath;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pdfPath) && File.Exists(pdfPath))
            {
                try
                {
                    // Open the PDF file with the default PDF viewer
                    Process.Start(pdfPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("PDF file not found. Please generate the invoice first.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnpdf_Click(object sender, EventArgs e)
        {
            try
            {
                // Define folder path and create it if it doesn't exist
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MEDICAL TEST REPORTS");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Define file name with test ID and timestamp
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string testID = txtInvoiceNo.Text; // or any other field containing test ID
                string fileName = $"TestReport_{testID}_{timestamp}.pdf";
                string filePath = Path.Combine(folderPath, fileName);

                // Create a document
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // Title and Header
                doc.Add(new Paragraph("ABC Medical Test Report", FontFactory.GetFont("Arial Black", 24)));
                doc.Add(new Paragraph($"Issued by: ABC Medical Test, Mawathagama, Kurunegala", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph(" "));

                // Patient Information
                doc.Add(new Paragraph("Patient Information", FontFactory.GetFont("Arial Black", 16)));
                doc.Add(new Paragraph($"Name: {txtpname.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph($"Address: {txtaddress.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph(" "));

                // Test Information
                doc.Add(new Paragraph("Test Information", FontFactory.GetFont("Arial Black", 16)));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"Test Name: {lblTestName.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"Invoice No: {txtInvoiceNo.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"Issued Date: {txtIssuedDate.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph($"Received Date: {txtReceivedDate.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph($"Cashier ID: {txtCashierID.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph(" "));

                // Test Results and Criteria
                doc.Add(new Paragraph("Medical Test Results", FontFactory.GetFont("Arial Black", 16)));
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.AddCell(new PdfPCell(new Phrase("Tested For", FontFactory.GetFont("Arial Black", 12))));
                table.AddCell(new PdfPCell(new Phrase("Results", FontFactory.GetFont("Arial Black", 12))));
                doc.Add(new Paragraph(" "));

                // Add test criteria and results
                for (int i = 0; i < listBoxCritiria.Items.Count; i++)
                {
                    table.AddCell(new PdfPCell(new Phrase(listBoxCritiria.Items[i].ToString(), FontFactory.GetFont("Arial", 12))));
                    table.AddCell(new PdfPCell(new Phrase(listBoxCResult.Items[i].ToString(), FontFactory.GetFont("Arial", 12))));
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"Technologist ID: {txtTechnologistID.Text}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph("Authorized Signature: _____________________", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph("Date: _____________________", FontFactory.GetFont("Arial", 12)));

                // Close the document
                doc.Close();

                // Store the PDF path at the form level
                pdfPath = filePath;

                MessageBox.Show("PDF has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
        }

        private void UpdateInvoice()
        {

            string sql = " UPDATE invoice set report_status_id = 1 where id  = ('" + frm_trsltview.id + "')";
            dbObj1.Update(sql);
        }


    }
}
