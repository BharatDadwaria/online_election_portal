using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    
    public partial class Form5 : Form
    {
        public string id;
        
        public Form5()
        {
            InitializeComponent();
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = null;
            MessageBox.Show("Logout Succesfully!!!");
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }





      /* 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

            

            {
                MessageBox.Show("Not agreed terms and conditions.\n");
            }
        }

            */

     /*   private void button2_Click(object sender, EventArgs e)
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
                cmd.CommandText = "update Ulogin set pres=@pres,vpres=@vpres,sec=@sec,vsec=@vsec,voted=1 where UserId= '"+id+"'";

                cmd.Parameters.AddWithValue("@pres", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@vpres", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@sec", comboBox3.SelectedItem);
                cmd.Parameters.AddWithValue("@vsec", comboBox4.SelectedItem);
                cmd.ExecuteNonQuery();
                mysqlconn.Close();

                MessageBox.Show("Your Vote is being recorded successfully. Thankyou for your valuable Vote ..... ");
                Form5 obj1 = new Form5();
                obj1.Show();
                this.Hide();


            }

            else

            {
                MessageBox.Show("Not agreed terms and conditions.\n");
                Form5 obj1 = new Form5();
                obj1.Show();
                this.Hide();

            }
        }

    */

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
            obj1.id = id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='President' and status='Approved'";

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
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='Vice_President' and status='Approved'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
             dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
             dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='Secretary' and status='Approved'";

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

            string cmdstr = "select VotingID,Name, Enrollment,status, EmailID, sex, Department, writeup from registration where post='Vice_Secretary' and status='Approved'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }
    }
}
