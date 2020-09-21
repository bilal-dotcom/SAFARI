using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;


namespace tp2
{

    public partial class ContactPm : System.Web.UI.Page
    {
        public string address, address_code,phone,phone_code,email,email_code,information,information_code,name1,email1,phone1,message1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Chaine de connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True");

            try
            {
                SqlCommand cmd = new SqlCommand("select * from contact where id=1", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    address = reader["address"].ToString();
                    address_code = reader["address_code"].ToString();
                    phone = reader["phone"].ToString();
                    phone_code = reader["phone_code"].ToString();
                    email = reader["email"].ToString();
                    email_code = reader["email_code"].ToString();
                    information = reader["information"].ToString();
                    information_code = reader["information_code"].ToString();
                    name1 = reader["address"].ToString();
                    email1 = reader["address"].ToString();
                    phone1 = reader["address"].ToString();
                    message1 = reader["address"].ToString();


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

        protected void btnSave_Click(object sender, EventArgs e)
        {
          
            if (sendMail(new Email { To = TextBoxMail.Text, Subject = TextBoxSujet.Text, Message = TextBoxMsg.Text }))
            {
               Insert();
                Response.Write("<script>alert('Votre email est envoyer avec succes')</script>");
             
            }
            else
            {
                Response.Write("<script>alert('Erreur d'envoi')</script>");
            }

        }
        int Insert()
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True"))
            {
                con.Open();

                String CommandeSql = "INSERT INTO [Infocontact] (nom,email,phone,message) VALUES (@column1,@column2,@column3,@column4)";
                SqlCommand commande = new SqlCommand(CommandeSql, con);


               String name = TextBoxNom.Text;
                commande.Parameters.AddWithValue("column1", name);
                String phone = TextBoxPhone.Text;
                commande.Parameters.AddWithValue("column3", phone);
                String mail = TextBoxMail.Text;
                commande.Parameters.AddWithValue("column2", mail);
                String sujet = TextBoxSujet.Text;
                commande.Parameters.AddWithValue("column4", sujet);


                return commande.ExecuteNonQuery();
            }
        }

        private bool sendMail(Email email)
        {
            bool status = false;
            try
            {
                string MailSender = "BilalFikara@teccart.online";
                string MailPw = "MOTDEpasse.2019";
                String texttt = "Bonjour Bienvenue sur notre agence de voyage,SAFARI." + "</br> Diffents voyages vous sont offerts." +
                "Vous pouvez passez un weekend de reve.Plusieurs voyahes vous sont offerts";
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com",587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 100000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(MailSender, MailPw);

                MailMessage mailMessage = new MailMessage(MailSender, email.To, email.Subject, texttt);
                // mailMessage.IsBodyHtml = true;
                mailMessage.BodyEncoding = System.Text.UTF8Encoding.UTF8;

                smtpClient.Send(mailMessage);

                status = true;
                return status; 

            }
            catch (Exception ex)
            {
                return status;
            }
        }

        protected void btnClr_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactPm.aspx");

        }
    }
}