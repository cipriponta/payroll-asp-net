<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PercentagesLogin.aspx.cs" Inherits="IncomeCalculator.PercentagesLogin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="lblPass" runat="server" Text="Enter Password" Width ="150px"></asp:Label>
    <asp:TextBox ID="tbPass" runat="server" Width ="200px"></asp:TextBox>
    <br />
    <asp:Button ID="btnPass" runat="server" Text="Log in" Width ="250px" OnClick="btnPass_Click"/>
    
</asp:Content>