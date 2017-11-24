<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Library.aspx.cs" Inherits="LibraryWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>welcome to library  main page </h1>
        
     <asp:HyperLink id="indexofall"
                 NavigateUrl="Index.aspx"
                text="link to SWITCH index page "
                runat="server"></asp:HyperLink>
    <br />
        <br />

    </div>

    



    <table ">
        <tr>
            <th>Books</th>
            <th>users</th>
        </tr>
        <tr>
            <td >
                <asp:GridView ID="gridofbooks" runat="server" AutoGenerateColumns="true"></asp:GridView>
            </td>

            <td >
                <asp:GridView ID="gridofusers" runat="server" AutoGenerateColumns="true"></asp:GridView>

            </td>
        </tr>
    </table>






    <%--books--%>
    <%--    <asp:GridView id="gridofbooks" runat="server" AutoGenerateColumns="true"></asp:GridView>--%>
    <br />
    <hr />
    <br />


    
    <%--<asp:Gridview ID ="gridofusers" runat="server" AutoGenerateColumns="true"></asp:Gridview>--%>

    <br />
    <hr />
    <br />
    <%--<div>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Add" />
        </div>--%>
</asp:Content>
