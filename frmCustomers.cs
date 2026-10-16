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
    public partial class frmCustomers : Form


    {


        private string connectionString =
            System.Configuration.ConfigurationManager
            .ConnectionStrings["HotelDB"].ConnectionString;
        int selectedCustomerID = 0;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {

            LoadCustomers();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Customers
                         (CustomerName, Phone)
                         VALUES (@Name, @Phone)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Customer saved successfully!");

            LoadCustomers();

            txtCustomerName.Clear();
            txtPhone.Clear();

        }


        private void LoadCustomers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT CustomerID, CustomerName, Phone
                                 FROM Customers
                                 ORDER BY CustomerID DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                selectedCustomerID = Convert.ToInt32(
                    dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

                txtCustomerName.Text =
                    dgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString();

                txtPhone.Text =
                    dgvCustomers.CurrentRow.Cells["Phone"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Customers
                     SET CustomerName = @Name, Phone = @Phone
                     WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Customer updated successfully!");

            LoadCustomers();

            txtCustomerName.Clear();
            txtPhone.Clear();
            selectedCustomerID = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer deleted successfully!");

                LoadCustomers();

                txtCustomerName.Clear();
                txtPhone.Clear();
                selectedCustomerID = 0;
            }
        }
    }
}