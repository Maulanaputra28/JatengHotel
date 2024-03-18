using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JatengHotel.Helper;

namespace JatengHotel.Helper
{
    public partial class MasterRoomType : Form
    {
        string title = "Room Type";
        SqlConnection conn = ConnectionSQL.GetConnection();
        public MasterRoomType()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            Data Roomtype = new Data();
            DataTable dt = Roomtype.RoomType;
            dataGridView1.DataSource = dt;
        }

        private void ClearData()
        {
            tb_name.Text = string.Empty;
            tb_RoomPrice.Text = string.Empty;
            numUD1.Value = 0;
            pictureBox1.Image = null;  
        }

        private void Default()
        {
            tb_name.Enabled = false;
            tb_RoomPrice.Enabled = false;
            numUD1.Enabled = false;
            btn_Insert.Enabled = true;
            btn_Update.Enabled = true;
            btn_delete.Enabled = true;
            btn_Browse.Enabled = false;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;

            pictureBox1.Enabled = false;
        }

        public static class Room
        {
            public static string name { get; set; }
            public static decimal capacity { get; set; }
            public static string RPrc { get; set; }
        }

        private bool Val()
        {
            var strgs = new List<string>()
            {
                tb_name.Text,
                tb_RoomPrice.Text, 
            };

            var strVal = Validations.ValidationString(strgs);
            if (!strVal)
            {
                SninppetMbox.Error(title, "All fields must be filled");
                return false;
            }

            if (numUD1.Value == 0)
            {
                SninppetMbox.Error(title, "Capacity cant 0");
                return false;
            }
            return true;
        }

        private void ViewImage(string name)
        {
            ConnectionSQL.OpenConnection();
            SqlCommand cmd = new SqlCommand($"select Photo from RoomType where Name = @nme", conn);
            cmd.Parameters.AddWithValue("@nme", name);

            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    byte[] img = (byte[])(reader["Photo"]);

                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                reader.Close();
            }

            ConnectionSQL.CloseConnection();
        }

        private void MasterRoomType_Load(object sender, EventArgs e)
        {
            loadData();
            Default();
        }

        private bool btnInsrt, btnUpdt = false;

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            btnInsrt = true;
            dataGridView1.CurrentRow.Selected = false; 
            ClearData();
            tb_name.Enabled = true;
            tb_RoomPrice.Enabled = true;
            numUD1.Enabled = true;
            btn_Browse.Enabled = true;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
        }



        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            Room.name = tb_name.Text;
        }

        private void numUD1_ValueChanged(object sender, EventArgs e)
        {
            Room.capacity = numUD1.Value;
        }

        private void tb_RoomPrice_TextChanged(object sender, EventArgs e)
        {
            Room.RPrc = tb_RoomPrice.Text;
        }

        string imgLocation = "";
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "jpg filles(*.jpg)|*.jpg|png filles(*.png)|*.png|All filles(*.*)|*.*";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                imgLocation = openfile.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

                //get path image
                //SninppetMbox.Information(title, openfile.FileName);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionSQL.GetConnection();
            var valid = Val();
            if (!valid) return;

            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);

            ConnectionSQL.OpenConnection();
            if (btnInsrt)
            {
                SqlCommand cmd = new SqlCommand("insert into RoomType(Name, Capacity, RoomPrice, Photo) values(@Name,@Capacity,@RoomPrice, @pto)", conn);
                cmd.Parameters.AddWithValue("@Name", Room.name);
                cmd.Parameters.AddWithValue("@Capacity", Room.capacity);
                cmd.Parameters.AddWithValue("@RoomPrice", Room.RPrc);
                cmd.Parameters.AddWithValue("@pto", images);
                cmd.ExecuteNonQuery();
                loadData();
                SninppetMbox.Information(title, "Succsess");
                ClearData();
                Default();
            }
            else if(btnUpdt){
                RoomType rtp = new RoomType();

                SqlCommand cmd = new SqlCommand($"Update RoomType set Name = @nme, Capacity = @cpty, RoomPrice = @Rpc where ID = {rtp.IdRoomType}", conn);
                cmd.Parameters.AddWithValue("@nme", Room.name);
                cmd.Parameters.AddWithValue("@cpty", Room.capacity);
                cmd.Parameters.AddWithValue("@Rpc", Room.RPrc);
                cmd.ExecuteNonQuery();
                loadData();
                SninppetMbox.Information(title, "Updated");
                ClearData();
                Default();
            }
            ConnectionSQL.CloseConnection();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            loadData();
            Default();
            ClearData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //btnDlt = true;
            SqlConnection conn = ConnectionSQL.GetConnection();
            var valid = Val();
            if (!valid) return;

            //SninppetMbox.Warning(title, "Are you sure want to delete ?");
            var result = MessageBox.Show("Are you sure want to delete ?","confirm",MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                ConnectionSQL.OpenConnection();
                RoomType rTyp = new RoomType();

                SqlCommand cmd = new SqlCommand("delete from RoomType where ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", rTyp.IdRoomType);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
                loadData();
                Default();
                ClearData();
            }
            else if (result == DialogResult.Cancel)
            {
                Default();
                ClearData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            /*dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;*/

            dataGridView1.CurrentRow.Selected = true;
            string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            int cpcty = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Capacity"].Value);
            int rPrc = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RoomPrice"].Value);



            tb_name.Text = name;
            tb_RoomPrice.Text = rPrc.ToString();
            numUD1.Value = cpcty;
            ViewImage(name);
            RoomType.name = name;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btnUpdt = true;
            btn_Insert.Enabled = false;
            btn_delete.Enabled = false;
            btn_Update.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            tb_name.Enabled = true;
            tb_RoomPrice.Enabled = true;
            numUD1.Enabled = true;

        }
    }
}
