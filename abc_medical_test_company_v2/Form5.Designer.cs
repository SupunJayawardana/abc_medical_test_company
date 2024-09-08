namespace abc_medical_test_company_v2
{
    partial class frm_addtrslt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_mainUser = new System.Windows.Forms.Panel();
            this.btnprint = new System.Windows.Forms.Button();
            this.lblTechnologistID = new System.Windows.Forms.Label();
            this.txtTechnologistID = new System.Windows.Forms.TextBox();
            this.listBoxCritiria = new System.Windows.Forms.ListBox();
            this.listBoxCResult = new System.Windows.Forms.ListBox();
            this.lblTestName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblCashierID = new System.Windows.Forms.Label();
            this.txtCashierID = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.txtReceivedDate = new System.Windows.Forms.TextBox();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.txtIssuedDate = new System.Windows.Forms.TextBox();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.cmbPatientName = new System.Windows.Forms.ComboBox();
            this.cmbtests = new System.Windows.Forms.ComboBox();
            this.cmbTechnologistID = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCritiria = new System.Windows.Forms.TextBox();
            this.txttestCResults = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddResults = new System.Windows.Forms.Button();
            this.btnCreateTestReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpdf = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_mainUser.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1031, 42);
            this.panel_header.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Results";
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.BackColor = System.Drawing.Color.White;
            this.panel_mainUser.Controls.Add(this.btnpdf);
            this.panel_mainUser.Controls.Add(this.btnprint);
            this.panel_mainUser.Controls.Add(this.lblTechnologistID);
            this.panel_mainUser.Controls.Add(this.txtTechnologistID);
            this.panel_mainUser.Controls.Add(this.listBoxCritiria);
            this.panel_mainUser.Controls.Add(this.listBoxCResult);
            this.panel_mainUser.Controls.Add(this.lblTestName);
            this.panel_mainUser.Controls.Add(this.listView1);
            this.panel_mainUser.Controls.Add(this.lbladdress);
            this.panel_mainUser.Controls.Add(this.txtaddress);
            this.panel_mainUser.Controls.Add(this.txtpname);
            this.panel_mainUser.Controls.Add(this.lblpname);
            this.panel_mainUser.Controls.Add(this.lblInvoiceNo);
            this.panel_mainUser.Controls.Add(this.txtInvoiceNo);
            this.panel_mainUser.Controls.Add(this.lblCashierID);
            this.panel_mainUser.Controls.Add(this.txtCashierID);
            this.panel_mainUser.Controls.Add(this.lblPatientName);
            this.panel_mainUser.Controls.Add(this.txtPatientName);
            this.panel_mainUser.Controls.Add(this.lblDoctorName);
            this.panel_mainUser.Controls.Add(this.txtDoctorName);
            this.panel_mainUser.Controls.Add(this.lblReceivedDate);
            this.panel_mainUser.Controls.Add(this.txtReceivedDate);
            this.panel_mainUser.Controls.Add(this.lblIssuedDate);
            this.panel_mainUser.Controls.Add(this.txtIssuedDate);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.ForeColor = System.Drawing.Color.Green;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 0);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(1031, 631);
            this.panel_mainUser.TabIndex = 7;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.ForestGreen;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(853, 478);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 39);
            this.btnprint.TabIndex = 53;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTechnologistID
            // 
            this.lblTechnologistID.AutoSize = true;
            this.lblTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTechnologistID.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTechnologistID.Location = new System.Drawing.Point(20, 486);
            this.lblTechnologistID.Name = "lblTechnologistID";
            this.lblTechnologistID.Size = new System.Drawing.Size(152, 20);
            this.lblTechnologistID.TabIndex = 51;
            this.lblTechnologistID.Text = "Technologist ID :";
            // 
            // txtTechnologistID
            // 
            this.txtTechnologistID.BackColor = System.Drawing.Color.White;
            this.txtTechnologistID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTechnologistID.ForeColor = System.Drawing.Color.Green;
            this.txtTechnologistID.Location = new System.Drawing.Point(198, 486);
            this.txtTechnologistID.Name = "txtTechnologistID";
            this.txtTechnologistID.Size = new System.Drawing.Size(175, 20);
            this.txtTechnologistID.TabIndex = 52;
            // 
            // listBoxCritiria
            // 
            this.listBoxCritiria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCritiria.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCritiria.ForeColor = System.Drawing.Color.Green;
            this.listBoxCritiria.FormattingEnabled = true;
            this.listBoxCritiria.ItemHeight = 20;
            this.listBoxCritiria.Location = new System.Drawing.Point(87, 305);
            this.listBoxCritiria.Name = "listBoxCritiria";
            this.listBoxCritiria.Size = new System.Drawing.Size(280, 180);
            this.listBoxCritiria.TabIndex = 50;
            // 
            // listBoxCResult
            // 
            this.listBoxCResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCResult.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCResult.ForeColor = System.Drawing.Color.Green;
            this.listBoxCResult.FormattingEnabled = true;
            this.listBoxCResult.ItemHeight = 20;
            this.listBoxCResult.Location = new System.Drawing.Point(399, 305);
            this.listBoxCResult.Name = "listBoxCResult";
            this.listBoxCResult.Size = new System.Drawing.Size(474, 180);
            this.listBoxCResult.TabIndex = 50;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTestName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTestName.Location = new System.Drawing.Point(304, 253);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(119, 20);
            this.lblTestName.TabIndex = 49;
            this.lblTestName.Text = "lblTESTnAME";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 289);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1031, 342);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbladdress.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbladdress.Location = new System.Drawing.Point(20, 122);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(90, 20);
            this.lbladdress.TabIndex = 30;
            this.lbladdress.Text = "Address :";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddress.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtaddress.ForeColor = System.Drawing.Color.Green;
            this.txtaddress.Location = new System.Drawing.Point(161, 122);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(262, 59);
            this.txtaddress.TabIndex = 27;
            // 
            // txtpname
            // 
            this.txtpname.BackColor = System.Drawing.Color.White;
            this.txtpname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtpname.ForeColor = System.Drawing.Color.Green;
            this.txtpname.Location = new System.Drawing.Point(161, 61);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(176, 20);
            this.txtpname.TabIndex = 28;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblpname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpname.Location = new System.Drawing.Point(20, 61);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(135, 20);
            this.lblpname.TabIndex = 25;
            this.lblpname.Text = "Patient Name :";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInvoiceNo.Location = new System.Drawing.Point(20, 210);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(111, 20);
            this.lblInvoiceNo.TabIndex = 31;
            this.lblInvoiceNo.Text = "Invoice No :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.White;
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceNo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.Green;
            this.txtInvoiceNo.Location = new System.Drawing.Point(138, 210);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(96, 20);
            this.txtInvoiceNo.TabIndex = 32;
            // 
            // lblCashierID
            // 
            this.lblCashierID.AutoSize = true;
            this.lblCashierID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCashierID.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCashierID.Location = new System.Drawing.Point(484, 61);
            this.lblCashierID.Name = "lblCashierID";
            this.lblCashierID.Size = new System.Drawing.Size(108, 20);
            this.lblCashierID.TabIndex = 35;
            this.lblCashierID.Text = "Cashier ID :";
            // 
            // txtCashierID
            // 
            this.txtCashierID.BackColor = System.Drawing.Color.White;
            this.txtCashierID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCashierID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCashierID.ForeColor = System.Drawing.Color.Green;
            this.txtCashierID.Location = new System.Drawing.Point(646, 61);
            this.txtCashierID.Name = "txtCashierID";
            this.txtCashierID.Size = new System.Drawing.Size(187, 20);
            this.txtCashierID.TabIndex = 36;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPatientName.Location = new System.Drawing.Point(20, 18);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(135, 20);
            this.lblPatientName.TabIndex = 37;
            this.lblPatientName.Text = "Patient Name :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPatientName.ForeColor = System.Drawing.Color.Green;
            this.txtPatientName.Location = new System.Drawing.Point(182, 15);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(241, 20);
            this.txtPatientName.TabIndex = 38;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDoctorName.Location = new System.Drawing.Point(484, 18);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(133, 20);
            this.lblDoctorName.TabIndex = 39;
            this.lblDoctorName.Text = "Doctor Name :";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BackColor = System.Drawing.Color.White;
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoctorName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtDoctorName.ForeColor = System.Drawing.Color.Green;
            this.txtDoctorName.Location = new System.Drawing.Point(646, 15);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(282, 20);
            this.txtDoctorName.TabIndex = 40;
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblReceivedDate.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblReceivedDate.Location = new System.Drawing.Point(257, 210);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(142, 20);
            this.lblReceivedDate.TabIndex = 41;
            this.lblReceivedDate.Text = "Received Date :";
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.BackColor = System.Drawing.Color.White;
            this.txtReceivedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceivedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtReceivedDate.ForeColor = System.Drawing.Color.Green;
            this.txtReceivedDate.Location = new System.Drawing.Point(405, 210);
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.Size = new System.Drawing.Size(238, 20);
            this.txtReceivedDate.TabIndex = 42;
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIssuedDate.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblIssuedDate.Location = new System.Drawing.Point(657, 210);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(121, 20);
            this.lblIssuedDate.TabIndex = 43;
            this.lblIssuedDate.Text = "Issued Date :";
            // 
            // txtIssuedDate
            // 
            this.txtIssuedDate.BackColor = System.Drawing.Color.White;
            this.txtIssuedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssuedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtIssuedDate.ForeColor = System.Drawing.Color.Green;
            this.txtIssuedDate.Location = new System.Drawing.Point(784, 210);
            this.txtIssuedDate.Name = "txtIssuedDate";
            this.txtIssuedDate.Size = new System.Drawing.Size(236, 20);
            this.txtIssuedDate.TabIndex = 44;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_footer.Controls.Add(this.cmbPatientName);
            this.panel_footer.Controls.Add(this.cmbtests);
            this.panel_footer.Controls.Add(this.cmbTechnologistID);
            this.panel_footer.Controls.Add(this.lblTest);
            this.panel_footer.Controls.Add(this.label8);
            this.panel_footer.Controls.Add(this.label9);
            this.panel_footer.Controls.Add(this.label6);
            this.panel_footer.Controls.Add(this.label2);
            this.panel_footer.Controls.Add(this.txtCritiria);
            this.panel_footer.Controls.Add(this.txttestCResults);
            this.panel_footer.Controls.Add(this.label5);
            this.panel_footer.Controls.Add(this.btnAddResults);
            this.panel_footer.Controls.Add(this.btnCreateTestReport);
            this.panel_footer.Controls.Add(this.label4);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 32);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1031, 599);
            this.panel_footer.TabIndex = 8;
            // 
            // cmbPatientName
            // 
            this.cmbPatientName.BackColor = System.Drawing.Color.ForestGreen;
            this.cmbPatientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPatientName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.cmbPatientName.ForeColor = System.Drawing.Color.White;
            this.cmbPatientName.FormattingEnabled = true;
            this.cmbPatientName.Location = new System.Drawing.Point(339, 144);
            this.cmbPatientName.Name = "cmbPatientName";
            this.cmbPatientName.Size = new System.Drawing.Size(449, 32);
            this.cmbPatientName.TabIndex = 49;
            this.cmbPatientName.UseWaitCursor = true;
            // 
            // cmbtests
            // 
            this.cmbtests.BackColor = System.Drawing.Color.ForestGreen;
            this.cmbtests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtests.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.cmbtests.ForeColor = System.Drawing.Color.White;
            this.cmbtests.FormattingEnabled = true;
            this.cmbtests.Location = new System.Drawing.Point(339, 272);
            this.cmbtests.Name = "cmbtests";
            this.cmbtests.Size = new System.Drawing.Size(449, 32);
            this.cmbtests.TabIndex = 54;
            this.cmbtests.UseWaitCursor = true;
            // 
            // cmbTechnologistID
            // 
            this.cmbTechnologistID.BackColor = System.Drawing.Color.ForestGreen;
            this.cmbTechnologistID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTechnologistID.ForeColor = System.Drawing.Color.White;
            this.cmbTechnologistID.FormattingEnabled = true;
            this.cmbTechnologistID.Location = new System.Drawing.Point(339, 211);
            this.cmbTechnologistID.Name = "cmbTechnologistID";
            this.cmbTechnologistID.Size = new System.Drawing.Size(449, 32);
            this.cmbTechnologistID.TabIndex = 50;
            this.cmbTechnologistID.UseWaitCursor = true;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.White;
            this.lblTest.Location = new System.Drawing.Point(104, 272);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(61, 20);
            this.lblTest.TabIndex = 53;
            this.lblTest.Text = "TEST :";
            this.lblTest.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(457, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 52;
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(175, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "TEST CRITIRIA :";
            this.label9.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(469, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "RESULT :";
            this.label6.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ADD TEST RESULTS :";
            this.label2.UseWaitCursor = true;
            // 
            // txtCritiria
            // 
            this.txtCritiria.BackColor = System.Drawing.Color.ForestGreen;
            this.txtCritiria.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.txtCritiria.ForeColor = System.Drawing.Color.White;
            this.txtCritiria.Location = new System.Drawing.Point(165, 367);
            this.txtCritiria.Multiline = true;
            this.txtCritiria.Name = "txtCritiria";
            this.txtCritiria.Size = new System.Drawing.Size(283, 132);
            this.txtCritiria.TabIndex = 48;
            this.txtCritiria.UseWaitCursor = true;
            // 
            // txttestCResults
            // 
            this.txttestCResults.BackColor = System.Drawing.Color.ForestGreen;
            this.txttestCResults.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.txttestCResults.ForeColor = System.Drawing.Color.White;
            this.txttestCResults.Location = new System.Drawing.Point(461, 367);
            this.txttestCResults.Multiline = true;
            this.txttestCResults.Name = "txttestCResults";
            this.txttestCResults.Size = new System.Drawing.Size(325, 132);
            this.txttestCResults.TabIndex = 48;
            this.txttestCResults.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "PATIENT NAME :";
            this.label5.UseWaitCursor = true;
            // 
            // btnAddResults
            // 
            this.btnAddResults.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResults.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResults.ForeColor = System.Drawing.Color.White;
            this.btnAddResults.Location = new System.Drawing.Point(811, 353);
            this.btnAddResults.Name = "btnAddResults";
            this.btnAddResults.Size = new System.Drawing.Size(98, 49);
            this.btnAddResults.TabIndex = 43;
            this.btnAddResults.Text = "ADD CRITIRIA";
            this.btnAddResults.UseVisualStyleBackColor = false;
            this.btnAddResults.UseWaitCursor = true;
            this.btnAddResults.Click += new System.EventHandler(this.btnAddResults_Click);
            // 
            // btnCreateTestReport
            // 
            this.btnCreateTestReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateTestReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTestReport.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTestReport.ForeColor = System.Drawing.Color.White;
            this.btnCreateTestReport.Location = new System.Drawing.Point(811, 408);
            this.btnCreateTestReport.Name = "btnCreateTestReport";
            this.btnCreateTestReport.Size = new System.Drawing.Size(98, 69);
            this.btnCreateTestReport.TabIndex = 44;
            this.btnCreateTestReport.Text = "CREATE TEST REPORT";
            this.btnCreateTestReport.UseVisualStyleBackColor = false;
            this.btnCreateTestReport.UseWaitCursor = true;
            this.btnCreateTestReport.Click += new System.EventHandler(this.btnCreateTestReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "TECHNOLOGIST NAME :";
            this.label4.UseWaitCursor = true;
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(740, 486);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(75, 23);
            this.btnpdf.TabIndex = 54;
            this.btnpdf.Text = "PDF";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // frm_addtrslt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 631);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_mainUser);
            this.Name = "frm_addtrslt";
            this.Text = "ADD TEST RESULTS";
            this.Load += new System.EventHandler(this.frm_addtrslt_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_mainUser.ResumeLayout(false);
            this.panel_mainUser.PerformLayout();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblCashierID;
        private System.Windows.Forms.TextBox txtCashierID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.TextBox txtReceivedDate;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.TextBox txtIssuedDate;
        private System.Windows.Forms.ComboBox cmbPatientName;
        private System.Windows.Forms.ComboBox cmbtests;
        private System.Windows.Forms.ComboBox cmbTechnologistID;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttestCResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddResults;
        private System.Windows.Forms.Button btnCreateTestReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBoxCritiria;
        private System.Windows.Forms.ListBox listBoxCResult;
        private System.Windows.Forms.Label lblTechnologistID;
        private System.Windows.Forms.TextBox txtTechnologistID;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCritiria;
        private System.Windows.Forms.Button btnpdf;
    }
}
