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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void accountsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var acctForm = new AccountsForm();
            this.Hide();
            acctForm.Show();
        }

        private void reportsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reports = new ReportsForm();
            this.Hide();
            reports.Show();
        }
    }
}
