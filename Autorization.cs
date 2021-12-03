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
    public partial class Autorization : Form
    {
        public Autorization()
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
            Registration register = new Registration();
            register.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.ru/maps/place/%D0%9A%D0%BE%D0%BB%D0%BB%D0%B5%D0%B4%D0%B6+%D0%9F%D1%81%D0%BA%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%B3%D0%BE+%D0%B3%D0%BE%D1%81%D1%83%D0%B4%D0%B0%D1%80%D1%81%D1%82%D0%B2%D0%B5%D0%BD%D0%BD%D0%BE%D0%B3%D0%BE+%D1%83%D0%BD%D0%B8%D0%B2%D0%B5%D1%80%D1%81%D0%B8%D1%82%D0%B5%D1%82%D0%B0/@57.8074291,28.3515594,17z/data=!4m12!1m6!3m5!1s0x0:0x804f3a7f4d7c2593!2z0J_QodCa0J7QktCT0KMsINCf0YHQutC-0LLRgdC60LjQuSDQs9C-0YHRg9C00LDRgNGB0YLQstC10L3QvdGL0Lkg0YPQvdC40LLQtdGA0YHQuNGC0LXRgg!8m2!3d57.814179!4d28.338835!3m4!1s0x46c01924c4eaea27:0x57bc3250c03d80a5!8m2!3d57.8068211!4d28.350902");

        }
    }
}

