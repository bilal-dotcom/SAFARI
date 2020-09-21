using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp2
{
    public partial class HomePm : System.Web.UI.Page
    {

        public string menu1, menu2, menu3, menu1_title, back_image, back_image_title, title1, title2, title3, img1, img2, img3,
           text_img1, text_img2, text_img3;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Chaine de connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2\tp2\App_Data\Database1.mdf;Integrated Security=True");

            try
            {
                SqlCommand cmd = new SqlCommand("select * from home where id=1", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    menu1 = reader["menu1"].ToString();
                    menu2 = reader["menu2"].ToString();
                    menu3 = reader["menu3"].ToString();
                    menu1_title = reader["menu1_title"].ToString();
                    back_image = reader["back_image"].ToString();
                    back_image_title = reader["back_image_title"].ToString();
                    title1 = reader["title1"].ToString();
                    title2 = reader["title2"].ToString();
                    title3 = reader["title3"].ToString();
                    img1 = reader["img1"].ToString();
                    img2 = reader["img2"].ToString();
                    img3 = reader["img3"].ToString();
                    text_img1 = reader["text_img1"].ToString();
                    text_img2 = reader["text_img2"].ToString();
                    text_img3 = reader["text_img3"].ToString();

                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                con.Close();
            }
        
        }
    }
}