namespace BankManagementSystem
{
    partial class frmDeleteUser
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
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::BankManagementSystem.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(710, 192);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(51, 39);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 62;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 34);
            this.label7.TabIndex = 61;
            this.label7.Text = "User ID :";
            // 
            // tbSearchID
            // 
            this.tbSearchID.BackColor = System.Drawing.Color.Gainsboro;
            this.tbSearchID.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchID.Location = new System.Drawing.Point(351, 195);
            this.tbSearchID.Multiline = true;
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(344, 36);
            this.tbSearchID.TabIndex = 60;
            this.tbSearchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchID.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchID_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbSave
            // 
            this.pbSave.Image = global::BankManagementSystem.Properties.Resources.check;
            this.pbSave.Location = new System.Drawing.Point(781, 192);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(51, 39);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 104;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbCancel
            // 
            this.pbCancel.Image = global::BankManagementSystem.Properties.Resources.close__1_;
            this.pbCancel.Location = new System.Drawing.Point(852, 192);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(51, 39);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 105;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // frmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 545);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSearchID);
            this.Name = "frmDeleteUser";
            this.Text = "frmDeleteUser";
            this.Leave += new System.EventHandler(this.frmDeleteUser_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbCancel;
    }
}