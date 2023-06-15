using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ATBM_HTTT
{
    class Dataprovider
    {
        private static Dataprovider instance;

        public static Dataprovider Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dataprovider();
                return Dataprovider.instance;
            }
            private set
            {
                Dataprovider.instance = value;
            }
        }
        private Dataprovider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null) // khi viet query can cach ra 
        {
            DataTable data = new DataTable();
            using (OracleConnection connection = Connection.GetDBConnection())
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null) // trả ra sos dòng bị ảnh hưởng (inssert / update/ delete)
        {
            int data = 0;// số dòng thành công 
            using (OracleConnection connection = Connection.GetDBConnection())
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null) // trả ra số lượng (khi truy cấn count(*) ... , trả ra số lượng ở ô đầu tiên trong dataset)
        {
            object data = 0;// số dòng thành công 
            using (OracleConnection connection = Connection.GetDBConnection())
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}