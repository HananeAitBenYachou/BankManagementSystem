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
    public partial class frmTransfer : Form
    {

        private clsClient _Client1;

        private clsClient _Client2;

        public frmTransfer()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            errorProvider1.Clear();
            tbTransferAmount.ResetText();
            tbAccountNumber1.ResetText();
            tbAccountNumber2.ResetText();
        }

        private bool _IsTransferAmountValid(decimal TransferAmount)
        {
            if (TransferAmount > _Client1.AccountBalance)
            {
                MessageBox.Show("Amount exceeds the available Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool _IsClientExist(ref clsClient Client , string AccountNumber)
        {
            Client = clsClient.Find(AccountNumber);

            return Client != null; 
        }

        private bool _PerformTransferOperation(decimal TransferAmount)
        {
            return _Client1.Transfer(TransferAmount, ref _Client2); 
        }

        private void tbAccountNumber1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber1.Text))
            {
                e.Cancel = true;
                tbAccountNumber1.Focus();
                errorProvider1.SetError(tbAccountNumber1, "This field cannot be left blank !");
                pbSearch1.Enabled = false;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbAccountNumber1, "");
                pbSearch1.Enabled = true;
            }
        }

        private void tbAccountNumber2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber2.Text))
            {
                e.Cancel = true;
                tbAccountNumber2.Focus();
                errorProvider1.SetError(tbAccountNumber2, "This field cannot be left blank !");
                pbSearch2.Enabled = false;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbAccountNumber2, "");
                pbSearch2.Enabled = true;
            }
        }

        private void pbSearch1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber1.Text))
            {
                tbAccountNumber1.Focus();
                errorProvider1.SetError(tbAccountNumber1, "This field cannot be left blank !");
            }

            if (!_IsClientExist(ref _Client1,tbAccountNumber1.Text.ToString()))
            {
                MessageBox.Show($"No Client with AccountNumber {tbAccountNumber1.Text}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Refresh();
                return;
            }

            else
            {
                MessageBox.Show($"Client with AccountNumber {tbAccountNumber1.Text} is found successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbSearch2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAccountNumber2.Text))
            {
                tbAccountNumber2.Focus();
                errorProvider1.SetError(tbAccountNumber2, "This field cannot be left blank !");
            }

            if (!_IsClientExist(ref _Client2, tbAccountNumber2.Text.ToString()))
            {
                MessageBox.Show($"No Client with AccountNumber {tbAccountNumber2.Text}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Refresh();
                return;
            }

            else
            {
                MessageBox.Show($"Client with AccountNumber {tbAccountNumber2.Text} is found successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbTransferAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTransferAmount.Text))
            {
                e.Cancel = true;
                tbTransferAmount.Focus();
                errorProvider1.SetError(tbTransferAmount, "This field cannot be left blank !");
            }
            else if (!int.TryParse(tbTransferAmount.Text.ToString(), out _))
            {
                e.Cancel = true;
                tbTransferAmount.Focus();
                errorProvider1.SetError(tbTransferAmount, "Please enter a valid amount !");
            }

            else
            {
                errorProvider1.SetError(tbTransferAmount, "");
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
                if ( !_IsClientExist(ref _Client1, tbAccountNumber1.Text.ToString())
                    || !_IsClientExist(ref _Client2, tbAccountNumber2.Text.ToString()) || !_IsTransferAmountValid(Convert.ToDecimal(tbTransferAmount.Text.ToString())))
                {
                    _Refresh();
                    return;
                }

                else
                {
                    if (_PerformTransferOperation(Convert.ToDecimal(tbTransferAmount.Text.ToString())))
                        MessageBox.Show($"{_Client1.AccountNumber} : New Balance is {_Client1.AccountBalance} \n{_Client2.AccountNumber} : New Balance is {_Client2.AccountBalance} ", "Transfer done Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    else
                        MessageBox.Show($"Operation was cancelled", "Transfer Failed !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _Refresh();
                }
            }

        }

        private void frmTransfer_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
