using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Sales_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if(!IsPostBack)
        {
            fillCustomer();
            fillItem();
        }

    }
    //protected void btnsubmit_Click1(object sender, EventArgs e)
    //{
    //    string insQry = "insert into tbl_saleshead(sh_invoice,sh_date,nu_id,sh_todate)values('" + txtinvoice.Text + "','" + txtdate.Text+ "','" + Session["user"] + "','" + DateTime.Now.ToShortDateString() + "')";
    //    SqlCommand cmd = new SqlCommand(insQry, con);
    //    cmd.ExecuteNonQuery();


    //    string selQry = "select max(sh_id) as saleshead from tbl_saleshead ";
    //    DataTable dt = new DataTable();
    //    SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
    //    adp.Fill(dt);
    //    if (dt.Rows.Count > 0)
    //    {
    //        Session["salesid"] = dt.Rows[0]["saleshead"].ToString();
    //    }
    //    //Response.Redirect("PurchaseItem.aspx");
    //    fillCustomer();

    //}
    protected void fillCustomer()
    {
        string selQry = "select * from tbl_newuser";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlcustomer.DataSource = dt;
        ddlcustomer.DataTextField = "nu_fname";
        ddlcustomer.DataValueField = "nu_id";
        ddlcustomer.DataBind();
        
    }
    //protected void btncancel_Click1(object sender, EventArgs e)
    //{
    //    txtinvoice.Text = "";
    //    ddlcustomer.ClearSelection();
    //    lbladdress.Text = "";
    //    lblcontact.Text = "";
    //}
    protected void ddlcustomer_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newuser where nu_id='" + ddlcustomer.SelectedValue + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbladdress.Text = dt.Rows[0]["nu_address"].ToString();
            lblcontact.Text = dt.Rows[0]["nu_phone"].ToString();
            Session["user"] = dt.Rows[0]["nu_id"].ToString();

        }
        con.Close();

    }


    //protected void ddlcustomer_SelectedIndexChanged1(object sender, EventArgs e)
    //{

    //}
    protected void btnadd_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_cart(product_id,cart_total,cart_qty,nu_id,sh_id)values('" + ddlitem.SelectedValue + "','" + txtprice.Text + "','" + txtqty.Text + "','" + Session["user"] + "','" + Session["saleshead"] + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();



        fillGrid();
    }
    protected void fillItem()
    {
        string selQry = "select * from tbl_product";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlitem.DataSource = dt;
        ddlitem.DataTextField = "product_Name";
        ddlitem.DataValueField = "product_id";
        ddlitem.DataBind();
    }
    protected void ddlitem_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_product where product_id='" + ddlitem.SelectedValue + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            txtprice.Text = dt.Rows[0]["product_price"].ToString();

        }
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_cart c  inner join tbl_product p on c.product_id=p.product_id  where nu_id='" + Session["user"] + "' and  c.cart_status='0'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["cartid"] = dt.Rows[0]["cart_id"].ToString();
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();

        string selQry1 = "select sum(cart_total) as total from tbl_cart where nu_id='" + Session["user"] + "' ";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        if (dt1.Rows.Count > 0)
        {
            lbltotal.Text = dt1.Rows[0]["total"].ToString();
            Session["price"] = lbltotal.Text;
           // ResetCartTotal();
        }
        //if (dt1.Rows.Count > 0)
        //{
        //    string upQry4 = "update  tbl_cart set cart_total='0'  where nu_id='" + Session["user"] + "'";
        //    SqlCommand cmd4 = new SqlCommand(upQry4, con);
        //    cmd4.ExecuteNonQuery();
        //    //lbltotal.Text = "0";
        //    //Session["amount"] = "0";
        //}
        
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
    }

    protected void txtqty_TextChanged(object sender, EventArgs e)
    {
        double total, p, c;
        p = Convert.ToInt32(txtprice.Text);
        c = Convert.ToInt32(txtqty.Text);
        total = p * c;

        txtprice.Text = total.ToString();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_cart where cart_id='" + idno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();

            fillGrid();
        }
    }
    protected void btncheckout_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_saleshead(sh_invoice,sh_date,nu_id,sh_todate)values('" + txtinvoice.Text + "','" + txtdate.Text + "','" + Session["user"] + "','" + DateTime.Now.ToShortDateString() + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();


        string selQry = "select max(sh_id) as saleshead from tbl_saleshead ";//maximum thil ninnu kuranju vanada data tharum
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["salesid"] = dt.Rows[0]["saleshead"].ToString();
        }
        //Response.Redirect("PurchaseItem.aspx");
        fillCustomer();


        string selQry1 = "select * from tbl_cart where cart_id='"+Session["cartid"]+"'";
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
         SqlDataAdapter adp2 = new SqlDataAdapter(selQry2, con);
         adp2.Fill(dtStock);
        if (dtStock.Rows.Count > 0)
        {
            Session["stockQty"] = dtStock.Rows[0]["stock_qty"].ToString();
        }

        int oldStock = Convert.ToInt32(Session["stockQty"].ToString());
        int cartStock = Convert.ToInt32(Session["cartStock"].ToString());

        int NewStock = oldStock - cartStock;

         

        if (dtStock.Rows.Count > 0)
        {

            string upQry1 = "update tbl_stock set stock_qty='" + NewStock + "' where product_id='" + Session["productID"] + "'";
            SqlCommand cmd1 = new SqlCommand(upQry1, con);
            cmd1.ExecuteNonQuery();
        }
        else
        {
            string insQry1 = "insert into tbl_stock(stock_qty,product_id)values('" + txtqty.Text + "','" + Session["productID"] + "')";
            SqlCommand cmd1 = new SqlCommand(insQry1, con);
            cmd1.ExecuteNonQuery();

            lblmsg.Text = "missed item is inserted add its total qty";
            Response.Redirect("../Product/Stock.aspx");
        }
        //if (dt1.Rows.Count > 0)
        //{
        //    string upQry4 = "update from tbl_cart set cart_total='0'  where nu_id='" + Session["user"] + "'";
        //    SqlCommand cmd4 = new SqlCommand(upQry4, con);
        //    cmd4.ExecuteNonQuery();
        //    lbltotal.Text = "0";
        //    Session["amount"] = "0";
        //}
        

        string upQry2 = "update  tbl_cart set cart_status='1' ,sh_id='" + Session["salesid"] + "' where nu_id='" + Session["user"] + "'and cart_status='0'";
        SqlCommand cmd2 = new SqlCommand(upQry2, con);
        cmd2.ExecuteNonQuery();



        string upQry3 = "update  tbl_saleshead set sh_grandtotal='" + Session["amount"] + "',sh_todate='" + DateTime.Now.ToShortDateString() + "' where nu_id='" + Session["user"] + "'";
        SqlCommand cmd3 = new SqlCommand(upQry3, con);
        cmd3.ExecuteNonQuery();


        ResetTotal();
        
        
    }

    protected void ResetTotal()
    {
        Session["price"] = null; 
    }
}
