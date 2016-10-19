namespace CRM_GoDinghy
{
    partial class frmAddEditCustomer
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFristName = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNummer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Company:";
            // 
            // cboCompany
            // 
            this.cboCompany.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceCustomer, "CompanyID", true));
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(137, 61);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(324, 21);
            this.cboCompany.TabIndex = 1;
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(CRM_GoDinghy.CustomersTable);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "First Name:";
            // 
            // txtFristName
            // 
            this.txtFristName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "FirstName", true));
            this.txtFristName.Location = new System.Drawing.Point(137, 89);
            this.txtFristName.Name = "txtFristName";
            this.txtFristName.Size = new System.Drawing.Size(324, 23);
            this.txtFristName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(137, 118);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(324, 23);
            this.txtLastName.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Last Name:";
            // 
            // txtPhoneNummer
            // 
            this.txtPhoneNummer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "PhoneNummer", true));
            this.txtPhoneNummer.Location = new System.Drawing.Point(137, 147);
            this.txtPhoneNummer.Name = "txtPhoneNummer";
            this.txtPhoneNummer.Size = new System.Drawing.Size(324, 23);
            this.txtPhoneNummer.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Phone Nummer:";
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "Mail", true));
            this.txtMail.Location = new System.Drawing.Point(137, 176);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(324, 23);
            this.txtMail.TabIndex = 9;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 180);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Mail:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 209);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "Date", true));
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceCustomer, "Date", true));
            this.dtpDate.Location = new System.Drawing.Point(137, 206);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(324, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(341, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtPhoneNummer);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtFristName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAddEditCustomer";
            this.Text = "Customers Info";
            this.Load += new System.EventHandler(this.frmAddEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cboCompany;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFristName;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPhoneNummer;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.BindingSource bindingSourceCustomer;

    }
}