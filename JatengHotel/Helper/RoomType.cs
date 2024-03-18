using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatengHotel.Helper
{
    class RoomType
    {
        SqlConnection conn = ConnectionSQL.GetConnection();
        public static string name { get; set; }
        public int IdRoomType
        {
            get
            {
                int id = 0;
                SqlCommand cmd = new SqlCommand("select ID from RoomType where Name = @nme", conn);
                cmd.Parameters.AddWithValue("@nme", name);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = Convert.ToInt32(reader["ID"]);
                    }
                    reader.Close();
                }
                return id;
            }
        }
    }
}
