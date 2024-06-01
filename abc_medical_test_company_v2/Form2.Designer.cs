namespace abc_medical_test_company_v2
{
    partial class frm_userReg
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
            this.dgv_userReg = new System.Windows.Forms.DataGridView();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txttelno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lbllname = new System.Windows.Forms.Label();
            this.lbltelno = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_mainUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).BeginInit();
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
            this.panel_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.AutoScroll = true;
            this.panel_mainUser.Controls.Add(this.dgv_userReg);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 42);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(1031, 589);
            this.panel_mainUser.TabIndex = 1;
            // 
            // dgv_userReg
            // 
            this.dgv_userReg.AllowUserToAddRows = false;
            this.dgv_userReg.AllowUserToDeleteRows = false;
            this.dgv_userReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_userReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_userReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userReg.Location = new System.Drawing.Point(0, 0);
            this.dgv_userReg.Name = "dgv_userReg";
            this.dgv_userReg.ReadOnly = true;
            this.dgv_userReg.RowHeadersWidth = 51;
            this.dgv_userReg.RowTemplate.Height = 24;
            this.dgv_userReg.Size = new System.Drawing.Size(1031, 352);
            this.dgv_userReg.TabIndex = 2;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.btnclear);
            this.panel_footer.Controls.Add(this.cmbstatus);
            this.panel_footer.Controls.Add(this.lblstatus);
            this.panel_footer.Controls.Add(this.cmbrole);
            this.panel_footer.Controls.Add(this.lblrole);
            this.panel_footer.Controls.Add(this.txtlname);
            this.panel_footer.Controls.Add(this.txttelno);
            this.panel_footer.Controls.Add(this.txtemail);
            this.panel_footer.Controls.Add(this.txtfname);
            this.panel_footer.Controls.Add(this.lbllname);
            this.panel_footer.Controls.Add(this.lbltelno);
            this.panel_footer.Controls.Add(this.lblemail);
            this.panel_footer.Controls.Add(this.lblfname);
            this.panel_footer.Controls.Add(this.txtpassword);
            this.panel_footer.Controls.Add(this.lblpassword);
            this.panel_footer.Controls.Add(this.txtusername);
            this.panel_footer.Controls.Add(this.lblusername);
            this.panel_footer.Controls.Add(this.btnDelete);
            this.panel_footer.Controls.Add(this.btnUpdate);
            this.panel_footer.Controls.Add(this.btnAdd);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 221);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1031, 410);
            this.panel_footer.TabIndex = 2;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(406, 240);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(101, 33);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // cmbstatus
            // 
            this.cmbstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(178, 331);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(168, 24);
            this.cmbstatus.TabIndex = 6;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblstatus.Location = new System.Drawing.Point(54, 333);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(75, 20);
            this.lblstatus.TabIndex = 5;
            this.lblstatus.Text = "Status :";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbrole
            // 
            this.cmbrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(178, 287);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(168, 24);
            this.cmbrole.TabIndex = 4;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblrole.Location = new System.Drawing.Point(54, 289);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(58, 20);
            this.lblrole.TabIndex = 3;
            this.lblrole.Text = "Role :";
            this.lblrole.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(178, 161);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(168, 22);
            this.txtlname.TabIndex = 2;
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(178, 245);
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(168, 22);
            this.txttelno.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(178, 203);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(168, 22);
            this.txtemail.TabIndex = 2;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(178, 119);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(168, 22);
            this.txtfname.TabIndex = 2;
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbllname.Location = new System.Drawing.Point(54, 161);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(110, 20);
            this.lbllname.TabIndex = 1;
            this.lbllname.Text = "Last Name :";
            this.lbllname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbltelno
            // 
            this.lbltelno.AutoSize = true;
            this.lbltelno.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelno.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbltelno.Location = new System.Drawing.Point(54, 245);
            this.lbltelno.Name = "lbltelno";
            this.lbltelno.Size = new System.Drawing.Size(106, 20);
            this.lbltelno.TabIndex = 1;
            this.lbltelno.Text = "Mobile No :";
            this.lbltelno.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblemail.Location = new System.Drawing.Point(54, 203);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(66, 20);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email :";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblfname.Location = new System.Drawing.Point(54, 119);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(113, 20);
            this.lblfname.TabIndex = 1;
            this.lblfname.Text = "First Name :";
            this.lblfname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(178, 77);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(168, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpassword.Location = new System.Drawing.Point(54, 77);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(103, 20);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password :";
            this.lblpassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(178, 35);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(168, 22);
            this.txtusername.TabIndex = 2;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblusername.Location = new System.Drawing.Point(54, 35);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(113, 20);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "User Name :";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(406, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(406, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(406, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frm_userReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1031, 631);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_mainUser);
            this.Controls.Add(this.panel_header);
            this.Name = "frm_userReg";
            this.Text = "USER REGISTRATION";
            this.Load += new System.EventHandler(this.frm_userReg_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_mainUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.DataGridView dgv_userReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txttelno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbltelno;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Button btnclear;
    }
}