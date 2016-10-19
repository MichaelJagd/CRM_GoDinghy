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
    public partial class frmAddEditCompany : MetroFramework.Forms.MetroForm
    {
        public frmAddEditCompany(CompanyTable obj)
        {
            InitializeComponent();
            bindingSourceCompany.DataSource = obj;
        }

        public CompanyTable CompanyInfo { get { return bindingSourceCompany.Current as CompanyTable; } }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSourceCompany.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
