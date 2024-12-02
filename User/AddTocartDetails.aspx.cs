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
            string selQry = "select * from tbl_product where product_id='" + Session["pid"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtproduct.Text = dt.Rows[0]["product_Name"].ToString();
            txtprice.Text = dt.Rows[0]["product_price"].ToString();
            txtunit.Text = dt.Rows[0]["product_unit"].ToString();
            

        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        double total,p,c;
        p = Convert.ToInt32(txtprice.Text);
        c = Convert.ToInt32(txtcartqty.Text);
        total = p * c;

        txtcarttotal.Text = total.ToString();

        

        


        string selQry1 = "select * from tbl_cart where nu_id='" + Session["newid"] + "' and product_id='" + Session["pid"] + "' ";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            Session["cartID"] = dt1.Rows[0]["cart_id"].ToString();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx"); 
    }
    
    protected void btnlist_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_cart(cart_qty,cart_total,nu_id,product_id,cart_status,delivery_status)values('" + txtcartqty.Text + "' ,'" + txtcarttotal.Text + "','" + Session["newid"] + "','" + Session["pid"] + "','0','0') ";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
    }
    protected void btncontinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddtoCart.aspx"); 
    }
}