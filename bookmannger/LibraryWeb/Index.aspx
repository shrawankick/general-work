<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" 
    CodeBehind="Index.aspx.cs" Inherits="LibraryWeb.Index" %>

<script runat="server">
   
</script>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="librarypage"
        NavigateUrl="Library.aspx"
        Text ="library main page"
        runat="server"
        />
    <br />

    <asp:HyperLink ID="bookpage"
        NavigateUrl="book.aspx"
        Text="BOOKS ONLY"
        runat="server" />
   <br/>
    <asp:HyperLink ID ="userpage"
        NavigateUrl="user.aspx"
        Text="USER ONLY"
        runat="server" />
        

</asp:Content>
