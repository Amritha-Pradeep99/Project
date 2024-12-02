using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;
public partial class Product_Default : System.Web.UI.Page
{
   // SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        //con.Open();
        if (!IsPostBack)
        {
            fillCategory();
            fillProduct();
            fillGrid();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_offer(offer_name,offer_fromdate,offer_todate,offer_price,product_id)values('" + txtoffer.Text + "','" + txtfromdate.Text + "','" + txtoffertodate.Text + "','" + txtprice.Text + "','" + ddlproduct.SelectedValue + "')";
        //SqlCommand cmd = new SqlCommand(insQry, con);
        //cmd.ExecuteNonQuery();
        obj.ExcecuteCommand(insQry);

        txtoffer.Text = "";
        txtfromdate.Text = "";
        txtoffertodate.Text = "";
        txtprice.Text = "";
        ddlproduct.ClearSelection();
        ddlsubcategory.ClearSelection();

        fillGrid();
    }
    protected void fillProduct()
    {
        string selQry = "select * from tbl_product ";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //ddlproduct.DataSource = dt;
        //ddlproduct.DataTextField = "product_Name";
        //ddlproduct.DataValueField = "product_id";
        //ddlproduct.DataBind();
        obj.fillDropDown(ddlproduct,"product_Name","product_id",selQry);
    }
    protected void fillCategory()
    {

        string selQry = "select * from tbl_category";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //ddlcategory.DataSource = dt;
        //ddlcategory.DataTextField = "ct_name";
        //ddlcategory.DataValueField = "ct_id";
        //ddlcategory.DataBind();
        obj.fillDropDown(ddlcategory, "ct_name", "ct_id", selQry);
    }
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_subcategory where ct_id='" + ddlcategory.SelectedValue + "' ";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //ddlsubcategory.DataSource = dt;
        //ddlsubcategory.DataTextField = "subcategory_name";
        //ddlsubcategory.DataValueField = "subcategory_id";
        //ddlsubcategory.DataBind();
        obj.fillDropDown(ddlsubcategory, "subcategory_name", "subcategory_id", selQry);
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_offer f inner join tbl_product p on f.product_id=p.product_id inner join tbl_subcategory s on s.subcategory_id=p.subcategory_id inner join tbl_category c on c.ct_id=s.ct_id";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);

        //Repeater1.DataSource = dt;
        //Repeater1.DataBind();

        //DataList1.DataSource = dt;
        //DataList1.DataBind();

        //GridView1.DataSource = dt;
        //GridView1.DataBind();
        obj.fillGrid(selQry, Repeater1);
        obj.fillGrid(selQry, DataList1);
        obj.fillGrid(selQry, GridView1);
    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
    }
}