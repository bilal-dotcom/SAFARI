using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp2
{
    public partial class SiteAfrica : System.Web.UI.MasterPage
    {
        public string menu1, menu2, menu3, menu1_title;
           

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