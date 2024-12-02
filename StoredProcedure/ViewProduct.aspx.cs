using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class StoredProcedure_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            fillCategory();
           
        }
    }
    protected void fillCategory()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        ddlcategory.DataSource = dt;
        ddlcategory.DataTextField = "ct_name";
        ddlcategory.DataValueField = "ct_id";
        ddlcategory.DataBind();
    }

    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("selectSubcategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@cid", SqlDbType.Int).Value = ddlcategory.SelectedValue;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        ddlsubcategory.DataSource = dt;
        ddlsubcategory.DataTextField = "subcategory_name";
        ddlsubcategory.DataValueField = "subcategory_id";
        ddlsubcategory.DataBind();

        fillDetails();
    }
    protected void fillDetails()
    {
        SqlCommand cmd = new SqlCommand("selectProduct", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@cid", SqlDbType.Int).Value = ddlcategory.SelectedValue;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }
    
}