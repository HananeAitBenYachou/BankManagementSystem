namespace BankManagementSystem
{
    partial class frmLoginLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoginLogList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginLogList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoginLogList
            // 
            this.dgvLoginLogList.AllowUserToAddRows = false;
            this.dgvLoginLogList.AllowUserToDeleteRows = false;
            this.dgvLoginLogList.AllowUserToOrderColumns = true;
            this.dgvLoginLogList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoginLogList.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvLoginLogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoginLogList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginLogList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoginLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoginLogList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoginLogList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvLoginLogList.Location = new System.Drawing.Point(136, 59);
            this.dgvLoginLogList.MultiSelect = false;
            this.dgvLoginLogList.Name = "dgvLoginLogList";
            this.dgvLoginLogList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginLogList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoginLogList.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvLoginLogList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoginLogList.RowTemplate.Height = 24;
            this.dgvLoginLogList.Size = new System.Drawing.Size(880, 333);
            this.dgvLoginLogList.TabIndex = 5;
            this.dgvLoginLogList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvLoginLogList_CellPainting);
            // 
            // frmLoginLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 465);
            this.Controls.Add(this.dgvLoginLogList);
            this.Name = "frmLoginLogs";
            this.Text = "frmLoginLogs";
            this.Load += new System.EventHandler(this.frmLoginLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginLogList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLoginLogList;
    }
}