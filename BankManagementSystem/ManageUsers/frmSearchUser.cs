using BankSystemBusinessLayer;
using System;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmSearchUser : Form
    {
        private int _UserID;

        private clsUser _User;

        public frmSearchUser()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            tbUserID.Text = "";
            tbUserName.Text = "";
            tbSalary.Text = "";           
            tbPassword.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhone.Text = "";
            dtpDateOfBirth.Value = DateTime.Now;
            tbEmail.Text = "";
            tbAddress.Text = "";
            _ResetPermissionsCheckBoxes();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\anonymity.png";
            tbSearchID.ResetText();
        }

        private void _CheckPermissionCheckBox(clsUser.enPermissions Permission, CheckBox chb)
        {        
            if ((_User.Permissions & ((short)Permission)) == (short)Permission)
            {
                chb.Checked = true;
            }
        }

        private void _CheckPermissionsCheckBoxes()
        {
            if (_User.Permissions == -1)
            {
                chbSelectAll.Checked = true;

                foreach (CheckBox ch in panelPermissions.Controls)
                {
                    ch.Checked = true;
                }
            }

            else
            {
                _CheckPermissionCheckBox(clsUser.enPermissions.eShowList, chbShowList);
                _CheckPermissionCheckBox(clsUser.enPermissions.eFindClient, chbFind);
                _CheckPermissionCheckBox(clsUser.enPermissions.eAddClient, chbAdd);
                _CheckPermissionCheckBox(clsUser.enPermissions.eUpdateClient, chbUpdate);
                _CheckPermissionCheckBox(clsUser.enPermissions.eDeleteClient, chbDelete);
                _CheckPermissionCheckBox(clsUser.enPermissions.eManageUsers, chbManageUsers);
                _CheckPermissionCheckBox(clsUser.enPermissions.eTransactions, chbTransactions);
                _CheckPermissionCheckBox(clsUser.enPermissions.eShowLogLogin, chbLoginLog);

            }
        }

        private void _ResetPermissionsCheckBoxes()
        {
            chbSelectAll.Checked = false;

            foreach (CheckBox chb in panelPermissions.Controls)
            {
                chb.Checked = false;
            }
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

        private void _LoadUserData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"No User with ID[{_UserID}] is found !");
                _Refresh();
                return;
            }

            tbUserID.Text = _User.UserID.ToString();
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbSalary.Text = _User.Salary.ToString();
            _CheckPermissionsCheckBoxes(); 
            tbFirstName.Text = _User.FirstName;
            tbLastName.Text = _User.LastName;
            tbPhone.Text = _User.Phone;
            dtpDateOfBirth.Value = _User.DateOfBirth;
            tbEmail.Text = _User.Email;
            tbAddress.Text = _User.Address;

            if (_User.ImagePath != "")
            {
                picture.Load(_User.ImagePath);
            }

            else
                picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\anonymity.png";
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {       
            if (ValidateChildren())
            {
                _ResetPermissionsCheckBoxes();
                errorProvider1.SetError(tbSearchID, "");
                _UserID = Convert.ToInt32(tbSearchID.Text);
                _LoadUserData();
                return;
            }

            _Refresh();
        }

        private void frmSearchUser_Leave(object sender, EventArgs e)
        {
            _Refresh();
            this.Close(); 
        }
    }
}
