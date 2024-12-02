using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Club_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_newclub  where nc_id='" + Session["clubid"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["nc_name"].ToString();
            txtcontact.Text = dt.Rows[0]["nc_pwd"].ToString();
        }
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        string upQry = "update tbl_newclub set  nc_name='" + txtname.Text + "' ,nc_pwd='" + txtcontact.Text + "'  where nc_id='" + Session["clubid"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("MyProfile.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}