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

namespace BankManagementSystem
{
    public partial class frmLoginLogs : Form
    {
        public frmLoginLogs()
        {
            InitializeComponent();
        }

        private void _RefreshLoginLogList()
        {
            dgvLoginLogList.DataSource = clsUser.GetAllLoginRecords(); 
        }

        private void dgvLoginLogList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmLoginLogs_Load(object sender, EventArgs e)
        {
            _RefreshLoginLogList(); 
        }
    }
}
