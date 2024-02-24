namespace BankManagementSystem.Transactions
{
    partial class frmTransfer
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
            this.pbSearch2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAccountNumber2 = new System.Windows.Forms.TextBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.tbTransferAmount = new System.Windows.Forms.TextBox();
            this.pbSearch1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAccountNumber1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSearch2
            // 
            this.pbSearch2.Image = global::BankManagementSystem.Properties.Resources.search;
            this.pbSearch2.Location = new System.Drawing.Point(791, 155);
            this.pbSearch2.Name = "pbSearch2";
            this.pbSearch2.Size = new System.Drawing.Size(51, 39);
            this.pbSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch2.TabIndex = 107;
            this.pbSearch2.TabStop = false;
            this.pbSearch2.Click += new System.EventHandler(this.pbSearch2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(272, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 34);
            this.label1.TabIndex = 106;
            this.label1.Text = "Transfer To :";
            // 
            // tbAccountNumber2
            // 
            this.tbAccountNumber2.BackColor = System.Drawing.Color.Gainsboro;
            this.tbAccountNumber2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNumber2.Location = new System.Drawing.Point(432, 155);
            this.tbAccountNumber2.Multiline = true;
            this.tbAccountNumber2.Name = "tbAccountNumber2";
            this.tbAccountNumber2.Size = new System.Drawing.Size(344, 36);
            this.tbAccountNumber2.TabIndex = 105;
            this.tbAccountNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAccountNumber2.Validating += new System.ComponentModel.CancelEventHandler(this.tbAccountNumber2_Validating);
            // 
            // pbCancel
            // 
            this.pbCancel.Image = global::BankManagementSystem.Properties.Resources.close__1_;
            this.pbCancel.Location = new System.Drawing.Point(863, 249);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(51, 39);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancel.TabIndex = 104;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = global::BankManagementSystem.Properties.Resources.check;
            this.pbSave.Location = new System.Drawing.Point(791, 249);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(51, 39);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 103;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(246, 253);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(181, 34);
            this.label.TabIndex = 102;
            this.label.Text = "Transfer Amount :";
            // 
            // tbTransferAmount
            // 
            this.tbTransferAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.tbTransferAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTransferAmount.Location = new System.Drawing.Point(432, 251);
            this.tbTransferAmount.Multiline = true;
            this.tbTransferAmount.Name = "tbTransferAmount";
            this.tbTransferAmount.Size = new System.Drawing.Size(344, 36);
            this.tbTransferAmount.TabIndex = 101;
            this.tbTransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTransferAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbTransferAmount_Validating);
            // 
            // pbSearch1
            // 
            this.pbSearch1.Image = global::BankManagementSystem.Properties.Resources.search;
            this.pbSearch1.Location = new System.Drawing.Point(791, 58);
            this.pbSearch1.Name = "pbSearch1";
            this.pbSearch1.Size = new System.Drawing.Size(51, 39);
            this.pbSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch1.TabIndex = 100;
            this.pbSearch1.TabStop = false;
            this.pbSearch1.Click += new System.EventHandler(this.pbSearch1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(257, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 34);
            this.label7.TabIndex = 99;
            this.label7.Text = "Fransfer From :";
            // 
            // tbAccountNumber1
            // 
            this.tbAccountNumber1.BackColor = System.Drawing.Color.Gainsboro;
            this.tbAccountNumber1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNumber1.Location = new System.Drawing.Point(432, 59);
            this.tbAccountNumber1.Multiline = true;
            this.tbAccountNumber1.Name = "tbAccountNumber1";
            this.tbAccountNumber1.Size = new System.Drawing.Size(344, 36);
            this.tbAccountNumber1.TabIndex = 98;
            this.tbAccountNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAccountNumber1.Validating += new System.ComponentModel.CancelEventHandler(this.tbAccountNumber1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 545);
            this.Controls.Add(this.pbSearch2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAccountNumber2);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbTransferAmount);
            this.Controls.Add(this.pbSearch1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAccountNumber1);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Leave += new System.EventHandler(this.frmTransfer_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAccountNumber2;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbTransferAmount;
        private System.Windows.Forms.PictureBox pbSearch1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAccountNumber1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}