<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Percentages.aspx.cs" Inherits="IncomeCalculator.Percentages" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="lblTaxPension" runat="server" Text="Pension Tax Percentage" Width="200px"></asp:Label>
    <asp:TextBox ID="tbTaxPension" runat="server" Width="100px"></asp:TextBox>
    <br />
    <asp:Label ID="lblTaxHealth" runat="server" Text="Health Tax Percentage" Width="200px"></asp:Label>
    <asp:TextBox ID="tbTaxHealth" runat="server" Width="100px"></asp:TextBox>
    <br />
    <asp:Label ID="lblTaxIncome" runat="server" Text="Income Tax Percentage" Width="200px"></asp:Label>
    <asp:TextBox ID="tbTaxIncome" runat="server" Width="100px"></asp:TextBox>
    <br />
    <asp:Label ID="lblGrossIncrease" runat="server" Text="Default Gross Increase Value" Width="200px"></asp:Label>
    <asp:TextBox ID="tbGrossIncrease" runat="server" Width="100px"></asp:TextBox>
    <br />
    <asp:Label ID="lblDeductions" runat="server" Text="Default Deductions Value" Width="200px"></asp:Label>
    <asp:TextBox ID="tbDeductions" runat="server" Width="100px"></asp:TextBox>
    <br />
    <asp:Label ID="lblGrossPrizes" runat="server" Text="Default Gross Prizes Value" Width="200px"></asp:Label>
    <asp:TextBox ID="tbGrossPrizes" runat="server" Width="100px"></asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="New Password" Width="200px"></asp:Label>
    <asp:TextBox ID="tbPassword" runat="server" Width="200px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnChangePercentages" runat="server" Text="Save New Values" Width="250px" OnClick="btnChangePercentages_Click" />
</asp:Content>