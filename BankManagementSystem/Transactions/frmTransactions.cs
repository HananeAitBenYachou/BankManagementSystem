using System;
using System.Windows.Forms;

namespace BankManagementSystem.Transactions
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void tpDeposit_Enter(object sender, EventArgs e)
        {   
            Form myForm = new frmDeposit();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpTransfer_Enter(object sender, EventArgs e)
        {
            Form myForm = new frmTransfer();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer3.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpWithDraw_Enter(object sender, EventArgs e)
        {
            Form myForm = new frmWithDraw();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer2.Controls.Add(myForm);
            myForm.Show();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            Form myForm = new frmDeposit();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }
        
    }
}
