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
        lblmsg.Text = Session["newfname"].ToString();
    }
    

    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("MyProfile.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditProfile.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePassword.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewPlayer.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ScheduleList.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewSchedule.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("PostComplaint.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("PostFeedback.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewSyllabus.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewProductDetails.aspx");
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewOfferDetails.aspx");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewComplaintReplay.aspx");
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddToCart.aspx");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewCartDetails.aspx");
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentOrder.aspx");
    }
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewDeliveryStatus.aspx");
    }
    protected void LinkButton18_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewOfferCartDetails.aspx");
    }
    protected void LinkButton19_Click(object sender, EventArgs e)
    {
        Response.Redirect("OfferPaymentOrder.aspx");
    }
    protected void LinkButton20_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewOfferDeliveryStatus.aspx");
    }
   
    protected void LinkButton22_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewWishList.aspx");
    }
    protected void LinkButton23_Click(object sender, EventArgs e)
    {
        Response.Redirect("Chat.aspx");
    }
    protected void LinkButton24_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmailSend.aspx");
    }
    protected void LinkButton25_Click(object sender, EventArgs e)
    {
        Response.Redirect("SendSMS.aspx");
    }
}