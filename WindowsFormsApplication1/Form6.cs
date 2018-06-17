using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            this.Hide();
            obj.Show();
            obj.id = id;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment, EmailID, sex, Department, writeup from registration where post='President' and status='Approved'";
            
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

            string cmdstr = "select VotingID, Name, Enrollment, EmailID, sex, Department, writeup from registration where post='Vice_President' and status='Approved'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            // dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           // dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ("server=localhost;userid=root;password=jaishriRAM0385;database=VoteMe");
            DataSet ds = new DataSet();

            conn.Open();

            string cmdstr = "select VotingID, Name, Enrollment, EmailID, sex, Department, writeup from registration where post='Secretary' and status='Approved'";

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

            string cmdstr = "select VotingID, Name, Enrollment, EmailID, sex, Department, writeup from registration where post='Vice_Secretary' and status='Approved'";

            MySqlCommand cmd = new MySqlCommand(cmdstr, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            adp.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
