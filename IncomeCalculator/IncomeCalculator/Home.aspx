<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="IncomeCalculator.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Instructions</h2>
    <h3>The home page provides basic instructions on how to use this website</h3>
    <h3>The header is updated using AJAX and it displays the current time and 2 adds which interchange each 10 seconds</h3>
    <h3>The Add Employees menu contains 3 submenus</h3>
    <ul>
        <li>
            <h4>The Add New Employees menu allows the user to introduce a new employee to the website's database</h4>
        </li>
        <li>
            <h4>The Update Employees menu allows the user to update the current entries in the database that describe the employee's salary slip</h4>
        </li>
        <li>
            <h4>The Delete Employees menu allows the user to delete an employee entry from the database</h4>
        </li>
    </ul>    
    <h3>The Add Reports menu contains 2 submenus</h3>
    <ul>
        <li>
            <h4>The Payroll menu includes information about the current costs of running the business</h4>
        </li>
        <li>
            <h4>The Salary Slips menu includes detailed information about each employee's payment</h4>
        </li>
    </ul>    
    <h3>The Percentages menu allows the user to modify the tax percentages in case of a tax change imposed by the government in which the business deploys it's activity</h3>
</asp:Content>
