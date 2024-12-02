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
    static int edID, flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            fillGrid();
        }
    }
    
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            SqlCommand cmd = new SqlCommand("updateRecordsCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = edID;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtcategory.Text;
            cmd.ExecuteNonQuery();

            flag = 0;
        }
        else
        {
            SqlCommand cmd = new SqlCommand("insertRecordsCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtcategory.Text;
            cmd.ExecuteNonQuery();
        }
        fillGrid();

        txtcategory.Text = "";
    }
    protected void fillGrid()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        gdcategory.DataSource = dt;
        gdcategory.DataBind();
    }
    
    protected void gdcategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int deleteID = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("deleteRecordsCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = deleteID;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);


        }
        if (e.CommandName == "ed")
        {
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("selectRecordsCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = edID;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            txtcategory.Text = dt.Rows[0]["ct_name"].ToString();

            flag = 1;

            fillGrid();
        }
        fillGrid();
    }
    protected void gdcategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdcategory.PageIndex = e.NewPageIndex;
        fillGrid(); 
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtcategory.Text = "";
    }
}