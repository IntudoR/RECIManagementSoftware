using System;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace RECIManagementSoftware
{
    public partial class Login : Form
    {
        private static string _dbName = "reci.mdf";
        private static string _mainDomain = AppDomain.CurrentDomain.BaseDirectory;
        private static string _computerName = System.Environment.MachineName;

        // TEMPORARY.
        // ToDo: Delete
        //private static string _serverName = "MSS2012";
        //private static string _usrName = "IntudoR";
        //private static string _password = "root";
        private static bool _remoteServer = true;

        #region Construct current form
        public Login()
        {
            InitializeComponent();

            CenterToScreen();

            label_InocorrectStatus.Hide();

            timer1.Enabled = true;

            // TEMPORARY.
            // ToDo: Delete
            checkBox_isRemoteServer.Checked = _remoteServer;
            //textBox_ServerName.Text = _serverName;
            //textBox_Username.Text = _usrName;
            //textBox_Password.Text = _password;

            // While there is no solution how to send connection string to main form
            checkBox_isRemoteServer.Enabled = false;
            textBox_ServerName.Enabled = _remoteServer;
        }

        SqlConnection Connection;
        MainWindow mainWindow;

        private string _dbPath;
        private string _connectionString;

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;

        }
        #endregion

        #region Login form control
        private void checkBox_isRemoteServer_Click(object sender, EventArgs e)
        {
            if (checkBox_isRemoteServer.Checked)
                textBox_ServerName.Enabled = true;
            else
                textBox_ServerName.Enabled = false;
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
                textBox_Password.UseSystemPasswordChar = false;
            else
                textBox_Password.UseSystemPasswordChar = true;
        }

        #endregion

        #region Initialize mainwindow form
        private void ConsturctMainForm()
        {
            try
            {
                if (mainWindow == null)
                    mainWindow = new();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format
                    (
                        "Construction exception error:\n{0}\nSource:\n{1}", ex.Message, ex.Source),
                        "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                mainWindow.Dispose();
                Close();
            }

        }

        private void OpenMainForm()
        {
            try
            {
                ConsturctMainForm();
                if (mainWindow != null)
                {
                    mainWindow.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format
                    (
                        "Construction exception error:\n{0}\nSource:\n{1}", ex.Message, ex.Source),
                        "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Connection = new();

            if (label_InocorrectStatus.Visible)
                label_InocorrectStatus.Hide();

            // IF TRUE, USE REMOTE CONNECTION
            if (checkBox_isRemoteServer.Checked)
            {
                _connectionString = String.Format
                    (
                        "Server={0}\\{1};" +
                        "Database=reci;" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30", _computerName, textBox_ServerName.Text
                    );
            }
            else
            {
                _dbPath = Path.Combine(_mainDomain, _dbName);
                _connectionString = String.Format
                    (
                        "Data Source=(LocalDB)\v11.0;" +
                        "AttachDBFilename = {0};" +
                        "Integrated Security=True; " +
                        "Connect Timeout=30", _dbPath
                    );
            }

            Connection.ConnectionString = _connectionString;
            Connection.Open();

            SqlCommand command = new();
            command.Connection = Connection;
            command.CommandText = String.Format
                (
                    "SELECT [Username], [Password] FROM [reci].[account] " +
                    "WHERE [Username] = '{0}' AND [Password] = '{1}'",
                    textBox_Username.Text, textBox_Password.Text
                    );

            DataTable data = new();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            try
            {
                adapter.Fill(data);

                if (data.Rows[0][0].ToString() == textBox_Username.Text)
                {
                    OpenMainForm();
                    Hide();

                }
                else
                {
                    label_InocorrectStatus.Show();
                }
            }
            catch (Exception ex)
            {
                label_InocorrectStatus.Show();
            }
            finally
            {
                Connection.Close();
            }

            Connection.Close();

        }
        #endregion

        #region Handle hidden form, appear current

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mainWindow != null)
            {
                if (!mainWindow.Visible)
                {
                    Show();
                }
            }
        }

        #endregion

    }
}
