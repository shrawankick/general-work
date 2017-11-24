using BookManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Storage.Hardcoded harddata = new Storage.Hardcoded();
            //BusinessLayer.library mylibrary = new BusinessLayer.library(harddata.Mybooks, harddata.Myusers);
            //Console.WriteLine(harddata.Mybooks[1].ToString());
            ////Console.WriteLine(harddata.Myusers[1].ToString());//user name 
            //Console.WriteLine(mylibrary.ToString());

            /*
            Books books = mylibrary.Search("1122233344");//function calling 
            if (books == null)
            {
                Console.WriteLine("there is no book with this value ");
            }
            else
            {
                Console.WriteLine(books.ToString());
            }


           /* user search*/
            /*
             User user = mylibrary.Searchinguser("12122");
             if (user == null)
             {
                 Console.WriteLine("there the no user ");
             }
             else
             {
                 Console.WriteLine(user.ToString());
             }

             */
             /*
            ///xml storage 

            //Storage.Xml xmlbookanduser = new Storage.Xml();
            //BusinessLayer.library xmllibrary = new library(xmlbookanduser.Xmlbooks, xmlbookanduser.Xmluser);
            //Console.WriteLine(xmllibrary.ToString());

            ///database storage 

<<<<<<< HEAD
            Storage.Db databasebooks = new Storage.Db();
            BusinessLayer.library booklibrary = new BusinessLayer.library(databasebooks.DBBook, harddata.Myusers);
            Console.WriteLine(booklibrary.BooksList[0].ToString());

            Console.WriteLine(databasebooks.ToString());

            Console.WriteLine(booklibrary.Userlist.ToString());
=======
            Storage.Db databasebooksandusers = new Storage.Db();//db object 
            BusinessLayer.library booklibrary =
                new BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);//library object 
                                                                                                      //Console.WriteLine(booklibrary.BooksList[0].ToString());

            //Console.WriteLine(booklibrary.ToString());

            //Console.WriteLine(booklibrary.DBBook[1].ToString());



            BusinessLayer.User user = new BusinessLayer.User("123", "bhanu");
            booklibrary.user(user);



            //Books books = new Books("one night at the call center  ", "bhanu", "1111111221");
            //Books books = new Books("two states  ", "nagesh", "010101010");
            //booklibrary.book(books);
            Console.WriteLine(booklibrary.ToString());

            Books books = new Books("karteek calling karteek ", "bhanu", "1111111221");
            booklibrary.book(books);
            Console.WriteLine(booklibrary.ToString());
            Console.ReadLine();

            //booklibrary.Removebook(books);
            //booklibrary.Removeuser(user);
            //booklibrary.Edituser(user);
            Console.WriteLine(booklibrary.ToString());

            */

          interfacing.conditions();

//<<<<<<< HEAD

//=======
//>>>>>>> a9c5af783ce4f384ea9164ece58914d2db035960
//            Console.ReadLine();
        }
    }
}
