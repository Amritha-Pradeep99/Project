using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class User_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_offer  where product_id='" + Session["productid"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtoffer.Text = dt.Rows[0]["offer_name"].ToString();
            txtofferprice.Text = dt.Rows[0]["offer_price"].ToString();
            if (dt.Rows.Count > 0)
            {
                Session["offerid"] = dt.Rows[0]["offer_id"].ToString();
            }
           
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        double total,p, q;
        p = Convert.ToInt32(txtofferprice.Text);
        q = Convert.ToInt32(txtcartqty.Text);
        total = p * q;
        txttotal.Text = total.ToString();

        //string insQry = "insert into tbl_cart(cart_qty,cart_total,nu_id,product_id,cart_status,offer_id,delivery_status)values('" + txtcartqty.Text + "','" + txttotal.Text + "','" + Session["newid"] + "','" + Session["productid"] + "','0','" + Session["offerid"] + "','0')";
        //SqlCommand cmd = new SqlCommand(insQry, con);
        //cmd.ExecuteNonQuery();

        //Response.Redirect("ViewOfferCartDetails.aspx"); 
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    
    protected void btnpay_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_cart(cart_qty,cart_total,nu_id,product_id,cart_status,offer_id,delivery_status,payment_status)values('" + txtcartqty.Text + "','" + txttotal.Text + "','" + Session["newid"] + "','" + Session["productid"] + "','0','" + Session["offerid"] + "','0','0')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewOfferDetails.aspx");
    }
}