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
    public partial class CreateTournirs : Form
    {
        public CreateTournirs()
        {
            InitializeComponent();

        }


        private void CreateTournirs_Load(object sender, EventArgs e)
        {
            List<string> categor = new List<string> { "RTS", "KKI", "FPS", "MOBA", "SportSim"};
            List<string> type = new List<string> { "Официальный", "Неофициальный" };
            List<string> prize = new List<string> { "С призовыми", "Без призовых" };
 

            categories.DataSource = categor;
            TypeCompetition.DataSource = type;
            PrizeMoney.DataSource = prize;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categories.SelectedItem == "RTS")
            {
                List<string> gamesRTS = new List<string> { "StarCraft2", "Age of Empires2" };
                disciplins.DataSource = gamesRTS;
            }
            if (categories.SelectedItem == "KKI")
            {
                List<string> gamesKKI = new List<string> { "Hearthstone", "Gvint" };
                disciplins.DataSource = gamesKKI;
            }
            if (categories.SelectedItem == "FPS")
            {
                List<string> gamesFPS = new List<string> { "CS:GO", "CoD Warzone", "R6: Siege", "Overwatch" };
                disciplins.DataSource = gamesFPS;
            }
            if (categories.SelectedItem == "MOBA")
            {
                List<string> gamesMOBA = new List<string> { "Dota2", "LoL" };
                disciplins.DataSource = gamesMOBA;
            }
            if (categories.SelectedItem == "SportSim")
            {
                List<string> gamesSportSim = new List<string> { "FIFA", "PES" };
                disciplins.DataSource = gamesSportSim;
            }
        }
       
        private void disciplins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void disciplnis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TypeCompetiton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              //  DB db = new DB();
                MySqlCommand command = new MySqlCommand(" INSERT INTO `events` ( `categories`, `disciplins`, `TypeCompetition`, `StartTournirs`,`PrizeMoney`) VALUES(@categories, @disciplins, @TypeCompetition, @startTournirs, @PrizeMoney)", DB.getConnection());
                command.Parameters.AddWithValue("@categories", categories.SelectedValue.ToString());
                command.Parameters.Add("@disciplins", MySqlDbType.VarChar).Value = disciplins.SelectedItem;
                command.Parameters.Add("@TypeCompetition", MySqlDbType.VarChar).Value = TypeCompetition.SelectedItem;
                command.Parameters.Add("@startTournirs", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                command.Parameters.Add("@PrizeMoney", MySqlDbType.VarChar).Value = PrizeMoney.SelectedItem;

                DB.OpenConnect();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Турнир создан");
                else
                    MessageBox.Show("Турнир не получилось создать");

                DB.CloseConnect();

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel vozvrat = new AdminPanel();
            vozvrat.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }



