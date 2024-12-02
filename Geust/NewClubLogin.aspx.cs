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
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newclub where nc_email='" + txtemail.Text + "' and nc_pwd='" + txtpwd.Text + "'and nc_status='1'";
        DataTable dtcb = new DataTable();
        SqlDataAdapter adpcb = new SqlDataAdapter(selQry, con);
        adpcb.Fill(dtcb);
        if (dtcb.Rows.Count > 0)
        {
            Session["clubname"] = dtcb.Rows[0]["nc_name"].ToString();
            Session["clubid"] = dtcb.Rows[0]["nc_id"].ToString();
            Response.Redirect("../Club/HomePage.aspx");

        }
        else
        {
            lblmsg.Text = "invalid Login!!!";
        }
    }
}