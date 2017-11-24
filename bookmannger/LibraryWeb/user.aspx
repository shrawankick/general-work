<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="false" CodeBehind="user.aspx.cs" Inherits="LibraryWeb.user" %>

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
        <asp:GridView ID="griduser" runat="server" AutoGenerateColumns="FALSE"
            ShowFooter="true">
            <Columns>
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:TemplateField HeaderText="USER ID">
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                    </ItemTemplate>
                    <%--<EditItemTemplate>
                        <asp:TextBox runat="server" ID="editId" Text='<%# Eval("Id") %>'></asp:TextBox>
                    </EditItemTemplate>--%>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="USER NAME">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="editName" Text='<%# Eval("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <table>
            <tr>
                <td>Id
                </td>
                <td>
                    <asp:TextBox ID="userId" runat="server"></asp:TextBox><br />
                   <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1" runat="server"
                        ErrorMessage="Required!" ValidationGroup="useradd"
                        ControlToValidate="userId">
                    </asp:RequiredFieldValidator>
                </td>

            </tr>

            <tr>
                <td>Name
                </td>
                <td>
                    <asp:TextBox ID="username" runat="server" ></asp:TextBox><br />
                    <asp:RequiredFieldValidator runat="server" ID="idvaladate" 
                        ControlToValidate="username"    ValidationGroup="useradd"                                
                          ErrorMessage="input required" ForeColor="Red" >

                    </asp:RequiredFieldValidator>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Add"   ValidationGroup="useradd" />
                </td>
            </tr>

        </table>
    </div>
</asp:Content>
