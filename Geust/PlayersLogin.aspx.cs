using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Geust_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_playerdetails where p_email='" + txtemail.Text + "' and p_pwd='" + txtpwd.Text+ "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["pname"] = dt.Rows[0]["p_name"].ToString();
            Session["pid"] = dt.Rows[0]["p_id"].ToString();
            Session["clubid"] = dt.Rows[0]["nc_id"].ToString();
            Response.Redirect("../Player/HomePage.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login!!!..";
        }      
    }
}