<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="false" CodeBehind="book.aspx.cs" Inherits="LibraryWeb.book" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <asp:HyperLink ID="indexofall"
        NavigateUrl="Index.aspx"
        Text="link to SWITCH index page "
        runat="server"></asp:HyperLink>
    <br />
    <asp:HyperLink ID="librarypage"
        NavigateUrl="Library.aspx"
        Text="library main page"
        runat="server" />
    <br />
    <br />
    <br />

    <div>
        <asp:GridView ID="grdLibrary" runat="server" AutoGenerateColumns="false"
            ShowFooter="true" OnSelectedIndexChanged="grdLibrary_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="true" />
                <asp:TemplateField HeaderText="Book name">

                    <ItemTemplate>
                        <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="editTitle" Text='<%# Eval("Title") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Author">
                    <ItemTemplate>
                        <asp:Label ID="lblAuthor" runat="server" Text='<%# Eval("Author") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="editAuthor" Text='<%# Eval("Author") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Isbn">
                    <ItemTemplate>
                        <asp:Label ID="lblIsbn" runat="server" Text='<%# Eval("Isbn") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </div>
    <div>
        <table>
            <tr>
                <td>Book name</td>
                <td>
                    <asp:TextBox ID="bookName" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1" runat="server"
                        ErrorMessage="Required!" ValidationGroup="bookadd"
                        ControlToValidate="bookName">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Author</td>
                <td>
                    <asp:TextBox ID="bookauthor" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2" runat="server"
                        ErrorMessage="Required!" ValidationGroup="bookadd"
                        ControlToValidate="bookauthor">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>ISBN
                </td>
                <td>
                    <asp:TextBox ID="bookIsbn" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3" runat="server"
                        ErrorMessage="Required!" ValidationGroup="bookadd"
                        ControlToValidate="bookIsbn">
                    </asp:RequiredFieldValidator>


                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Add"  ValidationGroup="bookadd"/>
                </td>
            </tr>
        </table>


    </div>


</asp:Content>
