<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAfrica.Master" AutoEventWireup="true" CodeBehind="ContactPm.aspx.cs" Inherits="tp2.ContactPm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <div id="box">
 
        <div id="box1">

            <h3> <%=address %></h3>
            <ul class="address">
                <i class="fa fa-home icon"><li> <%=address_code %></li></i>
            </ul>

            <h3> <%=phone %></h3>
            <ul class="phone">
              <i class="fa fa-phone icon">  <li> <%=phone_code %></li></i>
           <%--  --%>
            </ul>

            <h3> <%=email %></h3>
            <ul class="email">
              <i class="fa fa-envelope icon"> <li> <%=email_code %></li></i>
            </ul>
        </div>    
            

        <div id="box2">
            <h3 class=""> <%=information %></h3>
             <%=information_code %>

             <div id="txt">
                  
                 <asp:TextBox ID="TextBoxNom" runat="server" ClientIDMode="Static" placeholder="Your name.."></asp:TextBox>
                 <asp:TextBox ID="TextBoxMail" runat="server"  ClientIDMode="Static" placeholder="Your Email.." 
                 required pattern="[a-zA-Z0-9]+(\.|_|-)?[a-zA-Z0-9]+@outlook\.com" title = "Please enter a valid email address[aaaaa@outlook.com]"></asp:TextBox>

                  <asp:TextBox ID="TextBoxPhone" runat="server"  ClientIDMode="Static"  placeholder="Your Phone.."  
                      required pattern="^(\(\d{3}\)) ?\d{3}-\d{4}" title = "Please enter a valid phone [(000)000-000]" ></asp:TextBox>

                 <asp:TextBox ID="TextBoxSujet" runat="server"  ClientIDMode="Static" placeholder="Your Subject.."></asp:TextBox>
                  <asp:TextBox ID="TextBoxMsg" runat="server"  ClientIDMode="Static" placeholder="Your Message.."></asp:TextBox>
           
            </div>
            
                  <asp:Button ID="save" runat="server" Onclick="btnSave_Click" Text="Save" />
                  <asp:Button ID="clr" runat="server"  OnClick="btnClr_Click" Text="Clear" />
          
     

        </div>

    </div>
    

      <script src="jq/jquery-3.1.1.min.js"></script>
        <script src="jq/DemoJQ.js"></script> 


</asp:Content>
