<%@ Page Title="" Language="C#" MasterPageFile="~/Site1Exam.Master" AutoEventWireup="true" CodeBehind="BooksUsersInOnePage.aspx.cs" Inherits="LibraryExam.BooksUsersInOnePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--    <div>
        <asp:GridView ID="grdLibrary" runat="server" AutoGenerateColumns="false"
            ShowFooter="true" OnSelectedIndexChanged="grdLibrary_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="true" />


                <asp:TemplateField HeaderText="Bookid">
                    <ItemTemplate>
                        <asp:Label ID="lblid" runat="server" Text='<%# Eval("BookId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>




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
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="editIsbn" Text='<%# Eval("Isbn") %>'></asp:TextBox>
                    </EditItemTemplate>

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
                    <asp:Button ID="btnSubmit" runat="server" Text="Add" ValidationGroup="bookadd" />
                </td>
            </tr>
        </table>


    </div>--%>

        <table >
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



</asp:Content>
