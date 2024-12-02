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
    static int editID, flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            fillCategory();
            fillGrid();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            SqlCommand cmd = new SqlCommand("updateRecordsSubcategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subid", SqlDbType.Int).Value = editID;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = ddlcategory.SelectedValue;
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            SqlCommand cmd = new SqlCommand("insertRecordsSubcategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = ddlcategory.SelectedValue;
            cmd.ExecuteNonQuery();
        }
        fillGrid();
        txtname.Text="";
        ddlcategory.ClearSelection();
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
    protected void fillGrid()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsSubcategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        gdsubcategory.DataSource = dt;
        gdsubcategory.DataBind();
    }
    
    protected void gdsubcategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("deleteRecordsSubcategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subid", SqlDbType.Int).Value = idno;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt=new DataTable();
            adp.SelectCommand=cmd;
            adp.Fill(dt);

            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            editID = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("selectRecordsSubcategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subid", SqlDbType.Int).Value = editID;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["subcategory_name"].ToString();
            ddlcategory.SelectedValue = dt.Rows[0]["ct_id"].ToString();

            flag = 1;
        }
        fillGrid();
    }
    protected void gdsubcategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdsubcategory.PageIndex = e.NewPageIndex;
        fillGrid();
    }

    protected void btnshow_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsSubcategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        gdsubcategory.DataSource = dt;
        gdsubcategory.DataBind();
    }
}