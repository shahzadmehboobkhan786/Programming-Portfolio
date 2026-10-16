
using System;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace HotelManagementSystemCS
{
    public partial class frmLogin : Form
    {
        private string connectionString =
    System.Configuration.ConfigurationManager
    .ConnectionStrings["HotelDB"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password, salt, 100000))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                return Convert.ToBase64String(salt) + ":" +
                       Convert.ToBase64String(hash);
            }
        }

        private bool VerifyPassword(string password, string storedPassword)
        {
            string[] parts = storedPassword.Split(':');

            if (parts.Length != 2)
                return false;

            byte[] salt;
            byte[] storedHash;

            try
            {
                salt = Convert.FromBase64String(parts[0]);
                storedHash = Convert.FromBase64String(parts[1]);
            }
            catch (FormatException)
            {
                return false;
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password, salt, 100000))
            {
                byte[] enteredHash = pbkdf2.GetBytes(32);

                int difference = 0;

                if (enteredHash.Length != storedHash.Length)
                    return false;

                for (int i = 0; i < enteredHash.Length; i++)
                {
                    difference |= enteredHash[i] ^ storedHash[i];
                }
                return difference == 0;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" ||
                txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());

                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null &&
                        VerifyPassword(txtPassword.Text, result.ToString()))
                    {
                        MessageBox.Show("Login successful!");

                        this.Hide();

                        Form1 dashboard = new Form1();
                        dashboard.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter an admin username and password first.");
                return;
            }

            string passwordHash = HashPassword(password);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Users
                                     (Username, PasswordHash, UserRole)
                                     VALUES (@Username, @PasswordHash, 'Admin')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Admin account created successfully!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This username already exists. Choose another username.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}