using BankManagementSystem.Login;
using BankManagementSystem.Transactions;
using BankSystemBusinessLayer;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(26, 41, 128), Color.FromArgb(38, 208, 206), LinearGradientMode.Vertical);

            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void pnl_MouseLeave(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;

            pnl.BackColor = Color.Transparent;
        }

        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;

            pnl.BackColor = Color.FromArgb(138, 181, 214);
        }

        private void pnl_MouseHover(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;

            pnl.BackColor = Color.FromArgb(138, 181, 214);
        }

        private void pnl_MouseUp(object sender, MouseEventArgs e)
        {
            Panel pnl = (Panel)sender;

            pnl.BackColor = Color.Transparent;
        }

        private void _RefreshCurrentDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            _RefreshCurrentDateTime();
            timer1.Start();

            lblLoggedUser.Text = clsGlobal.CurrentUser.UserName;

            Form myForm = new frmDashboard();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void pbShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
            timer1.Stop(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _RefreshCurrentDateTime();
        }

        private void pnlClients_Click(object sender, MouseEventArgs e)
        {
            Form myForm = new frmManageClients();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void pnlTransactions_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eTransactions))
            {              
                return;
            }
               
            Form myForm = new frmTransactions();
    
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void pnlLogout_Click(object sender, EventArgs e)
        {
            Form Login = new frmLogin(); 
            this.Hide();
            Login.Show();
            
        }

        private void pnlLoginLog_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eShowLogLogin))
            {
                return;
            }
            Form myForm = new frmLoginLogs();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void pnlUserProfile_Click(object sender, EventArgs e)
        {
            Form myForm = new frmUserProfile();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void pnlDashboard_Click(object sender, EventArgs e)
        {
            Form myForm = new frmDashboard();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void pnlUsers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessRights(clsUser.enPermissions.eManageUsers))
            {
                return;
            }

            Form myForm = new frmManageUsers();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void pnlClients_Click(object sender, EventArgs e)
        {
            Form myForm = new frmManageClients();

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
