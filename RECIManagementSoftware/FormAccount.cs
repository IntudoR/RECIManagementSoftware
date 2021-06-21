using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    public partial class FormAccount : Form
    {
        private static string _computerName = System.Environment.MachineName;

        public FormAccount()
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

        private string _id = String.Empty;
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
                string queryInsert = String.Format("INSERT INTO [reci].[Account] " +
                    "VALUES('{0}','{1}','{2}','{3}',{4},'{5}','{6}')",
                    textBoxAccountUsername.Text,
                    textBoxAccountPassword.Text,
                    textBoxAccountStatus.Text,
                    textBoxAccountRegisterTime.Text,
                    textBoxAccountBalance.Text,
                    textBoxAccountMobile.Text,
                    textBoxAccountEmail.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryInsert, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelAccountOutput.Visible = true;
                    labelAccountOutput.Text = "account successfully added".ToUpper();

                    connection.Close();
                }
                _id = String.Empty;

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\n\tUsername: {2}\n\tPassword: {3}\n\tStatus: {4}\n\t" +
                    "Register time: {5}\n\tBalance: {6}\n\tMobile: {7}\n\tEmail: {8}.",
                    ex.Message, ex.Source,
                    textBoxAccountUsername.Text,
                    textBoxAccountPassword.Text,
                    textBoxAccountStatus.Text,
                    textBoxAccountRegisterTime.Text,
                    textBoxAccountBalance.Text,
                    textBoxAccountMobile.Text,
                    textBoxAccountEmail.Text
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
            if(_id == String.Empty)
            {
                labelAccountOutput.ForeColor = Color.Crimson;
                labelAccountOutput.Text = "Please select row".ToUpper();
                labelAccountOutput.Visible = true;
            }
            else
            {
                string queryDelete = String.Format("DELETE FROM [reci].[Account] " +
                    "WHERE idAccount = '{0}';", _id);

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelAccountOutput.Text = "account succeesfully deleted".ToUpper();
                    labelAccountOutput.Visible = true;

                    connection.Close();

                    _id = String.Empty;

                    populate();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelAccountOutput.Visible = false;
            labelAccountOutput.ForeColor = Color.Black;
            labelAccountOutput.Text = String.Empty;
        }

        private void AccountGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                if (AccountGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    _id = String.Empty;

                    AccountGridView.CurrentRow.Selected = true;

                    _id = AccountGridView.SelectedRows[0].Cells[0].Value.ToString();
                    textBoxAccountUsername.Text = AccountGridView.SelectedRows[0].Cells["Username"].Value.ToString();
                    textBoxAccountPassword.Text = AccountGridView.SelectedRows[0].Cells["Password"].Value.ToString();
                    textBoxAccountStatus.Text = AccountGridView.SelectedRows[0].Cells["Status"].Value.ToString();
                    textBoxAccountRegisterTime.Text = AccountGridView.SelectedRows[0].Cells["RegisterTime"].Value.ToString();
                    textBoxAccountBalance.Text = AccountGridView.SelectedRows[0].Cells["Balance"].Value.ToString();
                    textBoxAccountMobile.Text = AccountGridView.SelectedRows[0].Cells["Mobile"].Value.ToString();
                    textBoxAccountEmail.Text = AccountGridView.SelectedRows[0].Cells["Email"].Value.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Selected upper row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAccountEdit_Click(object sender, EventArgs e)
        {
            if (_id != String.Empty)
            {
                try
                {
                    string queryUpdate = String.Format("UPDATE [reci].[Account] SET " +
                        "Username='{0}',Password='{1}',Status='{2}'," +
                        "RegisterTime='{3}',Balance={4},Mobile='{5}',Email='{6}' " +
                        "WHERE idAccount='{7}'",
                        textBoxAccountUsername.Text,
                        textBoxAccountPassword.Text,
                        textBoxAccountStatus.Text,
                        textBoxAccountRegisterTime.Text,
                        textBoxAccountBalance.Text,
                        textBoxAccountMobile.Text,
                        textBoxAccountEmail.Text,
                        _id
                        );

                    using (var connection = new SqlConnection(_connectionString))
                    using (var command = new SqlCommand(queryUpdate, connection))
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        labelAccountOutput.Visible = true;
                        labelAccountOutput.Text = "account successfully updated".ToUpper();

                        connection.Close();
                    }

                    _id = String.Empty;

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                        "Input data:\n\n\tUsername: {2}\n\tPassword: {3}\n\tStatus: {4}\n\t" +
                        "Register time: {5}\n\tBalance: {6}\n\tMobile: {7}\n\tEmail: {8}.",
                        ex.Message, ex.Source,
                        textBoxAccountUsername.Text,
                        textBoxAccountPassword.Text,
                        textBoxAccountStatus.Text,
                        textBoxAccountRegisterTime.Text,
                        textBoxAccountBalance.Text,
                        textBoxAccountMobile.Text,
                        textBoxAccountEmail.Text
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
                labelAccountOutput.ForeColor = Color.Crimson;
                labelAccountOutput.Text = "please select row".ToUpper();
                labelAccountOutput.Visible = true;
            }
        }
    }
}
