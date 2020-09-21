<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAfrica.Master" AutoEventWireup="true" CodeBehind="InscriptionPm.aspx.cs" Inherits="tp2.Inscription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class="container" id="inscrip">

       <asp:TextBox ID="TextBoxID" runat="server" ClientIDMode="Static" placeholder="Your ID"></asp:TextBox>
       <asp:TextBox ID="TextBoxPasswd"  runat="server" ClientIDMode="Static" placeholder="Your Password"></asp:TextBox>
       <asp:TextBox ID="TextBoxNom" runat="server" ClientIDMode="Static" placeholder="Your name.."></asp:TextBox>
       <asp:TextBox ID="TextBoxPrenom" runat="server" ClientIDMode="Static" placeholder="Your firstname.."></asp:TextBox>
       <asp:TextBox ID="TextBoxMail" runat="server"  ClientIDMode="Static" placeholder="Your Email.." 
            required pattern="[a-zA-Z0-9]+(\.|_|-)?[a-zA-Z0-9]+@outlook\.com"  title= "Please enter a valid email address[aaaaa@outlook.com]"></asp:TextBox>
       <asp:TextBox ID="TextBoxPhone" runat="server"  ClientIDMode="Static"  placeholder="Your Phone.."  
           required pattern="^(\(\d{3}\)) ?\d{3}-\d{4}"  title= "Please enter a valid phone [(000)000-000]" ></asp:TextBox>
      
         
     </div> 
          <asp:Button ID="save" runat="server" OnClick="save_Click" Text="Inscrire" />            
           <asp:Button ID="clear" runat="server" OnClick="clear_Click1" Text="Clear" />
   
</asp:Content>
