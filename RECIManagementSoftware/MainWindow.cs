using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RECIManagementSoftware
{
    public partial class MainWindow : Form
    {
        private static string _connectionString;
        public MainWindow()
        {
            InitializeComponent();

            CenterToScreen();

            // COMPONENTS OUTSIDE INTITIALIZECOPMONENT METHOD
            tsButton_Logout.Click += new EventHandler(Logout);
            tsButton_Show.Click += new EventHandler(ShowForm);
        }

        SqlConnection Connection;

        private void Logout(object sender, EventArgs e)
        {
            Hide();
        }

        private void ShowForm(object sender, EventArgs e)
        {

        }

    }
}
