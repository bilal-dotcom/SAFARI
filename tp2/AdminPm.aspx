<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAfrica.Master" AutoEventWireup="true" CodeBehind="AdminPm.aspx.cs" Inherits="tp2.LoginAdminPm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .alert-success {}
    </style>
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  

<%--    <h1>Movies</h1>
    <div>
    @grid.GetHtml()
    </div>--%>

     <asp:TextBox ID="TextBoxId" runat="server" ClientIDMode="Static" placeholder="Your ID"></asp:TextBox>
        <asp:TextBox ID="TextBoxTitree" runat="server" ClientIDMode="Static" placeholder="Your Title"></asp:TextBox>
          <asp:TextBox ID="TextBoxDescription" runat="server" ClientIDMode="Static" placeholder="Your Description"></asp:TextBox>
          <asp:TextBox ID="TextBoxPrix" runat="server" ClientIDMode="Static" placeholder="Your Prix"></asp:TextBox>

           <%--<input type="file" id="File1" name="File1" runat="server" />--%>
            <br>
     
        <div>
            <div style="float:left">
                <asp:FileUpload id="FileUploadControl"  runat="server" />

                <asp:Button ID="Button1" runat="server" Onclick="Button1_Click1" Text="Inscrire" />
                  <asp:Button ID="btnUpdate" runat="server"  Onclick="btnUpdate_Click" Text="Update" />
                  <asp:Button ID="btnDelete" runat="server" Onclick="btnDelete_Click" Text="Delete" />
            </div>
            <div>
                 <asp:Image ID="Image1" runat="server" height="152px" Width="299px"/>
             </div>
        </div>
            <%--   Afficher les voyages depuis la BDA--%>

          <asp:SqlDataSource 
              ID="SqlDataSource1"
              runat="server" 
              ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
              SelectCommand="SELECT * FROM [voyage2]">
             
          </asp:SqlDataSource> 


      
        <asp:GridView  ID="GridView1" ShowFooter="True" runat="server" CssClass="alert-success" Width="552px" Height="200px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderType="radius" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" PageSize="5" ShowHeaderWhenEmpty="True" >
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>               
                    <asp:BoundField DataField="titre" HeaderText="Titre" SortExpression="titre" />
                    <asp:BoundField DataField="desription" HeaderText="Description" SortExpression="description" />
                    <asp:BoundField DataField="prix" HeaderText="Prix" SortExpression="prix" />
                    <asp:BoundField DataField="photo" HeaderText="Photo" SortExpression="photo" />
                     <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Gray" />
                <HeaderStyle BackColor="#00000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="Gray" />
                <SortedAscendingCellStyle BackColor="#CCCCC" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            
            </asp:GridView>

 
    
</asp:Content>
