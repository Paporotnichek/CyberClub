using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberClub
{
    public partial class Arhiv : Form
    {
        static string conString = "server=localhost;port=3306;user=root;password=root;database=DB";
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
    

        public Arhiv()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "categories";
            dataGridView1.Columns[2].Name = "disciplins";
            dataGridView1.Columns[3].Name = "TypeCompetition";
            dataGridView1.Columns[4].Name = "PrizeMoney";
            dataGridView1.Columns[5].Name = "startTournirs";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void add(string categories, string disciplins, string TypeCompetition, string PrizeMoney, string startTournirs)
        {

          //  DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `events` ( `categories`, `disciplins`, `TypeCompetition`, `StartTournirs`,`PrizeMoney`) VALUES(@categories, @disciplins, @TypeCompetition, @startTournirs, @PrizeMoney)", DB.getConnection());
            command.Parameters.Add("@categories", MySqlDbType.VarChar).Value = categories;
            command.Parameters.Add("@disciplins", MySqlDbType.VarChar).Value = disciplins;
            command.Parameters.Add("@TypeCompetition", MySqlDbType.VarChar).Value = TypeCompetition;
            command.Parameters.Add("@PrizeMoney", MySqlDbType.VarChar).Value = PrizeMoney;
            command.Parameters.Add("@startTournirs", MySqlDbType.Date).Value = startTournirs;
            try
            {
                con.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Succefully Inserted");
                }
                con.Close();
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }



        private void Arhiv_Load(object sender, EventArgs e)
        {

        }
        private void vnes(string id, string categories, string disciplins, string TypeCompetition, string PrizeMoney, string startTounrirs)
        {
            dataGridView1.Rows.Add(id, categories, disciplins, TypeCompetition, PrizeMoney, startTounrirs);
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            string sql = "Select * from events";
            cmd = new MySqlCommand(sql, DB.getConnection());
            try
            {
              //  con.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    vnes(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }
               // con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Vnesty_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

