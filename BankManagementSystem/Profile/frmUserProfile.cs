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

    public partial class frmUserProfile : Form
    {
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void _CheckPermissionCheckBox(clsUser.enPermissions Permission, CheckBox chb)
        {
            if ((clsGlobal.CurrentUser.Permissions & ((short)Permission)) == (short)Permission)
            {
                chb.Checked = true;
            }
        }

        private void _CheckPermissionsCheckBoxes()
        {
            if (clsGlobal.CurrentUser.Permissions == -1)
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

        private void _LoadUserData()
        {
            tbUserID.Text = clsGlobal.CurrentUser.UserID.ToString();
            tbUserName.Text = clsGlobal.CurrentUser.UserName;
            tbPassword.Text = clsGlobal.CurrentUser.Password;
            tbSalary.Text = clsGlobal.CurrentUser.Salary.ToString();
            tbFirstName.Text = clsGlobal.CurrentUser.FirstName;
            tbLastName.Text = clsGlobal.CurrentUser.LastName;
            tbPhone.Text = clsGlobal.CurrentUser.Phone;
            dtpDateOfBirth.Value = clsGlobal.CurrentUser.DateOfBirth;
            tbEmail.Text = clsGlobal.CurrentUser.Email;
            tbAddress.Text = clsGlobal.CurrentUser.Address;

            _CheckPermissionsCheckBoxes();
          
            if (clsGlobal.CurrentUser.ImagePath != "")
            {
                picture.Load(clsGlobal.CurrentUser.ImagePath);
            }
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            _LoadUserData(); 
        }
    }
}
