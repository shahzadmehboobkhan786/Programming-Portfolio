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
    public partial class frmHotelSettings : Form
    {

        private string connectionString =
    System.Configuration.ConfigurationManager
    .ConnectionStrings["HotelDB"].ConnectionString;
        private void LoadHotelSettings()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT HotelName, HotelAddress, PhoneNumber
                         FROM HotelSettings WHERE SettingID = 1";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtHotelName.Text = reader["HotelName"].ToString();
                        txtHotelAddress.Text = reader["HotelAddress"].ToString();
                        txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                    }
                }
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHotelName.Text) ||
                string.IsNullOrWhiteSpace(txtHotelAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter all hotel details.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE HotelSettings
                         SET HotelName = @Name,
                             HotelAddress = @Address,
                             PhoneNumber = @Phone
                         WHERE SettingID = 1";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value =
                    txtHotelName.Text.Trim();
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 200).Value =
                    txtHotelAddress.Text.Trim();
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 30).Value =
                    txtPhoneNumber.Text.Trim();

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Hotel settings saved successfully!");
                else
                    MessageBox.Show("Hotel settings record was not found.");
            }
        }
        public frmHotelSettings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHotelSettings_Load(object sender, EventArgs e)
        {
            LoadHotelSettings();
        }

        private void btnSaveSettings_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtHotelName.Text) ||
       string.IsNullOrWhiteSpace(txtHotelAddress.Text) ||
       string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter all hotel details.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE HotelSettings
                         SET HotelName = @Name,
                             HotelAddress = @Address,
                             PhoneNumber = @Phone
                         WHERE SettingID = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value =
                        txtHotelName.Text.Trim();

                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 200).Value =
                        txtHotelAddress.Text.Trim();

                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 30).Value =
                        txtPhoneNumber.Text.Trim();

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Hotel settings saved successfully!");
                    else
                        MessageBox.Show("Hotel settings record was not found.");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
