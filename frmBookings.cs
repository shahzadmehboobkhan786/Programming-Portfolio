using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace HotelManagementSystemCS
{
    public partial class frmBookings : Form

    {
        private string connectionString =
    System.Configuration.ConfigurationManager
    .ConnectionStrings["HotelDB"].ConnectionString;
        public frmBookings()
        {
            InitializeComponent();
        }

        private void frmBookings_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT RoomID, RoomNumber, PricePerNight
                             FROM Rooms
                             WHERE RoomStatus = 'Available'
                             ORDER BY RoomNumber";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbRoom.DataSource = dt;
                        cmbRoom.DisplayMember = "RoomNumber";
                        cmbRoom.ValueMember = "RoomID";
                        cmbRoom.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }

            LoadBookings();

            cmbBookingStatus.Items.Clear();

            cmbBookingStatus.Items.Add("All");
            cmbBookingStatus.Items.Add("Booked");
            cmbBookingStatus.Items.Add("Cancelled");

            cmbBookingStatus.SelectedIndex = 0;
        }

        private void LoadBookings()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                         B.BookingID,
                         R.RoomNumber,
                         B.GuestName,
                         B.GuestPhone,
                         B.CheckInDate,
                         B.CheckOutDate,
                         B.TotalAmount,
                         B.BookingStatus
                         FROM Bookings B
                         INNER JOIN Rooms R
                         ON B.RoomID = R.RoomID
                         ORDER BY B.BookingID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBookings.DataSource = dt;
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (cmbRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room.");
                return;
            }

            if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date)
            {
                MessageBox.Show("Check-out must be after check-in.");
                return;
            }

            DataRowView room = (DataRowView)cmbRoom.SelectedItem;

            decimal price = Convert.ToDecimal(room["PricePerNight"]);

            int nights = (dtpCheckOut.Value.Date -
                          dtpCheckIn.Value.Date).Days;

            decimal total = price * nights;

            lblTotalAmount.Text = total.ToString("0.00");

        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {

            if (txtGuestName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter guest name.");
                return;
            }

            if (cmbRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room.");
                return;
            }

            if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date)
            {
                MessageBox.Show("Check-out date must be after check-in date.");
                return;
            }

            decimal totalAmount = 0;

            DataRowView room = (DataRowView)cmbRoom.SelectedItem;
            decimal price = Convert.ToDecimal(room["PricePerNight"]);

            int nights = (dtpCheckOut.Value.Date -
                          dtpCheckIn.Value.Date).Days;

            totalAmount = price * nights;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string query = @"INSERT INTO Bookings
            (RoomID, GuestName, GuestPhone, CheckInDate,
             CheckOutDate, TotalAmount, BookingStatus)
            VALUES
            (@RoomID, @GuestName, @GuestPhone, @CheckInDate,
             @CheckOutDate, @TotalAmount, 'Booked')";

                    using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", cmbRoom.SelectedValue);
                        cmd.Parameters.AddWithValue("@GuestName", txtGuestName.Text.Trim());
                        cmd.Parameters.AddWithValue("@GuestPhone", txtGuestPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@CheckInDate", dtpCheckIn.Value.Date);
                        cmd.Parameters.AddWithValue("@CheckOutDate", dtpCheckOut.Value.Date);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        cmd.ExecuteNonQuery();
                    }

                    string updateQuery = @"UPDATE Rooms
                               SET RoomStatus = 'Occupied'
                               WHERE RoomID = @RoomID
                               AND RoomStatus = 'Available'";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", cmbRoom.SelectedValue);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            throw new Exception("This room is no longer available.");
                        }
                    }

                    transaction.Commit();

                    lblTotalAmount.Text = totalAmount.ToString("0.00");

                    LoadBookings();

                    MessageBox.Show("Booking saved successfully!");

                    txtGuestName.Clear();
                    txtGuestPhone.Clear();
                    cmbRoom.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving booking: " + ex.Message);
                }
            }

        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {

            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            int bookingID = Convert.ToInt32(
                dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this booking?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string query = @"UPDATE Bookings
                             SET BookingStatus = 'Cancelled'
                             WHERE BookingID = @BookingID
                             AND BookingStatus = 'Booked'";

                    int roomID;

                    using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            throw new Exception(
                                "This booking is already cancelled or cannot be cancelled.");
                        }
                    }

                    string roomQuery = @"SELECT RoomID
                                 FROM Bookings
                                 WHERE BookingID = @BookingID";

                    using (SqlCommand cmd = new SqlCommand(
                        roomQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        roomID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string updateRoom = @"UPDATE Rooms
                                  SET RoomStatus = 'Available'
                                  WHERE RoomID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(
                        updateRoom, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    LoadBookings();

                    MessageBox.Show("Booking cancelled successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT BookingID, GuestName, GuestPhone,
                                CheckInDate, CheckOutDate,
                                TotalAmount, BookingStatus
                         FROM Bookings
                         WHERE GuestName LIKE @GuestName
                         ORDER BY BookingID DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue(
                        "@GuestName", "%" + txtSearchGuest.Text.Trim() + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBookings.DataSource = dt;
                }
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {

            txtSearchGuest.Clear();

            LoadBookings();

        }

        private void cmbBookingStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbBookingStatus.SelectedItem == null)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;

                if (cmbBookingStatus.SelectedItem.ToString() == "All")
                {
                    query = @"SELECT B.BookingID, R.RoomNumber,
                             B.GuestName, B.GuestPhone,
                             B.CheckInDate, B.CheckOutDate,
                             B.TotalAmount, B.BookingStatus
                      FROM Bookings B
                      INNER JOIN Rooms R ON B.RoomID = R.RoomID
                      ORDER BY B.BookingID DESC";
                }
                else
                {
                    query = @"SELECT B.BookingID, R.RoomNumber,
                             B.GuestName, B.GuestPhone,
                             B.CheckInDate, B.CheckOutDate,
                             B.TotalAmount, B.BookingStatus
                      FROM Bookings B
                      INNER JOIN Rooms R ON B.RoomID = R.RoomID
                      WHERE B.BookingStatus = @Status
                      ORDER BY B.BookingID DESC";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (cmbBookingStatus.SelectedItem.ToString() != "All")
                    {
                        cmd.Parameters.AddWithValue(
                            "@Status", cmbBookingStatus.SelectedItem.ToString());
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBookings.DataSource = dt;
                }
            }

        }

        private void lblRoom_Click(object sender, EventArgs e)
        {

        }

        private void lblGuestName_Click(object sender, EventArgs e)
        {

        }

        private void lblCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}
