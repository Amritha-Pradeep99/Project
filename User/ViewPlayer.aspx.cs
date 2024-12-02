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
            fillClub();
        }
    }
   protected void fillClub()
    {
       

        string selQry = "select * from tbl_newclub";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        ddlclub.DataSource = dbt;
        ddlclub.DataTextField = "nc_name";
        ddlclub.DataValueField = "nc_id";
        ddlclub.DataBind();
    }



    protected void ddlclub_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_playerdetails where nc_id='" + ddlclub.SelectedValue + "'";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        gdvp.DataSource = dbt;
        gdvp.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}