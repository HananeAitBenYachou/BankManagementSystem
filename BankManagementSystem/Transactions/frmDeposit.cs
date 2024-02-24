using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemBusinessLayer;

namespace BankManagementSystem
{
    public partial class frmDeposit : Form
    {
        private clsClient _Client; 

        public frmDeposit()
        {
            InitializeComponent();
          
        }

        private void _Refresh()
        {
            errorProvider1.Clear();
            tbDepositAmount.ResetText(); 
            tbAccountNumber.ResetText(); 
        }

        private bool _IsDepositAmountValid(decimal DepositAmount)
        {
            if (DepositAmount <= 0)
            {
                MessageBox.Show("Deposit amount should be greater than zero !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool _IsClientExist(string AccountNumber)
        {
            _Client = clsClient.Find(AccountNumber);

            return _Client != null; 
        }

        private bool _PerformDepositOperation(decimal DepositAmount)
        {
            return _Client.Deposit(DepositAmount); 
        }

        private void tbAccountNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber.Text))
            {
                e.Cancel = true;
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "This field cannot be left blank !");
                pbSearch.Enabled = false;
            }
        
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbAccountNumber, "");
                pbSearch.Enabled = true;
            }
        }

        private void tbDepositAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDepositAmount.Text))
            {
                e.Cancel = true;
                tbDepositAmount.Focus();
                errorProvider1.SetError(tbDepositAmount, "This field cannot be left blank !");
            }
            else if (!int.TryParse(tbDepositAmount.Text.ToString(), out _))
            {
                e.Cancel = true;
                tbDepositAmount.Focus();
                errorProvider1.SetError(tbDepositAmount, "Please enter a valid amount !");
            }

            else
            {
                errorProvider1.SetError(tbDepositAmount, "");
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber.Text))
            {             
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "This field cannot be left blank !");
            }

            else if (!_IsClientExist(tbAccountNumber.Text.ToString()))
            {
                MessageBox.Show($"No Client with AccountNumber {tbAccountNumber.Text}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Refresh();
                return;
            }

            else
            {
                MessageBox.Show($"Client with AccountNumber {tbAccountNumber.Text} is found successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            _Refresh(); 
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                if (!_IsDepositAmountValid(Convert.ToDecimal(tbDepositAmount.Text.ToString())) || !_IsClientExist(tbAccountNumber.Text.ToString()))
                {
                    _Refresh();
                    return;
                }

                else
                {
                    if (_PerformDepositOperation(Convert.ToDecimal(tbDepositAmount.Text.ToString())))
                        MessageBox.Show($"New Balance is {_Client.AccountBalance}", "Amount Deposited Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                        MessageBox.Show($"Operation was cancelled", "Deposit Failed !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _Refresh();
                }
            }      
        }

        private void frmDeposit_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
