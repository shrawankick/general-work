using BookManager.BusinessLayer;
using BookManager.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private Db database;
        private List<Book> wbook;
        private List<User> wuser;
        protected void Page_Init(object sender, EventArgs e)
        {
            database  = new Db();
            wbook = database.DBBook;
            wuser = database.DBUser;
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
            Db databasebooksandusers = new Db();//db object 
            BookManager.BusinessLayer.library booklibrary =
            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);

            gridofbooks.DataSource = booklibrary.BooksList;
            gridofbooks.DataBind();

            gridofusers.DataSource = booklibrary.Userlist;
            gridofusers.DataBind();
        }

        //protected void grdLibrary_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}