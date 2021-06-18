using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        SqlConnection connection = new();

        public void OpenConneciton()
        {
            connection.Open();
        }

        public void CloseConneciton()
        {
            connection.Close();
        }

    }
}
