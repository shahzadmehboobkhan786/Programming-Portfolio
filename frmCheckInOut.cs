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
    public partial class frmCheckInOut : Form
    {

        private string connectionString =
   System.Configuration.ConfigurationManager
   .ConnectionStrings["HotelDB"].ConnectionString;
        public frmCheckInOut()
        {
            InitializeComponent();
        }

        private void frmCheckInOut_Load(object sender, EventArgs e)
        {
          

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT BookingID, GuestName
                 FROM Bookings
                 WHERE BookingStatus IN ('Booked', 'Checked In')
                 ORDER BY BookingID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbBooking.DataSource = dt;
                cmbBooking.DisplayMember = "GuestName";
                cmbBooking.ValueMember = "BookingID";
                cmbBooking.SelectedIndex = -1;
            }
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
                         B.BookingID,
                         R.RoomNumber,
                         B.GuestName,
                         B.GuestPhone,
                         B.CheckInDate,
                         B.CheckOutDate,
                         B.BookingStatus
                         FROM Bookings B
                         INNER JOIN Rooms R ON B.RoomID = R.RoomID
                         WHERE B.BookingID = @BookingID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvCheckInOut.DataSource = dt;
                }
            }

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

            if (cmbBooking.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a guest.");
                return;
            }

            DataRowView selectedBooking =
                cmbBooking.SelectedItem as DataRowView;

            if (selectedBooking == null)
            {
                return;
            }

            int bookingID =
                Convert.ToInt32(selectedBooking["BookingID"]);

            string connectionString =
      System.Configuration.ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Bookings
                         SET BookingStatus = 'Checked In'
                         WHERE BookingID = @BookingID
                         AND BookingStatus = 'Booked'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);

                    con.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Guest checked in successfully!");

                        frmCheckInOut_Load(sender, e);
                        dgvCheckInOut.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("This booking cannot be checked in.");
                    }
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            if (cmbBooking.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a guest.");
                return;
            }

            DataRowView selectedBooking =
                cmbBooking.SelectedItem as DataRowView;

            if (selectedBooking == null)
            {
                return;
            }

            int bookingID =
                Convert.ToInt32(selectedBooking["BookingID"]);

            string connectionString =
     System.Configuration.ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string query = @"
                UPDATE Rooms
                SET RoomStatus = 'Available'
                WHERE RoomID =
                (
                    SELECT RoomID
                    FROM Bookings
                    WHERE BookingID = @BookingID
                    AND BookingStatus = 'Checked In'
                );

                UPDATE Bookings
                SET BookingStatus = 'Checked Out'
                WHERE BookingID = @BookingID
                AND BookingStatus = 'Checked In';";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            transaction.Commit();

                            MessageBox.Show("Guest checked out successfully!");

                            dgvCheckInOut.DataSource = null;
                            frmCheckInOut_Load(sender, e);
                        }
                        else
                        {
                            transaction.Rollback();

                            MessageBox.Show(
                                "Please check in the guest before checking out.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}