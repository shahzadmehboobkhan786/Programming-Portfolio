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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers customerForm = new frmCustomers();
            customerForm.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRooms roomForm = new frmRooms();
            roomForm.ShowDialog();

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            frmBookings bookingsForm = new frmBookings();
            bookingsForm.ShowDialog();
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            frmCheckInOut form = new frmCheckInOut();
            form.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmBilling form = new frmBilling();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDashboardSummary();
        }
        private void LoadDashboardSummary()
        {
            string connectionString =
    System.Configuration.ConfigurationManager
        .ConnectionStrings["HotelDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
            SELECT
                (SELECT COUNT(*) FROM Rooms) AS TotalRooms,
                (SELECT COUNT(*) FROM Rooms
                 WHERE RoomStatus = 'Available') AS AvailableRooms,
                (SELECT COUNT(*) FROM Rooms
                 WHERE RoomStatus <> 'Available') AS OccupiedRooms,
                (SELECT COUNT(*) FROM Bookings) AS TotalBookings";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblTotalRooms.Text =
                            "Total Rooms: " + reader["TotalRooms"].ToString();

                        lblAvailableRooms.Text =
                            "Available Rooms: " + reader["AvailableRooms"].ToString();

                        lblOccupiedRooms.Text =
                            "Occupied Rooms: " + reader["OccupiedRooms"].ToString();

                        lblTotalBookings.Text =
                            "Total Bookings: " + reader["TotalBookings"].ToString();
                    }
                }
            }
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {

        }

        private void btnHotelSettings_Click(object sender, EventArgs e)
        {
            frmHotelSettings settingsForm = new frmHotelSettings();
            settingsForm.ShowDialog();
        }
    }
}
