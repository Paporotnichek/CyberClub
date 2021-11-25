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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "" || login.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                string LoginUser = login.Text;
                string PasswordUser = password.Text;
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@uL AND `Password`=@uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Не удалось войти", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                if (login.Text == "Admin")
                    {
                        this.Hide();
                        AdminPanel apanel = new AdminPanel();
                        apanel.Show();
                    }
                   else
                {
                    this.Hide();
                    User Users = new User();
                    Users.Show();
                }
                
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 register = new Form2();
            register.Show();
        }

    }
}

