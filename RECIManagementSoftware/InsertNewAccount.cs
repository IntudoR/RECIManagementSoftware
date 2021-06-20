using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RECIManagementSoftware
{
    class InsertNewAccount
    {
        private static string _computerName = Environment.MachineName;
        private static DateTime _today = DateTime.Today;
        public InsertNewAccount()
        {
            Login login = new();

            _connectionString = String.Format (
                        "Server={0}\\{1};" +
                        "Database=reci;" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30", _computerName, login.textBox_ServerName.Text
                    );

            var insertQuery = String.Format("INSERT INTO [reci].[Account] " +
                "VALUES('NewUser', 'pass1234', 'place-holder', '{0}')", _today);

            using(SqlConnection connection = new(_connectionString))
            using(SqlDataAdapter adapter = new(insertQuery, connection))
            {

            }

        }

        private string _connectionString;
    }
}
