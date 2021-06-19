using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RECIManagementSoftware
{
    public partial class MainWindow : Form
    {
        //private static string _dbName = "reci.mdf";
        //private static string _mainDomain = AppDomain.CurrentDomain.BaseDirectory;
        private static string _computerName = System.Environment.MachineName;
        public MainWindow()
        {
            // FORM MANIPULATION
            InitializeComponent();
            CenterToScreen();

            // COMPONENTS OUTSIDE INTITIALIZECOPMONENT METHOD
            tsButton_Logout.Click += new EventHandler(Logout);
            tsButton_Show.Click += new EventHandler(ShowForm);
        }

        private string _connectionString;

        SqlConnection Connection;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Login login = new();
            _connectionString = String.Format
                    (
                        "Server={0}\\{1};" +
                        "Database=reci;" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30", _computerName, login.textBox_ServerName.Text
                    );

            Connection = new();
            Connection.ConnectionString = _connectionString;

            try
            {
                Connection.Open(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception error:{0}", ex.Message), "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }

        }

        private void Logout(object sender, EventArgs e)
        {
            Hide();
        }

        private void ShowForm(object sender, EventArgs e)
        {

            switch (treeView1.SelectedNode.Text)
            {
                case "Account":
                    FormAccount formAccount = new();
                    formAccount.TopLevel = false;
                    formAccount.Dock = DockStyle.Fill;
                    formAccount.TopMost = true;
                    panel_ObjectView.Controls.Add(formAccount);
                    formAccount.Show();
                    break;
            }
        }

    }
}
