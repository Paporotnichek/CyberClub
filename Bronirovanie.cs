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
    public partial class Bronirovanie : Form
    {
        public Bronirovanie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bronirovanie_Load(object sender, EventArgs e)
        {
            List<string> comp = new List<string> { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };
            List<string> Bbusy = new List<string> { "Занят", "Не занят" };
            computer.DataSource = comp;
            busy.DataSource = Bbusy;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `zal` ( `computer`, `busy`, `start game`, `continue game`) VALUES(@computer, @busy, @start game, @continue game)", db.getConnection());
            command.Parameters.AddWithValue("@computer", computer.SelectedValue.ToString());
            command.Parameters.Add("@busy", MySqlDbType.VarChar).Value = busy.SelectedItem;
            command.Parameters.Add("@start game", MySqlDbType.VarChar).Value = start.???;
            command.Parameters.Add("@continue game", MySqlDbType.VarChar).Value = finish.;

            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Сеанс записан");
            else
                MessageBox.Show("Сеанс не получилось записать");

            db.CloseConnect();

        }
    }
}
