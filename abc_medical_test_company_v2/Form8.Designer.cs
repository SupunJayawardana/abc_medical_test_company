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
            this.dgv_userReg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_mainUser = new System.Windows.Forms.Panel();
            this.txtIssuedDate = new System.Windows.Forms.TextBox();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtCashierID = new System.Windows.Forms.TextBox();
            this.lblCashierID = new System.Windows.Forms.Label();
            this.txtTechnologistID = new System.Windows.Forms.TextBox();
            this.lblTechnologistID = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).BeginInit();
            this.panel_header.SuspendLayout();
            this.panel_mainUser.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv_userReg.Size = new System.Drawing.Size(800, 450);
            this.dgv_userReg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(800, 42);
            this.panel_header.TabIndex = 9;
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.Controls.Add(this.dgv_userReg);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 0);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(800, 450);
            this.panel_mainUser.TabIndex = 10;
            // 
            // txtIssuedDate
            // 
            this.txtIssuedDate.Location = new System.Drawing.Point(113, 107);
            this.txtIssuedDate.Name = "txtIssuedDate";
            this.txtIssuedDate.Size = new System.Drawing.Size(176, 22);
            this.txtIssuedDate.TabIndex = 22;
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedDate.Location = new System.Drawing.Point(6, 110);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(83, 15);
            this.lblIssuedDate.TabIndex = 21;
            this.lblIssuedDate.Text = "Issued Date :";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(309, 76);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(38, 15);
            this.lblTest.TabIndex = 19;
            this.lblTest.Text = "Test :";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(412, 38);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(168, 22);
            this.txtDoctorName.TabIndex = 18;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(309, 41);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(92, 15);
            this.lblDoctorName.TabIndex = 17;
            this.lblDoctorName.Text = "Doctor Name :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(412, 3);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(168, 22);
            this.txtPatientName.TabIndex = 16;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(309, 6);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(93, 15);
            this.lblPatientName.TabIndex = 15;
            this.lblPatientName.Text = "Patient Name :";
            // 
            // txtCashierID
            // 
            this.txtCashierID.Location = new System.Drawing.Point(113, 73);
            this.txtCashierID.Name = "txtCashierID";
            this.txtCashierID.Size = new System.Drawing.Size(176, 22);
            this.txtCashierID.TabIndex = 14;
            // 
            // lblCashierID
            // 
            this.lblCashierID.AutoSize = true;
            this.lblCashierID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierID.Location = new System.Drawing.Point(6, 76);
            this.lblCashierID.Name = "lblCashierID";
            this.lblCashierID.Size = new System.Drawing.Size(74, 15);
            this.lblCashierID.TabIndex = 13;
            this.lblCashierID.Text = "Cashier ID :";
            // 
            // txtTechnologistID
            // 
            this.txtTechnologistID.Location = new System.Drawing.Point(113, 38);
            this.txtTechnologistID.Name = "txtTechnologistID";
            this.txtTechnologistID.Size = new System.Drawing.Size(176, 22);
            this.txtTechnologistID.TabIndex = 12;
            // 
            // lblTechnologistID
            // 
            this.lblTechnologistID.AutoSize = true;
            this.lblTechnologistID.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnologistID.Location = new System.Drawing.Point(6, 41);
            this.lblTechnologistID.Name = "lblTechnologistID";
            this.lblTechnologistID.Size = new System.Drawing.Size(101, 15);
            this.lblTechnologistID.TabIndex = 11;
            this.lblTechnologistID.Text = "Technologist ID :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(113, 3);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(176, 22);
            this.txtInvoiceNo.TabIndex = 10;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(6, 6);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(75, 15);
            this.lblInvoiceNo.TabIndex = 9;
            this.lblInvoiceNo.Text = "Invoice No :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(687, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 104);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(593, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 59);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(593, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // cmbsearch
            // 
            this.cmbsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Location = new System.Drawing.Point(591, 12);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(198, 24);
            this.cmbsearch.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(688, 44);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(101, 24);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.comboBox1);
            this.panel_footer.Controls.Add(this.btnsearch);
            this.panel_footer.Controls.Add(this.cmbsearch);
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
            this.panel_footer.Controls.Add(this.textBox1);
            this.panel_footer.Controls.Add(this.txtDoctorName);
            this.panel_footer.Controls.Add(this.label2);
            this.panel_footer.Controls.Add(this.lblTest);
            this.panel_footer.Controls.Add(this.lblIssuedDate);
            this.panel_footer.Controls.Add(this.txtIssuedDate);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 256);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(800, 194);
            this.panel_footer.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Test Description :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 73);
            this.textBox1.TabIndex = 18;
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_mainUser);
            this.Name = "frm_invoice";
            this.Text = "INVOICE GENERATER";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_mainUser.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_userReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.TextBox txtIssuedDate;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtCashierID;
        private System.Windows.Forms.Label lblCashierID;
        private System.Windows.Forms.TextBox txtTechnologistID;
        private System.Windows.Forms.Label lblTechnologistID;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}