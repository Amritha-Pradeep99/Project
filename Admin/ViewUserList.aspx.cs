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
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_newuser n inner join tbl_place p on n.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id where nu_status='1'";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        grdDs.DataSource = dbt;
        grdDs.DataBind();
    }
    protected void grdDs_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdDs.PageIndex = e.NewPageIndex;
        fillGrid();
    }

   
}