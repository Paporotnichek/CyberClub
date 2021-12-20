using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberClub
{
    public partial class Simulation : Form
    {
        SqlFunction ss = new SqlFunction();
        private bool Working;
        public Simulation()

        {
            InitializeComponent();
        }
        string[] login = { "ilya12", "kifdh244", "nrh45" };
        string[] password = { "345", "4gh57", "4j582" };
        string[] name = { "Кирилл", "Павел", "Жора", "Семен", "Константин" };
        string[] surname = { "Миранчук", "Ильин", "Гришин", "Драгунов", "Мосин" };
        string[] email = { "miran@gmail.com", "pilya@yandex.ru", "grish@gmail.com", "SemenDrag@mail.ru" , "konstya@gmail.com" };
        Random random = new Random();
        int count = 0; 
        public void Registration()
        {
            while (Working)
            {
                string Login = login[random.Next(0, login.Length)] + random.Next(10000, 99999);
                string Password = password[random.Next(0, password.Length)];
                string Name = name[random.Next(0, name.Length)];
                string Surname = surname[random.Next(0, name.Length)];
                string Email = email[random.Next(0, email.Length)];
                ss.Registration(Login, Password, Name, Surname, Email);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Working = true;
            Task.Run(() => Registration());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Working = false;
        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }

        private void Simulation_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel vozvrat = new AdminPanel();
            vozvrat.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
