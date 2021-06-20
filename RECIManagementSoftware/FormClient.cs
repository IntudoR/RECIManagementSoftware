using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    public partial class FormClient : Form
    {
        private static string _computerName = System.Environment.MachineName;

        public FormClient()
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

                string queryTableView = "SELECT * FROM [reci].[Account]";

                SqlDataAdapter adapter = new(queryTableView, connection);
                SqlCommandBuilder builder = new(adapter);

                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                AccountGridView.DataSource = dataSet.Tables[0];

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
                string queryInsert = String.Format("INSERT INTO [reci].[Client] " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')",
                    textBoxClientAccountID.Text,
                    textBoxClientFirstName.Text,
                    textBoxClientLastName.Text,
                    textBoxClientGender.Text,
                    textBoxClientBirthday.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryInsert, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelClientOutput.Visible = true;
                    labelClientOutput.Text = "client successfully added".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\n\tAccountID: {2}\n\tFirstName: {3}\n\tLastName: {4}\n\t" +
                    "Gender: {5}\n\tBirthday: {6}",
                    ex.Message, ex.Source,
                    textBoxClientAccountID.Text,
                    textBoxClientFirstName.Text,
                    textBoxClientLastName.Text,
                    textBoxClientGender.Text,
                    textBoxClientBirthday.Text

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
            if(textBoxClientAccountID.Text == String.Empty)
            {
                labelClientOutput.ForeColor = Color.Crimson;
                labelClientOutput.Text = "AccountID field required".ToUpper();
                labelClientOutput.Visible = true;
            }
            else
            {
                string queryDelete = String.Format("DELETE FROM [reci].[Client] " +
                    "WHERE idAccount = '{0}';", textBoxClientAccountID.Text);

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelClientOutput.Text = "client succeesfully deleted".ToUpper();
                    labelClientOutput.Visible = true;

                    connection.Close();

                    populate();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClientOutput.Visible = false;
            labelClientOutput.ForeColor = Color.Black;
            labelClientOutput.Text = String.Empty;
        }

        private void AccountGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ClientGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ClientGridView.CurrentRow.Selected = true;

                    textBoxClientAccountID.Text = ClientGridView.SelectedRows[0].Cells["idAccount"].Value.ToString();
                    textBoxClientFirstName.Text = ClientGridView.SelectedRows[0].Cells["FirstName"].Value.ToString();
                    textBoxClientLastName.Text = ClientGridView.SelectedRows[0].Cells["LastName"].Value.ToString();
                    textBoxClientGender.Text = ClientGridView.SelectedRows[0].Cells["Gender"].Value.ToString();
                    textBoxClientBirthday.Text = ClientGridView.SelectedRows[0].Cells["Birthday"].Value.ToString();
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
                string queryUpdate = String.Format("UPDATE [reci].[Client] SET " +
                    "idAccount='{0}',FirstName='{1}',LastName='{2}'," +
                    "Gender='{3}',Birthday='{4}' " +
                    "WHERE idAccount='{0}'",
                    textBoxClientAccountID.Text,
                    textBoxClientFirstName.Text,
                    textBoxClientLastName.Text,
                    textBoxClientGender.Text,
                    textBoxClientBirthday.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryUpdate, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelClientOutput.Visible = true;
                    labelClientOutput.Text = "client successfully updated".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\n\tAccountID: {2}\n\tFirstName: {3}\n\tLastName: {4}\n\t" +
                    "Gender: {5}\n\tBirthday: {6}",
                    ex.Message, ex.Source,
                    textBoxClientAccountID.Text,
                    textBoxClientFirstName.Text,
                    textBoxClientLastName.Text,
                    textBoxClientGender.Text,
                    textBoxClientBirthday.Text

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
