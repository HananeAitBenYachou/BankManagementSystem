using System;
using System.Windows.Forms;
using BankSystemBusinessLayer;

namespace BankManagementSystem
{
    public static class clsGlobal
    {

        private static clsUser _CurrentUser = clsUser.Find("", "");
        public static clsUser CurrentUser
        {
            set
            {
                _CurrentUser = value;
            }

            get
            {
                return _CurrentUser;
            }
        }

        public static bool CheckAccessRights(clsUser.enPermissions Permission)
        {       
            if (!_CurrentUser.CheckAccessPermission(Permission))
            {
                MessageBox.Show("Access Denied! Please contact your Admin", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
    
            return true;     
        }
     
    }
}
