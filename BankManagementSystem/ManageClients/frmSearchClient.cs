using System;
using BankSystemBusinessLayer;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmSearchClient : Form
    {
        private int _ClientID;

        private clsClient _Client;

        public frmSearchClient()
        {
            InitializeComponent();
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

        private void _Refresh()
        {
            tbClientID.Text = "";
            tbAccountNumber.Text = "";
            tbAccountBalance.Text = "";
            tbPassword.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhone.Text = "";
            dtpDateOfBirth.Value = DateTime.Now;
            tbEmail.Text = "";
            tbAddress.Text = "";
            picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\unknown.png";
            tbSearchID.ResetText();
        }

        private void _LoadClientData()
        {
            _Client = clsClient.Find(_ClientID);

            if (_Client == null)
            {
                MessageBox.Show($"No Client with ID[{_ClientID}] is found !");
                _Refresh(); 
                return;
            }

            tbClientID.Text = _Client.ClientID.ToString();
            tbAccountNumber.Text = _Client.AccountNumber;
            tbAccountBalance.Text = _Client.AccountBalance.ToString();
            tbPassword.Text = _Client.Password;
            tbFirstName.Text = _Client.FirstName;
            tbLastName.Text = _Client.LastName;
            tbPhone.Text = _Client.Phone;
            dtpDateOfBirth.Value = _Client.DateOfBirth;
            tbEmail.Text = _Client.Email;
            tbAddress.Text = _Client.Address;

            if (_Client.ImagePath != "")
            {
                picture.Load(_Client.ImagePath);
            } 
            
            else
            {
                picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\unknown.png";
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                errorProvider1.SetError(tbSearchID, "");
                _ClientID = Convert.ToInt32(tbSearchID.Text);
                _LoadClientData();
                return;
            }

            _Refresh();
        }

        private void frmSearchClient_Leave(object sender, EventArgs e)
        {
            _Refresh();
            this.Close();
        }
    }
}
