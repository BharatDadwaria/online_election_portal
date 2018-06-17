using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        public string id;

        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)


            {
                MySqlConnection mysqlconn = new MySqlConnection();

                mysqlconn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
                mysqlconn.Open();
                MySqlCommand cmd = new MySqlCommand();
                //   MySqlCommand ulog = new MySqlCommand();

                cmd.Connection = mysqlconn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Ulogin set pres=@pres,vpres=@vpres,sec=@sec,vsec=@vsec,voted=1 where UserId= '" + id + "'";

                cmd.Parameters.AddWithValue("@pres", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@vpres", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@sec", comboBox3.SelectedItem);
                cmd.Parameters.AddWithValue("@vsec", comboBox4.SelectedItem);
                cmd.ExecuteNonQuery();
                mysqlconn.Close();

                MessageBox.Show("Your Vote is being recorded successfully. Thankyou for your valuable Vote ..... ");
                Form1 obj1 = new Form1();
                obj1.Show();
                this.Hide();


            }

            else

            {
                MessageBox.Show("Not agreed terms and conditions.\n");
                Form9 obj1 = new Form9();
                obj1.Show();
                this.Hide();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
