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
        lblmsg.Text = Session["adminname"].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("District.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyProfile.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditProfile.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Place.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePassword.aspx");
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminRegistration.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewClubList.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserlistBYLiterals.aspx");
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        Response.Redirect("MatchSchedule.aspx");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplicationView.aspx");
    }

    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewComplaint.aspx");
    }
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewFeedBack.aspx");
    }
    protected void LinkButton18_Click(object sender, EventArgs e)
    {
        Response.Redirect("AcceptList.aspx");
    }
    protected void LinkButton19_Click(object sender, EventArgs e)
    {
        Response.Redirect("RejectList.aspx");
    }
    protected void LinkButton20_Click(object sender, EventArgs e)
    {
        Response.Redirect("SolvedStatus.aspx");
    }
    protected void LinkButton21_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentOrder.aspx");
    }
    protected void LinkButton22_Click(object sender, EventArgs e)
    {
        Response.Redirect("OfferPaymentOrder.aspx");
    }
    protected void LinkButton23_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewNewsUpload.aspx");
    }
    protected void LinkButton24_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewUserlist.aspx");
    }
    protected void LinkButton25_Click(object sender, EventArgs e)
    {
        Response.Redirect("Category.aspx");
    }
}