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
    public partial class Inscription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Chaine de connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True");


        }

        int Insert()
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fikar\source\repos\Session 4\TP2\tp2_part2\tp2\App_Data\Database1.mdf;Integrated Security=True"))
            {
                con.Open();

                String CommandeSql = "INSERT INTO [client] (id,passwd,nom,prenom,telephone,email) VALUES (@column1,@column2,@column3,@column4,@column5,@column6)";
                SqlCommand commande = new SqlCommand(CommandeSql, con);


                String id = TextBoxID.Text;
                commande.Parameters.AddWithValue("column1", id);
                String passwd = TextBoxPasswd.Text;
                commande.Parameters.AddWithValue("column2", passwd);
                String nom = TextBoxNom.Text;
                commande.Parameters.AddWithValue("column3", nom);
                String prenom = TextBoxPrenom.Text;
                commande.Parameters.AddWithValue("column4", prenom);
                String telephone = TextBoxPhone.Text;
                commande.Parameters.AddWithValue("column5", telephone);
                String email = TextBoxMail.Text;
                commande.Parameters.AddWithValue("column6", email);

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
                String texttt = "Bonjour Bienvenue sur notre agence de voyage,SAFARI." + "Merci d'avoir completer votre inscription";
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);
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

        protected void clear_Click1(object sender, EventArgs e)
        {
            Response.Redirect("InscriptionPm.aspx");
        }

        protected void save_Click(object sender, EventArgs e)
        {

            String sujettt = "Validation d'inscription ";
            String msg = "Bonjour Bienvenue sur notre agence de voyage,SAFARI." + "Merci d'avoir completer votre inscription. ";

            if (sendMail(new Email { To = TextBoxMail.Text, Subject = sujettt, Message = msg }))
            {
                Insert();
                Response.Write("<script>alert('Votre inscription est completer avec succes')</script>");

            }
            else
            {
                Response.Write("<script>alert('Erreur d'envoi')</script>");
            }
        }
    }
}