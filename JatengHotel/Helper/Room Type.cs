using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatengHotel.Helper
{
    class Room_Type
    {
        SqlConnection conn = ConnectionSQL.GetConnection();

        public DataTable MasterRoom
        {
            get
            {
                ConnectionSQL.OpenConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select RoomNumber, RoomTypeID, RoomFlo or, Description from Room", conn);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                return dt;
            }
        }
    }
}
