using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class User_OfferPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_cart c inner join tbl_newuser n on c.nu_id=n.nu_id where cart_id='"+Session["cartid"]+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblMurchant.Text = Session["newfname"].ToString();
                lblDate.Text = dt.Rows[0]["payment_date"].ToString();
                lblAmoubnt.Text = Session["Total"].ToString();
                lblTID.Text = GetISB();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string upQry = "update tbl_cart set payment_pin='" + lblTID.Text + "',payment_status='1'  where cart_status='1' and cart_id='" + Session["cartid"] + "' and nu_id='" + Session["newid"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

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