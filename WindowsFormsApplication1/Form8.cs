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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='President'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='Vice_President'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            // dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='Secretary'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID,Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='Vice_Secretary'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=voteme;Password =jaishriRAM0385");


            MySqlCommand cmd = new MySqlCommand("select status from registration where Enrollment='" + textBox1.Text + "'", con);
            cmd.CommandType = CommandType.Text;
            //            cmd.Parameters.AddWithValue("@UserId", textBox1.Text);
            //          cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            //Form2 obj2 = new Form2();
            //        obj2.id = textBox1.Text;


            con.Open();

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MySqlConnection mysqlconn = new MySqlConnection();
                mysqlconn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
                mysqlconn.Open();
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.Connection = mysqlconn;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update registration set status='Approved' where Enrollment='"+ textBox1.Text +"'";
                //cmd.Parameters.AddWithValue("@Enroll", textBox1.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Sucesfully Validated");
                Form8 obj1 = new Form8();
                
                obj1.Show();
                this.Hide();
                //obj1.id = textBox1.Text;

            }
            else
            {
                MessageBox.Show("Enrollment is Invalid");
                Form8 obj1 = new Form8();
                obj1.Show();
                this.Hide();
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Succesfully!!!");
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 obj1 = new Form9();
            obj1.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
