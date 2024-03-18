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
using JatengHotel.Helper;


namespace JatengHotel
{
    public partial class LoginForm : Form
    {
        string title = "Login Form";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Username = tb_Username.Text;
            login.Password = tb_password.Text;
            //string name;

            DataTable dt = login.login;

            if (tb_Username.Text == "" && tb_password.Text == "")
            {
                SninppetMbox.Error(title, "all fields cant empty");
            } 
            else if (tb_Username.Text == "admin" && tb_password.Text == "admin123"){
                Main_Form_Admin MformAdmin = new Main_Form_Admin();
                MformAdmin.Show();
                this.Hide();
            }
            else if (dt.Rows[0][0].ToString() == "1")
            {
                SninppetMbox.Information(title, "Login Succsessfull");
                Main_Form Mfrm = new Main_Form();
                Mfrm.Show();
                this.Hide();
            }
        }
    }
}
