using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Introduction_4_Login_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        if ((txtusername.Text == "admin") && (txtpwd.Text == "123"))
        {
            HttpCookie myck = new HttpCookie("login");
            myck["lgname"] = txtusername.Text;
            myck["lgpwd"] = txtpwd.Text;
            Response.Cookies.Add(myck);


            Response.Redirect("Home.aspx");
        }
        else
        {
            lblmsg.Text = "invalid username or password...";
        }
    }
}