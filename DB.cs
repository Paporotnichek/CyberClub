using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberClub
{
   static class DB

    {
      static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=DB");
      static  public void OpenConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        static public void CloseConnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        static public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
