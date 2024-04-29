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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Activity4_GUI
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            PopulateDataGridView();
        }

        private void accountsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var acctForm = new AccountsForm();
            this.Hide();
            acctForm.Show();
        }

        private void PopulateDataGridView()
        {
            // Your MySQL connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            // SQL query with joins to retrieve data from students, sections, and clubs tables
            string query = "SELECT s.student_id AS ID, s.name AS Names, se.section_name AS Section, s.stud_gwa AS GWA, c.club_name AS Club, s.payment_status AS Payment " +
                           "FROM students s " +
                           "JOIN sections se ON s.section_id = se.section_id " +
                           "JOIN clubs c ON s.club_id = c.club_id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Create a MySqlCommand object with the SQL query and connection
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Create a DataTable to store the data
                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        // Create a MySqlDataAdapter to fill the DataTable with the data from the database
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            // Fill the DataTable with the data
                            adapter.Fill(dataTable);
                        }

                        // Set the DataSource of the DataGridView to the filled DataTable
                        ReportsGridView.DataSource = dataTable;
                    }

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void fullExportBtn_Click(object sender, EventArgs e)
        {
            // Construct the path to the template file
            string templateFolderPath = Path.Combine(Application.StartupPath, "reportsTemplate");
            string templateFilePath = Path.Combine(templateFolderPath, "StudentRecord.xlsx");

            // Check if the template folder exists
            if (!Directory.Exists(templateFolderPath))
            {
                MessageBox.Show("Template folder not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the template file exists
            if (!File.Exists(templateFilePath))
            {
                MessageBox.Show("Template file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the directory for generated reports if it doesn't exist
            string newFolderPath = Path.Combine(Application.StartupPath, "generatedReports");
            Directory.CreateDirectory(newFolderPath);

            // Construct the path for the new report file
            string newFilePath = Path.Combine(newFolderPath, $"StudentReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

            // Export data to Excel template
            ExportDataGridViewToExcelTemplate(ReportsGridView, templateFilePath, newFilePath);
        }

        private void ExportDataGridViewToExcelTemplate(DataGridView dgv, string templatePath, string newFilePath)
        {
            // Check if the template file exists
            if (!File.Exists(templatePath))
            {
                MessageBox.Show("Template file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start Excel and get Application object
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Make the app visible (optional)
                excelApp.Visible = false;

                // Open the template workbook
                Excel.Workbook workbook = excelApp.Workbooks.Open(templatePath);

                // Export data to the first sheet
                ExportDataToSheet(dgv, workbook.Sheets[1]);

                // Insert the graph into the second sheet
                InsertSectionGraph(workbook.Sheets[2]);

                // Save the workbook
                workbook.SaveAs(newFilePath);
                MessageBox.Show($"Data exported to {newFilePath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the workbook and release Excel objects
                workbook.Close();
                excelApp.Quit();
                ReleaseObject(workbook);
                ReleaseObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDataToSheet(DataGridView dgv, Excel.Worksheet sheet)
        {
            // Get the range of the worksheet (excluding the first two rows for headers)
            Excel.Range range = sheet.Range["A3", "F" + (dgv.RowCount + 2)];

            // Copy data from DataGridView to Excel worksheet
            object[,] data = new object[dgv.RowCount, dgv.ColumnCount];
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    data[i, j] = dgv.Rows[i].Cells[j].Value;
                }
            }
            range.Value = data;

            // Add signature placeholder
            int lastRow = dgv.RowCount + 2;
            sheet.Cells[lastRow + 1, 1] = "Signature:";
            sheet.Cells[lastRow + 1, 2] = "[Enter Signature Here]";
        }

        private void InsertSectionGraph(Excel.Worksheet sheet)
        {
            Excel.Range startCell = null;

            // Your MySQL connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            // SQL query to count the number of students per section
            string query = "SELECT se.section_name AS Section, COUNT(*) AS StudentCount " +
                           "FROM students s " +
                           "JOIN sections se ON s.section_id = se.section_id " +
                           "GROUP BY se.section_name";

            try
            {
                // Create MySqlConnection
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create MySqlCommand
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the command and read the result
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Get the starting cell for the data
                            startCell = sheet.Cells[3, 1];

                            // Write column headers
                            sheet.Cells[startCell.Row - 1, startCell.Column] = "Section";
                            sheet.Cells[startCell.Row - 1, startCell.Column + 1] = "Student Count";

                            // Write data to the sheet
                            int row = startCell.Row;
                            while (reader.Read())
                            {
                                sheet.Cells[row, startCell.Column] = reader["Section"];
                                sheet.Cells[row, startCell.Column + 1] = reader["StudentCount"];
                                row++;
                            }

                            // Get the range of section names and student counts
                            Excel.Range sectionNamesRange = sheet.Range[sheet.Cells[startCell.Row, startCell.Column], sheet.Cells[row - 1, startCell.Column]];
                            Excel.Range studentCountsRange = sheet.Range[sheet.Cells[startCell.Row, startCell.Column + 1], sheet.Cells[row - 1, startCell.Column + 1]];

                            // Set the chart location
                            Excel.Range chartRange = sheet.Range["C1", "M12"]; // Adjust the range as needed

                            // Create the chart
                            Excel.ChartObjects chartObjects = (Excel.ChartObjects)sheet.ChartObjects();
                            Excel.ChartObject chartObject = chartObjects.Add(chartRange.Left, chartRange.Top, chartRange.Width, chartRange.Height);
                            Excel.Chart chart = chartObject.Chart;

                            // Set the chart type
                            chart.ChartType = Excel.XlChartType.xlColumnClustered;

                            // Set the data range for the chart
                            chart.SetSourceData(studentCountsRange);

                            // Set category labels
                            chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).CategoryNames = sectionNamesRange;

                            // Set the chart title
                            chart.HasTitle = true;
                            chart.ChartTitle.Text = "Number of Students by Section";

                            // Add signature placeholder
                            int lastRow = row;
                            sheet.Cells[lastRow + 1, startCell.Column] = "Signature:";
                            sheet.Cells[lastRow + 1, startCell.Column + 1] = "[Enter Signature Here]";
                        }
                    }

                    // Close the connection
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void payExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Construct the path to the template file
                string templateFolderPath = Path.Combine(Application.StartupPath, "reportsTemplate");
                string templateFilePath = Path.Combine(templateFolderPath, "StudentPaymentStatus1.xlsx");

                // Check if the template folder exists
                if (!Directory.Exists(templateFolderPath))
                {
                    MessageBox.Show("Template folder not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the template file exists
                if (!File.Exists(templateFilePath))
                {
                    MessageBox.Show("Template file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Your MySQL connection string
                string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

                // SQL query to retrieve payment status data from the students table
                string query = "SELECT s.student_id AS ID, s.name AS Names, se.section_name AS Section, s.payment_status AS PaymentStatus " +
                               "FROM students s " +
                               "JOIN sections se ON s.section_id = se.section_id";

                // Create MySqlConnection
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create MySqlCommand
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Create a DataTable to store the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the database
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Create the directory for generated reports if it doesn't exist
                        string newFolderPath = Path.Combine(Application.StartupPath, "generatedReports");
                        Directory.CreateDirectory(newFolderPath);

                        // Construct the path for the new report file
                        string newFilePath = Path.Combine(newFolderPath, $"PaymentStatusReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

                        // Export data to Excel template
                        ExportPaymentStatusToExcel(dataTable, templateFilePath, newFilePath);

                        MessageBox.Show($"Payment status exported to {newFilePath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportPaymentStatusToExcel(DataTable dataTable, string templateFilePath, string newFilePath)
        {
            // Check if the template file exists
            if (!File.Exists(templateFilePath))
            {
                MessageBox.Show("Template file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start Excel and get Application object
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Make the app visible (optional)
                excelApp.Visible = false;

                // Open the template workbook
                Excel.Workbook workbook = excelApp.Workbooks.Open(templateFilePath);

                // Export data to the first worksheet
                ExportDataToSheet(dataTable, workbook.Sheets[1]);

                // Insert the graph for payment status into the second worksheet
                InsertPaymentStatusGraph(workbook.Sheets[2], dataTable.Rows.Count);

                // Save the workbook
                workbook.SaveAs(newFilePath);

                // Close the workbook and release Excel objects
                workbook.Close();
                excelApp.Quit();
                ReleaseObject(workbook);
                ReleaseObject(excelApp);

                MessageBox.Show($"Payment status exported to {newFilePath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDataToSheet(DataTable dataTable, Excel.Worksheet sheet)
        {
            // Get the starting cell for inserting data (starting from the third row)
            Excel.Range startCell = sheet.Cells[3, 1];

            // Get the range of the worksheet starting from the third row
            Excel.Range range = sheet.Range[startCell, sheet.Cells[startCell.Row + dataTable.Rows.Count - 1, startCell.Column + dataTable.Columns.Count - 1]];

            // Copy data from DataTable to Excel worksheet
            object[,] data = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    data[i, j] = dataTable.Rows[i][j];
                }
            }

            // Paste the data into the range
            range.Value = data;

            // Add signature placeholder
            int lastRow = startCell.Row + dataTable.Rows.Count;
            sheet.Cells[lastRow + 1, 1] = "Signature:";
            sheet.Cells[lastRow + 1, 2] = "[Enter Signature Here]";
        }

        private void InsertPaymentStatusGraph(Excel.Worksheet sheet, int rowCount)
        {
            Excel.Range startCell = null;

            // Your MySQL connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            // SQL query to count the number of students per payment status
            string query = "SELECT s.payment_status AS PaymentStatus, COUNT(*) AS StudentCount " +
                           "FROM students s " +
                           "GROUP BY s.payment_status";

            try
            {
                // Create MySqlConnection
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create MySqlCommand
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the command and read the result
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Get the starting cell for the data
                            startCell = sheet.Cells[3, 1];

                            // Write column headers
                            sheet.Cells[startCell.Row - 1, startCell.Column] = "Payment Status";
                            sheet.Cells[startCell.Row - 1, startCell.Column + 1] = "Student Count";

                            // Write data to the sheet
                            int row = startCell.Row;
                            while (reader.Read())
                            {
                                sheet.Cells[row, startCell.Column] = reader["PaymentStatus"];
                                sheet.Cells[row, startCell.Column + 1] = reader["StudentCount"];
                                row++;
                            }

                            // Get the range of payment status and student counts
                            Excel.Range paymentStatusRange = sheet.Range[sheet.Cells[startCell.Row, startCell.Column], sheet.Cells[row - 1, startCell.Column]];
                            Excel.Range studentCountsRange = sheet.Range[sheet.Cells[startCell.Row, startCell.Column + 1], sheet.Cells[row - 1, startCell.Column + 1]];

                            // Set the chart location
                            Excel.Range chartRange = sheet.Range["C1", "E12"]; // Adjust the range as needed

                            // Create the chart
                            Excel.ChartObjects chartObjects = (Excel.ChartObjects)sheet.ChartObjects();
                            Excel.ChartObject chartObject = chartObjects.Add(chartRange.Left, chartRange.Top, chartRange.Width, chartRange.Height);
                            Excel.Chart chart = chartObject.Chart;

                            // Set the chart type
                            chart.ChartType = Excel.XlChartType.xlColumnClustered;

                            // Set the data range for the chart
                            chart.SetSourceData(studentCountsRange);

                            // Set category labels
                            chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).CategoryNames = paymentStatusRange;

                            // Set the chart title
                            chart.HasTitle = true;
                            chart.ChartTitle.Text = "Number of Students by Payment Status";

                            // Add signature placeholder
                            int lastRow = row;
                            sheet.Cells[lastRow + 1, startCell.Column] = "Signature:";
                            sheet.Cells[lastRow + 1, startCell.Column + 1] = "[Enter Signature Here]";
                        }
                    }

                    // Close the connection
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void clubExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Construct the path to the template file
                string templateFolderPath = Path.Combine(Application.StartupPath, "reportsTemplate");
                string templateFilePath = Path.Combine(templateFolderPath, "StudentClubs4.xlsx");

                // Check if the template folder exists
                if (!Directory.Exists(templateFolderPath))
                {
                    MessageBox.Show("Template folder not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the template file exists
                if (!File.Exists(templateFilePath))
                {
                    MessageBox.Show("Template file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Your MySQL connection string
                string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

                // SQL query to retrieve data including student_id, name, and club_id (with the actual club name)
                string query = "SELECT s.student_id, s.name, c.club_name AS club_id " +
                               "FROM students s " +
                               "JOIN clubs c ON s.club_id = c.club_id";

                // Create MySqlConnection
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create MySqlCommand
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Create a DataTable to store the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the database
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Create the directory for generated reports if it doesn't exist
                        string newFolderPath = Path.Combine(Application.StartupPath, "generatedReports");
                        Directory.CreateDirectory(newFolderPath);

                        // Construct the path for the new report file
                        string newFilePath = Path.Combine(newFolderPath, $"StudentClubsReport{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

                        // Export data to Excel template
                        ExportClubsJoinedToExcel(dataTable, templateFilePath, newFilePath);

                        MessageBox.Show($"Student clubs joined exported to {newFilePath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportClubsJoinedToExcel(DataTable dataTable, string templateFilePath, string newFilePath)
        {
            // Check if the template file exists
            if (!File.Exists(templateFilePath))
            {
                MessageBox.Show("Template file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start Excel and get Application object
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Make the app visible (optional)
                excelApp.Visible = false;

                // Open the template workbook
                Excel.Workbook workbook = excelApp.Workbooks.Open(templateFilePath);

                // Export data to the first worksheet
                ExportDataToSheetClubs(dataTable, workbook.Sheets[1]);

                // Insert the graph for clubs on the second worksheet
                InsertClubsGraph(workbook.Sheets[2], dataTable);

                // Save the workbook
                workbook.SaveAs(newFilePath);

                // Close the workbook and release Excel objects
                workbook.Close();
                excelApp.Quit();
                ReleaseObject(workbook);
                ReleaseObject(excelApp);

                MessageBox.Show($"Student clubs joined exported to {newFilePath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDataToSheetClubs(DataTable dataTable, Excel.Worksheet sheet)
        {
            // Get the starting cell for inserting data (starting from the third row)
            Excel.Range startCell = sheet.Cells[3, 1];

            // Get the range of the worksheet starting from the third row
            Excel.Range range = sheet.Range[startCell, sheet.Cells[startCell.Row + dataTable.Rows.Count - 1, startCell.Column + dataTable.Columns.Count - 1]];

            // Copy data from DataTable to Excel worksheet
            object[,] data = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    data[i, j] = dataTable.Rows[i][j];
                }
            }

            // Paste the data into the range
            range.Value = data;

            // Add signature placeholder
            int lastRow = startCell.Row + dataTable.Rows.Count;
            sheet.Cells[lastRow + 1, 1] = "Signature:";
            sheet.Cells[lastRow + 1, 2] = "[Enter Signature Here]";
        }

        private void InsertClubsGraph(Excel.Worksheet sheet, DataTable dataTable)
        {
            Excel.Range startCell = null;

            // Your MySQL connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=Markbitancor.109;database=school";

            // SQL query to count the number of students per club
            string query = "SELECT c.club_name AS Club, COUNT(*) AS StudentCount " +
                           "FROM students s " +
                           "JOIN clubs c ON s.club_id = c.club_id " +
                           "GROUP BY c.club_name";

            try
            {
                // Create MySqlConnection
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create MySqlCommand
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the command and read the result
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Get the starting cell for the data
                            startCell = sheet.Cells[3, 1];

                            // Write column headers
                            sheet.Cells[startCell.Row - 1, startCell.Column] = "Club";
                            sheet.Cells[startCell.Row - 1, startCell.Column + 1] = "Student Count";

                            // Write data to the sheet
                            int row = startCell.Row;
                            while (reader.Read())
                            {
                                sheet.Cells[row, startCell.Column] = reader["Club"];
                                sheet.Cells[row, startCell.Column + 1] = reader["StudentCount"];
                                row++;
                            }

                            // Get the range of club names and student counts
                            Excel.Range clubNamesRange = sheet.Range[sheet.Cells[startCell.Row, startCell.Column], sheet.Cells[row - 1, startCell.Column]];
                            Excel.Range studentCountsRange = sheet.Range[sheet.Cells[startCell.Row, startCell.Column + 1], sheet.Cells[row - 1, startCell.Column + 1]];

                            // Set the chart location
                            Excel.Range chartRange = sheet.Range["C1", "M12"]; // Adjust the range as needed

                            // Create the chart
                            Excel.ChartObjects chartObjects = (Excel.ChartObjects)sheet.ChartObjects();
                            Excel.ChartObject chartObject = chartObjects.Add(chartRange.Left, chartRange.Top, chartRange.Width, chartRange.Height);
                            Excel.Chart chart = chartObject.Chart;

                            // Set the chart type
                            chart.ChartType = Excel.XlChartType.xlColumnClustered;

                            // Set the data range for the chart
                            chart.SetSourceData(studentCountsRange);

                            // Set category labels
                            chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).CategoryNames = clubNamesRange;

                            // Set the chart title
                            chart.HasTitle = true;
                            chart.ChartTitle.Text = "Number of Students per Club";

                            // Add signature placeholder
                            int lastRow = row;
                            sheet.Cells[lastRow + 1, startCell.Column] = "Signature:";
                            sheet.Cells[lastRow + 1, startCell.Column + 1] = "[Enter Signature Here]";
                        }
                    }

                    // Close the connection
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
