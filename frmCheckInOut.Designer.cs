namespace HotelManagementSystemCS
{
    partial class frmCheckInOut
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.cmbBooking = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvCheckInOut = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(128, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Guest Check-In / Check-Out";
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(28, 121);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(197, 29);
            this.lblBooking.TabIndex = 0;
            this.lblBooking.Text = "Select Booking:";
            // 
            // cmbBooking
            // 
            this.cmbBooking.DropDownHeight = 206;
            this.cmbBooking.FormattingEnabled = true;
            this.cmbBooking.IntegralHeight = false;
            this.cmbBooking.Location = new System.Drawing.Point(33, 169);
            this.cmbBooking.Name = "cmbBooking";
            this.cmbBooking.Size = new System.Drawing.Size(665, 28);
            this.cmbBooking.TabIndex = 1;
            this.cmbBooking.SelectedIndexChanged += new System.EventHandler(this.cmbBooking_SelectedIndexChanged);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(33, 289);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(355, 62);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Guest Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(438, 289);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(355, 62);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Guest Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dgvCheckInOut
            // 
            this.dgvCheckInOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInOut.Location = new System.Drawing.Point(12, 467);
            this.dgvCheckInOut.Name = "dgvCheckInOut";
            this.dgvCheckInOut.RowHeadersWidth = 62;
            this.dgvCheckInOut.RowTemplate.Height = 28;
            this.dgvCheckInOut.Size = new System.Drawing.Size(781, 150);
            this.dgvCheckInOut.TabIndex = 3;
            // 
            // frmCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(816, 661);
            this.Controls.Add(this.dgvCheckInOut);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.cmbBooking);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCheckInOut";
            this.Text = "frmCheckInOut";
            this.Load += new System.EventHandler(this.frmCheckInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.ComboBox cmbBooking;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvCheckInOut;
    }
}