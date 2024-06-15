using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_szkolenie_techiczne_1
{
    internal class LibraryDAO
    {
        public int UserID { get; set; }
        string connectionString = "datasource=localhost; port=8889; username=root; password=root; database=library";

        //sprawdzanie usera
        public bool CheckUser(string inputUserName, string inputPassword)
        {
            List<User> users = new List<User>();

            MySqlConnection connection = new MySqlConnection(connectionString);
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

            foreach (User u in users)
            {
                if (u.password == inputPassword && u.userName == inputUserName)
                {
                    connection.Close();
                    UserID = u.ID; 

                    
                    User_panel userPanel = new User_panel(UserID);
                    userPanel.Show();

                    return true;
                }
            }

            connection.Close();
            return false;
        }

        //pobieranie wszystkich ksiązek użytkownika
        public List<JObject> GetUserBooks(int userID)
        {
            List<JObject> UserBooks = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT user_ID, books.TITLE, books.AUTHOR, books.YEAR, books.BOOKID " +
                                  "FROM borrowedbooks INNER JOIN books ON books.BOOKID = borrowedbooks.BOOKID WHERE user_ID=@userID";
            command.Parameters.AddWithValue("@userID", userID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject userBook = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        userBook.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    UserBooks.Add(userBook);
                }
            }

            connection.Close();
            return UserBooks;
        }

        //pobieranie wszystkich książek
        public List<JObject> GetAllBook()
        {
            List<JObject> Books = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT BOOKID, TITLE, AUTHOR, YEAR, IsBorrowed FROM books";
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject Book = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Book.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    Books.Add(Book);
                }
                
            }

            connection.Close();
            return Books;
        }

        //wypozyczanie ksiazki
        public void BorrowBook(int bookID, int UserID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            
            MySqlCommand insertCommand = new MySqlCommand();
            insertCommand.CommandText = "INSERT INTO borrowedbooks (BORROWDATE, RETURNDATE, user_ID, BOOKID) VALUES (@borrowDate, @returnDate, @userID, @bookID)";
            insertCommand.Parameters.AddWithValue("@borrowDate", DateTime.Now.ToString("yyyyMMdd"));
            insertCommand.Parameters.AddWithValue("@returnDate", DateTime.Now.AddDays(14).ToString("yyyyMMdd")); // assuming a 14-day borrow period
            insertCommand.Parameters.AddWithValue("@userID", UserID); 
            insertCommand.Parameters.AddWithValue("@bookID", bookID);
            insertCommand.Connection = connection;
            insertCommand.ExecuteNonQuery();

            
            MySqlCommand updateCommand = new MySqlCommand();
            updateCommand.CommandText = "UPDATE books SET IsBorrowed = 1 WHERE BOOKID = @bookID";
            updateCommand.Parameters.AddWithValue("@bookID", bookID);
            updateCommand.Connection = connection;
            updateCommand.ExecuteNonQuery();

            connection.Close();
        }

        //zwrot ksiazki
        public void ReturnBook(int bookID, int UserID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            
            MySqlCommand deleteCommand = new MySqlCommand();
            deleteCommand.CommandText = "DELETE FROM borrowedbooks WHERE BOOKID = @bookID AND user_ID = @userID";
            deleteCommand.Parameters.AddWithValue("@bookID", bookID);
            deleteCommand.Parameters.AddWithValue("@userID", UserID);
            deleteCommand.Connection = connection;
            deleteCommand.ExecuteNonQuery();

            
            MySqlCommand updateCommand = new MySqlCommand();
            updateCommand.CommandText = "UPDATE books SET IsBorrowed = 0 WHERE BOOKID = @bookID";
            updateCommand.Parameters.AddWithValue("@bookID", bookID);
            updateCommand.Connection = connection;
            updateCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}