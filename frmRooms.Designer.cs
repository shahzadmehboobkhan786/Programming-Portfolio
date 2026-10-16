namespace HotelManagementSystemCS
{
    partial class frmRooms
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
            this.lblRoomTitle = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.cmbRoomStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomTitle
            // 
            this.lblRoomTitle.AutoSize = true;
            this.lblRoomTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRoomTitle.Location = new System.Drawing.Point(198, -5);
            this.lblRoomTitle.Name = "lblRoomTitle";
            this.lblRoomTitle.Size = new System.Drawing.Size(513, 70);
            this.lblRoomTitle.TabIndex = 0;
            this.lblRoomTitle.Text = "Room Management";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(28, 65);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(182, 32);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(28, 245);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(186, 32);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price Per Night";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(28, 167);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(142, 32);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(30, 100);
            this.txtRoomNumber.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(620, 50);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(34, 280);
            this.txtPrice.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(616, 50);
            this.txtPrice.TabIndex = 1;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Deluxe",
            "Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(34, 202);
            this.cmbRoomType.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(616, 28);
            this.cmbRoomType.TabIndex = 2;
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveRoom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveRoom.Location = new System.Drawing.Point(34, 415);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(197, 84);
            this.btnSaveRoom.TabIndex = 3;
            this.btnSaveRoom.Text = "Save Room";
            this.btnSaveRoom.UseVisualStyleBackColor = false;
            this.btnSaveRoom.Click += new System.EventHandler(this.btnSaveRoom_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(30, 518);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 62;
            this.dgvRooms.RowTemplate.Height = 28;
            this.dgvRooms.Size = new System.Drawing.Size(913, 152);
            this.dgvRooms.TabIndex = 4;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(460, 415);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(224, 84);
            this.btnDeleteRoom.TabIndex = 5;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditRoom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoom.ForeColor = System.Drawing.Color.White;
            this.btnEditRoom.Location = new System.Drawing.Point(257, 415);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(185, 84);
            this.btnEditRoom.TabIndex = 5;
            this.btnEditRoom.Text = "Edit Room";
            this.btnEditRoom.UseVisualStyleBackColor = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // cmbRoomStatus
            // 
            this.cmbRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomStatus.FormattingEnabled = true;
            this.cmbRoomStatus.Location = new System.Drawing.Point(437, 346);
            this.cmbRoomStatus.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbRoomStatus.Name = "cmbRoomStatus";
            this.cmbRoomStatus.Size = new System.Drawing.Size(213, 28);
            this.cmbRoomStatus.TabIndex = 6;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(705, 415);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(238, 84);
            this.btnUpdateStatus.TabIndex = 7;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(995, 682);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.cmbRoomStatus);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.btnSaveRoom);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblRoomTitle);
            this.Name = "frmRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Management";
            this.Load += new System.EventHandler(this.frmRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomTitle;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.ComboBox cmbRoomStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}