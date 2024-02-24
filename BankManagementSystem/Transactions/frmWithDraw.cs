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

namespace BankManagementSystem.Transactions
{
    public partial class frmWithDraw : Form
    {
        private clsClient _Client;

        public frmWithDraw()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            errorProvider1.Clear();          
            tbWithDrawAmount.ResetText();
            tbAccountNumber.ResetText();
        }

        private bool _IsWithdrawAmountValid(decimal WithDrawAmount)
        {
            if (WithDrawAmount > _Client.AccountBalance)
            {
                MessageBox.Show("Cannot withdraw, Insuffecient Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool _IsClientExist(string AccountNumber)
        {
            _Client = clsClient.Find(AccountNumber);

            return _Client != null;
        }

        private bool _PerformWithDrawOperation(decimal WithDrawAmount)
        {
            return _Client.Withdraw(WithDrawAmount);
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

        private void tbWithDrawAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbWithDrawAmount.Text))
            {
                e.Cancel = true;
                tbWithDrawAmount.Focus();
                errorProvider1.SetError(tbWithDrawAmount, "This field cannot be left blank !");
            }

            else if (!int.TryParse(tbWithDrawAmount.Text.ToString(), out _))
            {
                e.Cancel = true;
                tbWithDrawAmount.Focus();
                errorProvider1.SetError(tbWithDrawAmount, "Please enter a valid amount !");
            }

            else
            {
                errorProvider1.SetError(tbWithDrawAmount, "");
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber.Text))
            {
                tbAccountNumber.Focus();
                errorProvider1.SetError(tbAccountNumber, "This field cannot be left blank !");
            }

            if (!_IsClientExist(tbAccountNumber.Text.ToString()))
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
                if (!_IsClientExist(tbAccountNumber.Text.ToString()) || !_IsWithdrawAmountValid(Convert.ToDecimal(tbWithDrawAmount.Text.ToString())))
                {
                    _Refresh();
                    return;
                }

                else
                {
                    if (_PerformWithDrawOperation(Convert.ToDecimal(tbWithDrawAmount.Text.ToString())))
                        MessageBox.Show($"New Balance is {_Client.AccountBalance}", "Amount Withdrew Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                        MessageBox.Show($"Operation was cancelled", "Withdraw Failed !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _Refresh();
                }
            }

        }

        private void frmWithDraw_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
