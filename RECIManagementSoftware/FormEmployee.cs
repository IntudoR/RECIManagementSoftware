using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    public partial class FormEmployee : Form
    {
        private static string _computerName = System.Environment.MachineName;

        public FormEmployee()
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
        private string idEmployee;
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
                string queryInsert = String.Format("INSERT INTO [reci].[Employee] " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}', '{7}')",
                    textBoxEmployeeAccountID.Text,
                    textBoxEmployeeFirstName.Text,
                    textBoxEmployeeLastName.Text,
                    textBoxEmployeeGender.Text,
                    textBoxEmployeeOccupation.Text,
                    textBoxEmployeeBirthday.Text,
                    textBoxEmployeeSalary.Text,
                    textBoxEmployeeStatus.Text
                    );

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryInsert, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelEmployeeOutput.Visible = true;
                    labelEmployeeOutput.Text = "client successfully added".ToUpper();

                    connection.Close();
                }

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                    "Input data:\n\n\tAccountID: {2}\n\tFirstName: {3}\n\tLastName: {4}\n\t" +
                    "Gender: {5}\n\tOccupation: {6}\n\tBirthday: {7}\n\tSalary = {8}\n\t" +
                    "Status: {9}",
                    ex.Message, ex.Source,
                    textBoxEmployeeAccountID.Text,
                    textBoxEmployeeFirstName.Text,
                    textBoxEmployeeLastName.Text,
                    textBoxEmployeeGender.Text,
                    textBoxEmployeeOccupation.Text,
                    textBoxEmployeeBirthday.Text,
                    textBoxEmployeeSalary.Text,
                    textBoxEmployeeStatus.Text
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
            if(textBoxEmployeeAccountID.Text == String.Empty)
            {
                labelEmployeeOutput.ForeColor = Color.Crimson;
                labelEmployeeOutput.Text = "AccountID field required".ToUpper();
                labelEmployeeOutput.Visible = true;
            }
            else if (idEmployee != null)
            {
                string queryDelete = String.Format("DELETE FROM [reci].[Employee] " +
                    "WHERE idEmployee = '{0}';", idEmployee);

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(queryDelete, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    labelEmployeeOutput.Text = "client succeesfully deleted".ToUpper();
                    labelEmployeeOutput.Visible = true;

                    connection.Close();
                }
            }
            else
            {
                labelEmployeeOutput.Visible = true;
                labelEmployeeOutput.ForeColor = Color.Crimson;
                labelEmployeeOutput.Text = "please select a row".ToUpper();
            }

            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelEmployeeOutput.Visible = false;
            labelEmployeeOutput.ForeColor = Color.Black;
            labelEmployeeOutput.Text = String.Empty;
        }

        private void AccountGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (EmployeeGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    EmployeeGridView.CurrentRow.Selected = true;

                    idEmployee = EmployeeGridView.SelectedRows[0].Cells["idEmployee"].Value.ToString();
                    textBoxEmployeeAccountID.Text = EmployeeGridView.SelectedRows[0].Cells["idAccount"].Value.ToString();
                    textBoxEmployeeFirstName.Text = EmployeeGridView.SelectedRows[0].Cells["FirstName"].Value.ToString();
                    textBoxEmployeeLastName.Text = EmployeeGridView.SelectedRows[0].Cells["LastName"].Value.ToString();
                    textBoxEmployeeGender.Text = EmployeeGridView.SelectedRows[0].Cells["Gender"].Value.ToString();
                    textBoxEmployeeOccupation.Text = EmployeeGridView.SelectedRows[0].Cells["Occupation"].Value.ToString();
                    textBoxEmployeeBirthday.Text = EmployeeGridView.SelectedRows[0].Cells["Birthday"].Value.ToString();
                    textBoxEmployeeSalary.Text = EmployeeGridView.SelectedRows[0].Cells["MonthlySalary"].Value.ToString();
                    textBoxEmployeeStatus.Text = EmployeeGridView.SelectedRows[0].Cells["EmploymentStatus"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selected upper row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAccountEdit_Click(object sender, EventArgs e)
        {

            if (idEmployee != null)
            {
                try
                {

                    string queryUpdate = String.Format("UPDATE [reci].[Employee] SET " +
                        "idAccount='{0}',FirstName='{1}',LastName='{2}'," +
                        "Gender='{3}', Occupation='{4}',Birthday='{5}', MonthlySalary='{6}', EmploymentStatus='{7}' " +
                        "WHERE idEmployee='{8}'",
                        textBoxEmployeeAccountID.Text,
                        textBoxEmployeeFirstName.Text,
                        textBoxEmployeeLastName.Text,
                        textBoxEmployeeGender.Text,
                        textBoxEmployeeOccupation.Text,
                        textBoxEmployeeBirthday.Text,
                        textBoxEmployeeSalary.Text,
                        textBoxEmployeeStatus.Text,
                        idEmployee
                        );

                    using (var connection = new SqlConnection(_connectionString))
                    using (var command = new SqlCommand(queryUpdate, connection))
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        labelEmployeeOutput.Visible = true;
                        labelEmployeeOutput.Text = "client successfully updated".ToUpper();

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Exception error.\n\nMessage:\n{0}\n\nSource:{1}\n\n" +
                        "Input data:\n\n\tAccountID: {2}\n\tFirstName: {3}\n\tLastName: {4}\n\t" +
                        "Gender: {5}\n\tOccupation: {6}\n\tBirthday: {7}\n\tSalary = {8}\n\t" +
                        "Status: {9}",
                        ex.Message, ex.Source,
                        textBoxEmployeeAccountID.Text,
                        textBoxEmployeeFirstName.Text,
                        textBoxEmployeeLastName.Text,
                        textBoxEmployeeGender.Text,
                        textBoxEmployeeOccupation.Text,
                        textBoxEmployeeBirthday.Text,
                        textBoxEmployeeSalary.Text,
                        textBoxEmployeeStatus.Text
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
                labelEmployeeOutput.Visible = true;
                labelEmployeeOutput.ForeColor = Color.Crimson;
                labelEmployeeOutput.Text = "please select a row".ToUpper();
            }

            populate();
        }
    }
}
