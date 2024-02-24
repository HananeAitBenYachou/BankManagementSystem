namespace BankManagementSystem
{
    partial class frmDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblClientsCount = new System.Windows.Forms.Label();
            this.lblClientsNum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(126)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUsersCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(175, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 213);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagementSystem.Properties.Resources.teamwork;
            this.pictureBox1.Location = new System.Drawing.Point(33, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCount.ForeColor = System.Drawing.Color.White;
            this.lblUsersCount.Location = new System.Drawing.Point(212, 137);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(31, 40);
            this.lblUsersCount.TabIndex = 1;
            this.lblUsersCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblClientsCount);
            this.panel2.Controls.Add(this.lblClientsNum);
            this.panel2.Location = new System.Drawing.Point(672, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 213);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankManagementSystem.Properties.Resources.team;
            this.pictureBox2.Location = new System.Drawing.Point(33, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblClientsCount
            // 
            this.lblClientsCount.AutoSize = true;
            this.lblClientsCount.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsCount.ForeColor = System.Drawing.Color.White;
            this.lblClientsCount.Location = new System.Drawing.Point(220, 137);
            this.lblClientsCount.Name = "lblClientsCount";
            this.lblClientsCount.Size = new System.Drawing.Size(31, 40);
            this.lblClientsCount.TabIndex = 1;
            this.lblClientsCount.Text = "0";
            // 
            // lblClientsNum
            // 
            this.lblClientsNum.AutoSize = true;
            this.lblClientsNum.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsNum.ForeColor = System.Drawing.Color.White;
            this.lblClientsNum.Location = new System.Drawing.Point(191, 79);
            this.lblClientsNum.Name = "lblClientsNum";
            this.lblClientsNum.Size = new System.Drawing.Size(116, 45);
            this.lblClientsNum.TabIndex = 0;
            this.lblClientsNum.Text = "Clients :";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblClientsCount;
        private System.Windows.Forms.Label lblClientsNum;
    }
}