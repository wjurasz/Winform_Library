using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_szkolenie_techiczne_1
{
    internal class LibraryDAO
    {
        string connectionString = "datasource=localhost; port=8889; username=root; password=root; database=library";

        public bool CheckUser(string inputUserName, string inputPassword)
        {
            List<User> users = new List<User>();

            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            MySqlCommand getUsers = new MySqlCommand("SELECT ID, USERNAME, PASSWORD FROM users", connection);
            
            using (MySqlDataReader reader = getUsers.ExecuteReader()) 
            {
                while (reader.Read()) 
                {
                    User u = new User()
                    {
                        ID = reader.GetInt32(0),
                        userName = reader.GetString(1),
                        password = reader.GetString(2)
                    };

                    users.Add(u);

                }

            }

            foreach(User u in users)
            {
                if (u.password != inputPassword || u.userName != inputUserName)
                {
                    connection.Close();
                    return false;
                }

            }
            connection.Close();
            

            return true;



        }
    }
}
