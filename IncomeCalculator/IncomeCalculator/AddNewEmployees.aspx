<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewEmployees.aspx.cs" Inherits="IncomeCalculator.AddNewEmployees" %>

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
    <asp:Label ID="lblOccupation" runat="server" Text="Occupation" Width="100px"></asp:Label>
    <asp:TextBox ID="tbOccupation" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblGrossSalary" runat="server" Text="Gross Salary" Width="100px"></asp:Label>
    <asp:TextBox ID="tbGrossSalary" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnAddEmployee" runat="server" Text="Add Employee" Width="200px" OnClick="btnAddEmployee_Click" />
    &nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
</asp:Content>
