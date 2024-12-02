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

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_adminregistration(admin_name,admin_contact,admin_email,admin_pwd)values('" + txtname.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + txtpwd.Text + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();

        txtname.Text = "";
        txtcontact.Text = "";
        txtemail.Text = "";
        txtpwd.Text = "";

        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_adminregistration";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
        adp.Fill(dt);
        gdAR.DataSource = dt;
        gdAR.DataBind();

    }
    
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtcontact.Text = "";
        txtemail.Text = "";
        txtpwd.Text = "";
    }


    protected void gdAR_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdAR.PageIndex = e.NewPageIndex;
        fillGrid();
    }
}