using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Test_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string sel = "select * from tbl_video";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sel, con);
            adp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "play")
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_video where video_id='" + id + "'";
             DataTable dt = new DataTable();
             SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            Session["videoName"] = dt.Rows[0]["video_filename"].ToString();
            Response.Redirect("PlayNow.aspx");

            
        }
    }
}