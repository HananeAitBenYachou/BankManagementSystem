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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }


        private int _UserID;

        private void _Refresh()
        {
            errorProvider1.Clear();
            tbSearchID.ResetText();
        }

        private void tbSearchID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchID.Text))
            {
                e.Cancel = true;
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "This field cannot be left blank !");
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
        
        private void _DeleteUser(int UserID)
        {
            if (!clsUser.IsUserExist(UserID))
            {
                MessageBox.Show($"No User with ID[{UserID}] is found !");
            }

            else
            {
                if (clsUser.DeleteUser(UserID))
                    MessageBox.Show($"User with ID[{UserID}] is deleted successfully !");
                else
                    MessageBox.Show($"User with ID[{UserID}] delete failed !");
            }

        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (!clsUser.IsUserExist(Convert.ToInt32(tbSearchID.Text)))
                {
                    MessageBox.Show($"No User with UserID {tbSearchID.Text}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Refresh();
                }

                else
                {
                    MessageBox.Show($"User with UserID {tbSearchID.Text} is found successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }         
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                errorProvider1.SetError(tbSearchID, "");
                _UserID = Convert.ToInt32(tbSearchID.Text);
                _DeleteUser(_UserID);

                _Refresh(); 
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            _Refresh(); 
        }

        private void frmDeleteUser_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
