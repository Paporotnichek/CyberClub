using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberClub
{
    class SqlFunction
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=DB");
        public bool Registration(string login, string password, string name, string surname, string email)
        {
            bool flag = false;
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO users1 (login, password, name, surname,email) VALUES (@login, @password, @name, @surname,@email)", connection);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            connection.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            connection.Close();
            return flag;
        }

        // Авторизация пользователя
        public bool Autorization(string login, string password)
        {
            bool flag = false;
            MySqlCommand cmd = new MySqlCommand($"SELECT login FROM users1 WHERE login = @login AND password = @password", connection);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            connection.Open();
            MySqlDataReader srd = cmd.ExecuteReader();
            if (srd.HasRows)
            {
                flag = true;
            }
            connection.Close();
            return flag;
        }
    }
}
        
    

