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
        //bloffer.DataSource=dt;
        //bloffer.DataTextField = "ct_name";
        //bloffer.DataValueField = "ct_id";
        //bloffer.DataBind();
        obj.fillBulletedList(bloffer, "ct_name", "ct_id", selQry);
    }

    protected void bloffer_Click(object sender, BulletedListEventArgs e)
    {
        ListItem li = bloffer.Items[e.Index];
        lblmsg.Text = "You selected=" + li.Text + "with name=" + li.Value + "index=" + e.Index.ToString();
        string selQry = "select * from tbl_offer f inner join tbl_product p on f.product_id=p.product_id inner join tbl_subcategory s on s.subcategory_id=p.subcategory_id inner join tbl_category c on c.ct_id=s.ct_id where s.ct_id='"+li.Value+"' ";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);


        //GridView1.DataSource = dt;
        //GridView1.DataBind();

        //Repeater1.DataSource = dt;
        //Repeater1.DataBind();

        //DataList1.DataSource = dt;
        //DataList1.DataBind();
        obj.fillGrid(selQry, GridView1);
        obj.fillGrid(selQry, Repeater1);
        obj.fillGrid(selQry, DataList1);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ac")
        {
            Session["productid"] = e.CommandArgument.ToString();
           
            Response.Redirect("OfferCartDetails.aspx");
        }

    }
}