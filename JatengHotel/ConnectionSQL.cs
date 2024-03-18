using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatengHotel
{
    public sealed class ConnectionSQL
    {
        private static readonly string ConnectionString = @"Data Source =DESKTOP-1HS4PIK\SQLEXPRESS02;Initial Catalog=JatengHotel;integrated Security = True";
        private static SqlConnection _connection;
        public static readonly object LockObject = new object();
        
        private ConnectionSQL()
        {
            _connection = new SqlConnection(ConnectionString);
        }

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                lock (LockObject)
                {
                    if (_connection == null)
                    {
                        _connection = new SqlConnection(ConnectionString);
                    }

                }
            }
            return _connection;
        }

        public static void OpenConnection()
        {
            if(GetConnection().State != System.Data.ConnectionState.Open)
            {
                GetConnection().Open();
            }
        }

        public static void CloseConnection()
        {
            if (GetConnection().State != System.Data.ConnectionState.Closed)
            {
                GetConnection().Close();
            }
        }
    }
}
