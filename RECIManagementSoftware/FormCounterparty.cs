using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    public partial class FormCounterparty : Form
    {
        private static string _computerName = System.Environment.MachineName;

        public FormCounterparty()
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

            try
            {
                connection.Open();

                string queryTableView = "SELECT * FROM [reci].[Cp_contract]";

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

                string queryTableView = "SELECT * FROM [reci].[Order]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                OrderGridView.DataSource = dataSet.Tables[0];

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
        }

        private void buttonAccountAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = String.Format("INSERT INTO [reci].[Counterparty] " +
                    "VALUES('{0}','{1}','{2}','{3}')",
                    textBoxCounterpartyContractID.Text,
                    textBoxCounterpartyFirstName.Text,
                    textBoxCounterpartyLastName.Text,
                    textBoxCounterpartyMobile.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryInsert, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelCounterpartyOutput.Visible = true;
                    labelCounterpartyOutput.Text = "contract successfully added".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\tContractID: {2}\n\tFirstName: {3}\n\tLastName: {4}\n\t" +
                    "Mobile: {5}",
                    ex.Message, ex.Source,
                    textBoxCounterpartyContractID.Text,
                    textBoxCounterpartyFirstName.Text,
                    textBoxCounterpartyLastName.Text,
                    textBoxCounterpartyMobile.Text
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
            if(textBoxCounterpartyMobile.Text == String.Empty)
            {
                labelCounterpartyOutput.ForeColor = Color.Crimson;
                labelCounterpartyOutput.Text = "mobile field required".ToUpper();
                labelCounterpartyOutput.Visible = true;
            }
            else
            {
                string queryDelete = String.Format("DELETE FROM [reci].[Counterparty] " +
                    "WHERE Mobile = '{0}';", textBoxCounterpartyMobile.Text);

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelCounterpartyOutput.Text = "contract succeesfully deleted".ToUpper();
                    labelCounterpartyOutput.Visible = true;

                    connection.Close();

                    populate();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCounterpartyOutput.Visible = false;
            labelCounterpartyOutput.ForeColor = Color.Black;
            labelCounterpartyOutput.Text = String.Empty;
        }

        private void AccountGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                if (CounterpartyGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    CounterpartyGridView.CurrentRow.Selected = true;

                    textBoxCounterpartyContractID.Text = CounterpartyGridView.SelectedRows[0].Cells["idCPContract"].Value.ToString();
                    textBoxCounterpartyFirstName.Text = CounterpartyGridView.SelectedRows[0].Cells["FirstName"].Value.ToString();
                    textBoxCounterpartyLastName.Text = CounterpartyGridView.SelectedRows[0].Cells["LastName"].Value.ToString();
                    textBoxCounterpartyMobile.Text = CounterpartyGridView.SelectedRows[0].Cells["Mobile"].Value.ToString();
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
                string queryUpdate = String.Format("UPDATE [reci].[Counterparty] SET " +
                    "idCPContract='{0}',FirstName='{1}',LastName='{2}'," +
                    "Mobile='{3}' " +
                    "WHERE Mobile='{3}'",
                    textBoxCounterpartyContractID.Text,
                    textBoxCounterpartyFirstName.Text,
                    textBoxCounterpartyLastName.Text,
                    textBoxCounterpartyMobile.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryUpdate, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelCounterpartyOutput.Visible = true;
                    labelCounterpartyOutput.Text = "contract successfully updated".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\tContractID: {2}\n\tFirstName: {3}\n\tLastName: {4}\n\t" +
                    "Mobile: {5}",
                    ex.Message, ex.Source,
                    textBoxCounterpartyContractID.Text,
                    textBoxCounterpartyFirstName.Text,
                    textBoxCounterpartyLastName.Text,
                    textBoxCounterpartyMobile.Text
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
