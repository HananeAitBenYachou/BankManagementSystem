using System;
using BankSystemBusinessLayer;
using System.Windows.Forms;
using System.Net;

namespace BankManagementSystem
{
    public partial class frmAddUpdateClient : Form
    {
        private enum enMode { AddNew = 0 , Update = 1};

        private enMode _Mode; 

        private int _ClientID;

        private clsClient _Client; 

        public frmAddUpdateClient(int ClientID = 0)
        {
            InitializeComponent();

            _ClientID = ClientID;

            picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\unknown.png";

            if (ClientID == -1)
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

        private void frmAddUpdateClient_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _Client = new clsClient();
                lbSetImage.Visible = true;
                lbRemove.Visible = false;
                return;
            }
        }

        private void _LoadClientDataToUpdate()
        {           
            _Client = clsClient.Find(_ClientID); 
            
            if(_Client == null)
            {
                MessageBox.Show($"No Client with ID[{_ClientID}] is found !");
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

            if(_Client.ImagePath != "")
            {                
                picture.Load(_Client.ImagePath);
            }

            lbSetImage.Visible = true;
            lbRemove.Visible = (_Client.ImagePath != "");
        }
   
        private void tb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if(string.IsNullOrEmpty(textBox.Text))
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
               _IsTextBoxNotEmpty(tbPhone) && _IsTextBoxNotEmpty(tbPassword) && _IsTextBoxNotEmpty(tbAccountBalance) &&
               _IsTextBoxNotEmpty(tbAddress) && _IsTextBoxNotEmpty(tbAccountNumber)))
            {
                return true ;
            }

            return false;
        }

        private bool _IsAccountNumberValid()
        {
            if(clsClient.IsAccountNumberExist(tbAccountNumber.Text.ToString()))
            {
                MessageBox.Show("Error : this AccountNumber is already exist !", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbAccountNumber.Text = "";
                return false;
            }
            else
            {
                _Client.AccountNumber = tbAccountNumber.Text.ToString();
                return true;
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

            if (_Mode == enMode.Update)
            {
                lbSetImage.Visible = false;
            }

            lbRemove.Visible = false;

            tbSearchID.ResetText(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {          
            if (!_IsTextBoxesNotEmpty())       
                return;
           
            if (_Mode == enMode.AddNew && !_IsAccountNumberValid())
                return; 

            _Client.FirstName = tbFirstName.Text.ToString();
            _Client.LastName = tbLastName.Text.ToString();
            _Client.Email = tbEmail.Text.ToString();
            _Client.Phone = tbPhone.Text.ToString(); 
            _Client.Password = tbPassword.Text.ToString();
            _Client.DateOfBirth = dtpDateOfBirth.Value;
            _Client.AccountBalance = Convert.ToDecimal(tbAccountBalance.Text);
            _Client.Address = tbAddress.Text.ToString(); 

            if (picture.ImageLocation == @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\unknown.png")
            {
                _Client.ImagePath = "";
            }
            else
                _Client.ImagePath = picture.ImageLocation; 

            if (_Client.Save())
            {
                MessageBox.Show("Client Data saved successfully !");

            }

            else
                MessageBox.Show("Error : Client Data is not saved !");

            _Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh(); 
        }

        private void lbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.ImageLocation = @"C:\Users\hanan\source\repos\BankManagementSystem\Resources\unknown.png";
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchID.Text))
            {
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "This field cannot be left blank !");
                return;
            }

            else if (!int.TryParse(tbSearchID.Text.ToString(), out _))
            {
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "Please enter numbers only !");
            }

            else
            {
                errorProvider1.SetError(tbSearchID, "");
                _ClientID = Convert.ToInt32(tbSearchID.Text);
                _LoadClientDataToUpdate();
            }        
        }

        private void frmAddUpdateClient_Leave(object sender, EventArgs e)
        {
            _Refresh();
            this.Close();
        }
    }
}
