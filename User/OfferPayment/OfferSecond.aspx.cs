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
            string selQry = "select * from tbl_cart where cart_id='" + Session["cartid"] + "'and offer_id='" + Session["offerid"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lbl_Payto.Text = dt.Rows[0]["payment_toaccount"].ToString();
                lbl_Amount.Text = Session["Total"].ToString();
                lblCardNumber.Text = dt.Rows[0]["payment_fromaccount"].ToString();
                fillBill();
            }

            
        }
    }
    protected void fillBill()
    {
        string selQry1 = "select * from tbl_newuser where nu_id='" + Session["newid"] + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            txtName.Text = dt1.Rows[0]["nu_usern"].ToString();
            txtAddress.Text = dt1.Rows[0]["nu_address"].ToString();
            txtEmail.Text = dt1.Rows[0]["nu_email"].ToString();
            txtPhone.Text = dt1.Rows[0]["nu_phone"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string selQry1 = "select * from tbl_cart where cart_id='" + Session["cartid"] + "'and offer_id='" + Session["offerid"] + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            Session["productID"] = dt1.Rows[0]["product_id"].ToString();
            Session["cartStock"] = dt1.Rows[0]["cart_qty"].ToString();

        }
        string selQry2 = "select * from tbl_stock where product_id='" + Session["productID"] + "'";
        DataTable dtStock = new DataTable();
        SqlDataAdapter adpStock = new SqlDataAdapter(selQry2, con);
        adpStock.Fill(dtStock);
        if (dtStock.Rows.Count > 0)
        {
            Session["stockQty"] = dtStock.Rows[0]["stock_qty"].ToString();
        }

        int oldStock = Convert.ToInt32(Session["stockQty"].ToString());
        int cartStock = Convert.ToInt32(Session["cartStock"].ToString());

        int NewStock = oldStock - cartStock;


        string upQry1 = "update tbl_stock set stock_qty='" + NewStock + "' where product_id='" + Session["cartID"] + "'";
        SqlCommand cmd1 = new SqlCommand(upQry1, con);
        cmd1.ExecuteNonQuery();


        string upQry = "update tbl_cart set cart_status='1' where  nu_id='" + Session["newid"] + "' and  cart_status='0'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

        Response.Redirect("OfferThird.aspx");
    }
}