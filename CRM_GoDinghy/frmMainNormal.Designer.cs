namespace CRM_GoDinghy
{
    partial class frmMainNormal
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
            this.MetroTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridViewCus = new System.Windows.Forms.DataGridView();
            this.btnSaveCustomers = new MetroFramework.Controls.MetroTile();
            this.btnDeleteCustomers = new MetroFramework.Controls.MetroTile();
            this.btnEditCustomers = new MetroFramework.Controls.MetroTile();
            this.btnAddCustomers = new MetroFramework.Controls.MetroTile();
            this.btnRefreshCustomers = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridViewCom = new System.Windows.Forms.DataGridView();
            this.btnSaveCompany = new MetroFramework.Controls.MetroTile();
            this.btnDeleteCompany = new MetroFramework.Controls.MetroTile();
            this.btnEditCompany = new MetroFramework.Controls.MetroTile();
            this.btnAddCompany = new MetroFramework.Controls.MetroTile();
            this.btnRefreshCompany = new MetroFramework.Controls.MetroTile();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.chkFullScreen = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.mstylemMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.countyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDDataGridViewComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.companyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersTablesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetroTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).BeginInit();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mstylemMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MetroTab
            // 
            this.MetroTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroTab.Controls.Add(this.metroTabPage1);
            this.MetroTab.Controls.Add(this.metroTabPage2);
            this.MetroTab.Controls.Add(this.Settings);
            this.MetroTab.Location = new System.Drawing.Point(23, 63);
            this.MetroTab.Name = "MetroTab";
            this.MetroTab.SelectedIndex = 1;
            this.MetroTab.Size = new System.Drawing.Size(965, 368);
            this.MetroTab.TabIndex = 0;
            this.MetroTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dataGridViewCus);
            this.metroTabPage1.Controls.Add(this.btnSaveCustomers);
            this.metroTabPage1.Controls.Add(this.btnDeleteCustomers);
            this.metroTabPage1.Controls.Add(this.btnEditCustomers);
            this.metroTabPage1.Controls.Add(this.btnAddCustomers);
            this.metroTabPage1.Controls.Add(this.btnRefreshCustomers);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(957, 329);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Customers";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // dataGridViewCus
            // 
            this.dataGridViewCus.AllowUserToAddRows = false;
            this.dataGridViewCus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCus.AutoGenerateColumns = false;
            this.dataGridViewCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.companyIDDataGridViewComboBox,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNummerDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridViewCus.DataSource = this.customersTableBindingSource;
            this.dataGridViewCus.Location = new System.Drawing.Point(4, 85);
            this.dataGridViewCus.Name = "dataGridViewCus";
            this.dataGridViewCus.Size = new System.Drawing.Size(950, 241);
            this.dataGridViewCus.StandardTab = true;
            this.dataGridViewCus.TabIndex = 12;
            // 
            // btnSaveCustomers
            // 
            this.btnSaveCustomers.Location = new System.Drawing.Point(327, 3);
            this.btnSaveCustomers.Name = "btnSaveCustomers";
            this.btnSaveCustomers.Size = new System.Drawing.Size(75, 75);
            this.btnSaveCustomers.TabIndex = 7;
            this.btnSaveCustomers.Text = "Save";
            this.btnSaveCustomers.Click += new System.EventHandler(this.btnSaveCustomers_Click);
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Location = new System.Drawing.Point(246, 3);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(75, 75);
            this.btnDeleteCustomers.TabIndex = 8;
            this.btnDeleteCustomers.Text = "Delete";
            this.btnDeleteCustomers.Click += new System.EventHandler(this.btnDeleteCustomers_Click);
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.Location = new System.Drawing.Point(165, 3);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(75, 75);
            this.btnEditCustomers.TabIndex = 9;
            this.btnEditCustomers.Text = "Edit";
            this.btnEditCustomers.Click += new System.EventHandler(this.btnEditCustomers_Click);
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(84, 3);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(75, 75);
            this.btnAddCustomers.TabIndex = 10;
            this.btnAddCustomers.Text = "Add";
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // btnRefreshCustomers
            // 
            this.btnRefreshCustomers.Location = new System.Drawing.Point(3, 3);
            this.btnRefreshCustomers.Name = "btnRefreshCustomers";
            this.btnRefreshCustomers.Size = new System.Drawing.Size(75, 75);
            this.btnRefreshCustomers.TabIndex = 11;
            this.btnRefreshCustomers.Text = "Refresh";
            this.btnRefreshCustomers.Click += new System.EventHandler(this.btnRefreshCustomers_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dataGridViewCom);
            this.metroTabPage2.Controls.Add(this.btnSaveCompany);
            this.metroTabPage2.Controls.Add(this.btnDeleteCompany);
            this.metroTabPage2.Controls.Add(this.btnEditCompany);
            this.metroTabPage2.Controls.Add(this.btnAddCompany);
            this.metroTabPage2.Controls.Add(this.btnRefreshCompany);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(957, 329);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Companys";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // dataGridViewCom
            // 
            this.dataGridViewCom.AllowUserToAddRows = false;
            this.dataGridViewCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCom.AutoGenerateColumns = false;
            this.dataGridViewCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.companyNameDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.postalCodeDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1,
            this.countyDataGridViewTextBoxColumn1,
            this.customersTablesDataGridViewTextBoxColumn});
            this.dataGridViewCom.DataSource = this.companyTableBindingSource;
            this.dataGridViewCom.Location = new System.Drawing.Point(4, 85);
            this.dataGridViewCom.Name = "dataGridViewCom";
            this.dataGridViewCom.Size = new System.Drawing.Size(185, 0);
            this.dataGridViewCom.TabIndex = 7;
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Location = new System.Drawing.Point(327, 3);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(75, 75);
            this.btnSaveCompany.TabIndex = 2;
            this.btnSaveCompany.Text = "Save";
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(246, 3);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(75, 75);
            this.btnDeleteCompany.TabIndex = 3;
            this.btnDeleteCompany.Text = "Delete";
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Location = new System.Drawing.Point(165, 3);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(75, 75);
            this.btnEditCompany.TabIndex = 4;
            this.btnEditCompany.Text = "Edit";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(84, 3);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 75);
            this.btnAddCompany.TabIndex = 5;
            this.btnAddCompany.Text = "Add";
            // 
            // btnRefreshCompany
            // 
            this.btnRefreshCompany.Location = new System.Drawing.Point(3, 3);
            this.btnRefreshCompany.Name = "btnRefreshCompany";
            this.btnRefreshCompany.Size = new System.Drawing.Size(75, 75);
            this.btnRefreshCompany.TabIndex = 6;
            this.btnRefreshCompany.Text = "Refresh";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.chkFullScreen);
            this.Settings.Controls.Add(this.metroLabel3);
            this.Settings.Controls.Add(this.metroComboBox2);
            this.Settings.Controls.Add(this.metroLabel2);
            this.Settings.Controls.Add(this.metroComboBox1);
            this.Settings.Controls.Add(this.metroLabel1);
            this.Settings.HorizontalScrollbarBarColor = true;
            this.Settings.Location = new System.Drawing.Point(4, 35);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(957, 329);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.VerticalScrollbarBarColor = true;
            // 
            // chkFullScreen
            // 
            this.chkFullScreen.AutoSize = true;
            this.chkFullScreen.Location = new System.Drawing.Point(86, 138);
            this.chkFullScreen.Name = "chkFullScreen";
            this.chkFullScreen.Size = new System.Drawing.Size(28, 15);
            this.chkFullScreen.TabIndex = 7;
            this.chkFullScreen.Text = "?";
            this.chkFullScreen.UseVisualStyleBackColor = true;
            this.chkFullScreen.CheckStateChanged += new System.EventHandler(this.chkFullScreen_CheckStateChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Full Screen:";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Black ",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal ",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.metroComboBox2.Location = new System.Drawing.Point(3, 99);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Style:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.metroComboBox1.Location = new System.Drawing.Point(3, 40);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Theme:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Du er logget ind som: ";
            // 
            // mstylemMain
            // 
            this.mstylemMain.Owner = this;
            // 
            // countyDataGridViewTextBoxColumn
            // 
            this.countyDataGridViewTextBoxColumn.DataPropertyName = "County";
            this.countyDataGridViewTextBoxColumn.HeaderText = "County";
            this.countyDataGridViewTextBoxColumn.Name = "countyDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // companyIDDataGridViewComboBox
            // 
            this.companyIDDataGridViewComboBox.DataPropertyName = "CompanyID";
            this.companyIDDataGridViewComboBox.DataSource = this.companyTableBindingSource;
            this.companyIDDataGridViewComboBox.DisplayMember = "CompanyName";
            this.companyIDDataGridViewComboBox.HeaderText = "Company";
            this.companyIDDataGridViewComboBox.Name = "companyIDDataGridViewComboBox";
            this.companyIDDataGridViewComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.companyIDDataGridViewComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.companyIDDataGridViewComboBox.ValueMember = "ID";
            // 
            // companyTableBindingSource
            // 
            this.companyTableBindingSource.DataSource = typeof(CRM_GoDinghy.CompanyTable);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNummerDataGridViewTextBoxColumn
            // 
            this.phoneNummerDataGridViewTextBoxColumn.DataPropertyName = "PhoneNummer";
            this.phoneNummerDataGridViewTextBoxColumn.HeaderText = "PhoneNummer";
            this.phoneNummerDataGridViewTextBoxColumn.Name = "phoneNummerDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // customersTableBindingSource
            // 
            this.customersTableBindingSource.DataSource = typeof(CRM_GoDinghy.CustomersTable);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // companyNameDataGridViewTextBoxColumn1
            // 
            this.companyNameDataGridViewTextBoxColumn1.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn1.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn1.Name = "companyNameDataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            // 
            // postalCodeDataGridViewTextBoxColumn1
            // 
            this.postalCodeDataGridViewTextBoxColumn1.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn1.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn1.Name = "postalCodeDataGridViewTextBoxColumn1";
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            // 
            // countyDataGridViewTextBoxColumn1
            // 
            this.countyDataGridViewTextBoxColumn1.DataPropertyName = "County";
            this.countyDataGridViewTextBoxColumn1.HeaderText = "County";
            this.countyDataGridViewTextBoxColumn1.Name = "countyDataGridViewTextBoxColumn1";
            // 
            // customersTablesDataGridViewTextBoxColumn
            // 
            this.customersTablesDataGridViewTextBoxColumn.DataPropertyName = "CustomersTables";
            this.customersTablesDataGridViewTextBoxColumn.HeaderText = "CustomersTables";
            this.customersTablesDataGridViewTextBoxColumn.Name = "customersTablesDataGridViewTextBoxColumn";
            // 
            // frmMainNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MetroTab);
            this.Name = "frmMainNormal";
            this.Text = "GoDinghy CRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainNormal_Load);
            this.MetroTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mstylemMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MetroTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource companyTableBindingSource;
        private MetroFramework.Controls.MetroTile btnSaveCustomers;
        private MetroFramework.Controls.MetroTile btnDeleteCustomers;
        private MetroFramework.Controls.MetroTile btnEditCustomers;
        private MetroFramework.Controls.MetroTile btnAddCustomers;
        private MetroFramework.Controls.MetroTile btnRefreshCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn companyIDDataGridViewComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customersTableBindingSource;
        private MetroFramework.Controls.MetroTabPage Settings;
        public MetroFramework.Components.MetroStyleManager mstylemMain;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkFullScreen;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dataGridViewCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customersTablesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile btnSaveCompany;
        private MetroFramework.Controls.MetroTile btnDeleteCompany;
        private MetroFramework.Controls.MetroTile btnEditCompany;
        private MetroFramework.Controls.MetroTile btnAddCompany;
        private MetroFramework.Controls.MetroTile btnRefreshCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}