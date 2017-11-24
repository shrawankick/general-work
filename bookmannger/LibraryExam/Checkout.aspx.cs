using BookManager.BusinessLayer;
using BookManager.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryExam
{
    public partial class Checkout : System.Web.UI.Page
    {
        private Db database;
        private List<Book> wbook;
        private List<User> WUser;
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                LoadValues();

            }

        }

        private void LoadValues()
        {
            Db databasebooksandusers = new Db();//db object 
            BookManager.BusinessLayer.library booklibrary =
            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);


            DataTable booksTable = databasebooksandusers.checklistBook();

            ddlBook.DataSource = booksTable;
            ddlBook.DataTextField = "Title";
            ddlBook.DataValueField = "BookId";
            ddlBook.DataBind();


            DataTable UsersTable = databasebooksandusers.checklistUser();

            ddlUser.DataSource = UsersTable;
            ddlUser.DataTextField = "Username";
            ddlUser.DataValueField = "User_number";
            ddlUser.DataBind();

            DataTable Usersreturns = databasebooksandusers.checkreturns();

            ddlReturns.DataSource = Usersreturns;
            ddlReturns.DataTextField = "Title";
            ddlReturns.DataValueField = "BookId";
            ddlReturns.DataBind();


            ddlBook.Items.Insert(0, new ListItem("--Select Book--", "0"));
            ddlUser.Items.Insert(0, new ListItem("--Select [User]--", "0"));
            ddlReturns.Items.Insert(0, new ListItem("--Select book to return--", "0"));

            Db jointable = new Db();
            grdcheckBooks.DataSource = jointable.SelectedBookAndUser();
            grdcheckBooks.DataBind();

          




            //gridofbooks.DataSource = booklibrary.BooksList;
            //gridofbooks.DataBind();

            //gridofusers.DataSource = booklibrary.Userlist;
            //gridofusers.DataBind();
        }

        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }
        private void InitializeComponent()
        {
            //this.Init += page_Init;
            this.Load += new EventHandler(Page_Load);
            addBooksUser.Command += AddBooksUser_Command;
            returnbooks.Command += Returnbooks_Command;
           
        }

        private void Returnbooks_Command(object sender, CommandEventArgs e)
        {
            Db selectButton = new Db();
            selectButton.returnbooks(ddlReturns.SelectedValue);
            LoadValues();
        }

        private void AddBooksUser_Command(object sender, CommandEventArgs e)
        {
            Db selectButton = new Db();
            selectButton.InsertBookandUser(ddlBook.SelectedValue, ddlUser.SelectedValue);
            LoadValues();
        }

        //private void AddBooksUser_Click(object sender, EventArgs e)
        //{
        //    Db selectButton = new Db();
        //    selectButton.InsertBookandUser(ddlBook.SelectedValue, ddlUser.SelectedValue);
        //    LoadValues();
        //}


        //private void page_Init(object sender, EventArgs e)
        //{

        //}
    }
}