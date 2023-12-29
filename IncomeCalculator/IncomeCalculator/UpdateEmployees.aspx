<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateEmployees.aspx.cs" Inherits="IncomeCalculator.UpdateEmployees" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="SURNAME" HeaderText="SURNAME" SortExpression="SURNAME" />
            <asp:BoundField DataField="FIRST_NAME" HeaderText="FIRST_NAME" SortExpression="FIRST_NAME" />
            <asp:BoundField DataField="OCCUPATION" HeaderText="OCCUPATION" SortExpression="OCCUPATION" />
            <asp:BoundField DataField="GROSS_SALARY" HeaderText="GROSS_SALARY" SortExpression="GROSS_SALARY" />
            <asp:BoundField DataField="GROSS_PRIZES" HeaderText="GROSS_PRIZES" SortExpression="GROSS_PRIZES" />
            <asp:BoundField DataField="GROSS_INCREASE" HeaderText="GROSS_INCREASE" SortExpression="GROSS_INCREASE" />
            <asp:BoundField DataField="DEDUCTIONS" HeaderText="DEDUCTIONS" SortExpression="DEDUCTIONS" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" 
        runat="server" 
        ConnectionString="<%$ ConnectionStrings:CipriConnString %>" 
        ProviderName="<%$ ConnectionStrings:CipriConnString.ProviderName %>" 
        SelectCommand="SELECT &quot;ID&quot;, &quot;SURNAME&quot;, &quot;FIRST_NAME&quot;, &quot;OCCUPATION&quot;, &quot;GROSS_SALARY&quot;, &quot;GROSS_PRIZES&quot;, &quot;GROSS_INCREASE&quot;, &quot;DEDUCTIONS&quot; FROM &quot;EMPLOYEES&quot;" 
        UpdateCommand="UPDATE &quot;EMPLOYEES&quot; SET &quot;SURNAME&quot; = :SURNAME, &quot;FIRST_NAME&quot; = :FIRST_NAME, &quot;GROSS_SALARY&quot; = :GROSS_SALARY, &quot;OCCUPATION&quot; = :OCCUPATION, &quot;GROSS_PRIZES&quot; = :GROSS_PRIZES, &quot;GROSS_INCREASE&quot; = :GROSS_INCREASE, &quot;DEDUCTIONS&quot; = :DEDUCTIONS WHERE &quot;ID&quot; = :ID">
        <UpdateParameters>
            <asp:Parameter Name="SURNAME" Type="String" />
            <asp:Parameter Name="FIRST_NAME" Type="String" />
            <asp:Parameter Name="GROSS_SALARY" Type="Decimal" />
            <asp:Parameter Name="OCCUPATION" Type="String" />
            <asp:Parameter Name="GROSS_PRIZES" Type="Decimal" />
            <asp:Parameter Name="GROSS_INCREASE" Type="Decimal" />
            <asp:Parameter Name="DEDUCTIONS" Type="Decimal" />
            <asp:Parameter Name="ID" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>