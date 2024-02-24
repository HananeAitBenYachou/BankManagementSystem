using System;
using System.Windows.Forms;
using BankSystemBusinessLayer;

namespace BankManagementSystem
{
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        private int _ClientID;

        private void _Refresh()
        {
            errorProvider1.Clear();
            tbSearchID.ResetText();
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

        private void _DeleteClient(int ClientID)
        {
            if(!clsClient.IsClientExist(ClientID))
            {
                MessageBox.Show($"No Client with ID[{ClientID}] is found !");                             
            }

            else
            {
                if(clsClient.DeleteClient(ClientID))
                    MessageBox.Show($"Client with ID[{ClientID}] is deleted successfully !");
                else
                    MessageBox.Show($"Client with ID[{ClientID}] delete failed !");
            }

        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (!clsClient.IsClientExist(Convert.ToInt32(tbSearchID.Text)))
                {
                    MessageBox.Show($"No Client with ClientID {tbSearchID.Text}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Refresh();
                }

                else
                {
                    MessageBox.Show($"Client with ClientID {tbSearchID.Text} is found successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                errorProvider1.SetError(tbSearchID, "");
                _ClientID = Convert.ToInt32(tbSearchID.Text);
                _DeleteClient(_ClientID);

                _Refresh();
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            _Refresh(); 
        }

        private void frmDeleteClient_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
