namespace HotelManagementSystemCS
{
    partial class frmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilling));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.cmbBooking = new System.Windows.Forms.ComboBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(57, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(502, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hotel Billing and Payment";
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(65, 69);
            this.lblBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(169, 29);
            this.lblBooking.TabIndex = 0;
            this.lblBooking.Text = "Select Guest:";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(65, 166);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(198, 29);
            this.lblRoomPrice.TabIndex = 0;
            this.lblRoomPrice.Text = "Price Per Night:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(64, 291);
            this.lblNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(228, 32);
            this.lblNights.TabIndex = 0;
            this.lblNights.Text = "Number of Nights:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(458, 69);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 29);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Bill:";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(458, 167);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(167, 29);
            this.lblPaid.TabIndex = 0;
            this.lblPaid.Text = "Amount Paid:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(457, 291);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(238, 32);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Remaining Balance:";
            // 
            // cmbBooking
            // 
            this.cmbBooking.FormattingEnabled = true;
            this.cmbBooking.ItemHeight = 25;
            this.cmbBooking.Location = new System.Drawing.Point(65, 112);
            this.cmbBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBooking.MinimumSize = new System.Drawing.Size(65, 0);
            this.cmbBooking.Name = "cmbBooking";
            this.cmbBooking.Size = new System.Drawing.Size(312, 33);
            this.cmbBooking.TabIndex = 1;
            this.cmbBooking.SelectedIndexChanged += new System.EventHandler(this.cmbBooking_SelectedIndexChanged);
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(65, 211);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomPrice.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.ReadOnly = true;
            this.txtRoomPrice.Size = new System.Drawing.Size(312, 50);
            this.txtRoomPrice.TabIndex = 2;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(70, 331);
            this.txtNights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNights.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtNights.Name = "txtNights";
            this.txtNights.ReadOnly = true;
            this.txtNights.Size = new System.Drawing.Size(312, 50);
            this.txtNights.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Transparent;
            this.txtTotal.Location = new System.Drawing.Point(463, 113);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(274, 50);
            this.txtTotal.TabIndex = 2;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(463, 211);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountPaid.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(274, 50);
            this.txtAmountPaid.TabIndex = 2;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(463, 331);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBalance.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(274, 50);
            this.txtBalance.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(815, 112);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(193, 69);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSavePayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSavePayment.Location = new System.Drawing.Point(815, 211);
            this.btnSavePayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(201, 69);
            this.btnSavePayment.TabIndex = 3;
            this.btnSavePayment.Text = "Save Payment";
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // dgvBilling
            // 
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(65, 468);
            this.dgvBilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersWidth = 62;
            this.dgvBilling.RowTemplate.Height = 28;
            this.dgvBilling.Size = new System.Drawing.Size(765, 119);
            this.dgvBilling.TabIndex = 4;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintInvoice.Location = new System.Drawing.Point(815, 331);
            this.btnPrintInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(201, 69);
            this.btnPrintInvoice.TabIndex = 5;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(304, 402);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(245, 33);
            this.cmbPaymentMethod.TabIndex = 6;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Payment Method:.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1320, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.dgvBilling);
            this.Controls.Add(this.btnSavePayment);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.cmbBooking);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBilling";
            this.Text = "frmBilling";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ComboBox cmbBooking;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label1;
    }
}