using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

using System.Net.Mail;

public partial class User_Default : System.Web.UI.Page
{
    SqlConnection con= new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    string pass;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string selQry = "select *  from tbl_newuser where nu_usern='" + txtusername.Text + "' ";

        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            pass = dt.Rows[0]["nu_pwd"].ToString();
        }
        Mail();
    }
    private void Mail()
    {
        string selEmail = "select nu_email from tbl_newuser where nu_usern='" + txtusername.Text + "'";
        DataTable dtEmail = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selEmail, con);
        adp.Fill(dtEmail);
        string EmailID = "athulyapradeep2004@gmail.com";
        if (dtEmail.Rows.Count > 0)
        {
            EmailID = dtEmail.Rows[0]["nu_email"].ToString();

            ////Email Sendind Code

            MailMessage mail = new MailMessage();
            mail.To.Add(EmailID);
            mail.From = new MailAddress("onlinesaless12333@gmail.com");
            mail.Subject = "Registration Confirmation!!";

            string Body = "Your registration is confirmed and you  have to report with all documents at \r\n " + pass;
            mail.Body = Body;

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("onlinesaless12333@gmail.com", "viadwulavzipkqip");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            lblmsg.Text = "Password send to u r mail...";
        }

    }
    
}