namespace HotelManagementSystemCS
{
    partial class frmHotelSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.txtHotelAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotel Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(223, 97);
            this.txtHotelName.MinimumSize = new System.Drawing.Size(50, 70);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(715, 70);
            this.txtHotelName.TabIndex = 1;
            this.txtHotelName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHotelAddress
            // 
            this.txtHotelAddress.Location = new System.Drawing.Point(223, 276);
            this.txtHotelAddress.MinimumSize = new System.Drawing.Size(50, 70);
            this.txtHotelAddress.Multiline = true;
            this.txtHotelAddress.Name = "txtHotelAddress";
            this.txtHotelAddress.Size = new System.Drawing.Size(715, 70);
            this.txtHotelAddress.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(223, 467);
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(50, 70);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(715, 70);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(484, 570);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(227, 80);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click_1);
            // 
            // frmHotelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1319, 662);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtHotelAddress);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHotelSettings";
            this.Text = "frmHotelSettings";
            this.Load += new System.EventHandler(this.frmHotelSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.TextBox txtHotelAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}