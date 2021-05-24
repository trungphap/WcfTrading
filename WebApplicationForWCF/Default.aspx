<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationForWCF._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET for WCF</h1>
    </div>

    <div class="row">
        <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <asp:Button ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click" />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </div>
    <br />
    <br />
    <div class="row">
        <asp:Button ID="GetCommand" runat="server" Text="Get Command" OnClick="ButtonCmd_Click" />

        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </div>

</asp:Content>
