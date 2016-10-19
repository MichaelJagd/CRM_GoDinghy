namespace CRM_GoDinghy
{
    partial class frmAddEditUser
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
            this.txtFristName = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtInitials = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbUserType = new MetroFramework.Controls.MetroComboBox();
            this.cbActiv = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "First name:";
            // 
            // txtFristName
            // 
            this.txtFristName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFristName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "FirstName", true));
            this.txtFristName.Location = new System.Drawing.Point(102, 63);
            this.txtFristName.Name = "txtFristName";
            this.txtFristName.Size = new System.Drawing.Size(359, 23);
            this.txtFristName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(102, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(359, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Last name:";
            // 
            // txtInitials
            // 
            this.txtInitials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInitials.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Initials", true));
            this.txtInitials.Location = new System.Drawing.Point(102, 121);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(359, 23);
            this.txtInitials.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Initials:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Usertype:";
            // 
            // cbUserType
            // 
            this.cbUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.ItemHeight = 23;
            this.cbUserType.Items.AddRange(new object[] {
            "Normal",
            "Admin"});
            this.cbUserType.Location = new System.Drawing.Point(102, 150);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(359, 29);
            this.cbUserType.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbUserType.TabIndex = 4;
            // 
            // cbActiv
            // 
            this.cbActiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbActiv.FormattingEnabled = true;
            this.cbActiv.ItemHeight = 23;
            this.cbActiv.Items.AddRange(new object[] {
            "Normal",
            "Admin"});
            this.cbActiv.Location = new System.Drawing.Point(102, 185);
            this.cbActiv.Name = "cbActiv";
            this.cbActiv.Size = new System.Drawing.Size(359, 29);
            this.cbActiv.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbActiv.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 195);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Activ:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(102, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(359, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 221);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Password";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(341, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = typeof(CRM_GoDinghy.UsersTable);
            // 
            // frmAddEditUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbActiv);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbUserType);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtInitials);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFristName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAddEditUser";
            this.Text = "User info";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFristName;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtInitials;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbUserType;
        private MetroFramework.Controls.MetroComboBox cbActiv;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.BindingSource bindingSourceUser;
    }
}