using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.BusinessLayer
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; } 
        public string Isbn { get; private set; }
    public Book (string title , string author , string isbn)
    {
            Title = title;
            Author = author;
            Isbn = isbn;
   }
        public override string ToString()
        {
            return string.Format($"title = {Title}, author = {Author}, isbn = {Isbn}");
        }
    }

}
