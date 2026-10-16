namespace HotelManagementSystemCS
{
    partial class Form1
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
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnCheckInOut = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.lblTotalBookings = new System.Windows.Forms.Label();
            this.btnHotelSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(15, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(839, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOTEL MANAGEMENT SYSTEM";
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRooms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRooms.Location = new System.Drawing.Point(25, 137);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(400, 100);
            this.btnRooms.TabIndex = 1;
            this.btnRooms.Text = "Room Management";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomers.Location = new System.Drawing.Point(25, 293);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(400, 100);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customer Management";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckInOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckInOut.Location = new System.Drawing.Point(504, 137);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(400, 100);
            this.btnCheckInOut.TabIndex = 1;
            this.btnCheckInOut.Text = "Check-In / Check-Out";
            this.btnCheckInOut.UseVisualStyleBackColor = false;
            this.btnCheckInOut.Click += new System.EventHandler(this.btnCheckInOut_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayments.Location = new System.Drawing.Point(504, 482);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(400, 100);
            this.btnPayments.TabIndex = 1;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookings.Location = new System.Drawing.Point(504, 293);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(400, 100);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTotalRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.Location = new System.Drawing.Point(965, 137);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(264, 80);
            this.lblTotalRooms.TabIndex = 3;
            this.lblTotalRooms.Text = "Total Rooms: 0";
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.Location = new System.Drawing.Point(965, 251);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(264, 80);
            this.lblAvailableRooms.TabIndex = 3;
            this.lblAvailableRooms.Text = "Available Rooms: 0";
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblOccupiedRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedRooms.Location = new System.Drawing.Point(965, 435);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(264, 80);
            this.lblOccupiedRooms.TabIndex = 3;
            this.lblOccupiedRooms.Text = "Occupied Rooms: 0";
            // 
            // lblTotalBookings
            // 
            this.lblTotalBookings.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTotalBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBookings.Location = new System.Drawing.Point(970, 560);
            this.lblTotalBookings.Name = "lblTotalBookings";
            this.lblTotalBookings.Size = new System.Drawing.Size(259, 80);
            this.lblTotalBookings.TabIndex = 3;
            this.lblTotalBookings.Text = "Total Bookings: 0";
            // 
            // btnHotelSettings
            // 
            this.btnHotelSettings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHotelSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHotelSettings.Location = new System.Drawing.Point(25, 482);
            this.btnHotelSettings.Name = "btnHotelSettings";
            this.btnHotelSettings.Size = new System.Drawing.Size(400, 100);
            this.btnHotelSettings.TabIndex = 4;
            this.btnHotelSettings.Text = "Hotel Settings";
            this.btnHotelSettings.UseVisualStyleBackColor = false;
            this.btnHotelSettings.Click += new System.EventHandler(this.btnHotelSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btnHotelSettings);
            this.Controls.Add(this.lblTotalBookings);
            this.Controls.Add(this.lblOccupiedRooms);
            this.Controls.Add(this.lblAvailableRooms);
            this.Controls.Add(this.lblTotalRooms);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnCheckInOut);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnCheckInOut;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label lblTotalBookings;
        private System.Windows.Forms.Button btnHotelSettings;
    }
}

