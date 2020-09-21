<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAfrica.Master" AutoEventWireup="true" CodeBehind="LoginPm.aspx.cs" Inherits="tp2.LoginPm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <asp:TextBox ID="TextBoxID" runat="server" ClientIDMode="Static" placeholder="Your ID"></asp:TextBox>
       <asp:TextBox ID="TextBoxPasswd"  runat="server" ClientIDMode="Static" placeholder="Your Password"></asp:TextBox>

            <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="Se Connecter" />            
           <asp:Button ID="Reset" runat="server" OnClick="Reset_Click" Text="Clear" />
</asp:Content>
