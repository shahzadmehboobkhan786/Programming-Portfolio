namespace HotelManagementSystemCS
{
    partial class frmBookings
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
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuestPhone = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblGuestPhone = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchGuest = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.cmbBookingStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(29, 275);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(255, 26);
            this.txtGuestName.TabIndex = 1;
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.Location = new System.Drawing.Point(29, 374);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Size = new System.Drawing.Size(241, 26);
            this.txtGuestPhone.TabIndex = 2;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(377, 273);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(241, 26);
            this.dtpCheckIn.TabIndex = 3;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(377, 378);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(241, 26);
            this.dtpCheckOut.TabIndex = 4;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(16, 111);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(94, 38);
            this.lblRoom.TabIndex = 5;
            this.lblRoom.Text = "Room";
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(80, 500);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(286, 57);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Amount";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBookRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoom.ForeColor = System.Drawing.Color.White;
            this.btnBookRoom.Location = new System.Drawing.Point(396, 500);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(286, 57);
            this.btnBookRoom.TabIndex = 7;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(23, 563);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 62;
            this.dgvBookings.RowTemplate.Height = 28;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1253, 110);
            this.dgvBookings.TabIndex = 8;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(29, 163);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(260, 28);
            this.cmbRoom.TabIndex = 0;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(19, 221);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(178, 38);
            this.lblGuestName.TabIndex = 5;
            this.lblGuestName.Text = "Guest Name";
            this.lblGuestName.Click += new System.EventHandler(this.lblGuestName_Click);
            // 
            // lblGuestPhone
            // 
            this.lblGuestPhone.AutoSize = true;
            this.lblGuestPhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestPhone.Location = new System.Drawing.Point(22, 318);
            this.lblGuestPhone.Name = "lblGuestPhone";
            this.lblGuestPhone.Size = new System.Drawing.Size(183, 38);
            this.lblGuestPhone.TabIndex = 5;
            this.lblGuestPhone.Text = "Guest Phone";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(361, 319);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(219, 38);
            this.lblCheckOut.TabIndex = 9;
            this.lblCheckOut.Text = "Check-out Date";
            this.lblCheckOut.Click += new System.EventHandler(this.lblCheckOut_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(361, 221);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(199, 38);
            this.lblCheckIn.TabIndex = 9;
            this.lblCheckIn.Text = "Check-in Date";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(272, 441);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(63, 32);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(25, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(205, 38);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Amount:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(712, 500);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(286, 57);
            this.btnCancelBooking.TabIndex = 13;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(725, 330);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 51);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search Guest";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchGuest
            // 
            this.txtSearchGuest.Location = new System.Drawing.Point(919, 330);
            this.txtSearchGuest.MinimumSize = new System.Drawing.Size(0, 50);
            this.txtSearchGuest.Name = "txtSearchGuest";
            this.txtSearchGuest.Size = new System.Drawing.Size(253, 50);
            this.txtSearchGuest.TabIndex = 15;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(725, 422);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(175, 51);
            this.btnClearSearch.TabIndex = 16;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // cmbBookingStatus
            // 
            this.cmbBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingStatus.FormattingEnabled = true;
            this.cmbBookingStatus.Location = new System.Drawing.Point(1041, 529);
            this.cmbBookingStatus.Name = "cmbBookingStatus";
            this.cmbBookingStatus.Size = new System.Drawing.Size(213, 28);
            this.cmbBookingStatus.TabIndex = 17;
            this.cmbBookingStatus.SelectedIndexChanged += new System.EventHandler(this.cmbBookingStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(321, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Room Booking";
            // 
            // frmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1290, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBookingStatus);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.txtSearchGuest);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGuestPhone);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtGuestPhone);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.cmbRoom);
            this.Name = "frmBookings";
            this.Text = "frmBookings";
            this.Load += new System.EventHandler(this.frmBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtGuestPhone;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblGuestPhone;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.ComboBox cmbBookingStatus;
        private System.Windows.Forms.Label label1;
    }
}