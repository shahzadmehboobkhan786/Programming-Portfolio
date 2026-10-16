

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
    public partial class frmRooms : Form


    {
        private string connectionString =
    System.Configuration.ConfigurationManager
    .ConnectionStrings["HotelDB"].ConnectionString;
        int selectedRoomID = 0;
        public frmRooms()
        {
            InitializeComponent();
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            LoadRooms();

            cmbRoomStatus.Items.Clear();

            cmbRoomStatus.Items.Add("Available");
            cmbRoomStatus.Items.Add("Occupied");
            cmbRoomStatus.Items.Add("Under Maintenance");

            cmbRoomStatus.SelectedIndex = 0;
        }

        private void LoadRooms()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT RoomID, RoomNumber, RoomType, " +
                                   "PricePerNight, RoomStatus FROM Rooms";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRooms.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text.Trim() == "" ||
       cmbRoomType.Text == "" ||
       txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than zero.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Rooms
                             (RoomNumber, RoomType, PricePerNight)
                             VALUES
                             (@RoomNumber, @RoomType, @PricePerNight)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber",
                            txtRoomNumber.Text.Trim());

                        cmd.Parameters.AddWithValue("@RoomType",
                            cmbRoomType.Text);

                        cmd.Parameters.AddWithValue("@PricePerNight", price);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Room saved successfully!");

                LoadRooms();
                txtRoomNumber.Clear();
                cmbRoomType.SelectedIndex = -1;
                txtPrice.Clear();
                txtRoomNumber.Focus();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This room number already exists.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                selectedRoomID = Convert.ToInt32(
                    dgvRooms.CurrentRow.Cells["RoomID"].Value);

                txtRoomNumber.Text =
                    dgvRooms.CurrentRow.Cells["RoomNumber"].Value.ToString();

                cmbRoomType.Text =
                    dgvRooms.CurrentRow.Cells["RoomType"].Value.ToString();

                txtPrice.Text =
                    dgvRooms.CurrentRow.Cells["PricePerNight"].Value.ToString();
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (selectedRoomID == 0)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            if (txtRoomNumber.Text.Trim() == "" ||
                cmbRoomType.Text == "" ||
                !decimal.TryParse(txtPrice.Text, out decimal price) ||
                price <= 0)
            {
                MessageBox.Show("Please enter valid room details.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Rooms
                             SET RoomNumber = @RoomNumber,
                                 RoomType = @RoomType,
                                 PricePerNight = @Price
                             WHERE RoomID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber",
                            txtRoomNumber.Text.Trim());

                        cmd.Parameters.AddWithValue("@RoomType",
                            cmbRoomType.Text);

                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@RoomID", selectedRoomID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Room updated successfully!");
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
        }

      
private void btnDeleteRoom_Click(object sender, EventArgs e)
{
    if (selectedRoomID == 0)
    {
        MessageBox.Show("Please select a room first.");
        return;
    }

    DialogResult result = MessageBox.Show(
        "Are you sure you want to delete this room?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

    if (result != DialogResult.Yes)
    {
        return;
    }

    try
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RoomID", selectedRoomID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        MessageBox.Show("Room deleted successfully!");

        selectedRoomID = 0;
        txtRoomNumber.Clear();
        cmbRoomType.SelectedIndex = -1;
        txtPrice.Clear();

        LoadRooms();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error deleting room: " + ex.Message);
    }
}

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {

            if (selectedRoomID == 0)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            if (cmbRoomStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Rooms
                             SET RoomStatus = @Status
                             WHERE RoomID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Status", cmbRoomStatus.Text);
                        cmd.Parameters.AddWithValue("@RoomID", selectedRoomID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Room status updated successfully!");
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
