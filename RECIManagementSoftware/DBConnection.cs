using System;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RECI_APP
{
    public class DBConnection
   {
        /* SAMPLES OF CONNECTION
        SqlConnection Connection = new(@"Data Source = DESKTOP-PP6SC19\MSS2012; Initial Catalog = reci; Integrated Security = false; User ID = sa; Password = root");
        SqlConnection Connection = new(@"Server = DESKTOP-PP6SC19\MSS2012; Database = reci; User ID = sa; Password = root");
        SqlConnection Connection = new(@"Data Source =" + srv + "; Initial Catalog =" + ctlg + "; Integrated Security = false; User ID =" + usr + "; Password =" + pswd );
        SqlConnection Connection = new(@"Data Source = DESKTOP-PP6SC19\MSS2012; Initial Catalog =" + ctlg + "; Integrated Security = false; User ID =" + usr + "; Password =" + pswd);
        */
        private string _dbName = "reci.mdf";
        private string _mainDomain = AppDomain.CurrentDomain.BaseDirectory;
        private string _dbPath;
        private string _remoteConnectionString;

        SqlConnection Connection = new();


        public void OpenConneciton(bool isLocalDB)
        {
            switch (isLocalDB)
            {
                case false:
                    MessageBox.Show("There is only way through local db just yet.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    _dbPath = Path.Combine(_mainDomain, _dbName);
                    Connection.Open();
                    break;
            }
            
        }

        public string GetConnection()
        {
            return Convert.ToString(Connection);
        }

        public void CloseConneciton()
        {
            Connection.Close();
        }

    }
}
