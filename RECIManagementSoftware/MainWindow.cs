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
            tsButton_Close.Click += new EventHandler(CloseForm);
        }

        private string _connectionString;

        SqlConnection Connection;

        FormAccount formAccount;
        FormAssignment formAssignment;
        FormClient FormClient;
        FormContract formContract;
        FormCounterparty formCounterparty;
        FormCounterpartyContract formCounterpartyContract;
        FormEmployee formEmployee;

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
                    if (formAccount == null)
                        formAccount = new();
                    formAccount.TopLevel = false;
                    formAccount.Dock = DockStyle.Fill;
                    formAccount.TopMost = true;
                    panel_ObjectView.Controls.Add(formAccount);
                    formAccount.Show();
                    break;

                case "Assignment":
                    if(formAssignment == null)
                        formAssignment = new();
                    formAssignment.TopLevel = false;
                    formAssignment.Dock = DockStyle.Fill;
                    formAssignment.TopMost = true;
                    panel_ObjectView.Controls.Add(formAssignment);
                    formAssignment.Show();
                    break;

                case "Client":
                    if (FormClient == null)
                        FormClient = new();
                    FormClient.TopLevel = false;
                    FormClient.Dock = DockStyle.Fill;
                    FormClient.TopMost = true;
                    panel_ObjectView.Controls.Add(FormClient);
                    FormClient.Show();
                    break;

                case "Contract":
                    if (formContract == null)
                        formContract = new();
                    formContract.TopLevel = false;
                    formContract.Dock = DockStyle.Fill;
                    formContract.TopMost = true;
                    panel_ObjectView.Controls.Add(formContract);
                    formContract.Show();
                    break;

                case "Counterparty":
                    if (formCounterparty == null)
                        formCounterparty = new();
                    formCounterparty.TopLevel = false;
                    formCounterparty.Dock = DockStyle.Fill;
                    formCounterparty.TopMost = true;
                    panel_ObjectView.Controls.Add(formCounterparty);
                    formCounterparty.Show();
                    break;

                case "Counterparty contract":
                    if (formCounterpartyContract == null)
                        formCounterpartyContract = new();
                    formCounterpartyContract.TopLevel = false;
                    formCounterpartyContract.Dock = DockStyle.Fill;
                    formCounterpartyContract.TopMost = true;
                    panel_ObjectView.Controls.Add(formCounterpartyContract);
                    formCounterpartyContract.Show();
                    break;
                case "Employee":
                    if (formEmployee == null)
                        formEmployee = new();
                    formEmployee.TopLevel = false;
                    formEmployee.Dock = DockStyle.Fill;
                    formEmployee.TopMost = true;
                    panel_ObjectView.Controls.Add(formEmployee);
                    formEmployee.Show();
                    break;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "Account":
                    if (formAccount != null)
                        formAccount.Hide();
                    break;

                case "Assignment":
                    if (formAssignment != null)
                        formAssignment.Hide();
                    break;

                case "Client":
                    if (FormClient != null)
                        FormClient.Hide();
                    break;

                case "Contract":
                    if (formContract != null)
                        formContract.Hide();
                    break;

                case "Counterparty":
                    if (formCounterparty != null)
                        formCounterparty.Hide();
                    break;

                case "Counterparty contract":
                    if (formCounterpartyContract != null)
                        formCounterpartyContract.Hide();
                    break;

                case "Employee":
                    if (formEmployee != null)
                        formEmployee.Hide();
                    break;
            }
        }

    }
}
