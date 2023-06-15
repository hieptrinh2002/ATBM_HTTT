using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace ATBM_HTTT
{
    class Connection
    {
      
        public static string username { set; get; }
        public static string password { set; get; }

        const string host = "localhost";
        const int port = 1521;
        const string sid = "xe";
      
        Connection()
        {
            username = "";
            password = "";
        }
 
        public static OracleConnection GetDBConnection()
        {
         
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username+";";
            OracleConnection conn = new OracleConnection(connString);
            return conn;
        }

        public static string getConnString()
        {
            return ("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username + ";");
        }

    }
}
