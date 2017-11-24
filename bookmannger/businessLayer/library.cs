using BookManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.BusinessLayer
{
    public class library
    {

        /// <summary>
        /// books list and user list
        /// </summary>
        public List<Book> BooksList { get; private set; }
        public List<User> Userlist { get; private set; }
        public library(List<Book> booksList, List<User> userlist)
        {
            BooksList = booksList;
            Userlist = userlist;
        }
        public override string ToString()
        {
            string outlist = "";
            foreach (Book book in BooksList)
            {
                outlist += book.ToString();
                outlist += "\r\n";
            }
            foreach (User user in Userlist)
            {
                outlist += user.ToString();
                outlist += "\r\n";

            }
            return outlist;
        }

        public Book Search(string myvalue)
        {
            foreach (Book book in BooksList)
            {
                if (book.Title == myvalue ||
                    book.Author == myvalue ||
                    book.Isbn == myvalue)
                {
                    return book;
                }
            }
            return null;
        }


        public User Searchinguser(string myvalue)
        {
            foreach (User usersearch in Userlist)
            {
                if (usersearch.Id == myvalue ||
                    usersearch.Name == myvalue)

                {
                    return usersearch;
                }
            }
            return null;
        }


        public Book SearchBookByTitle(string title)
        {
            foreach (Book book in BooksList)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }

        public void user(User user)
        {
           Console.WriteLine("----------------------------------------");
           Console.WriteLine("initial user Count: {0}", Userlist.Count);
            Console.WriteLine("----------------------------------------");
            Userlist.Add(user);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("user Count: {0}", Userlist.Count);
            Console.WriteLine("----------------------------------------");
        }


        public void book(Book book)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("initial  books Count: {0}", BooksList.Count);
            Console.WriteLine("----------------------------------------");
            BooksList.Add(book);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("books Count: {0}", BooksList.Count);
            Console.WriteLine("----------------------------------------");
        }

        public void Removebook(Book delbooks)
        {
            BooksList.Remove(delbooks);
            Console.WriteLine("books Count: {0}", BooksList.Count);
            
                       
        }
        public void Removeuser(User delusers)
        {
            Userlist.Remove(delusers);
            Console.WriteLine("users Count: {0}", Userlist.Count);
        }


        public void EditBook(string oldname,string newname)
        {
            int p = FindIndexbyNameForBook(oldname);
            Book Oldbook = BooksList[p];
            if (p >= 0)
            {
                BooksList.RemoveAt(p);
                Book newBook = new Book(newname, Oldbook.Author, Oldbook.Isbn);
                BooksList.Insert(p, newBook);
                Console.WriteLine(newBook);
               

            }
            Console.WriteLine("there is no book ");
        }

        public void EditUser(string oldname, string newname)
        {
            int p = FindIndexbyNameForUser(oldname);
            User Olduser = Userlist[p];
            if (p < 0)
            {
               
                Userlist.RemoveAt(p);
                User newUser = new User(Olduser.Id, newname);
                Userlist.Insert(p, newUser);
                Console.WriteLine(newUser);

            }
            Console.WriteLine("there is no book ");
        }




        public int FindIndexbyNameForUser(string nameofuser)
        {

            int position = -1;
            for (int i = 0; i < Userlist.Count; i++)
            {
                if (Userlist[i].Name == nameofuser)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }

        public int FindIndexbyNameForBook(string nameofbook)
        {

            int position = -1;
            for (int i = 0; i < BooksList.Count; i++)
            {
                if (BooksList[i].Title == nameofbook)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }




        //public void Edituser(User editusers)
        //{
        //    Console.WriteLine("write The position to edit");
        //    var x =Console.ReadLine();
        //    Console.WriteLine("enter The text to edit");
        //    var edituser = Console.ReadLine();
        //    Userlist.Insert( Convert.ToInt32(x) , editusers);
        //}



        //List<User> adduser = new List<User>();
        //public void Add(List<User> adduser,Books books)
        //{


        //    Userlist.Add(user);
        //    Userlist.Add(books);
        //}













    }
}
