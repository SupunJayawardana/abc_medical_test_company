namespace abc_medical_test_company_v2
{
    partial class frm_patient
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
            this.lbladdress = new System.Windows.Forms.Label();
            this.txttelno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lbltelno = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel_mainUser = new System.Windows.Forms.Panel();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearchpatient = new System.Windows.Forms.Button();
            this.btnAddpanel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dgv_userReg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btninvoice = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_mainUser.SuspendLayout();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbladdress.ForeColor = System.Drawing.Color.White;
            this.lbladdress.Location = new System.Drawing.Point(336, 307);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(79, 20);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Address";
            // 
            // txttelno
            // 
            this.txttelno.BackColor = System.Drawing.Color.DarkGreen;
            this.txttelno.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txttelno.ForeColor = System.Drawing.Color.White;
            this.txttelno.Location = new System.Drawing.Point(336, 274);
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(253, 27);
            this.txttelno.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.DarkGreen;
            this.txtemail.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(336, 221);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(253, 27);
            this.txtemail.TabIndex = 2;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.DarkGreen;
            this.txtfname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtfname.ForeColor = System.Drawing.Color.White;
            this.txtfname.Location = new System.Drawing.Point(336, 168);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(253, 27);
            this.txtfname.TabIndex = 2;
            // 
            // lbltelno
            // 
            this.lbltelno.AutoSize = true;
            this.lbltelno.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbltelno.ForeColor = System.Drawing.Color.White;
            this.lbltelno.Location = new System.Drawing.Point(336, 251);
            this.lbltelno.Name = "lbltelno";
            this.lbltelno.Size = new System.Drawing.Size(61, 20);
            this.lbltelno.TabIndex = 1;
            this.lbltelno.Text = "Tel No";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(336, 198);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(60, 20);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email ";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblfname.ForeColor = System.Drawing.Color.White;
            this.lblfname.Location = new System.Drawing.Point(336, 145);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(129, 20);
            this.lblfname.TabIndex = 1;
            this.lblfname.Text = "Patient Name ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(616, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(616, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(616, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.Controls.Add(this.panel_edit);
            this.panel_mainUser.Controls.Add(this.dgv_userReg);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 53);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(1087, 0);
            this.panel_mainUser.TabIndex = 4;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.Transparent;
            this.panel_edit.Controls.Add(this.txtsearch);
            this.panel_edit.Controls.Add(this.btnSearchpatient);
            this.panel_edit.Controls.Add(this.btnAddpanel);
            this.panel_edit.Controls.Add(this.btnedit);
            this.panel_edit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_edit.Location = new System.Drawing.Point(0, -98);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(1087, 98);
            this.panel_edit.TabIndex = 3;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.DarkGreen;
            this.txtsearch.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtsearch.ForeColor = System.Drawing.Color.White;
            this.txtsearch.Location = new System.Drawing.Point(391, 14);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(304, 27);
            this.txtsearch.TabIndex = 7;
            // 
            // btnSearchpatient
            // 
            this.btnSearchpatient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchpatient.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearchpatient.ForeColor = System.Drawing.Color.White;
            this.btnSearchpatient.Location = new System.Drawing.Point(476, 47);
            this.btnSearchpatient.Name = "btnSearchpatient";
            this.btnSearchpatient.Size = new System.Drawing.Size(134, 33);
            this.btnSearchpatient.TabIndex = 6;
            this.btnSearchpatient.Text = "Search";
            this.btnSearchpatient.UseVisualStyleBackColor = true;
            this.btnSearchpatient.Click += new System.EventHandler(this.btnSearchpatient_Click);
            // 
            // btnAddpanel
            // 
            this.btnAddpanel.BackColor = System.Drawing.Color.Transparent;
            this.btnAddpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddpanel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddpanel.ForeColor = System.Drawing.Color.White;
            this.btnAddpanel.Location = new System.Drawing.Point(322, 47);
            this.btnAddpanel.Name = "btnAddpanel";
            this.btnAddpanel.Size = new System.Drawing.Size(134, 33);
            this.btnAddpanel.TabIndex = 5;
            this.btnAddpanel.Text = "Register Patient";
            this.btnAddpanel.UseVisualStyleBackColor = false;
            this.btnAddpanel.Click += new System.EventHandler(this.btnAddpanel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(621, 47);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(134, 33);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.Btnedit);
            // 
            // dgv_userReg
            // 
            this.dgv_userReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_userReg.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dgv_userReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_userReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_userReg.Location = new System.Drawing.Point(0, 0);
            this.dgv_userReg.Name = "dgv_userReg";
            this.dgv_userReg.RowHeadersWidth = 51;
            this.dgv_userReg.RowTemplate.Height = 24;
            this.dgv_userReg.Size = new System.Drawing.Size(1087, 0);
            this.dgv_userReg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Information";
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.btncancel);
            this.panel_footer.Controls.Add(this.btninvoice);
            this.panel_footer.Controls.Add(this.lbladdress);
            this.panel_footer.Controls.Add(this.txtaddress);
            this.panel_footer.Controls.Add(this.txttelno);
            this.panel_footer.Controls.Add(this.txtemail);
            this.panel_footer.Controls.Add(this.txtnic);
            this.panel_footer.Controls.Add(this.txtfname);
            this.panel_footer.Controls.Add(this.lbltelno);
            this.panel_footer.Controls.Add(this.label2);
            this.panel_footer.Controls.Add(this.lblemail);
            this.panel_footer.Controls.Add(this.lblfname);
            this.panel_footer.Controls.Add(this.btnDelete);
            this.panel_footer.Controls.Add(this.btnUpdate);
            this.panel_footer.Controls.Add(this.btnAdd);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel_footer.ForeColor = System.Drawing.Color.White;
            this.panel_footer.Location = new System.Drawing.Point(0, 53);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1087, 578);
            this.panel_footer.TabIndex = 5;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(616, 400);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(134, 33);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btninvoice
            // 
            this.btninvoice.BackColor = System.Drawing.Color.Transparent;
            this.btninvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninvoice.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvoice.ForeColor = System.Drawing.Color.White;
            this.btninvoice.Location = new System.Drawing.Point(616, 149);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(134, 33);
            this.btninvoice.TabIndex = 0;
            this.btninvoice.Text = "Invoice";
            this.btninvoice.UseVisualStyleBackColor = false;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.DarkGreen;
            this.txtaddress.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtaddress.ForeColor = System.Drawing.Color.White;
            this.txtaddress.Location = new System.Drawing.Point(336, 327);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(253, 62);
            this.txtaddress.TabIndex = 2;
            // 
            // txtnic
            // 
            this.txtnic.BackColor = System.Drawing.Color.DarkGreen;
            this.txtnic.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtnic.ForeColor = System.Drawing.Color.White;
            this.txtnic.Location = new System.Drawing.Point(336, 115);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(253, 27);
            this.txtnic.TabIndex = 2;
            this.txtnic.TextChanged += new System.EventHandler(this.txtnic_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC No";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1087, 53);
            this.panel_header.TabIndex = 3;
            // 
            // frm_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1087, 631);
            this.Controls.Add(this.panel_mainUser);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Name = "frm_patient";
            this.Text = "PATIENT INFORMATION";
            this.Load += new System.EventHandler(this.frm_patient_Load);
            this.panel_mainUser.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txttelno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lbltelno;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.DataGridView dgv_userReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btninvoice;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Button btnAddpanel;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnSearchpatient;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.Label label2;
    }
}