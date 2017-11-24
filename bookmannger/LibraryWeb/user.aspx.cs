using BookManager.Storage;
using BookManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWeb
{
    public partial class user : System.Web.UI.Page

    {
        private Db database;
        private List<User> wuser;

        public GridViewPageEventHandler GrdLibrary_PageIndexChanging { get; private set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            database = new Db();
            wuser = database.DBUser;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadvaluesOfuser();
            }

        }

        private void LoadvaluesOfuser()
        {
            Db databasebooksandusers = new Db();//db object 
            BookManager.BusinessLayer.library booklibrary =
            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
            griduser.DataSource = booklibrary.Userlist;

            griduser.DataBind();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Db databasebooksandusers = new Db();//db object
            databasebooksandusers.Insertuser(new User(userId.Text, username.Text));
            userId.Text = "";
            username.Text = "";
            LoadvaluesOfuser();
        }

        //private void Grduser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    Label useridvalue = (Label)griduser.Rows[e.RowIndex].FindControl("lblId");
        //    BookManager.Storage.Db databasebooksandusers = new BookManager.Storage.Db();//db object
        //    BookManager.BusinessLayer.library booklibrary =
        //    new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
        //    databasebooksandusers.Deletebook(useridvalue.Text);
        //    LoadvaluesOfuser();
        //}

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
            griduser.PageIndexChanging += Griduser_PageIndexChanging;
            griduser.RowDeleting += Griduser_RowDeleting;
            griduser.RowEditing += Griduser_RowEditing;
            griduser.RowUpdating += Griduser_RowUpdating;
            griduser.RowCancelingEdit += Griduser_RowCancelingEdit;

        }

        private void Griduser_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            griduser.EditIndex = -1;
            LoadvaluesOfuser();


        }

        private void Griduser_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label useridvalue = (Label)griduser.Rows[e.RowIndex].FindControl("lblId");
            Db databasebooksandusers = new Db();//db object
            BookManager.BusinessLayer.library booklibrary =
            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
            string nameEdit  = ((TextBox)griduser.Rows[e.RowIndex].FindControl("editName")).Text;
            databasebooksandusers.UpdateUser(nameEdit, useridvalue.Text);
            griduser.EditIndex = -1;
            LoadvaluesOfuser();
        }

        private void Griduser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            griduser.EditIndex = e.NewEditIndex;
        }

        private void Griduser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label useridvalue = (Label)griduser.Rows[e.RowIndex].FindControl("lblId");
            Db databasebooksandusers = new Db();//db object
            BookManager.BusinessLayer.library booklibrary =
            new BookManager.BusinessLayer.library(databasebooksandusers.DBBook, databasebooksandusers.DBUser);
            databasebooksandusers.Deleteuser(useridvalue.Text);
            LoadvaluesOfuser();
        }

        private void Griduser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    }