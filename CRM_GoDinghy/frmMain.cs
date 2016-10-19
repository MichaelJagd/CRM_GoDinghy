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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form1 frm = new Form1())
            {
                frm.ShowDialog();
            }
        }
        public void LoadForm(MetroFramework.Forms.MetroForm frm)
        {
            frm.MdiParent = this;
            frm.BringToFront();
            frm.ShowDialog();
        }     
    }
}
