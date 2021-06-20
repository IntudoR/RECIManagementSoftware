using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    public partial class FormAssignment : Form
    {
        private static string _computerName = System.Environment.MachineName;
        public FormAssignment()
        {
            Login login = new();
            _connectionString = String.Format
                    (
                        "Server={0}\\{1};" +
                        "Database=reci;" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30", _computerName, login.textBox_ServerName.Text
                    );

            connection.ConnectionString = _connectionString;

            InitializeComponent();
        }

        private string _connectionString;
        SqlConnection connection = new();

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            try
            {
                connection.Open();

                string queryTableView = "SELECT * FROM [reci].[Assignment]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                AssignmentGridView.DataSource = dataSet.Tables[0];

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
        private void buttonAssignmentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string queryInsert = String.Format("INSERT INTO [reci].[Assignment] " +
                    "VALUES('{0}','{1}')",
                    textBoxAssignmentCounterpartyID.Text,
                    textBoxAssignmentDate.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryInsert, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelAssignmentOutput.Visible = true;
                    labelAssignmentOutput.Text = "assignment successfully added".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\n\tCounterpartyID {2}\n\tDate: {3}",
                    ex.Message, ex.Source,
                    textBoxAssignmentCounterpartyID.Text,
                    textBoxAssignmentDate.Text
                    ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        private void buttonAssignmenttDelete_Click(object sender, EventArgs e)
        {
            if (textBoxAssignmentDate.Text == String.Empty && textBoxAssignmentCounterpartyID.Text == String.Empty)
            {
                labelAssignmentOutput.ForeColor = Color.Crimson;
                labelAssignmentOutput.Text = "date and counterparty id fields required".ToUpper();
                labelAssignmentOutput.Visible = true;
            }
            else
            {
                string queryDelete = String.Format("DELETE FROM [reci].[Assignment] " +
                    "WHERE Mobile = '{0}' AND '{1}';", 
                    textBoxAssignmentDate.Text, textBoxAssignmentCounterpartyID);

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelAssignmentOutput.Text = "account succeesfully deleted".ToUpper();
                    labelAssignmentOutput.Visible = true;

                    connection.Close();

                    populate();
                }
            }
        }

        private void buttonAssignmentEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string queryUpdate = String.Format("UPDATE [reci].[Assignment] SET " +
                    "idCounterparty='{0}',Date='{1}'" +
                    "WHERE Date='{1}' AND 'idCounterparty={0}",
                    textBoxAssignmentCounterpartyID.Text,
                    textBoxAssignmentDate.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryUpdate, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelAssignmentOutput.Visible = true;
                    labelAssignmentOutput.Text = "account successfully updated".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\n\tCounterpartyID {2}\n\tDate: {3}",
                    ex.Message, ex.Source,
                    textBoxAssignmentCounterpartyID.Text,
                    textBoxAssignmentDate.Text
                    ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        private void AssignmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (AssignmentGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    AssignmentGridView.CurrentRow.Selected = true;

                    textBoxAssignmentCounterpartyID.Text = AssignmentGridView.SelectedRows[0].Cells["idCounterparty"].Value.ToString();
                    textBoxAssignmentDate.Text = AssignmentGridView.SelectedRows[0].Cells["Date"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Selected upper row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelAssignmentOutput.Visible = false;
            labelAssignmentOutput.ForeColor = Color.Black;
            labelAssignmentOutput.Text = String.Empty;
        }

    }
}
