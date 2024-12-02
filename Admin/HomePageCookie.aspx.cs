using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie requestcookie = Request.Cookies["login"];
        if (requestcookie != null)
        {
            lblmsg.Text = requestcookie["admin_name"].ToString();
        }
        else
        {
            Response.Redirect("../Geust/AdminLoginCookie.aspx");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Cookies.Remove("login");
       

        Response.Redirect("../Geust/AdminLoginCookie.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyProfileCookie.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditProfileCookie.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePasswordCookie.aspx");
    }
}