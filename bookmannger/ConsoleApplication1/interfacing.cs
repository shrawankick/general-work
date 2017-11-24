using BookManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.ConsoleApplication1
{
    public class interfacing
    {
        public static void options()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("!MAKE SHURE CAPLOCK IS ON!");
            Console.WriteLine("welcome to library");
            Console.WriteLine("what you want to do ? ");
            Console.WriteLine("AB: Add Book");
            Console.WriteLine("AU: Add User");

            Console.WriteLine("EB: Edit Book");
            Console.WriteLine("EU: Edit User");
            Console.WriteLine("DB: Delete Book");
            Console.WriteLine("DU: Delete User");
            Console.WriteLine("SBT: Search Book by Title");
            Console.WriteLine("SUI: Search User by Id");
            Console.WriteLine("======================================================");
            Console.WriteLine("X: Exit");
            Console.WriteLine("======================================================");
        }
        public static void conditions()
        {

            options();
            var choice = Console.ReadLine();
            if (choice == "AB")
            {
                Console.WriteLine("add books");

                Storage.Db databasebooksandusers = new Storage.Db();
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                Book books = CaputureBook();
                booklibrary.book(books);
                Console.WriteLine(booklibrary.ToString());

                conditions();

                Console.ReadLine();
            }
            else if (choice == "AU")
            {
                Console.WriteLine("add user");



                Storage.Db databasebooksandusers = new Storage.Db();
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                User user = CaputureUsuer();
                booklibrary.user(user);
                Console.WriteLine(booklibrary.ToString());

                conditions();

                Console.ReadLine();

            }
            else if (choice == "EB")
            {
                Console.WriteLine("edit books");

                Console.WriteLine("enter the title you want to edit ");
                var oldtitle = Console.ReadLine();
                Console.WriteLine("enter new title");
                var newtitle = Console.ReadLine();
                Storage.Db databasebooksandusers = new Storage.Db();
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                booklibrary.EditBook(oldtitle, newtitle);
                //Console.WriteLine(booklibrary.ToString());


                conditions();
                Console.ReadLine();

            }
            else if (choice == "EU")
            {
                Console.WriteLine("edit user");


                Console.WriteLine("enter the name you want to edit ");
                var oldname = Console.ReadLine();
                Console.WriteLine("enter new name");
                var newname = Console.ReadLine();
                Storage.Db databasebooksandusers = new Storage.Db();
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                booklibrary.EditBook(oldname, newname);
                //Console.WriteLine(booklibrary.ToString());


                conditions();
                Console.ReadLine();

            }
            else if (choice == "DB")
            {
                Console.WriteLine("delete books");

                Console.WriteLine("Enter the value to delete in book");
                var bookvalue = Console.ReadLine();

                Storage.Db databasebooksandusers = new Storage.Db();//db object 
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                Book books = booklibrary.Search(bookvalue);//function calling 
                if (books == null)
                {
                    Console.WriteLine("there is no book with this value ");
                }
                else
                {
                    //Console.WriteLine(books.ToString());
                    booklibrary.Removebook(books);
                    Console.WriteLine(booklibrary.ToString());

                }

                conditions();
                Console.ReadLine();

            }
            else if (choice == "DU")
            {
                Console.WriteLine("delete user");

                Console.WriteLine("Enter the value to delete in book");
                var uservalue = Console.ReadLine();

                Storage.Db databasebooksandusers = new Storage.Db();//db object 
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                User user = booklibrary.Searchinguser(uservalue);
                if (user == null)
                {
                    Console.WriteLine("there the no user ");
                }
                else
                {
                    booklibrary.Removeuser(user);
                    Console.WriteLine(user.ToString());
                }


                conditions();
                Console.ReadLine();

            }
            else if (choice == "SBT")
            {
                Console.WriteLine("search books");
                Console.WriteLine("Enter the value to serarch in books");
                var bookvalue = Console.ReadLine();

                Storage.Db databasebooksandusers = new Storage.Db();//db object 
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                Book books = booklibrary.Search(bookvalue);//function calling 
                if (books == null)
                {
                    Console.WriteLine("there is no book with this value ");
                }
                else
                {
                    Console.WriteLine(books.ToString());
                    booklibrary.Removebook(books);
                }


                conditions();
                Console.ReadLine();


            }
            else if (choice == "SUI")
            {
                Console.WriteLine("search users ");

                Console.WriteLine("Enter the value to serarch in users");
                var uservalue = Console.ReadLine();

                Storage.Db databasebooksandusers = new Storage.Db();//db object 
                BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
                User user = booklibrary.Searchinguser(uservalue);
                if (user == null)
                {
                    Console.WriteLine("there the no user ");
                }
                else
                {
                    Console.WriteLine(user.ToString());
                }

                conditions();
                Console.ReadLine();


            }
            else if (choice == "X")
            {
                Console.WriteLine("EXIT");
            }

        }
        public static Book CaputureBook()
        {

            Console.WriteLine("Enter book to add ");
            Console.WriteLine("book name");

            Console.Write("What's the title ? ");
            string title = Console.ReadLine();

            Console.Write("What is author  name? ");
            string author = Console.ReadLine();

            Console.Write("what is isbn number ?");
            string isbn = Console.ReadLine();

            return new Book(title, author, isbn);

        }
        public static User CaputureUsuer()
        {

            Console.WriteLine("Enter User to add ");
            Console.WriteLine("USER name");

            Console.Write("What's the User name ? ");
            string username = Console.ReadLine();



            Console.Write("what is Id number ?");
            string id = Console.ReadLine();

            return new User(username, id);

        }

        //public static void DBllibrary()
        //{
        //    Storage.Db databasebooksandusers = new Storage.Db();//db object 
        //    BusinessLayer.library booklibrary =
        //        new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
        //}



    }
}
