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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        GoDinghyDBEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new GoDinghyDBEntities();
            usersTableBindingSource.DataSource = db.UsersTables.ToList();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser(new UsersTable()))
            {
                if (frm.ShowDialog() == DialogResult.OK) {
                    try 
                    {
                        usersTableBindingSource.Add(frm.Users);
                        db.UsersTables.Add(frm.Users);
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                
                }
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            UsersTable obj = usersTableBindingSource.Current as UsersTable;
            if(obj != null){
                using (frmAddEditUser frm = new frmAddEditUser(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            usersTableBindingSource.EndEdit();
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            usersTableBindingSource.DataSource = db.UsersTables.ToList();
            Cursor.Current = Cursors.Default;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataGridView.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridView.Rows[i].Selected)
                    {
                        db.UsersTables.Remove(dataGridView.Rows[i].DataBoundItem as UsersTable);
                        usersTableBindingSource.RemoveAt(dataGridView.Rows[i].Index);
                    }
                }
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    usersTableBindingSource.EndEdit();
                    await db.SaveChangesAsync();                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }    
    }
}
