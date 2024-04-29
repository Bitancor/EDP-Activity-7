using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Activity4_GUI
{
    public partial class AccountsForm : Form
    {
        // Your MySQL connection string
        string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";
        public AccountsForm()
        {
            InitializeComponent();

            PopulateAccountsDataGridView();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void dashboardLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var home = new DashboardForm();
            this.Hide();
            home.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameTxt.Text;
            string password = this.passwordTxt.Text;
            string status = "Inactive"; // Set the status to "Inactive" for new accounts

            // Your MySQL connection string
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            try
            {
                // Create a new MySqlConnection object
                MySqlConnection conn = new MySqlConnection(myConnectionString);

                // Open the database connection
                conn.Open();

                // SQL query to insert a new record into the accounts table
                string sql = "INSERT INTO accounts (username, password, status) VALUES (@username, @password, @status)";

                // Create a new MySqlCommand object with the SQL query and connection
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // Add parameters to the command to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@status", status); // Set the status parameter

                // Execute the SQL command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the insertion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account added successfully!");
                    PopulateAccountsDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to add account!");
                }

                // Close the database connection
                conn.Close();
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that may occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PopulateAccountsDataGridView()
        {
            try
            {
                // Create a MySqlConnection object
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to select all columns from the accounts table
                    string query = "SELECT * FROM accounts";

                    // Create a MySqlCommand object with the SQL query and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Create a DataTable to store the data
                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        // Create a MySqlDataAdapter to fill the DataTable with the data from the database
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            // Fill the DataTable with the data
                            adapter.Fill(dataTable);
                        }

                        // Set the DataSource of the DataGridView to the filled DataTable
                        accountsDataGridView.DataSource = dataTable;
                    }

                    // Close the connection
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that may occur during the database operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchboxTxt.Text.Trim().ToLower(); // Get the search term from the textbox and convert to lowercase

            // Cast the DataGridView's DataSource to a DataTable
            if (accountsDataGridView.DataSource is DataTable dataTable)
            {
                // Build a filter expression for the DataView based on the search term
                string filterExpression = $"username LIKE '%{searchTerm}%'";

                // Apply the filter to the DataView
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string currentUsername = currentUsernameTxt.Text.Trim();
            string newUsername = newUsernameTxt.Text.Trim();

            // Your MySQL connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to update the username in the accounts table
                    string sql = "UPDATE accounts SET username = @newUsername WHERE username = @currentUsername";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@newUsername", newUsername);
                        cmd.Parameters.AddWithValue("@currentUsername", currentUsername);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Username updated successfully.");
                            PopulateAccountsDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Current username not found. Username not updated.");
                        }
                    }

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
