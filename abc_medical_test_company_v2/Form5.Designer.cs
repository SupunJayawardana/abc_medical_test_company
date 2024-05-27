namespace abc_medical_test_company_v2
{
    partial class Form5
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txttelno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbltelno = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.dgv_userReg = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel_mainUser = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblTechnologistID = new System.Windows.Forms.Label();
            this.txtTechnologistID = new System.Windows.Forms.TextBox();
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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).BeginInit();
            this.panel_mainUser.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(692, 127);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(101, 24);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // cmbsearch
            // 
            this.cmbsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Location = new System.Drawing.Point(595, 95);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(198, 24);
            this.cmbsearch.TabIndex = 4;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(10, 212);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(61, 15);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Address :";
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(117, 180);
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(176, 22);
            this.txttelno.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(117, 146);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(176, 22);
            this.txtemail.TabIndex = 2;
            // 
            // lbltelno
            // 
            this.lbltelno.AutoSize = true;
            this.lbltelno.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelno.Location = new System.Drawing.Point(10, 184);
            this.lbltelno.Name = "lbltelno";
            this.lbltelno.Size = new System.Drawing.Size(50, 15);
            this.lbltelno.TabIndex = 1;
            this.lbltelno.Text = "Tel No :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(10, 150);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 15);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email :";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(800, 42);
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
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(117, 208);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(176, 59);
            this.txtaddress.TabIndex = 2;
            // 
            // dgv_userReg
            // 
            this.dgv_userReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_userReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_userReg.Location = new System.Drawing.Point(0, 0);
            this.dgv_userReg.Name = "dgv_userReg";
            this.dgv_userReg.RowHeadersWidth = 51;
            this.dgv_userReg.RowTemplate.Height = 24;
            this.dgv_userReg.Size = new System.Drawing.Size(800, 408);
            this.dgv_userReg.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(597, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(597, 162);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 59);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(691, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 104);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.Controls.Add(this.dgv_userReg);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 42);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(800, 408);
            this.panel_mainUser.TabIndex = 7;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.btnsearch);
            this.panel_footer.Controls.Add(this.cmbsearch);
            this.panel_footer.Controls.Add(this.lbladdress);
            this.panel_footer.Controls.Add(this.txtaddress);
            this.panel_footer.Controls.Add(this.txttelno);
            this.panel_footer.Controls.Add(this.txtemail);
            this.panel_footer.Controls.Add(this.lbltelno);
            this.panel_footer.Controls.Add(this.lblemail);
            this.panel_footer.Controls.Add(this.btnDelete);
            this.panel_footer.Controls.Add(this.btnUpdate);
            this.panel_footer.Controls.Add(this.btnAdd);
            this.panel_footer.Controls.Add(this.lblInvoiceNo);
            this.panel_footer.Controls.Add(this.txtInvoiceNo);
            this.panel_footer.Controls.Add(this.lblTechnologistID);
            this.panel_footer.Controls.Add(this.txtTechnologistID);
            this.panel_footer.Controls.Add(this.lblCashierID);
            this.panel_footer.Controls.Add(this.txtCashierID);
            this.panel_footer.Controls.Add(this.lblPatientName);
            this.panel_footer.Controls.Add(this.txtPatientName);
            this.panel_footer.Controls.Add(this.lblDoctorName);
            this.panel_footer.Controls.Add(this.txtDoctorName);
            this.panel_footer.Controls.Add(this.lblReceivedDate);
            this.panel_footer.Controls.Add(this.txtReceivedDate);
            this.panel_footer.Controls.Add(this.lblIssuedDate);
            this.panel_footer.Controls.Add(this.txtIssuedDate);
            this.panel_footer.Controls.Add(this.lblResult);
            this.panel_footer.Controls.Add(this.txtResult);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 175);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(800, 275);
            this.panel_footer.TabIndex = 8;
            this.panel_footer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_footer_Paint);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(10, 15);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(75, 15);
            this.lblInvoiceNo.TabIndex = 9;
            this.lblInvoiceNo.Text = "Invoice No :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(117, 12);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(176, 22);
            this.txtInvoiceNo.TabIndex = 10;
            // 
            // lblTechnologistID
            // 
            this.lblTechnologistID.AutoSize = true;
            this.lblTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnologistID.Location = new System.Drawing.Point(10, 50);
            this.lblTechnologistID.Name = "lblTechnologistID";
            this.lblTechnologistID.Size = new System.Drawing.Size(101, 15);
            this.lblTechnologistID.TabIndex = 11;
            this.lblTechnologistID.Text = "Technologist ID :";
            // 
            // txtTechnologistID
            // 
            this.txtTechnologistID.Location = new System.Drawing.Point(117, 47);
            this.txtTechnologistID.Name = "txtTechnologistID";
            this.txtTechnologistID.Size = new System.Drawing.Size(176, 22);
            this.txtTechnologistID.TabIndex = 12;
            // 
            // lblCashierID
            // 
            this.lblCashierID.AutoSize = true;
            this.lblCashierID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierID.Location = new System.Drawing.Point(10, 85);
            this.lblCashierID.Name = "lblCashierID";
            this.lblCashierID.Size = new System.Drawing.Size(74, 15);
            this.lblCashierID.TabIndex = 13;
            this.lblCashierID.Text = "Cashier ID :";
            // 
            // txtCashierID
            // 
            this.txtCashierID.Location = new System.Drawing.Point(117, 82);
            this.txtCashierID.Name = "txtCashierID";
            this.txtCashierID.Size = new System.Drawing.Size(176, 22);
            this.txtCashierID.TabIndex = 14;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(313, 15);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(93, 15);
            this.lblPatientName.TabIndex = 15;
            this.lblPatientName.Text = "Patient Name :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(416, 12);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(168, 22);
            this.txtPatientName.TabIndex = 16;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(313, 50);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(92, 15);
            this.lblDoctorName.TabIndex = 17;
            this.lblDoctorName.Text = "Doctor Name :";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(416, 47);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(168, 22);
            this.txtDoctorName.TabIndex = 18;
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedDate.Location = new System.Drawing.Point(313, 85);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(98, 15);
            this.lblReceivedDate.TabIndex = 19;
            this.lblReceivedDate.Text = "Received Date :";
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.Location = new System.Drawing.Point(416, 82);
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.Size = new System.Drawing.Size(168, 22);
            this.txtReceivedDate.TabIndex = 20;
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedDate.Location = new System.Drawing.Point(10, 119);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(83, 15);
            this.lblIssuedDate.TabIndex = 21;
            this.lblIssuedDate.Text = "Issued Date :";
            // 
            // txtIssuedDate
            // 
            this.txtIssuedDate.Location = new System.Drawing.Point(117, 116);
            this.txtIssuedDate.Name = "txtIssuedDate";
            this.txtIssuedDate.Size = new System.Drawing.Size(176, 22);
            this.txtIssuedDate.TabIndex = 22;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(313, 119);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(50, 15);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Result :";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(369, 116);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(215, 151);
            this.txtResult.TabIndex = 24;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_mainUser);
            this.Controls.Add(this.panel_header);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).EndInit();
            this.panel_mainUser.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txttelno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbltelno;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.DataGridView dgv_userReg;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblTechnologistID;
        private System.Windows.Forms.TextBox txtTechnologistID;
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
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}
