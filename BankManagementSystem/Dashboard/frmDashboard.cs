using System;
using System.Windows.Forms;
using BankSystemBusinessLayer;

namespace BankManagementSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblUsersCount.Text = clsUser.GetUsersCount().ToString();
            lblClientsCount.Text = clsClient.GetClientsCount().ToString();
        }
    }
}
