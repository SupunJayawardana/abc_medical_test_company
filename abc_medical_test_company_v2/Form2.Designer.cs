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
            this.panel_header.Size = new System.Drawing.Size(800, 42);
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
            this.panel_mainUser.Controls.Add(this.dgv_userReg);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 42);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(800, 408);
            this.panel_mainUser.TabIndex = 1;
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
            // panel_footer
            // 
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
            this.panel_footer.Location = new System.Drawing.Point(0, 302);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(800, 148);
            this.panel_footer.TabIndex = 2;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(362, 114);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(168, 24);
            this.cmbstatus.TabIndex = 6;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(303, 121);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(51, 15);
            this.lblstatus.TabIndex = 5;
            this.lblstatus.Text = "status :";
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(362, 81);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(168, 24);
            this.cmbrole.TabIndex = 4;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(315, 87);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(39, 15);
            this.lblrole.TabIndex = 3;
            this.lblrole.Text = "Role :";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(362, 50);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(168, 22);
            this.txtlname.TabIndex = 2;
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(99, 117);
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(168, 22);
            this.txttelno.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(99, 83);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(168, 22);
            this.txtemail.TabIndex = 2;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(99, 50);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(168, 22);
            this.txtfname.TabIndex = 2;
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllname.Location = new System.Drawing.Point(282, 54);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(72, 15);
            this.lbllname.TabIndex = 1;
            this.lbllname.Text = "last name :";
            // 
            // lbltelno
            // 
            this.lbltelno.AutoSize = true;
            this.lbltelno.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelno.Location = new System.Drawing.Point(42, 121);
            this.lbltelno.Name = "lbltelno";
            this.lbltelno.Size = new System.Drawing.Size(50, 15);
            this.lbltelno.TabIndex = 1;
            this.lbltelno.Text = "Tel No :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(46, 87);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 15);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email :";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(18, 54);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(74, 15);
            this.lblfname.TabIndex = 1;
            this.lblfname.Text = "first name :";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(362, 16);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(168, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(284, 20);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(70, 15);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "password :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(99, 16);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(168, 22);
            this.txtusername.TabIndex = 2;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(21, 20);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(72, 15);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "username :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("DejaVu Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(593, 97);
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
            this.btnUpdate.Location = new System.Drawing.Point(593, 32);
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
            this.btnAdd.Location = new System.Drawing.Point(687, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 104);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frm_userReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_mainUser);
            this.Controls.Add(this.panel_header);
            this.Name = "frm_userReg";
            this.Text = "USER REGISTRATION";
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
    }
}