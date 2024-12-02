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
            fillGrid();
        }
    }
    protected void fillGrid()
    {
        String selQry = "select * from tbl_cart c inner join tbl_product p on c.product_id=p.product_id inner join tbl_subcategory s on s.subcategory_id=p.subcategory_id inner join tbl_category ca on ca.ct_id=s.ct_id inner join tbl_offer f on f.offer_id=c.offer_id where nu_id='" + Session["newid"] + "'  and c.cart_status='0'  ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

        string selQry1 = "select sum(cart_total) as total from tbl_cart where nu_id='" + Session["newid"] + "'  and cart_status='0'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        if (dt1.Rows.Count > 0)
        {
            lbltotal.Text = dt1.Rows[0]["total"].ToString();
            Session["Total"] = lbltotal.Text;

        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName == "pay")
        //{

        //    Session["cartid"] = e.CommandArgument.ToString();
        //    string selQry = "select * from tbl_cart where cart_id='" + Session["cartid"] + "'";
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //    adp.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        Session["productID"] = dt.Rows[0]["product_id"].ToString();
        //        Session["cartStock"] = dt.Rows[0]["cart_qty"].ToString();
        //    }

        //    string selQry1 = "select * from tbl_stock where product_id='" + Session["productID"] + "'";
        //    DataTable dtStock = new DataTable();
        //    SqlDataAdapter adpStock = new SqlDataAdapter(selQry1, con);
        //    adpStock.Fill(dtStock);
        //    if (dtStock.Rows.Count > 0)
        //    {
        //        Session["stockQty"] = dtStock.Rows[0]["stock_qty"].ToString();
        //    }

        //    int NewStock = Convert.ToInt32(Session["stockQty"].ToString()) - Convert.ToInt32(Session["cartStock"].ToString());

        //    string upQry1 = "update tbl_stock set stock_qty='" + NewStock + "' where product_id='" + Session["cartid"] + "'";
        //    SqlCommand cmd1 = new SqlCommand(upQry1, con);
        //    cmd1.ExecuteNonQuery();
        //    string upQry = "update tbl_cart set cart_status='1' where cart_id='" + Session["cartid"] + "'";
        //    SqlCommand cmd = new SqlCommand(upQry, con);
        //    cmd.ExecuteNonQuery();


        //    Response.Redirect("Paynow.aspx");
        //}
        if (e.CommandName == "ed")
        {
            Session["cartid"] = e.CommandArgument.ToString();
            Response.Redirect("OfferEditQty.aspx");
        }
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete tbl_cart where cart_id='"+idno+"'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();



            fillGrid();
        }
    }
    protected void btncheckout_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_cart  where   nu_id='" + Session["newid"] + "' and cart_status='0'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);


        string upQry = "update tbl_cart set cart_status='1' where nu_id='" + Session["newid"] + "' and cart_status='0'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

        try
        {
            //Session["fname"] = dt.Rows[0]["name"].ToString();

            Response.Redirect("../User/OfferPayment/OfferFirst.aspx");

        }
        catch (Exception)
        { }
       
       // Response.Redirect("OfferFirst.aspx");
    }
    protected void btncontinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewOfferDetails.aspx");
    }
}