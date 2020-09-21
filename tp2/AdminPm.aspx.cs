using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

using System.Web.Helpers;

namespace tp2
{
    public partial class LoginAdminPm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Chaine de connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True");
            
        }

          //Pour faire le upload et l'incription du voyage
        protected void Button1_Click1(object sender, EventArgs e)
        {
            String varid = TextBoxId.Text;
            String vartitre = TextBoxTitree.Text;
            String vardescription = TextBoxDescription.Text;
            String varprix = TextBoxPrix.Text;
            String varphoto = "";

            if(Page.IsPostBack)
            {
                bool fileOK = false;
                String path = Server.MapPath("~/img/");

                if (FileUploadControl.HasFile)
                {
                    String fileExtension = System.IO.Path.GetExtension(FileUploadControl.FileName).ToLower();
                    String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };

                    for (int i =0;i<allowedExtensions.Length;i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                            fileOK = true;
                    }

                }

                if(fileOK)
                {
                    try
                    {
                        FileUploadControl.PostedFile.SaveAs(path + FileUploadControl.FileName);
                        Image1.ImageUrl = "~/img/" + FileUploadControl.FileName;
                        varphoto = "~/img/" + FileUploadControl.FileName;

                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True");

                        SqlCommand cmd = new SqlCommand("INSERT INTO [voyage2] (titre,desription,prix,photo,id) VALUES ('" + vartitre + "', '" + vardescription + "','" +varprix + "','" + varphoto + "','" + varid +"')");

                        //SqlCommand cmd = new SqlCommand("delete from voyage");

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        Response.Write("<script>alert('Votre insertion est completer avec succes')</script>");

                    }
                    catch (Exception ex)
                    {
                     
                    }
                }
                else
                {
                    Response.Write("<script>alert('Erreur d'upload de la photo')</script>");
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            String varid = TextBoxId.Text;
          
            try
            {
        
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True");
                
                SqlCommand cmd = new SqlCommand("Delete From voyage2 Where id=' + varid +' ");

             
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Votre suppression est completer avec succes')</script>");

      

            }
            catch (Exception ex)
            {

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String varid = TextBoxId.Text;
                String vartitre = TextBoxTitree.Text;
                String vardescription = TextBoxDescription.Text;
                String varprix = TextBoxPrix.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("UPDATE [voyage2] SET titre='" + vartitre + "',desription='" + vardescription + "',prix='" + varprix + "' WHERE id="+varid);

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Votre Modification est completer avec succes')</script>");

            }
            catch (Exception ex)
            {

            }
        }
    }

}