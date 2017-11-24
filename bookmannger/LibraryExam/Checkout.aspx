<%@ Page Title="" Language="C#" MasterPageFile="~/Site1Exam.Master" AutoEventWireup="false" CodeBehind="Checkout.aspx.cs" Inherits="LibraryExam.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


  <br />

    <div <%--style: align="center--%>">
        <table>
            <tr>
                <th class="auto-style1">Book:</th>
                <td class="auto-style1">
                    <asp:DropDownList  runat="server" ID="ddlBook">
                    </asp:DropDownList>
                </td>
            
                <th>User:</th>
                <td>
                    <asp:DropDownList ID="ddlUser" runat="server">
                    </asp:DropDownList>
                </td>
            
                <td>
                    <asp:Button runat="server" Text="submit" ID="addBooksUser"  />
                </td>
            </tr>
        </table>
    </div>
      <br />
      <br />
      <br />
    <div>
        <asp:GridView ID="grdcheckBooks" runat="server" AutoGenerateColumns="true" style="margin-left: 85px" Width="359px"></asp:GridView>
    </div>
      <br />
      <br />
      <br />
<table>
    <tr>
        <td>
            Return:
        </td>
        <td>
            <asp:DropDownList ID="ddlReturns" runat="server">
                    </asp:DropDownList>

        </td>
        <td>
             <asp:Button runat="server" Text="submit" ID="returnbooks"  />
        </td>
    </tr>
</table>


</asp:Content>
