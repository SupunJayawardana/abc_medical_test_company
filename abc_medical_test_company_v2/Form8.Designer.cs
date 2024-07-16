namespace abc_medical_test_company_v2
{
    partial class frm_invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_mainUser = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtTechnologistID = new System.Windows.Forms.TextBox();
            this.lblTechnologistID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtIssuedDate = new System.Windows.Forms.TextBox();
            this.txtCashierID = new System.Windows.Forms.TextBox();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.lblCashierID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbxtestprice = new System.Windows.Forms.ListBox();
            this.lbxtestdesc = new System.Windows.Forms.ListBox();
            this.lbxtest = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel_ChooseInvoice = new System.Windows.Forms.Panel();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.cmbtests = new System.Windows.Forms.ComboBox();
            this.cmbTechnologistID = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.cmbCashierID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttestdescrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTests = new System.Windows.Forms.Button();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_mainUser.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_ChooseInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEDICAL TEST BILLING INVOICE";
            this.label1.UseWaitCursor = true;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1087, 42);
            this.panel_header.TabIndex = 9;
            this.panel_header.UseWaitCursor = true;
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.Controls.Add(this.panel5);
            this.panel_mainUser.Controls.Add(this.panel2);
            this.panel_mainUser.Controls.Add(this.panel4);
            this.panel_mainUser.Controls.Add(this.panel3);
            this.panel_mainUser.Controls.Add(this.panel_ChooseInvoice);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 0);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(1087, 631);
            this.panel_mainUser.TabIndex = 10;
            this.panel_mainUser.UseWaitCursor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPatientAddress);
            this.panel5.Controls.Add(this.txtPatientName);
            this.panel5.Controls.Add(this.lblPatientName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 0);
            this.panel5.TabIndex = 0;
            this.panel5.UseWaitCursor = true;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientAddress.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPatientAddress.ForeColor = System.Drawing.Color.Green;
            this.txtPatientAddress.Location = new System.Drawing.Point(70, 106);
            this.txtPatientAddress.Multiline = true;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(214, 96);
            this.txtPatientAddress.TabIndex = 34;
            this.txtPatientAddress.UseWaitCursor = true;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPatientName.ForeColor = System.Drawing.Color.Green;
            this.txtPatientName.Location = new System.Drawing.Point(70, 78);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(214, 20);
            this.txtPatientName.TabIndex = 34;
            this.txtPatientName.UseWaitCursor = true;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPatientName.Location = new System.Drawing.Point(66, 52);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(205, 20);
            this.lblPatientName.TabIndex = 33;
            this.lblPatientName.Text = "PATIENT INFORMATION";
            this.lblPatientName.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDoctorName);
            this.panel2.Controls.Add(this.lblDoctorName);
            this.panel2.Controls.Add(this.txtTechnologistID);
            this.panel2.Controls.Add(this.lblTechnologistID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 0);
            this.panel2.TabIndex = 0;
            this.panel2.UseWaitCursor = true;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoctorName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtDoctorName.ForeColor = System.Drawing.Color.Green;
            this.txtDoctorName.Location = new System.Drawing.Point(581, 75);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(214, 20);
            this.txtDoctorName.TabIndex = 37;
            this.txtDoctorName.UseWaitCursor = true;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDoctorName.Location = new System.Drawing.Point(577, 52);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(362, 20);
            this.lblDoctorName.TabIndex = 35;
            this.lblDoctorName.Text = "PERSCRIBING PHYSCIAN\'S INFORMATION";
            this.lblDoctorName.UseWaitCursor = true;
            // 
            // txtTechnologistID
            // 
            this.txtTechnologistID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTechnologistID.ForeColor = System.Drawing.Color.Green;
            this.txtTechnologistID.Location = new System.Drawing.Point(863, 182);
            this.txtTechnologistID.Name = "txtTechnologistID";
            this.txtTechnologistID.Size = new System.Drawing.Size(214, 20);
            this.txtTechnologistID.TabIndex = 30;
            this.txtTechnologistID.UseWaitCursor = true;
            // 
            // lblTechnologistID
            // 
            this.lblTechnologistID.AutoSize = true;
            this.lblTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnologistID.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTechnologistID.Location = new System.Drawing.Point(693, 182);
            this.lblTechnologistID.Name = "lblTechnologistID";
            this.lblTechnologistID.Size = new System.Drawing.Size(152, 20);
            this.lblTechnologistID.TabIndex = 29;
            this.lblTechnologistID.Text = "Technologist ID :";
            this.lblTechnologistID.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblInvoiceNo);
            this.panel4.Controls.Add(this.txtInvoiceNo);
            this.panel4.Controls.Add(this.txtIssuedDate);
            this.panel4.Controls.Add(this.txtCashierID);
            this.panel4.Controls.Add(this.lblIssuedDate);
            this.panel4.Controls.Add(this.lblCashierID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, -356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1087, 88);
            this.panel4.TabIndex = 0;
            this.panel4.UseWaitCursor = true;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInvoiceNo.Location = new System.Drawing.Point(66, 46);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(111, 20);
            this.lblInvoiceNo.TabIndex = 27;
            this.lblInvoiceNo.Text = "Invoice No :";
            this.lblInvoiceNo.UseWaitCursor = true;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceNo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.Green;
            this.txtInvoiceNo.Location = new System.Drawing.Point(193, 46);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(214, 20);
            this.txtInvoiceNo.TabIndex = 28;
            this.txtInvoiceNo.UseWaitCursor = true;
            // 
            // txtIssuedDate
            // 
            this.txtIssuedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssuedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtIssuedDate.ForeColor = System.Drawing.Color.Green;
            this.txtIssuedDate.Location = new System.Drawing.Point(581, 44);
            this.txtIssuedDate.Name = "txtIssuedDate";
            this.txtIssuedDate.Size = new System.Drawing.Size(214, 20);
            this.txtIssuedDate.TabIndex = 41;
            this.txtIssuedDate.UseWaitCursor = true;
            // 
            // txtCashierID
            // 
            this.txtCashierID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCashierID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCashierID.ForeColor = System.Drawing.Color.Green;
            this.txtCashierID.Location = new System.Drawing.Point(863, 8);
            this.txtCashierID.Name = "txtCashierID";
            this.txtCashierID.Size = new System.Drawing.Size(214, 20);
            this.txtCashierID.TabIndex = 32;
            this.txtCashierID.UseWaitCursor = true;
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedDate.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblIssuedDate.Location = new System.Drawing.Point(441, 46);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(121, 20);
            this.lblIssuedDate.TabIndex = 40;
            this.lblIssuedDate.Text = "Issued Date :";
            this.lblIssuedDate.UseWaitCursor = true;
            // 
            // lblCashierID
            // 
            this.lblCashierID.AutoSize = true;
            this.lblCashierID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierID.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCashierID.Location = new System.Drawing.Point(743, 10);
            this.lblCashierID.Name = "lblCashierID";
            this.lblCashierID.Size = new System.Drawing.Size(108, 20);
            this.lblCashierID.TabIndex = 31;
            this.lblCashierID.Text = "Cashier ID :";
            this.lblCashierID.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lbltotal);
            this.panel3.Controls.Add(this.lbxtestprice);
            this.panel3.Controls.Add(this.lbxtestdesc);
            this.panel3.Controls.Add(this.lbxtest);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, -268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 293);
            this.panel3.TabIndex = 0;
            this.panel3.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1000, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 54;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(732, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Total :";
            this.label6.UseWaitCursor = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.Color.Green;
            this.lbltotal.Location = new System.Drawing.Point(920, 207);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(50, 20);
            this.lbltotal.TabIndex = 45;
            this.lbltotal.Text = "Total";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbltotal.UseWaitCursor = true;
            // 
            // lbxtestprice
            // 
            this.lbxtestprice.BackColor = System.Drawing.Color.White;
            this.lbxtestprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxtestprice.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbxtestprice.ForeColor = System.Drawing.Color.Green;
            this.lbxtestprice.FormatString = "C2";
            this.lbxtestprice.FormattingEnabled = true;
            this.lbxtestprice.ItemHeight = 20;
            this.lbxtestprice.Location = new System.Drawing.Point(810, 71);
            this.lbxtestprice.Name = "lbxtestprice";
            this.lbxtestprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbxtestprice.Size = new System.Drawing.Size(160, 100);
            this.lbxtestprice.TabIndex = 44;
            this.lbxtestprice.UseWaitCursor = true;
            // 
            // lbxtestdesc
            // 
            this.lbxtestdesc.BackColor = System.Drawing.Color.White;
            this.lbxtestdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxtestdesc.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbxtestdesc.ForeColor = System.Drawing.Color.Green;
            this.lbxtestdesc.FormattingEnabled = true;
            this.lbxtestdesc.ItemHeight = 20;
            this.lbxtestdesc.Location = new System.Drawing.Point(433, 71);
            this.lbxtestdesc.Name = "lbxtestdesc";
            this.lbxtestdesc.Size = new System.Drawing.Size(418, 100);
            this.lbxtestdesc.TabIndex = 44;
            this.lbxtestdesc.UseWaitCursor = true;
            // 
            // lbxtest
            // 
            this.lbxtest.BackColor = System.Drawing.Color.White;
            this.lbxtest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxtest.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbxtest.ForeColor = System.Drawing.Color.Green;
            this.lbxtest.FormattingEnabled = true;
            this.lbxtest.ItemHeight = 20;
            this.lbxtest.Location = new System.Drawing.Point(247, 71);
            this.lbxtest.Name = "lbxtest";
            this.lbxtest.Size = new System.Drawing.Size(211, 100);
            this.lbxtest.TabIndex = 44;
            this.lbxtest.UseWaitCursor = true;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(237, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 204);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            // 
            // panel_ChooseInvoice
            // 
            this.panel_ChooseInvoice.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_ChooseInvoice.Controls.Add(this.cmbDoctorName);
            this.panel_ChooseInvoice.Controls.Add(this.cmbtests);
            this.panel_ChooseInvoice.Controls.Add(this.cmbTechnologistID);
            this.panel_ChooseInvoice.Controls.Add(this.lblTest);
            this.panel_ChooseInvoice.Controls.Add(this.cmbCashierID);
            this.panel_ChooseInvoice.Controls.Add(this.label2);
            this.panel_ChooseInvoice.Controls.Add(this.txttestdescrip);
            this.panel_ChooseInvoice.Controls.Add(this.label5);
            this.panel_ChooseInvoice.Controls.Add(this.btnAddTests);
            this.panel_ChooseInvoice.Controls.Add(this.btnCreateInvoice);
            this.panel_ChooseInvoice.Controls.Add(this.label3);
            this.panel_ChooseInvoice.Controls.Add(this.label4);
            this.panel_ChooseInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ChooseInvoice.Location = new System.Drawing.Point(0, 25);
            this.panel_ChooseInvoice.Name = "panel_ChooseInvoice";
            this.panel_ChooseInvoice.Size = new System.Drawing.Size(1087, 606);
            this.panel_ChooseInvoice.TabIndex = 0;
            this.panel_ChooseInvoice.UseWaitCursor = true;
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.BackColor = System.Drawing.Color.ForestGreen;
            this.cmbDoctorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDoctorName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDoctorName.ForeColor = System.Drawing.Color.White;
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(462, 143);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(345, 32);
            this.cmbDoctorName.TabIndex = 38;
            this.cmbDoctorName.UseWaitCursor = true;
            // 
            // cmbtests
            // 
            this.cmbtests.BackColor = System.Drawing.Color.ForestGreen;
            this.cmbtests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtests.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.cmbtests.ForeColor = System.Drawing.Color.White;
            this.cmbtests.FormattingEnabled = true;
            this.cmbtests.Location = new System.Drawing.Point(462, 344);
            this.cmbtests.Name = "cmbtests";
            this.cmbtests.Size = new System.Drawing.Size(345, 32);
            this.cmbtests.TabIndex = 42;
            this.cmbtests.UseWaitCursor = true;
            // 
            // cmbTechnologistID
            // 
            this.cmbTechnologistID.BackColor = System.Drawing.Color.ForestGreen;
            this.cmbTechnologistID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTechnologistID.ForeColor = System.Drawing.Color.White;
            this.cmbTechnologistID.FormattingEnabled = true;
            this.cmbTechnologistID.Location = new System.Drawing.Point(462, 210);
            this.cmbTechnologistID.Name = "cmbTechnologistID";
            this.cmbTechnologistID.Size = new System.Drawing.Size(345, 32);
            this.cmbTechnologistID.TabIndex = 38;
            this.cmbTechnologistID.UseWaitCursor = true;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.White;
            this.lblTest.Location = new System.Drawing.Point(247, 344);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(61, 20);
            this.lblTest.TabIndex = 39;
            this.lblTest.Text = "TEST :";
            this.lblTest.UseWaitCursor = true;
            // 
            // cmbCashierID
            // 
            this.cmbCashierID.BackColor = System.Drawing.Color.ForestGreen;
            this.cmbCashierID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCashierID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.cmbCashierID.ForeColor = System.Drawing.Color.White;
            this.cmbCashierID.FormattingEnabled = true;
            this.cmbCashierID.Location = new System.Drawing.Point(462, 277);
            this.cmbCashierID.Name = "cmbCashierID";
            this.cmbCashierID.Size = new System.Drawing.Size(345, 32);
            this.cmbCashierID.TabIndex = 38;
            this.cmbCashierID.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "TEST DESCRIPTION :";
            this.label2.UseWaitCursor = true;
            // 
            // txttestdescrip
            // 
            this.txttestdescrip.BackColor = System.Drawing.Color.ForestGreen;
            this.txttestdescrip.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.txttestdescrip.ForeColor = System.Drawing.Color.White;
            this.txttestdescrip.Location = new System.Drawing.Point(462, 411);
            this.txttestdescrip.Multiline = true;
            this.txttestdescrip.Name = "txttestdescrip";
            this.txttestdescrip.Size = new System.Drawing.Size(345, 93);
            this.txttestdescrip.TabIndex = 36;
            this.txttestdescrip.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "PHISCIAN NAME :";
            this.label5.UseWaitCursor = true;
            // 
            // btnAddTests
            // 
            this.btnAddTests.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTests.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTests.ForeColor = System.Drawing.Color.White;
            this.btnAddTests.Location = new System.Drawing.Point(826, 447);
            this.btnAddTests.Name = "btnAddTests";
            this.btnAddTests.Size = new System.Drawing.Size(61, 49);
            this.btnAddTests.TabIndex = 26;
            this.btnAddTests.Text = "Add Test";
            this.btnAddTests.UseVisualStyleBackColor = false;
            this.btnAddTests.UseWaitCursor = true;
            this.btnAddTests.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInvoice.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Location = new System.Drawing.Point(893, 447);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(84, 49);
            this.btnCreateInvoice.TabIndex = 26;
            this.btnCreateInvoice.Text = "CREATE INVOICE";
            this.btnCreateInvoice.UseVisualStyleBackColor = false;
            this.btnCreateInvoice.UseWaitCursor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "CASHIER NAME :";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(247, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "TECHNOLOGIST NAME :";
            this.label4.UseWaitCursor = true;
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 631);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_mainUser);
            this.Name = "frm_invoice";
            this.Text = "INVOICE GENERATER";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frm_invoice_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_mainUser.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_ChooseInvoice.ResumeLayout(false);
            this.panel_ChooseInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_ChooseInvoice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.ComboBox cmbtests;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Label lblTechnologistID;
        private System.Windows.Forms.TextBox txtTechnologistID;
        private System.Windows.Forms.Label lblCashierID;
        private System.Windows.Forms.TextBox txtCashierID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txttestdescrip;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.TextBox txtIssuedDate;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.ComboBox cmbTechnologistID;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.ComboBox cmbCashierID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxtest;
        private System.Windows.Forms.ListBox lbxtestprice;
        private System.Windows.Forms.ListBox lbxtestdesc;
        private System.Windows.Forms.Button btnAddTests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}