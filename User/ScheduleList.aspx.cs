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
            fillGrid();
        }
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_schedule s  inner join tbl_place p on s.place_id=p.place_id inner join tbl_district  d on d.district_id=p.district_id ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        gdsl.DataSource = dt;
        gdsl.DataBind();
    }


    protected void gdsl_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdsl.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}