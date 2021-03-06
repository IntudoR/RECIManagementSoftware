using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    public partial class FormRental : Form
    {
        private static string _computerName = System.Environment.MachineName;

        public FormRental()
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
        private string _id;
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

                string queryTableView = "SELECT * FROM [reci].[Counterparty]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                CounterpartyGridView.DataSource = dataSet.Tables[0];

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
                string queryInsert = String.Format("INSERT INTO [reci].[Rental] " +
                    "VALUES('{0}','{1}')",
                    textBoxContractOrderID.Text,
                    textBoxContractMonthlyPayment.Text
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
                    textBoxContractOrderID.Text,
                    textBoxContractMonthlyPayment.Text
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
            if (_id == String.Empty)
            {
                labelContractOutput.ForeColor = Color.Crimson;
                labelContractOutput.Text = "please select row".ToUpper();
                labelContractOutput.Visible = true;
            }
            else
            {
                string queryDelete = String.Format("DELETE FROM [reci].[Rental] " +
                    "WHERE idRental = '{0}';", _id);

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelContractOutput.Text = "rental succeesfully deleted".ToUpper();
                    labelContractOutput.Visible = true;

                    connection.Close();

                    populate();
                }
            }
        }

        private void buttonAccountEdit_Click(object sender, EventArgs e)
        {
            if (_id != String.Empty)
            {
                try
                {
                    string queryUpdate = String.Format("UPDATE [reci].[Rental] SET " +
                        "idProperty='{0}', idClient='{1}'" +
                        "WHERE idRental='{2}'",
                        textBoxContractOrderID.Text,
                        textBoxContractMonthlyPayment.Text,
                        _id
                        );

                    using (var connection = new SqlConnection(_connectionString))
                    using (var command = new SqlCommand(queryUpdate, connection))
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        labelContractOutput.Visible = true;
                        labelContractOutput.Text = "rental successfully updated".ToUpper();

                        connection.Close();
                    }

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                        "Input data:\n\tOrderID: {2}\n\tMonthlyPayment: {3}",
                        ex.Message, ex.Source,
                        textBoxContractOrderID.Text,
                        textBoxContractMonthlyPayment.Text
                        ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
                connection.Close();
            }
            else 
            {
                labelContractOutput.ForeColor = Color.Crimson;
                labelContractOutput.Text = "please select row".ToUpper();
                labelContractOutput.Visible = true;
            }
        }

        private void AccountGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = String.Empty;

                if (RentalGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    RentalGridView.CurrentRow.Selected = true;

                    _id = RentalGridView.SelectedRows[0].Cells[0].Value.ToString();
                    textBoxContractOrderID.Text = RentalGridView.SelectedRows[0].Cells["idProperty"].Value.ToString();
                    textBoxContractMonthlyPayment.Text = RentalGridView.SelectedRows[0].Cells["idClient"].Value.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Selected upper row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelContractOutput.Visible = false;
            labelContractOutput.ForeColor = Color.Black;
            labelContractOutput.Text = String.Empty;
        }
    }
}
