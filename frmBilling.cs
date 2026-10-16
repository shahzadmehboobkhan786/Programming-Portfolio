using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace HotelManagementSystemCS
{
    public partial class frmBilling : Form
    {

        private string connectionString =
    System.Configuration.ConfigurationManager
    .ConnectionStrings["HotelDB"].ConnectionString;

        private string invoiceHotelName = "";
        private string invoiceHotelAddress = "";
        private string invoiceHotelPhone = "";

        private string _invoicePaymentMethod = "";
        private string _invoicePaymentStatus = "";
        private string _invoiceBookingID = "";
        private string _invoiceGuestName = "";
        private DateTime _invoicePaymentDate = DateTime.Now;
        private int _invoicePaymentID = 0;
        public frmBilling()
        {
            InitializeComponent();
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {




            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("Digital Payment");
            cmbPaymentMethod.SelectedIndex = 0;
            string connectionString =
       System.Configuration.ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT BookingID, GuestName
                         FROM Bookings
                         WHERE BookingStatus = 'Checked In'
                         ORDER BY BookingID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbBooking.DataSource = dt;
                cmbBooking.DisplayMember = "GuestName";
                cmbBooking.ValueMember = "BookingID";
                cmbBooking.SelectedIndex = -1;
            }

            LoadPayments();
        }

       

        private void cmbBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBooking.SelectedItem == null)
            {
                return;
            }

            DataRowView selectedBooking = cmbBooking.SelectedItem as DataRowView;

            if (selectedBooking == null)
            {
                return;
            }

            int bookingID = Convert.ToInt32(selectedBooking["BookingID"]);

            string connectionString =
    System.Configuration.ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                         R.PricePerNight,
                         DATEDIFF(DAY, B.CheckInDate, B.CheckOutDate) AS Nights
                         FROM Bookings B
                         INNER JOIN Rooms R ON B.RoomID = R.RoomID
                         WHERE B.BookingID = @BookingID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtRoomPrice.Text = reader["PricePerNight"].ToString();
                            txtNights.Text = reader["Nights"].ToString();
                        }
                    }
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal price;
            int nights;
            decimal amountPaid;

            if (!decimal.TryParse(txtRoomPrice.Text, out price) ||
                !int.TryParse(txtNights.Text, out nights))
            {
                MessageBox.Show("Please select a guest first.");
                return;
            }

            if (nights <= 0 || price < 0)
            {
                MessageBox.Show("Invalid room price or number of nights.");
                return;
            }

            decimal total = price * nights;
            txtTotal.Text = total.ToString("0.00");

            if (string.IsNullOrWhiteSpace(txtAmountPaid.Text))
            {
                txtAmountPaid.Text = "0";
            }

            if (!decimal.TryParse(txtAmountPaid.Text, out amountPaid) ||
                amountPaid < 0)
            {
                MessageBox.Show("Please enter a valid amount paid.");
                return;
            }

            decimal balance = total - amountPaid;
            txtBalance.Text = balance.ToString("0.00");

            MessageBox.Show("Bill calculated successfully!");
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {

            decimal total;
            decimal amountPaid;
            decimal balance;

            if (cmbBooking.SelectedValue == null ||
                !decimal.TryParse(txtTotal.Text, out total) ||
                !decimal.TryParse(txtAmountPaid.Text, out amountPaid) ||
                !decimal.TryParse(txtBalance.Text, out balance))
            {
                MessageBox.Show("Please select a guest and calculate the bill first.");
                return;
            }

            if (amountPaid < 0 || amountPaid > total)
            {
                MessageBox.Show("Amount paid must be between 0 and the total bill.");
                return;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            int bookingID = Convert.ToInt32(cmbBooking.SelectedValue);
            string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            string paymentStatus;

            if (balance == 0)
            {
                paymentStatus = "Paid";
            }
            else if (amountPaid > 0)
            {
                paymentStatus = "Partial";
            }
            else
            {
                paymentStatus = "Unpaid";
            }

            string connectionString =
     System.Configuration.ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO dbo.Payments
            (BookingID, TotalAmount, AmountPaid, Balance, PaymentStatus, PaymentMethod)
            VALUES
            (@BookingID, @TotalAmount, @AmountPaid, @Balance, @PaymentStatus, @PaymentMethod)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);
                    cmd.Parameters.AddWithValue("@TotalAmount", total);
                    cmd.Parameters.AddWithValue("@AmountPaid", amountPaid);
                    cmd.Parameters.AddWithValue("@Balance", balance);
                    cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment saved successfully!");
                    LoadPayments();
                }
            }


        }
        private void LoadPayments()
        {
            string connectionString =
     System.Configuration.ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                P.PaymentID,
                B.GuestName,
                P.TotalAmount,
                P.AmountPaid,
                P.Balance,
                P.PaymentDate,
                P.PaymentStatus
            FROM dbo.Payments P
            INNER JOIN dbo.Bookings B
                ON P.BookingID = B.BookingID
            ORDER BY P.PaymentID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBilling.DataSource = dt;
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        { // Check whether a previous payment is selected
            if (dgvBilling.CurrentRow != null &&
                dgvBilling.CurrentRow.Cells["PaymentID"].Value != null)
            {
                int paymentID = Convert.ToInt32(
                    dgvBilling.CurrentRow.Cells["PaymentID"].Value);
                _invoicePaymentID = paymentID;

                string connectionString =
     System.Configuration.ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT
                    P.PaymentID,
                    P.BookingID,
                    B.GuestName,
                    B.CheckInDate,
                    B.CheckOutDate,
                    R.RoomNumber,
                    R.PricePerNight,
                    P.TotalAmount,
                    P.AmountPaid,
                    P.Balance,
                    P.PaymentMethod,
                    P.PaymentDate,
                    P.PaymentStatus
                FROM dbo.Payments P
                INNER JOIN dbo.Bookings B
                    ON P.BookingID = B.BookingID
                INNER JOIN dbo.Rooms R
                    ON B.RoomID = R.RoomID
                WHERE P.PaymentID = @PaymentID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Payment record not found.");
                                return;
                            }

                            // Load saved payment details into invoice controls
                            cmbBooking.Text = reader["GuestName"].ToString();
                            txtRoomPrice.Text =
                                Convert.ToDecimal(reader["PricePerNight"]).ToString();
                            txtNights.Text =
                                (Convert.ToDateTime(reader["CheckOutDate"]) -
                                 Convert.ToDateTime(reader["CheckInDate"])).Days.ToString();
                            txtTotal.Text =
                                Convert.ToDecimal(reader["TotalAmount"]).ToString();
                            txtAmountPaid.Text =
                                Convert.ToDecimal(reader["AmountPaid"]).ToString();
                            txtBalance.Text =
                                Convert.ToDecimal(reader["Balance"]).ToString();

                            string savedMethod = reader["PaymentMethod"].ToString();
                            string savedStatus = reader["PaymentStatus"].ToString();

                            cmbPaymentMethod.SelectedItem = savedMethod;

                            // Keep the exact saved status for the invoice
                            _invoicePaymentMethod = savedMethod;
                            _invoicePaymentStatus = savedStatus;
                            _invoiceBookingID = reader["BookingID"].ToString();
                            _invoiceGuestName = reader["GuestName"].ToString();
                            _invoicePaymentDate =
                                Convert.ToDateTime(reader["PaymentDate"]);
                        }
                    }
                }

                printDocument1.PrintPage -= printDocument1_PrintPage;
                printDocument1.PrintPage += printDocument1_PrintPage;

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a payment from the payment history first.");
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            LoadInvoiceHotelSettings();
            Graphics g = e.Graphics;

            Font titleFont = new Font("Arial", 22, FontStyle.Bold);
            Font headingFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 11);
            Font smallFont = new Font("Arial", 9);

            Pen blackPen = new Pen(Color.Black, 1);

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;

            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;


            // Invoice header
            g.DrawString(invoiceHotelName, titleFont, Brushes.Black,
                new RectangleF(x, y, width, 35), center);
            y += 35;

            g.DrawString(invoiceHotelAddress, normalFont, Brushes.Black,
                new RectangleF(x, y, width, 25), center);
            y += 25;

            g.DrawString("Phone: " + invoiceHotelPhone, normalFont, Brushes.Black,
                new RectangleF(x, y, width, 25), center);
            y += 35;
            // Invoice details
            g.DrawString("Invoice Date: " + _invoicePaymentDate.ToString("dd-MMM-yyyy"),
                 normalFont, Brushes.Black, x, y);
            y += 25;

            string invoiceNumber = "INV-" +
    _invoicePaymentID.ToString("D5");

            g.DrawString("Invoice Number: " + invoiceNumber,
                normalFont, Brushes.Black, x, y);
            y += 25;

            g.DrawString("Booking ID: " + _invoiceBookingID,
                  normalFont, Brushes.Black, x, y);
            y += 25;

            g.DrawString("Guest Name: " + _invoiceGuestName,
                 normalFont, Brushes.Black, x, y);
            y += 35;

            // Table column widths
            float col1 = x;
            float col2 = x + width * 0.43f;
            float col3 = x + width * 0.65f;
            float col4 = x + width * 0.78f;

            float tableHeight = 32;

            // Table heading
            g.FillRectangle(Brushes.LightGray, x, y, width, tableHeight);
            g.DrawRectangle(blackPen, x, y, width, tableHeight);

            g.DrawString("Description", headingFont, Brushes.Black, col1 + 5, y + 7);
            g.DrawString("Rate", headingFont, Brushes.Black, col2 + 5, y + 7);
            g.DrawString("Nights", headingFont, Brushes.Black, col3 + 2, y + 7);
            g.DrawString("Amount", headingFont, Brushes.Black, col4 + 2, y + 7);

            y += tableHeight;

            // Room charge row
            g.DrawRectangle(blackPen, x, y, width, tableHeight);

            g.DrawString("Room Charges", normalFont, Brushes.Black, col1 + 5, y + 7);
            g.DrawString("$" + decimal.Parse(txtRoomPrice.Text).ToString("N2"),
                normalFont, Brushes.Black, col2 + 5, y + 7);
            g.DrawString(txtNights.Text, normalFont, Brushes.Black, col3 + 2, y + 7);
            g.DrawString("$" + decimal.Parse(txtTotal.Text).ToString("N2"),
                normalFont, Brushes.Black, col4 + 2, y + 7);

            float tableTop = y - tableHeight;
            float tableBottom = y + tableHeight;

            g.DrawLine(blackPen, col2, tableTop, col2, tableBottom);
            g.DrawLine(blackPen, col3, tableTop, col3, tableBottom);
            g.DrawLine(blackPen, col4, tableTop, col4, tableBottom);

            y += tableHeight + 30;

            // Payment summary
            g.DrawLine(blackPen, x, y, x + width, y);
            y += 15;

            g.DrawString("PAYMENT SUMMARY", headingFont, Brushes.Black, x, y);
            y += 30;

            g.DrawString("Total Bill:", normalFont, Brushes.Black, x, y);
            g.DrawString("$" + decimal.Parse(txtTotal.Text).ToString("N2"),
                normalFont, Brushes.Black, x + width - 150, y);
            y += 25;

            g.DrawString("Amount Paid:", normalFont, Brushes.Black, x, y);
            g.DrawString("$" + decimal.Parse(txtAmountPaid.Text).ToString("N2"),
                normalFont, Brushes.Black, x + width - 150, y);
            y += 25;

            g.DrawString("Remaining Balance:", headingFont, Brushes.Black, x, y);
            g.DrawString("$" + decimal.Parse(txtBalance.Text).ToString("N2"),
                headingFont, Brushes.Black, x + width - 150, y);
            y += 30;

            // NEW: Payment method
            string paymentMethod = _invoicePaymentMethod;

            g.DrawString("Payment Method: " + paymentMethod,
                normalFont, Brushes.Black, x, y);
            y += 25;

            // NEW: Payment status
            decimal amountPaid = decimal.Parse(txtAmountPaid.Text);
            decimal balance = decimal.Parse(txtBalance.Text);

            string paymentStatus = _invoicePaymentStatus;

            g.DrawString("Payment Status: " + paymentStatus,
                headingFont, Brushes.Black, x, y);
            y += 35;

            g.DrawLine(blackPen, x, y, x + width, y);
            y += 15;

            // Footer
            g.DrawString("Thank you for staying with us!",
                headingFont, Brushes.Black,
                new RectangleF(x, y, width, 25), center);
            y += 25;

            g.DrawString("Please keep this invoice for your records.",
                smallFont, Brushes.Black,
                new RectangleF(x, y, width, 20), center);

            center.Dispose();
            titleFont.Dispose();
            headingFont.Dispose();
            normalFont.Dispose();
            smallFont.Dispose();
            blackPen.Dispose();
        }
        private void LoadInvoiceHotelSettings()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT HotelName, HotelAddress, PhoneNumber
                         FROM HotelSettings
                         WHERE SettingID = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            invoiceHotelName = reader["HotelName"].ToString();
                            invoiceHotelAddress = reader["HotelAddress"].ToString();
                            invoiceHotelPhone = reader["PhoneNumber"].ToString();
                        }
                    }
                }
            }
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}