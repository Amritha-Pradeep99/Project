using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Introduction_4_Login_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            HttpCookie reqcookie = Request.Cookies["login"];
            if (reqcookie != null)
            {

                lblwelcome.Text = reqcookie["lgname"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
      
    }
    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        //Response.Cookies.Clear();    clear all cookies
        //Request.Cookies.Clear();     clear all cookies

        Response.Cookies.Remove("login");
        Request.Cookies.Remove("login");



        Response.Redirect("Login.aspx");
    }
}