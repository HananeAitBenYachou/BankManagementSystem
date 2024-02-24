namespace BankManagementSystem.Transactions
{
    partial class frmWithDraw
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
            this.label = new System.Windows.Forms.Label();
            this.tbWithDrawAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(229, 212);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(192, 34);
            this.label.TabIndex = 92;
            this.label.Text = "WithDraw Amount :";
            // 
            // tbWithDrawAmount
            // 
            this.tbWithDrawAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.tbWithDrawAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWithDrawAmount.Location = new System.Drawing.Point(432, 210);
            this.tbWithDrawAmount.Multiline = true;
            this.tbWithDrawAmount.Name = "tbWithDrawAmount";
            this.tbWithDrawAmount.Size = new System.Drawing.Size(344, 36);
            this.tbWithDrawAmount.TabIndex = 91;
            this.tbWithDrawAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWithDrawAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbWithDrawAmount_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(242, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 34);
            this.label7.TabIndex = 89;
            this.label7.Text = "Account Number :";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.tbAccountNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNumber.Location = new System.Drawing.Point(432, 72);
            this.tbAccountNumber.Multiline = true;
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(344, 36);
            this.tbAccountNumber.TabIndex = 88;
            this.tbAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbAccountNumber_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbCancel
            // 
            this.pbCancel.Image = global::BankManagementSystem.Properties.Resources.close__1_;
            this.pbCancel.Location = new System.Drawing.Point(863, 205);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(51, 39);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 94;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = global::BankManagementSystem.Properties.Resources.check;
            this.pbSave.Location = new System.Drawing.Point(791, 205);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(51, 39);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 93;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::BankManagementSystem.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(791, 71);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(51, 39);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 90;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // frmWithDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 545);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbWithDrawAmount);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAccountNumber);
            this.Name = "frmWithDraw";
            this.Text = "frmWithDraw";
            this.Leave += new System.EventHandler(this.frmWithDraw_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbWithDrawAmount;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}