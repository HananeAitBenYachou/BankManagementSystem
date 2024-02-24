using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BankSystemBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankManagementSystem
{
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }

        private void _RefreshClientsList()
        {
            dgvClientsList.DataSource = clsClient.GetAllClients();
        }

        private void _SearchClientByID(int ClientID)
        {
            DataView dataview = clsClient.GetAllClients().DefaultView;

            dataview.RowFilter = "ClientID = " + ClientID;

            dgvClientsList.DataSource = dataview;

        }

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eShowList))
            {
                pbSearch.Visible = false ;
                pbRefresh.Visible = false;
                tbSearchID.Visible = false;
                dgvClientsList.Visible = false;
                return;
            }

            _RefreshClientsList();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                int ClientID = Convert.ToInt32(tbSearchID.Text.ToString());

                if (clsClient.IsClientExist(ClientID))
                {
                    _SearchClientByID(ClientID);
                }

                else
                    MessageBox.Show("clientID not found !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); 
            tbSearchID.ResetText(); 
            _RefreshClientsList();
        }

        private void tbSearchID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchID.Text))
            {
                e.Cancel = true;
                tbSearchID.Focus();
                errorProvider1.SetError(tbSearchID, "Please enter clientID to search !");
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

        private void tpAddClient_Enter(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eAddClient))        
                return;
            

            Form myForm = new frmAddUpdateClient(-1);

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpAddClient_Leave(object sender, EventArgs e)
        {          
            _RefreshClientsList();          
        }

        private void tpUpdateClient_Enter(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eUpdateClient))
                return;

            Form myForm = new frmAddUpdateClient();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer2.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpUpdateClient_Leave(object sender, EventArgs e)
        {
            _RefreshClientsList();
        }

        private void tpSearchClient_Enter(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eFindClient))
                return;

            Form myForm = new frmSearchClient(); 

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer4.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpDeleteClient_Enter(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eDeleteClient))
                return;

            Form myForm = new frmDeleteClient();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer3.Controls.Add(myForm);
            myForm.Show();
        }

        private void tpDeleteClient_Leave(object sender, EventArgs e)
        {
            _RefreshClientsList(); 
        }

        private void dgvClientsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

    }
}
