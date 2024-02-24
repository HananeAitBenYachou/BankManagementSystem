namespace BankManagementSystem
{
    partial class frmDeposit
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.tbDepositAmount = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(222, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 34);
            this.label7.TabIndex = 82;
            this.label7.Text = "Account Number :";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.tbAccountNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNumber.Location = new System.Drawing.Point(412, 84);
            this.tbAccountNumber.Multiline = true;
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(344, 36);
            this.tbAccountNumber.TabIndex = 81;
            this.tbAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbAccountNumber_Validating);
            // 
            // tbDepositAmount
            // 
            this.tbDepositAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDepositAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepositAmount.Location = new System.Drawing.Point(412, 222);
            this.tbDepositAmount.Multiline = true;
            this.tbDepositAmount.Name = "tbDepositAmount";
            this.tbDepositAmount.Size = new System.Drawing.Size(344, 36);
            this.tbDepositAmount.TabIndex = 84;
            this.tbDepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDepositAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbDepositAmount_Validating);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(228, 222);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 34);
            this.label.TabIndex = 85;
            this.label.Text = "Deposit Amount :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbCancel
            // 
            this.pbCancel.Image = global::BankManagementSystem.Properties.Resources.close__1_;
            this.pbCancel.Location = new System.Drawing.Point(843, 217);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(51, 39);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 87;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = global::BankManagementSystem.Properties.Resources.check;
            this.pbSave.Location = new System.Drawing.Point(771, 217);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(51, 39);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 86;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::BankManagementSystem.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(771, 83);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(51, 39);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 83;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 545);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbDepositAmount);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAccountNumber);
            this.Name = "frmDeposit";
            this.Text = "frmDeposit";
            this.Leave += new System.EventHandler(this.frmDeposit_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.TextBox tbDepositAmount;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}