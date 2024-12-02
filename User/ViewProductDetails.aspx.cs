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
    //SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        //con.Open();
        if (!IsPostBack)
        {
            fillCategory();
        }
    }
    protected void fillCategory()
    {

        string selQry = "select * from tbl_category";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //blproduct.DataSource = dt;
        //blproduct.DataTextField = "ct_name";
        //blproduct.DataValueField = "ct_id";
        //blproduct.DataBind();
        obj.fillBulletedList(blproduct, "ct_name", "ct_id", selQry);
    }
    protected void blproduct_Click(object sender, BulletedListEventArgs e)
    {
        ListItem li = blproduct.Items[e.Index];
        lblmsg.Text = "youselected=" + li.Text + "with value=" + li.Value + "index=" + e.Index.ToString();
        string selQry = "select * from tbl_product  p inner join tbl_subcategory s on p.subcategory_id=s.subcategory_id  inner join tbl_category c on c.ct_id=s.ct_id where s.ct_id='" + li.Value + "'";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);

        //GridView1.DataSource = dt;
        //GridView1.DataBind();

        //DataList1.DataSource = dt;
        //DataList1.DataBind();

        //Repeater1.DataSource = dt;
        //Repeater1.DataBind();
        obj.fillGrid(selQry, GridView1);
        obj.fillGrid(selQry, DataList1);
        obj.fillGrid(selQry, Repeater1);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "wish")
        {
            int toid = Convert.ToInt32(e.CommandArgument.ToString());
            int fromid = Convert.ToInt32(Session["newid"].ToString());
            string selQry = "select * from tbl_wishlist where product_id='" + toid + "' and nu_id='"+fromid+"'";
            DataTable dt = new DataTable();
            dt = obj.selCommand(selQry);
            if (dt.Rows.Count > 0)
            {
                string upQry = "update tbl_wishlist set wishlist_date='" + DateTime.Now.ToShortDateString() + "' where product_id='" + toid + "' and nu_id='" + fromid + "'";
                obj.ExcecuteCommand(upQry);

                Response.Write("<script>alert('wishlisted')</script>");
            }
            else
            {
                string insQry = "insert into tbl_wishlist(product_id,nu_id,wishlist_date)values('"+toid+"','"+fromid+"','"+ DateTime.Now.ToShortDateString()+"')";
                obj.ExcecuteCommand(insQry);
            }
           
        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int toid = Convert.ToInt32(e.CommandArgument.ToString());
        int fromid = Convert.ToInt32(Session["newid"].ToString());
        string selQry = "select * from tbl_wishlist where product_id='" + toid + "' and nu_id='" + fromid + "'";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        if (dt.Rows.Count > 0)
        {
            string upQry = "update tbl_wishlist set wishlist_date='" + DateTime.Now.ToShortDateString() + "' where product_id='" + toid + "' and nu_id='" + fromid + "'";
            obj.ExcecuteCommand(upQry);

            Response.Write("<script>alert('wishlisted')</script>");
        }
        else
        {
            string insQry = "insert into tbl_wishlist(product_id,nu_id,wishlist_date)values('" + toid + "','" + fromid + "','" + DateTime.Now.ToShortDateString() + "')";
            obj.ExcecuteCommand(insQry);
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int toid = Convert.ToInt32(e.CommandArgument.ToString());
        int fromid = Convert.ToInt32(Session["newid"].ToString());
        string selQry = "select * from tbl_wishlist where product_id='" + toid + "' and nu_id='" + fromid + "'";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        if (dt.Rows.Count > 0)
        {
            string upQry = "update tbl_wishlist set wishlist_date='" + DateTime.Now.ToShortDateString() + "' where product_id='" + toid + "' and nu_id='" + fromid + "'";
            obj.ExcecuteCommand(upQry);

            Response.Write("<script>alert('wishlisted')</script>");
        }
        else
        {
            string insQry = "insert into tbl_wishlist(product_id,nu_id,wishlist_date)values('" + toid + "','" + fromid + "','" + DateTime.Now.ToShortDateString() + "')";
            obj.ExcecuteCommand(insQry);
        }
    }
}