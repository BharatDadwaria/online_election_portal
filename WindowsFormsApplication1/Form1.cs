using System;
using System.Data;
using System.Configuration;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=voteme;password=jaishriRAM0385";
                con.Open();

            }
            catch (Exception)
            {



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.curaj.ac.in");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start("https://www.curaj.ac.in");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 obj1 = new Form3();
            obj1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=voteme;Password =jaishriRAM0385");


            MySqlCommand cmd = new MySqlCommand("select * from Ulogin where UserId='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserId", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            Form2 obj2 = new Form2();
            obj2.id = textBox1.Text;


            con.Open();

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Form5 obj1 = new Form5();
                obj1.Show();
                this.Hide();
                obj1.id = textBox1.Text;

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                Form1 obj1 = new Form1();
                obj1.Show();
                this.Hide();
            }





            /* string uid, pass;
             uid = textBox1.Text;
             pass = textBox2.Text;

             MySqlConnection con;
             con = new MySqlConnection();
             con.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=voteme";

             MySqlCommand cmd;
             //MySqlDataReader reader;
             //string query;
          //   cmd = new SqlCommand("SELECT UserId FROM Ulogin WHERE UserId=" + textBox1.Text + " and Password = " + textBox2.Text + "'", con);
             try
             {
                 con.Open();
                 string query;
                 query = "select password from voteme.ulogin where username = '" + uid + "'";
                 cmd = new MySqlCommand("SELECT UserId FROM Ulogin WHERE UserId=" + textBox1.Text + " and Password = " + textBox2.Text + "'", con);
                 //cmd = new MySqlCommand(query, con);
                 //reader = cmd.ExecuteReader();
                 //string upass = query;

                 //MySqlDataReader dr = cmd.ExecuteReader();

                 {
                     Form5 obj1 = new Form5();
                     obj1.Show();
                     this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Invalid username or password");
                 }



                 con.Close(); }
             catch
             {
                 MessageBox.Show("Error!!!!");
             }
             finally { con.Dispose();
             }
             */
            /* MySqlDataAdapter a = new MySqlDataAdapter("select count(*) from ulogin where UserId=" + textBox1.Text + " and Password =" + textBox2.Text + "'", con);
             DataTable dt = new DataTable();
             a.Fill(dt);
             if (dt.Rows[0][0].ToString()=="1")
             {
                 MessageBox.Show("Login Succesfully");
                 this.Hide();
                 Form5 obj1 = new Form5();
                 obj1.Show();

             }
             else
             {
                 MessageBox.Show("Invalid Username and Password");
             }
             */




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 obj1 = new Form4();
            obj1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Contact to your Department !!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 obj1 = new Form6();
            obj1.Show();
            this.Hide();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminLogin obj1 = new AdminLogin();
            obj1.Show();
            this.Hide();
            /*
            
        */
        }
    }
}
