using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RECIManagementSoftware
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            // FORM MANIPULATION
            InitializeComponent();
            CenterToScreen();

            // COMPONENTS OUTSIDE INTITIALIZECOPMONENT METHOD
            tsButton_Logout.Click += new EventHandler(Logout);
            tsButton_Show.Click += new EventHandler(ShowForm);
        }

        SqlConnection Connection;

        public string Receive(string msg)
        {
            return msg;
        }

        public Action<string> OnMessageAlert { get; set; }


        private void Logout(object sender, EventArgs e)
        {
            Hide();
        }

        private void ShowForm(object sender, EventArgs e)
        {

        }

    }
}
