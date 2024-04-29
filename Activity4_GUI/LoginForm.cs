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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameTxt.Text;
            string password = this.passwordTxt.Text;
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    // Check login credentials
                    string sqlSelect = "SELECT COUNT(*) FROM accounts WHERE username = @username AND password = @password";
                    MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conn);
                    cmdSelect.Parameters.AddWithValue("@username", username);
                    cmdSelect.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmdSelect.ExecuteScalar());

                    if (count > 0)
                    {
                        // Update user status to "Active"
                        string sqlUpdate = "UPDATE accounts SET status = 'Active' WHERE username = @username";
                        MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                        cmdUpdate.Parameters.AddWithValue("@username", username);
                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User logged in successfully!");
                            // Proceed to dashboard or home form
                            var home = new DashboardForm();
                            this.Hide();
                            home.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user status!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/password!");
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void recoverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverForm = new RecoveryForm();
            this.Hide();
            recoverForm.Show();
        }

        private void showpassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the visibility of the password text based on the state of the checkbox
            passwordTxt.UseSystemPasswordChar = !showpassCheckBox.Checked;
        }
    }
}
