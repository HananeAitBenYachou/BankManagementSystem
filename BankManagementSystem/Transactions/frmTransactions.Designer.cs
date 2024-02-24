namespace BankManagementSystem.Transactions
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlContainer3 = new System.Windows.Forms.Panel();
            this.tpTransfer = new System.Windows.Forms.TabPage();
            this.pnlContainer2 = new System.Windows.Forms.Panel();
            this.tpWithDraw = new System.Windows.Forms.TabPage();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tpDeposit = new System.Windows.Forms.TabPage();
            this.tcTransactions = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpTransfer.SuspendLayout();
            this.tpWithDraw.SuspendLayout();
            this.tpDeposit.SuspendLayout();
            this.tcTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "deposit.png");
            this.imageList1.Images.SetKeyName(1, "withdrawal.png");
            this.imageList1.Images.SetKeyName(2, "transaction.png");
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
            // tpTransfer
            // 
            this.tpTransfer.Controls.Add(this.pnlContainer3);
            this.tpTransfer.ImageIndex = 2;
            this.tpTransfer.Location = new System.Drawing.Point(4, 44);
            this.tpTransfer.Name = "tpTransfer";
            this.tpTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransfer.Size = new System.Drawing.Size(1174, 496);
            this.tpTransfer.TabIndex = 4;
            this.tpTransfer.Text = "Transfer";
            this.tpTransfer.UseVisualStyleBackColor = true;
            this.tpTransfer.Enter += new System.EventHandler(this.tpTransfer_Enter);
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
            // tpWithDraw
            // 
            this.tpWithDraw.Controls.Add(this.pnlContainer2);
            this.tpWithDraw.ImageIndex = 1;
            this.tpWithDraw.Location = new System.Drawing.Point(4, 44);
            this.tpWithDraw.Name = "tpWithDraw";
            this.tpWithDraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpWithDraw.Size = new System.Drawing.Size(1174, 496);
            this.tpWithDraw.TabIndex = 3;
            this.tpWithDraw.Text = "WithDraw";
            this.tpWithDraw.UseVisualStyleBackColor = true;
            this.tpWithDraw.Enter += new System.EventHandler(this.tpWithDraw_Enter);
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
            // tpDeposit
            // 
            this.tpDeposit.Controls.Add(this.pnlContainer);
            this.tpDeposit.ImageIndex = 0;
            this.tpDeposit.Location = new System.Drawing.Point(4, 44);
            this.tpDeposit.Name = "tpDeposit";
            this.tpDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposit.Size = new System.Drawing.Size(1174, 496);
            this.tpDeposit.TabIndex = 2;
            this.tpDeposit.Text = "Deposit";
            this.tpDeposit.UseVisualStyleBackColor = true;
            this.tpDeposit.Enter += new System.EventHandler(this.tpDeposit_Enter);
            // 
            // tcTransactions
            // 
            this.tcTransactions.Controls.Add(this.tpDeposit);
            this.tcTransactions.Controls.Add(this.tpWithDraw);
            this.tcTransactions.Controls.Add(this.tpTransfer);
            this.tcTransactions.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTransactions.ImageList = this.imageList1;
            this.tcTransactions.ItemSize = new System.Drawing.Size(100, 40);
            this.tcTransactions.Location = new System.Drawing.Point(18, 12);
            this.tcTransactions.Multiline = true;
            this.tcTransactions.Name = "tcTransactions";
            this.tcTransactions.SelectedIndex = 0;
            this.tcTransactions.Size = new System.Drawing.Size(1182, 544);
            this.tcTransactions.TabIndex = 2;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 568);
            this.Controls.Add(this.tcTransactions);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpTransfer.ResumeLayout(false);
            this.tpWithDraw.ResumeLayout(false);
            this.tpDeposit.ResumeLayout(false);
            this.tcTransactions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tcTransactions;
        private System.Windows.Forms.TabPage tpDeposit;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TabPage tpWithDraw;
        private System.Windows.Forms.Panel pnlContainer2;
        private System.Windows.Forms.TabPage tpTransfer;
        private System.Windows.Forms.Panel pnlContainer3;
        private System.Windows.Forms.ImageList imageList1;
    }
}