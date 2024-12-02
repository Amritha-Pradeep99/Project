using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie reqcookie = Request.Cookies["userlogin"];
        if (reqcookie != null)
        {
            lblmsg.Text = reqcookie["nu_fname"].ToString(); 
            lbltext.Text= reqcookie["nu_lname"].ToString();
           
        }
        else
        {
            Response.Redirect("../NewUserStoredProcedure/UserLogin.aspx");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Cookies.Remove("userlogin");


        Response.Redirect("../NewUserStoredProcedure/UserLogin.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("../NewUserStoredProcedure/MyProfile.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("../NewUserStoredProcedure/EditProfile.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("../NewUserStoredProcedure/ChangePassword.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductGallery.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewUserBlink.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserLogin.aspx");
    }
}