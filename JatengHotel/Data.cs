using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatengHotel
{
    class Data
    {
        SqlConnection conn = ConnectionSQL.GetConnection();
        public DataTable RoomType
        {
            get
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Name, Capacity, RoomPrice from RoomType", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
