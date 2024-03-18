using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatengHotel
{
    class Login
    {
        SqlConnection conn = ConnectionSQL.GetConnection();
        public string Password { get; set; }
        public string Username { get; set; }

        public DataTable login
        {
            get
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee where Username = @username and Password = @password", conn);
                sda.SelectCommand.Parameters.AddWithValue("@username", Username);
                sda.SelectCommand.Parameters.AddWithValue("@password", Password);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                return dt;
            }
        }
    }
}
