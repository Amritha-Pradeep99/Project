using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Admin_Default : System.Web.UI.Page
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
        string selQry = "select * from tbl_newclub n inner join tbl_place p on n.place_id=p.place_id inner join tbl_district  d on d.district_id=p.district_id where n.nc_status='2'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        gdnc.DataSource = dt;
        gdnc.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdnc.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void gdnc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ac")
        {
            int cidno = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_newclub set nc_status='1' where nc_id='" + cidno + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();


            fillGrid();
        }
    }
}