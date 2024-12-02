using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Club_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillplayername();
           
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
         string photoimg=Path.GetFileName(filephoto.PostedFile.FileName.ToString());
        filephoto.SaveAs(Server.MapPath("../Assests/Playerdoc/" + photoimg));

        string insQry = "insert into tbl_playergallery(p_id,pg_photo)values('" + ddlplayername.SelectedValue + "','" + photoimg + "')";
        SqlCommand cmd=new SqlCommand(insQry,con);
        cmd.ExecuteNonQuery();
        

        ddlplayername.ClearSelection();
    }
    protected void fillplayername()
    {

        string selQry = "select * from tbl_playerdetails where nc_id='" + Session["clubid"] + "'";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        ddlplayername.DataSource = dbt;
        ddlplayername.DataTextField = "p_name";
        ddlplayername.DataValueField = "p_id";
        ddlplayername.DataBind();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_playergallery pg inner join tbl_playerdetails p on pg.p_id=p.p_id where p.nc_id='" + Session["clubid"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

        DataList1.DataSource = dt;
        DataList1.DataBind();

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        ddlplayername.ClearSelection();
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_playergallery where p_id='" + idno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();

             
        }
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        fillGrid();
    }
}