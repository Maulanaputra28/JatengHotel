using JatengHotel.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JatengHotel
{
    public partial class Main_Form_Admin : Form
    {
        public Main_Form_Admin()
        {
            InitializeComponent();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterRoomType MstrRmtyp = new MasterRoomType();
            MstrRmtyp.Show();
            this.Hide();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_Roomcs MstrRoom = new Master_Roomcs();
            MstrRoom.Show();
            this.Hide();
        }
    }
}
