using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class User_Payment_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string selQry = "select * from tbl_cart c inner join tbl_newuser n on n.nu_id=c.nu_id where cart_id='"+Session["cartid"]+"'";
            DataTable dt = new DataTable();
            dt = obj.selCommand(selQry);
            lblMurchant.Text = Session["newfname"].ToString();
            lblDate.Text = txtdate.ToString();
            lblAmoubnt.Text = Session["amount"].ToString();
            lblTID.Text = GetISB();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strIsb = GetISB();

        //select query azhuthanam...

        string upQry = "update tbl_cart set payment_pin='" + lblTID.Text + "' ,payment_status='1' where cart_status='1' and nu_id='" + Session["newid"] + "' and cart_id='"+Session["cartID"]+"'";
        obj.ExcecuteCommand(upQry);


        //string upQry1 = "update tbl_cart set cart_status='1' where  payment_id='" + Session["paymentID"] + "' and nu_id='" + Session["newid"] + "'";
        //obj.ExcecuteCommand(upQry1);

        Session["amount"] = null; // or Session["amount"] = "";
        lblAmoubnt.Text = ""; // Clear the label text or reset it to an initial state
        Response.Redirect("~/User/HomePage.aspx");
    }
    private string GetISB()
    {
        string allowedChars = "";

        // allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
        allowedChars += "1,2,3,4,5,6,7,8,9,0";

        char[] sep = { ',' }; 
        string[] arr = allowedChars.Split(sep);

        string passwordString = "";

        string temp = "";

        Random rand = new Random();
        for (int i = 0; i < 4; i++)
        {
            temp = arr[rand.Next(0, arr.Length)];
            passwordString += temp;
        }
        return ("M-" + passwordString);

    }
}