using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace tp2
{
    public partial class LoginPm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            userDataContext db = new userDataContext();

          
            HttpCookie cookie = new HttpCookie("userInfo");



            login temps = (from u in db.logins
                                 where u.id == TextBoxID.Text.Trim() && u.password == TextBoxPasswd.Text.Trim()
                                 select u).SingleOrDefault<login>();

            if (temps != null)
            {
                cookie.Values.Add("nom", temps.id);
                cookie.Expires = DateTime.Now.AddDays(3);
                Response.Cookies.Add(cookie);
                Response.Redirect("AdminPm.aspx");
            }
            else
            {
                Response.Write("<script>alert('Bad login informations');</script>");
            }


        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPm.aspx"); 

        }
    }
}