namespace BankManagementSystem
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.tcUsers = new System.Windows.Forms.TabControl();
            this.tpUsersList = new System.Windows.Forms.TabPage();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.tpSearchUser = new System.Windows.Forms.TabPage();
            this.pnlContainer4 = new System.Windows.Forms.Panel();
            this.tpAddUser = new System.Windows.Forms.TabPage();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tpUpdateUser = new System.Windows.Forms.TabPage();
            this.pnlContainer2 = new System.Windows.Forms.Panel();
            this.tpDeleteUser = new System.Windows.Forms.TabPage();
            this.pnlContainer3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcUsers.SuspendLayout();
            this.tpUsersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.tpSearchUser.SuspendLayout();
            this.tpAddUser.SuspendLayout();
            this.tpUpdateUser.SuspendLayout();
            this.tpDeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsers
            // 
            this.tcUsers.Controls.Add(this.tpUsersList);
            this.tcUsers.Controls.Add(this.tpSearchUser);
            this.tcUsers.Controls.Add(this.tpAddUser);
            this.tcUsers.Controls.Add(this.tpUpdateUser);
            this.tcUsers.Controls.Add(this.tpDeleteUser);
            this.tcUsers.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUsers.ImageList = this.imageList1;
            this.tcUsers.ItemSize = new System.Drawing.Size(97, 30);
            this.tcUsers.Location = new System.Drawing.Point(18, 12);
            this.tcUsers.Multiline = true;
            this.tcUsers.Name = "tcUsers";
            this.tcUsers.SelectedIndex = 0;
            this.tcUsers.Size = new System.Drawing.Size(1182, 544);
            this.tcUsers.TabIndex = 1;
            // 
            // tpUsersList
            // 
            this.tpUsersList.BackColor = System.Drawing.Color.White;
            this.tpUsersList.Controls.Add(this.tbSearchID);
            this.tpUsersList.Controls.Add(this.pbRefresh);
            this.tpUsersList.Controls.Add(this.pbSearch);
            this.tpUsersList.Controls.Add(this.dgvUsersList);
            this.tpUsersList.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUsersList.ImageIndex = 1;
            this.tpUsersList.Location = new System.Drawing.Point(4, 34);
            this.tpUsersList.Name = "tpUsersList";
            this.tpUsersList.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsersList.Size = new System.Drawing.Size(1174, 506);
            this.tpUsersList.TabIndex = 0;
            this.tpUsersList.Text = "Users List";
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
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToOrderColumns = true;
            this.dgvUsersList.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvUsersList.Location = new System.Drawing.Point(21, 108);
            this.dgvUsersList.MultiSelect = false;
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersWidth = 51;
            this.dgvUsersList.RowTemplate.Height = 24;
            this.dgvUsersList.Size = new System.Drawing.Size(1135, 377);
            this.dgvUsersList.TabIndex = 0;
            this.dgvUsersList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsersList_CellPainting);
            // 
            // tpSearchUser
            // 
            this.tpSearchUser.BackColor = System.Drawing.Color.White;
            this.tpSearchUser.Controls.Add(this.pnlContainer4);
            this.tpSearchUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSearchUser.ImageIndex = 0;
            this.tpSearchUser.Location = new System.Drawing.Point(4, 34);
            this.tpSearchUser.Name = "tpSearchUser";
            this.tpSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchUser.Size = new System.Drawing.Size(1174, 506);
            this.tpSearchUser.TabIndex = 1;
            this.tpSearchUser.Text = "Search User";
            this.tpSearchUser.Enter += new System.EventHandler(this.tpSearchUser_Enter);
            // 
            // pnlContainer4
            // 
            this.pnlContainer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.pnlContainer4.Location = new System.Drawing.Point(-2, 1);
            this.pnlContainer4.Name = "pnlContainer4";
            this.pnlContainer4.Size = new System.Drawing.Size(1178, 512);
            this.pnlContainer4.TabIndex = 2;
            // 
            // tpAddUser
            // 
            this.tpAddUser.Controls.Add(this.pnlContainer);
            this.tpAddUser.ImageIndex = 4;
            this.tpAddUser.Location = new System.Drawing.Point(4, 34);
            this.tpAddUser.Name = "tpAddUser";
            this.tpAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddUser.Size = new System.Drawing.Size(1174, 506);
            this.tpAddUser.TabIndex = 2;
            this.tpAddUser.Text = "Add User";
            this.tpAddUser.UseVisualStyleBackColor = true;
            this.tpAddUser.Enter += new System.EventHandler(this.tpAddUser_Enter);
            this.tpAddUser.Leave += new System.EventHandler(this.tpAddUser_Leave);
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
            // tpUpdateUser
            // 
            this.tpUpdateUser.Controls.Add(this.pnlContainer2);
            this.tpUpdateUser.ImageIndex = 3;
            this.tpUpdateUser.Location = new System.Drawing.Point(4, 34);
            this.tpUpdateUser.Name = "tpUpdateUser";
            this.tpUpdateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateUser.Size = new System.Drawing.Size(1174, 506);
            this.tpUpdateUser.TabIndex = 3;
            this.tpUpdateUser.Text = "Update User";
            this.tpUpdateUser.UseVisualStyleBackColor = true;
            this.tpUpdateUser.Enter += new System.EventHandler(this.tpUpdateUser_Enter);
            this.tpUpdateUser.Leave += new System.EventHandler(this.tpUpdateUser_Leave);
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
            // tpDeleteUser
            // 
            this.tpDeleteUser.Controls.Add(this.pnlContainer3);
            this.tpDeleteUser.ImageIndex = 2;
            this.tpDeleteUser.Location = new System.Drawing.Point(4, 34);
            this.tpDeleteUser.Name = "tpDeleteUser";
            this.tpDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteUser.Size = new System.Drawing.Size(1174, 506);
            this.tpDeleteUser.TabIndex = 4;
            this.tpDeleteUser.Text = "Delete User";
            this.tpDeleteUser.UseVisualStyleBackColor = true;
            this.tpDeleteUser.Enter += new System.EventHandler(this.tpDeleteUser_Enter);
            this.tpDeleteUser.Leave += new System.EventHandler(this.tpDeleteUser_Leave);
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
            this.imageList1.Images.SetKeyName(0, "search-user.png");
            this.imageList1.Images.SetKeyName(1, "users.png");
            this.imageList1.Images.SetKeyName(2, "delete-user.png");
            this.imageList1.Images.SetKeyName(3, "edit-info.png");
            this.imageList1.Images.SetKeyName(4, "add-user.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 568);
            this.Controls.Add(this.tcUsers);
            this.Name = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.tcUsers.ResumeLayout(false);
            this.tpUsersList.ResumeLayout(false);
            this.tpUsersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.tpSearchUser.ResumeLayout(false);
            this.tpAddUser.ResumeLayout(false);
            this.tpUpdateUser.ResumeLayout(false);
            this.tpDeleteUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUsers;
        private System.Windows.Forms.TabPage tpUsersList;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.TabPage tpSearchUser;
        private System.Windows.Forms.Panel pnlContainer4;
        private System.Windows.Forms.TabPage tpAddUser;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TabPage tpUpdateUser;
        private System.Windows.Forms.Panel pnlContainer2;
        private System.Windows.Forms.TabPage tpDeleteUser;
        private System.Windows.Forms.Panel pnlContainer3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
      //  private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}