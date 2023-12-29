<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payroll2.aspx.cs" Inherits="IncomeCalculator.Payroll2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="SURNAME" HeaderText="SURNAME" SortExpression="SURNAME" />
            <asp:BoundField DataField="FIRST_NAME" HeaderText="FIRST_NAME" SortExpression="FIRST_NAME" />
            <asp:BoundField DataField="OCCUPATION" HeaderText="OCCUPATION" SortExpression="OCCUPATION" />
            <asp:BoundField DataField="GROSS_SALARY" HeaderText="GROSS_SALARY" SortExpression="GROSS_SALARY" />
            <asp:BoundField DataField="NET_SALARY" HeaderText="NET_SALARY" SortExpression="NET_SALARY" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CipriConnString %>" ProviderName="<%$ ConnectionStrings:CipriConnString.ProviderName %>" SelectCommand="SELECT &quot;SURNAME&quot;, &quot;FIRST_NAME&quot;, &quot;OCCUPATION&quot;, &quot;GROSS_SALARY&quot;, &quot;NET_SALARY&quot; FROM &quot;EMPLOYEES&quot;"></asp:SqlDataSource>
    <asp:Label ID="lblTotalGross" runat="server" Text="Total Gross" Width="150px"></asp:Label>
    <asp:TextBox ID="tbTotalGross" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <asp:Label ID="lblTotalNet" runat="server" Text="Total Net" Width="150px"></asp:Label>
    <asp:TextBox ID="tbTotalNet" runat="server" ReadOnly="True"></asp:TextBox>
    
</asp:Content>