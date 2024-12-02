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
        if (!IsPostBack)
        {
            fillItem();
            
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_cart(product_id,cart_total,cart_qty,nu_id,sh_id)values('" + ddlitem.SelectedValue + "','" + txtprice.Text + "','" + txtqty.Text + "','" + Session["user"] + "','"+Session["saleshead"] +"')";
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
        GridView1.DataSource = dt;
        GridView1.DataBind();

        string selQry1 = "select sum(cart_total) as total from tbl_cart where nu_id='" + Session["user"] + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        if (dt1.Rows.Count > 0)
        {
           lbltotal.Text= dt1.Rows[0]["total"].ToString();
           Session["amount"] = lbltotal.Text;

        }
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
            string delQry = "delete from tbl_cart where cart_id='"+idno+"'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();

            fillGrid();
        }
    }
    protected void btncheckout_Click(object sender, EventArgs e)
    {
        string upQry = "update  tbl_cart set cart_status='1' ,sh_id='"+ Session["salesid"]+"' where nu_id='" + Session["user"] + "'and cart_status='0'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();



        string upQry1 = "update  tbl_saleshead set sh_grandtotal='" + Session["amount"] + "',sh_todate='" + DateTime.Now.ToShortDateString() + "' where nu_id='" + Session["user"] + "'";
        SqlCommand cmd1 = new SqlCommand(upQry1, con);
        cmd1.ExecuteNonQuery();
    }
}