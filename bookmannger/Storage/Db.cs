using BookManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace BookManager.Storage
{
    public class Db
    {
        private readonly static string ConnectionString =
                ConfigurationManager.ConnectionStrings
                                ["DbString"].ConnectionString;
        public List<Book> DBBook { get; set; }
        public List<User> DBUser { get; set; }

        public Db()
        {
            DBBook = new List<Book>();
            DBUser = new List<User>();
            string dbTitle = "";
            string dbAuthor = "";
            string dbIsbn = "";
            string dbUsername = "";
            string dbId = "";
            int n = 1;
            n = n + 1;
            string pk = n.ToString();


            string booksqueryString = "SELECT  Title,Author,Isbn from Book ";
            string userqueryString = "SELECT Username,UserId FROM [User]";
            //        string bookinsert= "INSERT INTO Book (Title,Author,Isbn])
            //VALUES(1, 'Kelly', 'Jill')";

            using (SqlConnection bookconnection =
                                     new SqlConnection(ConnectionString))

            using (SqlConnection userconnection =
                                     new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(booksqueryString, bookconnection);
                SqlCommand usercommand = new SqlCommand(userqueryString, userconnection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    userconnection.Open();
                    SqlDataReader usersreader = usercommand.ExecuteReader();
                    while (usersreader.Read())
                    {
                        dbUsername = (string)usersreader[0];
                        dbId = (string)usersreader[1];

                        User datauser = new User(dbId, dbUsername);
                        DBUser.Add(datauser);
                    }
                    usersreader.Close();
                    {
                        bookconnection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("\t{0}\t{1}\t{2}",
                            //    reader[0], reader[1], reader[2]);

                            dbTitle = (string)reader[0];
                            dbAuthor = (string)reader[1];
                            dbIsbn = (string)reader[2];

                            Book databook = new Book(dbTitle, dbAuthor, dbIsbn);
                            DBBook.Add(databook);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }
        }
        private static void ExecuteSql(string sqlQuery)
        {
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))
            {
                var myCommand = new SqlCommand(sqlQuery, insertconnection);

                insertconnection.Open();
                myCommand.ExecuteNonQuery();
                insertconnection.Close();
            }
        }

        public void Insertbook(Book book)
        {
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))

            {
                string insertBook = $@"
                            Insert into Book 
                                    (Title, Author, Isbn)
                            Values
                                    ('{book.Title}', '{book.Author}', '{book.Isbn}')";

                var myCommand = new SqlCommand(insertBook, insertconnection);

                insertconnection.Open();
                myCommand.ExecuteNonQuery();
                insertconnection.Close();
            }
        }

        public void Deletebook(string ISBN)
        {
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))
            {
                string DeleteBook = $@"DELETE FROM Book WHERE ISBN = '{ISBN}'";

                var myCommand = new SqlCommand(DeleteBook, insertconnection);

                insertconnection.Open();
                myCommand.ExecuteNonQuery();
                insertconnection.Close();
            }
        }

        public void Updatebook(string newtitle, string newauthor, string isbn)
        {
            string sqlUpdateBook =
                $@"Update Book set Title='{newtitle}', Author='{newauthor}' WHERE ISBN = '{isbn}' ";
            ExecuteSql(sqlUpdateBook);
        }


        public void Insertuser(User user)
        {
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))

            {
                string insertUser = $@"Insert into [User] ([UserId],[Username])
Values('{user.Id}', '{user.Name}')";

                var myCommand = new SqlCommand(insertUser, insertconnection);

                insertconnection.Open();
                myCommand.ExecuteNonQuery();
                insertconnection.Close();
            }
        }

        public void Deleteuser(string id)
        {
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))
            {
                string DeleteUser = $@"DELETE FROM [User] WHERE [UserId] = '{id}'";

                var myCommand = new SqlCommand(DeleteUser, insertconnection);

                insertconnection.Open();
                myCommand.ExecuteNonQuery();
                insertconnection.Close();
            }
        }

        public void UpdateUser(string newName, string id)
        {
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))
            {
                string UpdateUser = $@"Update [User] set Username='{newName}' WHERE [UserId] = '{id}' ";

                var myCommand = new SqlCommand(UpdateUser, insertconnection);

                insertconnection.Open();
                myCommand.ExecuteNonQuery();
                insertconnection.Close();
            }
        }



        public DataTable checklistBook()
        {
            DataTable returnTable = new DataTable();
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand("SELECT Title,BookId FROM Book"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = insertconnection;
                    insertconnection.Open();
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(returnTable);
                    insertconnection.Close();

                }
            }
            return returnTable;
        }

        public DataTable checklistUser()
        {
            DataTable returnTableUsers = new DataTable();
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand("SELECT Username,User_number FROM [User]"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = insertconnection;
                    insertconnection.Open();
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(returnTableUsers);
                    insertconnection.Close();

                }
            }
            return returnTableUsers;
        }

        public void InsertBookandUser(string bookname, string username)
        {
            using (SqlConnection insertconnection =
                                  new SqlConnection(ConnectionString))
            {
                string InsertBookandUser = $@"insert into [UserBooks] (User_number,BookId) 
                values('{username}','{bookname}' ) ";
                var myCommand = new SqlCommand(InsertBookandUser, insertconnection);
                insertconnection.Open();
                myCommand.ExecuteNonQuery();
                insertconnection.Close();
            }

        }
        public DataTable SelectedBookAndUser()
        {
            DataTable returnSelectedUsaeAndBooks = new DataTable();
            using (SqlConnection insertconnection =
                                  new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                string SelectedBookandUser = $@"select title,[Username] from UserBooks 
                                            inner join Book on UserBooks.BookId = Book.BookId
										inner join [User] on UserBooks.User_number=[user].[User_number]";
                SqlCommand selectedsql = new SqlCommand(SelectedBookandUser);
                selectedsql.CommandType = CommandType.Text;
                selectedsql.Connection = insertconnection;
                insertconnection.Open();
                dataAdapter.SelectCommand = selectedsql;
                dataAdapter.Fill(returnSelectedUsaeAndBooks);
                insertconnection.Close();
            }
            return returnSelectedUsaeAndBooks;
        }

        public DataTable checkreturns()
        {
            DataTable returnstolibrary = new DataTable();
            using (SqlConnection insertconnection =
                                   new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                using (SqlCommand cmd = new SqlCommand("SELECT BookId ,Title from Book where bookId in (select bookId from userbooks) "))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = insertconnection;
                    insertconnection.Open();
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(returnstolibrary);

                    insertconnection.Close();

                }
                return returnstolibrary;
            }


        }

        public void returnbooks(string bookname)
        {
            using (SqlConnection insertconnection =
                                  new SqlConnection(ConnectionString))
            {
                string returnbook = $@"delete from [UserBooks] where [BookId]='{bookname}'";
                var returncmd = new SqlCommand(returnbook, insertconnection);
                insertconnection.Open();
                returncmd.ExecuteNonQuery();
                insertconnection.Close();

            }
        }

    }
}