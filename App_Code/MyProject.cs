using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for MyProject
/// </summary>
public class MyProject
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
	public MyProject() //constructor
	{
        con.Open();
	}
    public void ExcecuteCommand(string qry)
    {
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
    }
    public DataTable selCommand(string selQry)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        return dt;
    }
    public void fillGrid(string selQry, GridView grd)
    {
        DataTable dt = new DataTable();
        dt = selCommand(selQry);
        grd.DataSource = dt;
        grd.DataBind();
    }
    public void fillGrid(string selQry, Repeater rp)
    {
        DataTable dt = new DataTable();
        dt = selCommand(selQry);
        rp.DataSource = dt;
        rp.DataBind();
    }
    public void fillGrid(string selQry, DataList dl)
    {
        DataTable dt = new DataTable();
        dt = selCommand(selQry);
        dl.DataSource = dt;
        dl.DataBind();

    }
    
    public void fillBulletedList(BulletedList bl, string txtField, string valueField, string selQry)
    {
        DataTable dt = selCommand(selQry);
        bl.DataSource = dt;
        bl.DataTextField = txtField;
        bl.DataValueField = valueField;
        bl.DataBind();
    }
    public void fillDropDown(DropDownList ddl, string txtField, string valueFiled, string selQry)
    {
        DataTable dt = selCommand(selQry);
        ddl.DataSource = dt;
        ddl.DataTextField = txtField;
        ddl.DataValueField = valueFiled;
        ddl.DataBind();
    }

    
}