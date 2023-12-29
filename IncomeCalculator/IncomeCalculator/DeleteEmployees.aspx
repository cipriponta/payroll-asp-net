<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteEmployees.aspx.cs" Inherits="IncomeCalculator.DeleteEmployees" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="lblSurname" runat="server" Text="Surname" Width="100px"></asp:Label>
    <asp:TextBox ID="tbSurname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblFirstName" runat="server" Text="First Name" Width="100px"></asp:Label>
    <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnDelEmployee" runat="server" Text="Delete Employee" Width="200px" OnClick="btnDelEmployee_Click" />
</asp:Content>
