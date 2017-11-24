using BookManager.BusinessLayer;
using BookManager.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryExam
{
    public partial class BooksUsersInOnePage : System.Web.UI.Page
    {
        //private BookManager.Storage.Db database;
        //private List<Book> WebBook;
        //private List<User> WebUser;

        protected void Page_Init(object sender, EventArgs e)
        {
            //database = new BookManager.Storage.Db();
            //WebBook = database.DBBook;
            //WebUser = database.DBUser;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Loadvalues();
            }

        }


        private void Loadvalues()
        {
            Db databasebooksandusers = new Db();
            BookManager.BusinessLayer.library booklibrary =
            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);

            gridofbooks.DataSource = booklibrary.BooksList;
            gridofbooks.DataBind();

            gridofusers.DataSource = booklibrary.Userlist;
            gridofusers.DataBind();
        }


    }
}