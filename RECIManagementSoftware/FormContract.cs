using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    public partial class FormContract : Form
    {
        private static string _computerName = System.Environment.MachineName;

        public FormContract()
        {
            InitializeComponent();

            Login login = new();
            _connectionString = String.Format
                    (
                        "Server={0}\\{1};" +
                        "Database=reci;" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30", _computerName, login.textBox_ServerName.Text
                    );

            connection.ConnectionString = _connectionString;
        }

        private string _connectionString;
        SqlConnection connection = new();

        private void FormAccount_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            try
            {
                connection.Open();

                string queryTableView = "SELECT * FROM [reci].[Contract]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                ContractGridView.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                connection.Open();

                string queryTableView = "SELECT * FROM [reci].[Employee]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                EmployeeGridView.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                connection.Open();

                string queryTableView = "SELECT * FROM [reci].[Rental]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                RentalGridView.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                connection.Open();

                string queryTableView = "SELECT * FROM [reci].[Property]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                PropertyGridView.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                connection.Open();

                string queryTableView = "SELECT * FROM [reci].[Client]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                ClientGridView.DataSource = dataSet.Tables[0];

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonAccountAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = String.Format("INSERT INTO [reci].[Contract] " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                    textBoxContractEmployeeID.Text,
                    textBoxContractRentalID.Text,
                    textBoxContractPayment.Text,
                    textBoxContractPaid.Text,
                    textBoxContractDate.Text,
                    textBoxContractExpires.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryInsert, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelContractOutput.Visible = true;
                    labelContractOutput.Text = "contract successfully added".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\tidEmployee: {2}\n\tidRental: {3}\n\tPayment: {4}\n\t" +
                    "Paid: {5}\n\tDate: {6}\n\tExpires: {7}",
                    ex.Message, ex.Source,
                    textBoxContractEmployeeID.Text,
                    textBoxContractRentalID.Text,
                    textBoxContractPayment.Text,
                    textBoxContractPaid.Text,
                    textBoxContractDate.Text,
                    textBoxContractExpires.Text
                    ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        private void buttonAccountDelete_Click(object sender, EventArgs e)
        {
            if(textBoxContractExpires.Text == String.Empty)
            {
                labelContractOutput.ForeColor = Color.Crimson;
                labelContractOutput.Text = "employee id and rental id fields required".ToUpper();
                labelContractOutput.Visible = true;
            }
            else
            {
                string queryDelete = String.Format("DELETE FROM [reci].[Contract] " +
                    "WHERE Mobile = '{0}';", textBoxContractExpires.Text);

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelContractOutput.Text = "contract succeesfully deleted".ToUpper();
                    labelContractOutput.Visible = true;

                    connection.Close();

                    populate();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelContractOutput.Visible = false;
            labelContractOutput.ForeColor = Color.Black;
            labelContractOutput.Text = String.Empty;
        }

        private void AccountGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                if (ContractGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ContractGridView.CurrentRow.Selected = true;

                    textBoxContractEmployeeID.Text = ContractGridView.SelectedRows[0].Cells["idEmployee"].Value.ToString();
                    textBoxContractRentalID.Text = ContractGridView.SelectedRows[0].Cells["idRental"].Value.ToString();
                    textBoxContractPayment.Text = ContractGridView.SelectedRows[0].Cells["Payment"].Value.ToString();
                    textBoxContractPaid.Text = ContractGridView.SelectedRows[0].Cells["Paid"].Value.ToString();
                    textBoxContractDate.Text = ContractGridView.SelectedRows[0].Cells["Date"].Value.ToString();
                    textBoxContractExpires.Text = ContractGridView.SelectedRows[0].Cells["Expires"].Value.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Selected upper row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAccountEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string queryUpdate = String.Format("UPDATE [reci].[Contract] SET " +
                    "idEmployee='{0}',idRental='{1}',Payment='{2}'," +
                    "Paid='{3}',Date='{4}',Expires='{5}' " +
                    "WHERE idEmployee='{0}' AND idRental={1}",
                    textBoxContractEmployeeID.Text,
                    textBoxContractRentalID.Text,
                    textBoxContractPayment.Text,
                    textBoxContractPaid.Text,
                    textBoxContractDate.Text,
                    textBoxContractExpires.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryUpdate, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelContractOutput.Visible = true;
                    labelContractOutput.Text = "contract successfully updated".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\tidEmployee: {2}\n\tidRental: {3}\n\tPayment: {4}\n\t" +
                    "Paid: {5}\n\tDate: {6}\n\tExpires: {7}",
                    ex.Message, ex.Source,
                    textBoxContractEmployeeID.Text,
                    textBoxContractRentalID.Text,
                    textBoxContractPayment.Text,
                    textBoxContractPaid.Text,
                    textBoxContractDate.Text,
                    textBoxContractExpires.Text
                    ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 
            finally
            {
                connection.Close();
            }
            connection.Close();
        }
    }
}
