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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=voteme;Password =jaishriRAM0385");


            MySqlCommand cmd = new MySqlCommand("select * from adminlogin where UserId='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserId", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            Form2 obj2 = new Form2();
            obj2.id = textBox1.Text;


            con.Open();

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Form8 obj1 = new Form8();
                obj1.Show();
                this.Hide();
// obj1.id = textBox1.Text;

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                Form1 obj1 = new Form1();
                obj1.Show();
                this.Hide();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
