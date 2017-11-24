<%@ Page Title="" Language="C#" MasterPageFile="~/Site1Exam.Master" AutoEventWireup="true" CodeBehind="IndexPage.aspx.cs" Inherits="LibraryExam.IndexPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br />
    this is an index page 
      <br />
      <br />
    <asp:HyperLink id="BooksAndUser"
        NavigateUrl="BooksUsersInOnePage.aspx"
        Text ="library for display"
        runat="server"
        ></asp:HyperLink>
    <br />
      <br />
    <asp:HyperLink id="checkout"
        NavigateUrl="Checkout.aspx"
        Text ="Applacation for librarian "
        runat="server"
        ></asp:HyperLink>

</asp:Content>
