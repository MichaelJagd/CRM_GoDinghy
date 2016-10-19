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
    public partial class frmAddEditUser : MetroFramework.Forms.MetroForm
    {
        public frmAddEditUser(UsersTable obj)
        {         
            InitializeComponent();
            bindingSourceUser.DataSource = obj;
        }
        public UsersTable Users { get { return bindingSourceUser.Current as UsersTable; } }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSourceUser.EndEdit();
            DialogResult = DialogResult.OK;            
        }
    }
}
