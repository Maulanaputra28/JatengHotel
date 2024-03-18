using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JatengHotel.Helper
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void questsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm Lfrm = new LoginForm();
            Lfrm.Show();
            this.Hide();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy HH:mm";
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm Lfrm = new LoginForm();
            Lfrm.Show();
            this.Hide();
        }
    }
}
