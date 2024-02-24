using BankManagementSystem.Properties;
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
using static BankSystemBusinessLayer.clsUser;

namespace BankManagementSystem
{
    public partial class frmAddUpdateUser : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private int _UserID;

        private clsUser _User;

        public frmAddUpdateUser(int UserID = 0)
        {
            InitializeComponent();

            picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\anonymity.png";

            _UserID = UserID;

            if (_UserID == -1)
            {
                _Mode = enMode.AddNew;
                tbSearchID.Visible = false;
                pbSearch.Visible = false;
                label7.Visible = false;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new clsUser();
                lbSetImage.Visible = true;
                lbRemove.Visible = false;
                return;
            }
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
            }
            else
            {
                _CheckPermissionCheckBox(clsUser.enPermissions.eShowLogLogin, chbLoginLog);
                _CheckPermissionCheckBox(clsUser.enPermissions.eManageUsers, chbManageUsers);
                _CheckPermissionCheckBox(clsUser.enPermissions.eTransactions, chbTransactions);
                _CheckPermissionCheckBox(clsUser.enPermissions.eShowList, chbShowList);
                _CheckPermissionCheckBox(clsUser.enPermissions.eFindClient, chbFind);
                _CheckPermissionCheckBox(clsUser.enPermissions.eAddClient, chbAdd);
                _CheckPermissionCheckBox(clsUser.enPermissions.eUpdateClient, chbUpdate);
                _CheckPermissionCheckBox(clsUser.enPermissions.eDeleteClient, chbDelete);

            }
        }

        private void _LoadUserDataToUpdate()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"No User with ID[{_UserID}] is found !");
                return;
            }

            tbUserID.Text = _User.UserID.ToString();
            tbUserName.Text = _User.UserName;
            tbSalary.Text = _User.Salary.ToString();
            _CheckPermissionsCheckBoxes(); 
            tbPassword.Text = _User.Password;
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

            lbSetImage.Visible = true;
            lbRemove.Visible = (_User.ImagePath != ""); 
        }

        private void tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "This field cannot be left blank !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private bool _IsTextBoxNotEmpty(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Focus();
                errorProvider1.SetError(textBox, "This field cannot be left blank !");
                return false;
            }

            else
            {
                errorProvider1.SetError(textBox, "");
                return true;
            }
        }

        private bool _IsTextBoxesNotEmpty()
        {
            if ((_IsTextBoxNotEmpty(tbFirstName) && _IsTextBoxNotEmpty(tbLastName) && _IsTextBoxNotEmpty(tbEmail) &&
               _IsTextBoxNotEmpty(tbPhone) && _IsTextBoxNotEmpty(tbPassword) && _IsTextBoxNotEmpty(tbSalary) &&
               _IsTextBoxNotEmpty(tbAddress) && _IsTextBoxNotEmpty(tbUserName)))
            {
                return true;
            }

            return false;
        }

        private void _ResetPermissionsCheckBoxes()
        {
            chbSelectAll.Checked = false;

            foreach (CheckBox chb in panelPermissions.Controls)
            {
                chb.Checked = false;
                chb.Enabled = true;
            }
        }

        private void _Refresh()
        {
            tbUserID.Text = "";
            tbUserName.Text = "";
            tbSalary.Text = "";
            _ResetPermissionsCheckBoxes(); 
            tbPassword.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhone.Text = "";
            dtpDateOfBirth.Value = DateTime.Now;
            tbEmail.Text = "";
            tbAddress.Text = "";
            panelPermissions.Enabled = true;
            picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\anonymity.png";

            if(_Mode == enMode.Update)
            {
                lbSetImage.Visible = false;
            }

            lbRemove.Visible = false;
            tbSearchID.ResetText();
            errorProvider1.Clear(); 
        }

        private void _GetUserPermissions(CheckBox chb)
        {         
            if (chb.Checked)
            {
                _User.Permissions += Convert.ToInt16(chb.Tag);
            }    
        }

        private void _SetUserPermissions()
        {
            if (chbSelectAll.Checked)
            {              
                _User.Permissions = -1;
            }

            else
            {
                _User.Permissions = 0; 

                foreach (CheckBox chb in panelPermissions.Controls)
                {
                    _GetUserPermissions(chb);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsTextBoxesNotEmpty())
                return;

            _SetUserPermissions(); 
            _User.UserName = tbUserName.Text.ToString();             
            _User.FirstName = tbFirstName.Text.ToString();
            _User.LastName = tbLastName.Text.ToString();
            _User.Email = tbEmail.Text.ToString();
            _User.Phone = tbPhone.Text.ToString();
            _User.Password = tbPassword.Text.ToString();
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.Salary = Convert.ToDecimal(tbSalary.Text);
            _User.Address = tbAddress.Text.ToString();

            if (picture.ImageLocation == @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\anonymity.png")
            {
                _User.ImagePath = "";
            }
            else
                _User.ImagePath = picture.ImageLocation;

            if (_User.Save())
            {
                MessageBox.Show("User Data saved successfully !");
                _Refresh();
            }

            else
                MessageBox.Show("Error : User Data is not saved !");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void lbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\anonymity.png";
            lbRemove.Visible = false;
            lbSetImage.Visible = true;
        }

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture.Load(openFileDialog1.FileName);
            }

            lbRemove.Visible = true;
        }

        private void tbSearchID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchID.Text))
            {
                e.Cancel = true;
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "This field cannot be left blank !");
            }

            else if (!int.TryParse(tbSearchID.Text.ToString(), out int SearchID))
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchID.Text))
            {
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "This field cannot be left blank !");
                return;
            }

            else if (!int.TryParse(tbSearchID.Text.ToString(), out int SearchID))
            {

                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "Please enter numbers only !");
            }

            else
            {
                errorProvider1.SetError(tbSearchID, "");
                _UserID = Convert.ToInt32(tbSearchID.Text);
                _LoadUserDataToUpdate();
            }
        }

        private void frmAddUpdateUser_Leave(object sender, EventArgs e)
        {
            _Refresh();
            this.Close();
        }

        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSelectAll.Checked)
            {
                foreach (CheckBox chb in panelPermissions.Controls)
                {
                    chb.Checked = true;
                    chb.Enabled = false;
                }

            }

            else
            {
                foreach (CheckBox chb in panelPermissions.Controls)
                {
                    chb.Checked = false;
                    chb.Enabled = true;
                }
            }
        }
    }
}
