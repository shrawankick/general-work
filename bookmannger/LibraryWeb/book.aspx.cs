using BookManager.BusinessLayer;
using BookManager.Storage;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWeb
{
    public partial class book : System.Web.UI.Page
    {
        private Db database;
        private List<Book> wbook;

        protected void Page_Init(object sender, EventArgs e)
        {
            database = new Db();
            wbook = database.DBBook;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadValuesOfBooks();
            }
        }

        private void LoadValuesOfBooks()
        {
////<<<<<<< HEAD
//            Db databasebooksandusers = new Db();//db object 
//            BookManager.BusinessLayer.library booklibrary =
//            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
////=======
            Db databaseBooksAndUsers = new Db();
            library booklibrary =
                new library(
                        databaseBooksAndUsers.DBBook,
                        databaseBooksAndUsers.DBUser);
//>>>>>>> 31c41ef97066953a8b57e9681e84dfa5aa1a81a0
            grdLibrary.DataSource = booklibrary.BooksList;
            //grdLibrary.DataSource = wbook;
            grdLibrary.DataBind();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
/*//<<<<<<< HEAD
            Db databasebooksandusers = new Db();//db object
            databasebooksandusers.Insertbook(new Book(bookName.Text, bookauthor.Text, bookIsbn.Text));
//=======*/
            Db databasebooksandusers = new Db();
            databasebooksandusers.Insertbook(
                                        new Book(
                                            bookName.Text,
                                            bookauthor.Text,
                                            bookIsbn.Text));
            CleanBookUI();
            LoadValuesOfBooks();
        }

        private void CleanBookUI()
        {
//>>>>>>> 31c41ef97066953a8b57e9681e84dfa5aa1a81a0
            bookName.Text = "";
            bookauthor.Text = "";
            bookIsbn.Text = "";
        }

        private void GrdLibrary_RowDeleting(
                                object sender, 
                                GridViewDeleteEventArgs e)
        {
            Label isbnvalue = (Label)grdLibrary.Rows[e.RowIndex].FindControl("lblIsbn");

////<<<<<<< HEAD
//            Db databasebooksandusers = new Db();//db object
//            BookManager.BusinessLayer.library booklibrary =
//            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
////=======
            Db databasebooksandusers = new Db();
            library booklibrary =
                new library(
                    databasebooksandusers.DBBook, 
                    databasebooksandusers.DBUser);
//>>>>>>> 31c41ef97066953a8b57e9681e84dfa5aa1a81a0
            databasebooksandusers.Deletebook(isbnvalue.Text);
            LoadValuesOfBooks();
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
            this.Init += Page_Init;
            this.Load += new EventHandler(Page_Load);
            btnSubmit.Click += BtnSubmit_Click;
            //grdLibrary.PageIndexChanging += GrdLibrary_PageIndexChanging;
            grdLibrary.RowDeleting += GrdLibrary_RowDeleting;
            grdLibrary.RowEditing += GrdLibrary_RowEditing;
            grdLibrary.RowUpdating += GrdLibrary_RowUpdating;
            grdLibrary.RowCancelingEdit += GrdLibrary_RowCancelingEdit;
        }

        private void GrdLibrary_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdLibrary.EditIndex = -1;
            LoadValuesOfBooks(); ;
        }

        private void GrdLibrary_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label isbnvalue = (Label)grdLibrary.Rows[e.RowIndex].FindControl("lblIsbn");
            Db databasebooksandusers = new Db();//db object
/*<<<<<<< HEAD
            BookManager.BusinessLayer.library booklibrary =
            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
            string titleEdit = ((TextBox)grdLibrary.Rows[e.RowIndex].FindControl("editTitle")).Text;
            string authorEdit = ((TextBox)grdLibrary.Rows[e.RowIndex].FindControl("editAuthor")).Text;


            databasebooksandusers.Updatebook(titleEdit, authorEdit, isbnvalue.Text);
=======*/
            library booklibrary =
            new library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
            string titleEdit = ((TextBox)grdLibrary
                                    .Rows[e.RowIndex]
                                        .FindControl( "editTitle"))
                                            .Text;
            string authorEdit = ((TextBox)grdLibrary.Rows[e.RowIndex].FindControl(
                                                                        "editAuthor")).Text;

            databasebooksandusers.Updatebook(
                                    titleEdit, 
                                    authorEdit, 
                                    isbnvalue.Text);
//>>>>>>> 31c41ef97066953a8b57e9681e84dfa5aa1a81a0
            grdLibrary.EditIndex = -1;
            LoadValuesOfBooks();
        }

        private void GrdLibrary_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdLibrary.EditIndex = e.NewEditIndex;
        }

        private void GrdLibrary_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdLibrary.PageIndex = e.NewPageIndex;
            LoadValuesOfBooks();
        }

        protected void grdLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}