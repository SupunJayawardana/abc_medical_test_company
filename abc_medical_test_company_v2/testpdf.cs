using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace abc_medical_test_company_v2
{
    public partial class testpdf : Form
    {
        public testpdf()
        {
            InitializeComponent();
        }

        // Export Invoice PDF Button
        private void btnpdf_Click(object sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Add timestamp to filename
            string pdfFilePath = $@"C:\PDF\invoice_{timestamp}.pdf"; // Path with timestamp
            ExportInvoiceToPdf(pdfFilePath);
            MessageBox.Show("Invoice exported to PDF successfully!");
        }

        // Print Invoice PDF Button
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Add timestamp to filename
            string pdfFilePath = $@"C:\PDF\invoice_{timestamp}.pdf"; // Path with timestamp

            // Ensure the file is exported before printing
            ExportInvoiceToPdf(pdfFilePath);

            // Print the PDF after exporting it
            PrintPdf(pdfFilePath);

            MessageBox.Show("Invoice exported to PDF and sent to the printer!");
        }

        // Method to export invoice to PDF
        private void ExportInvoiceToPdf(string pdfFilePath)
        {
            // Create a PDF document
            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // Add a logo image
                string logoPath = @"C:\Users\asthr\OneDrive\Pictures\projicons\logo.png"; // Update the path to your logo image
                iTextSharp.text.Image logoImage = iTextSharp.text.Image.GetInstance(logoPath);
                logoImage.ScaleToFit(100f, 100f); // Scale logo to fit
                logoImage.Alignment = Element.ALIGN_LEFT;
                document.Add(logoImage);

                // Add invoice details
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("ABC Medical Test Company", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)));
                document.Add(new Paragraph("123 Medical Lane"));
                document.Add(new Paragraph("City, State, 12345"));
                document.Add(new Paragraph("Phone: (123) 456-7890"));
                document.Add(new Paragraph("Email: info@abcmedical.com"));
                document.Add(new Paragraph(" "));

                // Invoice title
                document.Add(new Paragraph("Invoice", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                document.Add(new Paragraph(" "));

                // Customer details
                document.Add(new Paragraph("Bill To:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                document.Add(new Paragraph("John Doe"));
                document.Add(new Paragraph("456 Customer St."));
                document.Add(new Paragraph("City, State, 67890"));
                document.Add(new Paragraph("Phone: (987) 654-3210"));
                document.Add(new Paragraph("Email: john.doe@example.com"));
                document.Add(new Paragraph(" "));

                // Table with invoice items
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;

                // Table headers
                table.AddCell("Description");
                table.AddCell("Quantity");
                table.AddCell("Unit Price");
                table.AddCell("Total");

                // Sample data
                table.AddCell("Medical Test A");
                table.AddCell("2");
                table.AddCell("$50.00");
                table.AddCell("$100.00");

                table.AddCell("Medical Test B");
                table.AddCell("1");
                table.AddCell("$75.00");
                table.AddCell("$75.00");

                // Add total row
                table.AddCell("");
                table.AddCell("");
                table.AddCell("Subtotal");
                table.AddCell("$175.00");

                table.AddCell("");
                table.AddCell("");
                table.AddCell("Tax (5%)");
                table.AddCell("$8.75");

                table.AddCell("");
                table.AddCell("");
                table.AddCell("Total");
                table.AddCell("$183.75");

                document.Add(table);

                // Footer
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("Thank you for your business!", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12)));

                document.Close();
            }
        }

        // Method to print the PDF
        private void PrintPdf(string pdfFilePath)
        {
            // Print the PDF using the default PDF viewer
            Process printProcess = new Process();
            printProcess.StartInfo.FileName = pdfFilePath;
            printProcess.StartInfo.Verb = "print"; // Open the file with the "print" verb
            printProcess.StartInfo.CreateNoWindow = true;
            printProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            printProcess.Start();

            // Optional: Wait for the printing process to complete before closing
            printProcess.WaitForExit();
        }
    }
}
