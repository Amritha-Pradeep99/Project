using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie reqcookie = Request.Cookies["newuserlogin"];
        if (reqcookie != null)
        {
            lblmsg.Text = reqcookie["nu_fname"].ToString();
        }
        else
        {
            Response.Redirect("../Geust/NewUserLoginCookie.aspx");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Cookies.Remove("newuserlogin");


        Response.Redirect("../Geust/NewUserLoginCookie.aspx");
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