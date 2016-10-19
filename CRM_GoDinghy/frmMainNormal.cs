using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRM_GoDinghy
{
    public partial class frmMainNormal : MetroFramework.Forms.MetroForm
    {
       // GoDinghyDBEntities db;
        public frmMainNormal()
        {
            InitializeComponent();
        }       
        private void frmMainNormal_Load(object sender, EventArgs e)
        {
            db = new GoDinghyDBEntities();
            companyTableBindingSource.DataSource = db.CompanyTables.ToList();
            customersTableBindingSource.DataSource = db.CustomersTables.ToList();
            label1.Text += " ";

            if (chkFullScreen.CheckState == CheckState.Checked)
            {
                chkFullScreen.Text = "True";
            }
            else {
                chkFullScreen.Text = "False";
            }
        }
        GoDinghyDBEntities db;
        private void loadCompany() {
            db = new GoDinghyDBEntities();
            companyTableBindingSource.DataSource = db.CompanyTables.ToList();
        }

        private void btnRefreshCompany_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            companyTableBindingSource.DataSource = db.CompanyTables.ToList();
            Cursor.Current = Cursors.Default;
        }
        private async void btnAddCompany_Click(object sender, EventArgs e)
        {      
            using (frmAddEditCompany frm = new frmAddEditCompany(new CompanyTable()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        companyTableBindingSource.Add(frm.CompanyInfo);
                        db.CompanyTables.Add(frm.CompanyInfo);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async void btnEditCompany_Click(object sender, EventArgs e)
        {
            CompanyTable obj = companyTableBindingSource.Current as CompanyTable;
            if (obj != null)
            {
                using (frmAddEditCompany frm = new frmAddEditCompany(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            companyTableBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this company", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = dataGridViewCom.RowCount;
                    for (int i = rows - 1; i >= 0; i--)
                    {
                        if (dataGridViewCom.Rows[i].Selected)
                        {
                            db.CompanyTables.Remove(dataGridViewCom.Rows[i].DataBoundItem as CompanyTable);
                            companyTableBindingSource.RemoveAt(dataGridViewCom.Rows[i].Index);
                        }
                    }
                }
            }              
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        private async void btnSaveCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    companyTableBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            companyTableBindingSource.DataSource = db.CompanyTables.ToList();
            customersTableBindingSource.DataSource = db.CustomersTables.ToList();
            Cursor.Current = Cursors.Default;
        }
        private async void btnAddCustomers_Click(object sender, EventArgs e)
        {
            using (frmAddEditCustomer frm = new frmAddEditCustomer(new CustomersTable()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        customersTableBindingSource.Add(frm.CustomerInfo);
                        db.CustomersTables.Add(frm.CustomerInfo);
                        await db.SaveChangesAsync();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private async void btnEditCustomers_Click(object sender, EventArgs e)
        {
            CustomersTable obj = customersTableBindingSource.Current as CustomersTable;
            if (obj != null)
            {
                using (frmAddEditCustomer frm = new frmAddEditCustomer(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            customersTableBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Customer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataGridViewCus.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridViewCus.Rows[i].Selected)
                    {
                        db.CustomersTables.Remove(dataGridViewCus.Rows[i].DataBoundItem as CustomersTable);
                        customersTableBindingSource.RemoveAt(dataGridViewCus.Rows[i].Index);
                    }
                }
            }
        }
        private async void btnSaveCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customersTableBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void styleSetup(){ 
        
        }

        private void chkFullScreen_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkFullScreen.CheckState == CheckState.Checked)
            {
                chkFullScreen.Text = "True";
            }
            else
            {
                chkFullScreen.Text = "False";
            }
        }       
    }
}
