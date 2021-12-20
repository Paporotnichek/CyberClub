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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || password.Text == "" || email.Text == "" || login.Text == "" || surname.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                if (checkUser())
                    return;

              //  DB db = new DB();
                MySqlCommand command = new MySqlCommand(" INSERT INTO `users1` ( `Login`, `Password`, `Name`, `Surname`,`Email`) VALUES(@login,@pass,@name,@surname,@email)", DB.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
                DB.OpenConnect();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");
                DB.CloseConnect();
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization vhod = new Autorization();
            vhod.Show();
        }
        public Boolean checkUser() 
        {
          //  DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users1` WHERE `Login`=@uL ", DB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть!");
                return true;
            }
            else
            {

                this.Hide();
                Autorization vhod = new Autorization();
                vhod.Show();
                return false;

            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            login.Clear();
            password.Clear();
            name.Clear();
            login.Clear();
            surname.Clear();

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
