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
            fillCategory();
            fillGrid();
        }
    }
    protected void fillCategory()
    {
        string selQry = "select * from tbl_category";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlcategory.DataSource = dt;
        ddlcategory.DataTextField = "ct_name";
        ddlcategory.DataValueField = "ct_id";
        ddlcategory.DataBind();
     
    }

    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from  tbl_subcategory where ct_id='" + ddlcategory.Text + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlsubcategory.DataSource = dt;
        ddlsubcategory.DataTextField = "subcategory_name";
        ddlsubcategory.DataValueField = "subcategory_id";
        ddlsubcategory.DataBind();

        fillGrid();
    }

    
    protected void fillGrid()
    {
        string selQry = "select * from tbl_product p inner join tbl_subcategory s on p.subcategory_id=s.subcategory_id inner join tbl_category c on c.ct_id=s.ct_id   where  s.ct_id='" + ddlcategory.Text + "' ";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            DataList1.DataSource = dt;
            DataList1.DataBind();
       
    }
    

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ac")
        {
            Session["pid"] = e.CommandArgument.ToString();
            Response.Redirect("AddTocartDetails.aspx");
        }
    }
}   