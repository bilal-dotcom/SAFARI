<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAfrica.Master" AutoEventWireup="true" CodeBehind="HomePm.aspx.cs" Inherits="tp2.HomePm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div id="part1" style="background-image:url('img/img7.jpg')" >


            <p id="back_image_title">
                <span id="text_back_image_title">  <%=back_image_title %> </span>
            </p>
            
       </div>

        <div id ="div3"  >

            <div class="bloc">

                <div class="titre">
                  <%=title1 %> 
                </div>

                <a/ href="/InscriptionPm.aspx">    <div class="back" style="background-image:url('img/img1.jpg')">
                
                </div> </a>
                <div class="text"> 
                <%=text_img1 %> 

                </div>

            </div>

            <div class="bloc">

                <div class="titre">
                 <%=title2 %> 
                </div>
               <a/ href="/InscriptionPm.aspx">   <div class="back" style="background-image:url('img/img2.jpg')" >
                
                </div> </a>
                <div class="text">
                  <%=text_img2 %> 
                </div>

            </div>

            <div class="bloc">
                
                <div class="titre">
                <%=title3 %> 
                </div>
                <a/ href="/InscriptionPm.aspx">   <div class="back" style="background-image:url('img/img8.jpg')" >
                
                </div>  </a>
                <div class="text">
                <%=text_img3 %>
                </div>

            </div>

            <br />

           </div>
    
</asp:Content>
