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

namespace Activity4_GUI
{
    public partial class RecoveryForm : Form
    {
        public RecoveryForm()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            string confirmPassword = confirmPasswordTxt.Text.Trim();

            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.");
                return; // Exit the method
            }

            // Your MySQL connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to update the password for the given username
                    string sql = "UPDATE accounts SET password = @password WHERE username = @username";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Username not found. Password not updated.");
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void showpassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the visibility of the password text based on the state of the checkbox
            passwordTxt.UseSystemPasswordChar = !showpassCheckBox.Checked;
            confirmPasswordTxt.UseSystemPasswordChar = !showpassCheckBox.Checked;
        }
    }
}
