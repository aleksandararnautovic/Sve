<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebPresentationLayer.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1>Prvi KLK sa vezbi</h1>
    <p>
        <asp:ListBox ID="listBox1" runat="server" Width="516px"></asp:ListBox>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" Width="122px" OnClick="Button1_Click" />
    </p>
    <p>&nbsp;</p>
</asp:Content>

