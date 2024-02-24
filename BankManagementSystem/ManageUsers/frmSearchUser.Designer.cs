namespace BankManagementSystem
{
    partial class frmSearchUser
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.panelPermissions = new System.Windows.Forms.Panel();
            this.chbAdd = new System.Windows.Forms.CheckBox();
            this.chbLoginLog = new System.Windows.Forms.CheckBox();
            this.chbTransactions = new System.Windows.Forms.CheckBox();
            this.chbManageUsers = new System.Windows.Forms.CheckBox();
            this.chbDelete = new System.Windows.Forms.CheckBox();
            this.chbShowList = new System.Windows.Forms.CheckBox();
            this.chbUpdate = new System.Windows.Forms.CheckBox();
            this.chbFind = new System.Windows.Forms.CheckBox();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbPermissions.SuspendLayout();
            this.panelPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(321, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 34);
            this.label7.TabIndex = 79;
            this.label7.Text = "User ID : ";
            // 
            // tbSearchID
            // 
            this.tbSearchID.BackColor = System.Drawing.Color.Gainsboro;
            this.tbSearchID.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchID.Location = new System.Drawing.Point(428, 24);
            this.tbSearchID.Multiline = true;
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(344, 36);
            this.tbSearchID.TabIndex = 78;
            this.tbSearchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchID.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchID_Validating);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(459, 312);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(150, 35);
            this.dtpDateOfBirth.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 28);
            this.label10.TabIndex = 75;
            this.label10.Text = "Salary";
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(459, 381);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(150, 35);
            this.tbAddress.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 28);
            this.label9.TabIndex = 73;
            this.label9.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(152, 381);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(150, 35);
            this.tbEmail.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 71;
            this.label8.Text = "DateOfBirth";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(349, 388);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 28);
            this.label.TabIndex = 70;
            this.label.Text = "Address";
            // 
            // tbPhone
            // 
            this.tbPhone.Enabled = false;
            this.tbPhone.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(459, 243);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(150, 35);
            this.tbPhone.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 68;
            this.label6.Text = "Phone";
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(459, 174);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 35);
            this.tbLastName.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 66;
            this.label5.Text = "Email";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(459, 105);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 35);
            this.tbFirstName.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 64;
            this.label4.Text = "UserName";
            // 
            // tbSalary
            // 
            this.tbSalary.Enabled = false;
            this.tbSalary.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(152, 312);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(150, 35);
            this.tbSalary.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 62;
            this.label3.Text = "LastName";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(152, 243);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(150, 35);
            this.tbPassword.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "FirstName";
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(152, 174);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(150, 35);
            this.tbUserName.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "User ID";
            // 
            // tbUserID
            // 
            this.tbUserID.Enabled = false;
            this.tbUserID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.Location = new System.Drawing.Point(152, 105);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(150, 35);
            this.tbUserID.TabIndex = 57;
            // 
            // gbPermissions
            // 
            this.gbPermissions.BackColor = System.Drawing.Color.Gainsboro;
            this.gbPermissions.Controls.Add(this.panelPermissions);
            this.gbPermissions.Controls.Add(this.chbSelectAll);
            this.gbPermissions.Enabled = false;
            this.gbPermissions.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.Location = new System.Drawing.Point(681, 126);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(206, 331);
            this.gbPermissions.TabIndex = 83;
            this.gbPermissions.TabStop = false;
            // 
            // panelPermissions
            // 
            this.panelPermissions.BackColor = System.Drawing.Color.Transparent;
            this.panelPermissions.Controls.Add(this.chbAdd);
            this.panelPermissions.Controls.Add(this.chbLoginLog);
            this.panelPermissions.Controls.Add(this.chbTransactions);
            this.panelPermissions.Controls.Add(this.chbManageUsers);
            this.panelPermissions.Controls.Add(this.chbDelete);
            this.panelPermissions.Controls.Add(this.chbShowList);
            this.panelPermissions.Controls.Add(this.chbUpdate);
            this.panelPermissions.Controls.Add(this.chbFind);
            this.panelPermissions.Enabled = false;
            this.panelPermissions.Location = new System.Drawing.Point(21, 54);
            this.panelPermissions.Name = "panelPermissions";
            this.panelPermissions.Size = new System.Drawing.Size(163, 261);
            this.panelPermissions.TabIndex = 5;
            // 
            // chbAdd
            // 
            this.chbAdd.AutoSize = true;
            this.chbAdd.Location = new System.Drawing.Point(12, 71);
            this.chbAdd.Name = "chbAdd";
            this.chbAdd.Size = new System.Drawing.Size(99, 28);
            this.chbAdd.TabIndex = 8;
            this.chbAdd.Tag = "4";
            this.chbAdd.Text = "Add Client";
            this.chbAdd.UseVisualStyleBackColor = true;
            // 
            // chbLoginLog
            // 
            this.chbLoginLog.AutoSize = true;
            this.chbLoginLog.Location = new System.Drawing.Point(12, 221);
            this.chbLoginLog.Name = "chbLoginLog";
            this.chbLoginLog.Size = new System.Drawing.Size(94, 28);
            this.chbLoginLog.TabIndex = 7;
            this.chbLoginLog.Tag = "128";
            this.chbLoginLog.Text = "Login Log";
            this.chbLoginLog.UseVisualStyleBackColor = true;
            // 
            // chbTransactions
            // 
            this.chbTransactions.AutoSize = true;
            this.chbTransactions.Location = new System.Drawing.Point(12, 191);
            this.chbTransactions.Name = "chbTransactions";
            this.chbTransactions.Size = new System.Drawing.Size(115, 28);
            this.chbTransactions.TabIndex = 6;
            this.chbTransactions.Tag = "64";
            this.chbTransactions.Text = "Transactions";
            this.chbTransactions.UseVisualStyleBackColor = true;
            // 
            // chbManageUsers
            // 
            this.chbManageUsers.AutoSize = true;
            this.chbManageUsers.Location = new System.Drawing.Point(12, 161);
            this.chbManageUsers.Name = "chbManageUsers";
            this.chbManageUsers.Size = new System.Drawing.Size(123, 28);
            this.chbManageUsers.TabIndex = 5;
            this.chbManageUsers.Tag = "32";
            this.chbManageUsers.Text = "Manage Users";
            this.chbManageUsers.UseVisualStyleBackColor = true;
            // 
            // chbDelete
            // 
            this.chbDelete.AutoSize = true;
            this.chbDelete.Location = new System.Drawing.Point(12, 131);
            this.chbDelete.Name = "chbDelete";
            this.chbDelete.Size = new System.Drawing.Size(117, 28);
            this.chbDelete.TabIndex = 4;
            this.chbDelete.Tag = "16";
            this.chbDelete.Text = "Delete Client";
            this.chbDelete.UseVisualStyleBackColor = true;
            // 
            // chbShowList
            // 
            this.chbShowList.AutoSize = true;
            this.chbShowList.Location = new System.Drawing.Point(12, 11);
            this.chbShowList.Name = "chbShowList";
            this.chbShowList.Size = new System.Drawing.Size(144, 28);
            this.chbShowList.TabIndex = 1;
            this.chbShowList.Tag = "1";
            this.chbShowList.Text = "Show Clients List";
            this.chbShowList.UseVisualStyleBackColor = true;
            // 
            // chbUpdate
            // 
            this.chbUpdate.AutoSize = true;
            this.chbUpdate.Location = new System.Drawing.Point(12, 101);
            this.chbUpdate.Name = "chbUpdate";
            this.chbUpdate.Size = new System.Drawing.Size(119, 28);
            this.chbUpdate.TabIndex = 3;
            this.chbUpdate.Tag = "8";
            this.chbUpdate.Text = "Update Client";
            this.chbUpdate.UseVisualStyleBackColor = true;
            // 
            // chbFind
            // 
            this.chbFind.AutoSize = true;
            this.chbFind.Location = new System.Drawing.Point(12, 41);
            this.chbFind.Name = "chbFind";
            this.chbFind.Size = new System.Drawing.Size(101, 28);
            this.chbFind.TabIndex = 2;
            this.chbFind.Tag = "2";
            this.chbFind.Text = "Find Client";
            this.chbFind.UseVisualStyleBackColor = true;
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.Location = new System.Drawing.Point(33, 20);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(135, 28);
            this.chbSelectAll.TabIndex = 0;
            this.chbSelectAll.Tag = "-1";
            this.chbSelectAll.Text = "All Permissions";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(725, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 28);
            this.label11.TabIndex = 84;
            this.label11.Text = "Permissions";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::BankManagementSystem.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(787, 23);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(51, 39);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 80;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // picture
            // 
            this.picture.Image = global::BankManagementSystem.Properties.Resources.anonymity;
            this.picture.Location = new System.Drawing.Point(942, 126);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(169, 219);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 76;
            this.picture.TabStop = false;
            // 
            // frmSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 545);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSearchID);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserID);
            this.Name = "frmSearchUser";
            this.Leave += new System.EventHandler(this.frmSearchUser_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.panelPermissions.ResumeLayout(false);
            this.panelPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.Panel panelPermissions;
        private System.Windows.Forms.CheckBox chbLoginLog;
        private System.Windows.Forms.CheckBox chbTransactions;
        private System.Windows.Forms.CheckBox chbManageUsers;
        private System.Windows.Forms.CheckBox chbDelete;
        private System.Windows.Forms.CheckBox chbShowList;
        private System.Windows.Forms.CheckBox chbUpdate;
        private System.Windows.Forms.CheckBox chbFind;
        private System.Windows.Forms.CheckBox chbSelectAll;
        private System.Windows.Forms.CheckBox chbAdd;
    }
}