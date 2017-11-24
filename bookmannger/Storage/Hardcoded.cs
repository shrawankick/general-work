using BookManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Storage
{
    public class Hardcoded 
    {
        //public BusinessLayer.Books Mybook { get; private set; }
        public List<Book> Mybooks { get;private set; }
        //public BusinessLayer.User Myuser { get; private set; }
        public List<User> Myusers { get; private set; }
        public Hardcoded()
        {
            //Mybooks = new List<Books>()
            //{
            //    new Book("life of PI", "shrawan", "11222111222"),
            //    new Book("you can win ", "shiva kehera", "11222333444")
            //};
            Mybooks = new List<Book>()
             {
                 new Book ("life of PI", "shrawan", "11222111222"),
                 new Book("you can win ", "shiva kehera", "11222333444")
             };

            //Mybook = new BusinessLayer.Books("life of PI", "shrawan", "11222111222");
            //Mybooks = new BusinessLayer.Books("you can win ", "shiva kehera", "11222333444");

            Myusers = new List<User>()
            {
                new User("10md1a0450", "shrawan"),
                new User("10md1a0451", "pavan")
            };

            //Myuser = new BusinessLayer.User("10md1a0450", "shrawan");
        }

        

    }
}
