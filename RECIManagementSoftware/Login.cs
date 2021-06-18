﻿using System;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace RECIManagementSoftware
{
    public partial class Login : Form
    {
        private string _connectionString;
        private string _dbName = "reci.mdf";
        private string _mainDomain = AppDomain.CurrentDomain.BaseDirectory;
        private string _dbPath;
        private string _computerName = System.Environment.MachineName;

        private bool _lockedBy;

        SqlConnection Connection = new();


        public Login()
        {
            InitializeComponent();

            CenterToScreen();

            label_InocorrectStatus.Hide();

            _lockedBy = checkBox_isRemoteServer.Checked;
      
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_ServerName.Enabled = false;
            textBox_Password.UseSystemPasswordChar = true;

        }

        private void checkBox_isRemoteServer_Click(object sender, EventArgs e)
        {
            _lockedBy = checkBox_isRemoteServer.Checked;

            if (_lockedBy)
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

        private void button_Login_Click(object sender, EventArgs e)
        {

            if (_lockedBy == true)
            {
                _connectionString = String.Format
                    (
                        "Server={0}\\{1}; Database=reci; Integrated Security=True; Connect Timeout=30", _computerName, textBox_ServerName.Text
                    );
            }
            else
            {
                _dbPath = Path.Combine(_mainDomain, _dbName);
                _connectionString = String.Format
                    (
                        "Data Source=(LocalDB)\v11.0; AttachDBFilename = {0}; Integrated Security=True; Connect Timeout=30", _dbPath
                    );
            }

            Connection.ConnectionString = _connectionString;
            Connection.Open();

            SqlCommand command = new();
            command.Connection = Connection;
            command.CommandText = String.Format("SELECT [Username], [Password] FROM [reci].[account] WHERE [Username] = '{0}' AND [Password] = '{1}'"
                    , textBox_Username.Text, textBox_Password.Text);

            DataTable data = new();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            try
            {
                if (data.Rows[0][0].ToString() == textBox_Username.Text)
                {
                    MainWindow mainWindow = new();
                    mainWindow.Show();

                    this.Hide();
                }
                else
                {
                    label_InocorrectStatus.Show();
                }
            }
            catch(Exception ex)
            {
                label_InocorrectStatus.Show();
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }

            Connection.Close();

        }  
    }
}
