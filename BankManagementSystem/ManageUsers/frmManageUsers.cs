using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            dgvUsersList.DataSource = clsUser.GetAllUsers();
        }

        private void _SearchUserByID(int UserID)
        {
            DataView dataview = clsUser.GetAllUsers().DefaultView;

            dataview.RowFilter = "UserID = " + UserID;

            dgvUsersList.DataSource = dataview;

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {      
            _RefreshUsersList();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int UserID = Convert.ToInt32(tbSearchID.Text.ToString());

                if (clsUser.IsUserExist(UserID))
                {
                    _SearchUserByID(UserID);
                }

                else
                    MessageBox.Show("UserID not found !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            tbSearchID.ResetText();
            _RefreshUsersList();
        }

        private void tbSearchID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchID.Text))
            {
                e.Cancel = true;
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "Please enter UserID to search !");
            }

            else if (!int.TryParse(tbSearchID.Text.ToString(), out _))
            {
                e.Cancel = true;
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "Please enter numbers only !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSearchID, "");
            }
        }

        private void tpAddUser_Enter(object sender, EventArgs e)
        {
            Form myForm = new frmAddUpdateUser(-1);

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpAddUser_Leave(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void tpUpdateUser_Enter(object sender, EventArgs e)
        {
            Form myForm = new frmAddUpdateUser();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer2.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpUpdateUser_Leave(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void tpSearchUser_Enter(object sender, EventArgs e)
        {
            Form myForm = new frmSearchUser();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer4.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpDeleteUser_Enter(object sender, EventArgs e)
        {
            Form myForm = new frmDeleteUser();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer3.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpDeleteUser_Leave(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void dgvUsersList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

    }
}
