<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalarySlips.aspx.cs" Inherits="IncomeCalculator.SalarySlips" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Label ID="lbSearch" runat="server" Text="Search by Surname" Width="150px"></asp:Label>
    <asp:TextBox ID="tbSearch" runat="server" Width="150px"></asp:TextBox>
    <br />
    <asp:Button ID="btnSearch" runat="server" Text="Search" Width="200px" />
    <br />
    <br />
    <asp:Panel ID="MainPanel" runat="server"></asp:Panel>
</asp:Content>