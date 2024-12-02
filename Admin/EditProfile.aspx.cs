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

            string selQry = "select * from tbl_adminregistration where admin_id='" + Session["adminid"] + "'";
            DataTable dbt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dbt);
            txtname.Text = dbt.Rows[0]["admin_name"].ToString();
            txtcontact.Text = dbt.Rows[0]["admin_contact"].ToString();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string upQry = "update tbl_adminregistration set admin_name='" + txtname.Text + "',admin_contact='" + txtcontact.Text + "' where admin_id='" + Session["adminid"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("MyProfile.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}