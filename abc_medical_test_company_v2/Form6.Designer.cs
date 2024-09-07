namespace abc_medical_test_company_v2
{
    partial class frm_trsltview
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
            this.panel_mainUser = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.btnaddresult = new System.Windows.Forms.Button();
            this.txttest = new System.Windows.Forms.TextBox();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrepostats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).BeginInit();
            this.panel_mainUser.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel_header.SuspendLayout();
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
            this.dgv_userReg.Size = new System.Drawing.Size(865, 379);
            this.dgv_userReg.TabIndex = 2;
            // 
            // panel_mainUser
            // 
            this.panel_mainUser.Controls.Add(this.dgv_userReg);
            this.panel_mainUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainUser.Location = new System.Drawing.Point(0, 42);
            this.panel_mainUser.Name = "panel_mainUser";
            this.panel_mainUser.Size = new System.Drawing.Size(865, 379);
            this.panel_mainUser.TabIndex = 10;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.lblrepostats);
            this.panel_footer.Controls.Add(this.btnaddresult);
            this.panel_footer.Controls.Add(this.txttest);
            this.panel_footer.Controls.Add(this.txtpatientname);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 421);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(865, 54);
            this.panel_footer.TabIndex = 11;
            // 
            // btnaddresult
            // 
            this.btnaddresult.BackColor = System.Drawing.Color.ForestGreen;
            this.btnaddresult.FlatAppearance.BorderSize = 0;
            this.btnaddresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddresult.Font = new System.Drawing.Font("DejaVu Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddresult.ForeColor = System.Drawing.Color.White;
            this.btnaddresult.Location = new System.Drawing.Point(695, 9);
            this.btnaddresult.Name = "btnaddresult";
            this.btnaddresult.Size = new System.Drawing.Size(158, 33);
            this.btnaddresult.TabIndex = 5;
            this.btnaddresult.Text = "Add Test Results";
            this.btnaddresult.UseVisualStyleBackColor = false;
            this.btnaddresult.Click += new System.EventHandler(this.btnaddresult_Click);
            // 
            // txttest
            // 
            this.txttest.Location = new System.Drawing.Point(366, 15);
            this.txttest.Name = "txttest";
            this.txttest.Size = new System.Drawing.Size(168, 22);
            this.txttest.TabIndex = 2;
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(174, 15);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(168, 22);
            this.txtpatientname.TabIndex = 2;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(865, 42);
            this.panel_header.TabIndex = 9;
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
            // lblrepostats
            // 
            this.lblrepostats.AutoSize = true;
            this.lblrepostats.Location = new System.Drawing.Point(594, 21);
            this.lblrepostats.Name = "lblrepostats";
            this.lblrepostats.Size = new System.Drawing.Size(44, 16);
            this.lblrepostats.TabIndex = 6;
            this.lblrepostats.Text = "label2";
            // 
            // frm_trsltview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 475);
            this.Controls.Add(this.panel_mainUser);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Name = "frm_trsltview";
            this.Text = "TEST RESULT VIEWER";
            this.Load += new System.EventHandler(this.frm_trsltview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userReg)).EndInit();
            this.panel_mainUser.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_userReg;
        private System.Windows.Forms.Panel panel_mainUser;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Button btnaddresult;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttest;
        private System.Windows.Forms.Label lblrepostats;
    }
}