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
    public partial class frmAddEditCustomer : MetroFramework.Forms.MetroForm
    {
        public frmAddEditCustomer(CustomersTable obj)
        {   
            InitializeComponent();
                
            bindingSourceCustomer.DataSource = obj;
        }

        public CustomersTable CustomerInfo { get { return bindingSourceCustomer.Current as CustomersTable; } }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSourceCustomer.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            cboCompany.DisplayMember = "CompanyName";
            cboCompany.ValueMember = "ID";
            using(GoDinghyDBEntities db = new GoDinghyDBEntities())
            {
                cboCompany.DataSource = db.CompanyTables.ToList();
            }

        }
    }
}
