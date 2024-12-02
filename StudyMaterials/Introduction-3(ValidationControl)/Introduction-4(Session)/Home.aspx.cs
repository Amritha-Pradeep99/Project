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

        if (Session["lgname"] != null)
        {
            lblwelcome.Text = Session["lgname"].ToString();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        Session["lgname"] = null;
        Response.Redirect("Login.aspx");
    }
}