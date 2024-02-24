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

namespace BankManagementSystem.Login
{
    public partial class frmLogin : Form
    {
        private bool _LoginFailed = false;
        private short _FailedLoginCount = 0;

        private string _UserName = "";
        private string _Password = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                e.Cancel = true;
                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "This field cannot be left blank !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUserName, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                e.Cancel = true;
                tbPassword.Focus();
                errorProvider1.SetError(tbPassword, "This field cannot be left blank !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, "");
            }
        }

        private void tbUserName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbUserName, "");
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPassword, "");
        }

        private void _Refresh()
        {
            errorProvider1.Clear();
            tbUserName.ResetText();
            tbPassword.ResetText();
            lblFailedLoginMsg.ResetText();
            lblFailedLoginMsg.Visible = false;      
            _LoginFailed = false;
            _FailedLoginCount = 0; 
        }

        private bool _Login(string UserName , string Password , ref short FailedLoginCount)
        {
            clsGlobal.CurrentUser = clsUser.Find(UserName, Password);

            if (clsGlobal.CurrentUser == null)
            {
                FailedLoginCount++;

                lblFailedLoginMsg.Visible = true;              
                lblFailedLoginMsg.Text = "Invalid Username / Password " + $"You have ({3 - FailedLoginCount}) Trail(s) to login !";              
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {          
                _UserName = tbUserName.Text.Trim();
                _Password = tbPassword.Text.Trim();
                _LoginFailed = !(_Login(_UserName, _Password, ref _FailedLoginCount));

                if (!_LoginFailed)
                {
                    clsGlobal.CurrentUser.AddNewLoginRecord(); 
                    Form Main = new frmMain();
                    this.Hide();
                    Main.Show();
                }

                else
                {
                    if (_FailedLoginCount == 3)
                    {
                        MessageBox.Show("Your are Locked after 3 failed trails !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        _Refresh();                      
                    }

                    else
                        return;
                }
            }
        }

    }

}
