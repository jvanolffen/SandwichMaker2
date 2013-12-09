using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SandwichMaker2
{
    class Database
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private const String connectionstring = "Server=sql3.freemysqlhosting.net;Database=sql324076;Uid=sql324076;Pwd=yI8!dN5*;";
        private String query = "SELECT name FROM Ingredients;";

        public void CheckIngredients() {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["name"].ToString());
            }
            connection.Close();
        }

        public Database()
        {

        }
    }
}
