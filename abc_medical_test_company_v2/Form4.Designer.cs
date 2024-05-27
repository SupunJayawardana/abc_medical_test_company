namespace abc_medical_test_company_v2
{
    partial class frm_patientview
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
            this.panel_mainUser = new System.Windows.Forms.Panel();
            this.dgv_userReg = new System.Windows.Forms.DataGridView();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.txtsearchby = new System.Windows.Forms.TextBox();
            this.lblsearchby = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_mainUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.Controls.Add(this.dgv_userReg);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 42);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(800, 366);
            this.panel_mainUser.TabIndex = 7;
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
            this.dgv_userReg.Size = new System.Drawing.Size(800, 366);
            this.dgv_userReg.TabIndex = 2;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.btnsearch);
            this.panel_footer.Controls.Add(this.cmbsearch);
            this.panel_footer.Controls.Add(this.txtsearchby);
            this.panel_footer.Controls.Add(this.lblsearchby);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 408);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(800, 42);
            this.panel_footer.TabIndex = 8;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(689, 9);
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
            this.cmbsearch.Location = new System.Drawing.Point(562, 9);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(121, 24);
            this.cmbsearch.TabIndex = 4;
            // 
            // txtsearchby
            // 
            this.txtsearchby.Location = new System.Drawing.Point(389, 10);
            this.txtsearchby.Name = "txtsearchby";
            this.txtsearchby.Size = new System.Drawing.Size(168, 22);
            this.txtsearchby.TabIndex = 2;
            // 
            // lblsearchby
            // 
            this.lblsearchby.AutoSize = true;
            this.lblsearchby.Font = new System.Drawing.Font("DejaVu Sans Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchby.Location = new System.Drawing.Point(311, 14);
            this.lblsearchby.Name = "lblsearchby";
            this.lblsearchby.Size = new System.Drawing.Size(72, 15);
            this.lblsearchby.TabIndex = 1;
            this.lblsearchby.Text = "username :";
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
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Information";
            // 
            // frm_patientview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_mainUser);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Name = "frm_patientview";
            this.Text = "PATIENT INFO VIEWER";
            this.panel_mainUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.DataGridView dgv_userReg;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.TextBox txtsearchby;
        private System.Windows.Forms.Label lblsearchby;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
    }
}