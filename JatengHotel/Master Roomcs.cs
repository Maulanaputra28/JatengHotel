using JatengHotel.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JatengHotel
{
    public partial class Master_Roomcs : Form
    {
        string title = "Master Room";
        SqlConnection conn = ConnectionSQL.GetConnection();
        public Master_Roomcs()
        {
            InitializeComponent();
        }

        private void Master_Roomcs_Load(object sender, EventArgs e)
        {
            Room_Type Rtyp = new Room_Type();
            DataTable dt = Rtyp.MasterRoom;

            dataGridView1.DataSource = dt;
        }
    }
}
