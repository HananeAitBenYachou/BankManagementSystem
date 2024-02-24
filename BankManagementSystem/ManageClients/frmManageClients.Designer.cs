namespace BankManagementSystem
{
    partial class frmManageClients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageClients));
            this.tcClients = new System.Windows.Forms.TabControl();
            this.tpClientsList = new System.Windows.Forms.TabPage();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.dgvClientsList = new System.Windows.Forms.DataGridView();
            this.tpSearchClient = new System.Windows.Forms.TabPage();
            this.pnlContainer4 = new System.Windows.Forms.Panel();
            this.tpAddClient = new System.Windows.Forms.TabPage();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tpUpdateClient = new System.Windows.Forms.TabPage();
            this.pnlContainer2 = new System.Windows.Forms.Panel();
            this.tpDeleteClient = new System.Windows.Forms.TabPage();
            this.pnlContainer3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcClients.SuspendLayout();
            this.tpClientsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).BeginInit();
            this.tpSearchClient.SuspendLayout();
            this.tpAddClient.SuspendLayout();
            this.tpUpdateClient.SuspendLayout();
            this.tpDeleteClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClients
            // 
            this.tcClients.Controls.Add(this.tpClientsList);
            this.tcClients.Controls.Add(this.tpSearchClient);
            this.tcClients.Controls.Add(this.tpAddClient);
            this.tcClients.Controls.Add(this.tpUpdateClient);
            this.tcClients.Controls.Add(this.tpDeleteClient);
            this.tcClients.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcClients.ImageList = this.imageList1;
            this.tcClients.ItemSize = new System.Drawing.Size(97, 30);
            this.tcClients.Location = new System.Drawing.Point(12, 12);
            this.tcClients.Multiline = true;
            this.tcClients.Name = "tcClients";
            this.tcClients.SelectedIndex = 0;
            this.tcClients.Size = new System.Drawing.Size(1182, 544);
            this.tcClients.TabIndex = 0;
            // 
            // tpClientsList
            // 
            this.tpClientsList.BackColor = System.Drawing.Color.White;
            this.tpClientsList.Controls.Add(this.tbSearchID);
            this.tpClientsList.Controls.Add(this.pbRefresh);
            this.tpClientsList.Controls.Add(this.pbSearch);
            this.tpClientsList.Controls.Add(this.dgvClientsList);
            this.tpClientsList.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpClientsList.ImageIndex = 0;
            this.tpClientsList.Location = new System.Drawing.Point(4, 34);
            this.tpClientsList.Name = "tpClientsList";
            this.tpClientsList.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientsList.Size = new System.Drawing.Size(1174, 506);
            this.tpClientsList.TabIndex = 0;
            this.tpClientsList.Text = "Clients List";
            // 
            // tbSearchID
            // 
            this.tbSearchID.BackColor = System.Drawing.Color.Gainsboro;
            this.tbSearchID.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchID.Location = new System.Drawing.Point(418, 44);
            this.tbSearchID.Multiline = true;
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(244, 43);
            this.tbSearchID.TabIndex = 4;
            this.tbSearchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchID.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchID_Validating);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = global::BankManagementSystem.Properties.Resources.reload1;
            this.pbRefresh.Location = new System.Drawing.Point(736, 43);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(51, 39);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 3;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::BankManagementSystem.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(675, 43);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(51, 39);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 2;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // dgvClientsList
            // 
            this.dgvClientsList.AllowUserToAddRows = false;
            this.dgvClientsList.AllowUserToDeleteRows = false;
            this.dgvClientsList.AllowUserToOrderColumns = true;
            this.dgvClientsList.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvClientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvClientsList.Location = new System.Drawing.Point(21, 108);
            this.dgvClientsList.MultiSelect = false;
            this.dgvClientsList.Name = "dgvClientsList";
            this.dgvClientsList.ReadOnly = true;
            this.dgvClientsList.RowHeadersWidth = 51;
            this.dgvClientsList.RowTemplate.Height = 24;
            this.dgvClientsList.Size = new System.Drawing.Size(1135, 377);
            this.dgvClientsList.TabIndex = 0;
            this.dgvClientsList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvClientsList_CellPainting);
            // 
            // tpSearchClient
            // 
            this.tpSearchClient.BackColor = System.Drawing.Color.White;
            this.tpSearchClient.Controls.Add(this.pnlContainer4);
            this.tpSearchClient.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSearchClient.ImageIndex = 1;
            this.tpSearchClient.Location = new System.Drawing.Point(4, 34);
            this.tpSearchClient.Name = "tpSearchClient";
            this.tpSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchClient.Size = new System.Drawing.Size(1174, 506);
            this.tpSearchClient.TabIndex = 1;
            this.tpSearchClient.Text = "Search Client";
            this.tpSearchClient.Enter += new System.EventHandler(this.tpSearchClient_Enter);
            // 
            // pnlContainer4
            // 
            this.pnlContainer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.pnlContainer4.Location = new System.Drawing.Point(-2, 1);
            this.pnlContainer4.Name = "pnlContainer4";
            this.pnlContainer4.Size = new System.Drawing.Size(1178, 512);
            this.pnlContainer4.TabIndex = 2;
            // 
            // tpAddClient
            // 
            this.tpAddClient.Controls.Add(this.pnlContainer);
            this.tpAddClient.ImageIndex = 2;
            this.tpAddClient.Location = new System.Drawing.Point(4, 34);
            this.tpAddClient.Name = "tpAddClient";
            this.tpAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddClient.Size = new System.Drawing.Size(1174, 506);
            this.tpAddClient.TabIndex = 2;
            this.tpAddClient.Text = "Add Client";
            this.tpAddClient.UseVisualStyleBackColor = true;
            this.tpAddClient.Enter += new System.EventHandler(this.tpAddClient_Enter);
            this.tpAddClient.Leave += new System.EventHandler(this.tpAddClient_Leave);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.pnlContainer.Location = new System.Drawing.Point(-4, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1178, 512);
            this.pnlContainer.TabIndex = 0;
            // 
            // tpUpdateClient
            // 
            this.tpUpdateClient.Controls.Add(this.pnlContainer2);
            this.tpUpdateClient.ImageIndex = 3;
            this.tpUpdateClient.Location = new System.Drawing.Point(4, 34);
            this.tpUpdateClient.Name = "tpUpdateClient";
            this.tpUpdateClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateClient.Size = new System.Drawing.Size(1174, 506);
            this.tpUpdateClient.TabIndex = 3;
            this.tpUpdateClient.Text = "Update Client";
            this.tpUpdateClient.UseVisualStyleBackColor = true;
            this.tpUpdateClient.Enter += new System.EventHandler(this.tpUpdateClient_Enter);
            this.tpUpdateClient.Leave += new System.EventHandler(this.tpUpdateClient_Leave);
            // 
            // pnlContainer2
            // 
            this.pnlContainer2.BackColor = System.Drawing.Color.White;
            this.pnlContainer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.pnlContainer2.Location = new System.Drawing.Point(-2, 1);
            this.pnlContainer2.Name = "pnlContainer2";
            this.pnlContainer2.Size = new System.Drawing.Size(1178, 512);
            this.pnlContainer2.TabIndex = 1;
            // 
            // tpDeleteClient
            // 
            this.tpDeleteClient.Controls.Add(this.pnlContainer3);
            this.tpDeleteClient.ImageIndex = 4;
            this.tpDeleteClient.Location = new System.Drawing.Point(4, 34);
            this.tpDeleteClient.Name = "tpDeleteClient";
            this.tpDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteClient.Size = new System.Drawing.Size(1174, 506);
            this.tpDeleteClient.TabIndex = 4;
            this.tpDeleteClient.Text = "Delete Client";
            this.tpDeleteClient.UseVisualStyleBackColor = true;
            this.tpDeleteClient.Enter += new System.EventHandler(this.tpDeleteClient_Enter);
            this.tpDeleteClient.Leave += new System.EventHandler(this.tpDeleteClient_Leave);
            // 
            // pnlContainer3
            // 
            this.pnlContainer3.BackColor = System.Drawing.Color.White;
            this.pnlContainer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.pnlContainer3.Location = new System.Drawing.Point(-2, 1);
            this.pnlContainer3.Name = "pnlContainer3";
            this.pnlContainer3.Size = new System.Drawing.Size(1178, 512);
            this.pnlContainer3.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "users.png");
            this.imageList1.Images.SetKeyName(1, "search-user.png");
            this.imageList1.Images.SetKeyName(2, "add-user.png");
            this.imageList1.Images.SetKeyName(3, "edit-info.png");
            this.imageList1.Images.SetKeyName(4, "delete-user.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 568);
            this.Controls.Add(this.tcClients);
            this.Name = "frmManageClients";
            this.Load += new System.EventHandler(this.frmManageClients_Load);
            this.tcClients.ResumeLayout(false);
            this.tpClientsList.ResumeLayout(false);
            this.tpClientsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).EndInit();
            this.tpSearchClient.ResumeLayout(false);
            this.tpAddClient.ResumeLayout(false);
            this.tpUpdateClient.ResumeLayout(false);
            this.tpDeleteClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClients;
        private System.Windows.Forms.TabPage tpClientsList;
        private System.Windows.Forms.TabPage tpSearchClient;
        private System.Windows.Forms.TabPage tpAddClient;
        private System.Windows.Forms.TabPage tpUpdateClient;
        private System.Windows.Forms.TabPage tpDeleteClient;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.DataGridView dgvClientsList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlContainer2;
        private System.Windows.Forms.Panel pnlContainer3;
        private System.Windows.Forms.Panel pnlContainer4;
        private System.Windows.Forms.ImageList imageList1;
    }
}