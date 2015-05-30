namespace RossiterScenicTours
{
    partial class FrmVehicleCost
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
            this.lblDS = new System.Windows.Forms.Label();
            this.lblKmCharge = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Location = new System.Drawing.Point(83, 32);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(13, 13);
            this.lblDS.TabIndex = 13;
            this.lblDS.Text = "$";
            // 
            // lblKmCharge
            // 
            this.lblKmCharge.AutoSize = true;
            this.lblKmCharge.Location = new System.Drawing.Point(12, 34);
            this.lblKmCharge.Name = "lblKmCharge";
            this.lblKmCharge.Size = new System.Drawing.Size(65, 13);
            this.lblKmCharge.TabIndex = 12;
            this.lblKmCharge.Text = "Km - Charge";
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(101, 58);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(100, 20);
            this.txtSeats.TabIndex = 11;
            this.txtSeats.Text = "32";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(11, 61);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(66, 13);
            this.lblSeats.TabIndex = 10;
            this.lblSeats.Text = "No. of Seats";
            // 
            // FrmVehicleCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(227, 141);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.lblKmCharge);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.lblSeats);
            this.Name = "FrmVehicleCost";
            this.Text = "Add / Edit Vehicle";
            this.Controls.SetChildIndex(this.lblSeats, 0);
            this.Controls.SetChildIndex(this.txtSeats, 0);
            this.Controls.SetChildIndex(this.lblKmCharge, 0);
            this.Controls.SetChildIndex(this.lblDS, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Label lblKmCharge;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Label lblSeats;

    }
}
