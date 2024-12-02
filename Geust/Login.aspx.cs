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

        if (!IsPostBack)
        {
            
        }
    }
   
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_adminregistration where admin_email='" + txtemail.Text + "' and admin_pwd='" + txtpassword.Text + "'";
        DataTable dtAdmin = new DataTable();
        SqlDataAdapter adpAdmin = new SqlDataAdapter(selQry, con);
        adpAdmin.Fill(dtAdmin);


        string selQry1 = "select * from tbl_newclub where nc_email='" + txtemail.Text + "' and nc_pwd='" + txtpassword.Text + "'and nc_status='1'";
        DataTable dtcb = new DataTable();
        SqlDataAdapter adpcb = new SqlDataAdapter(selQry1, con);
        adpcb.Fill(dtcb);


        string selQry2 = "select * from tbl_newuser where nu_email='" + txtemail.Text + "' and nu_pwd='" + txtpassword.Text + "'";
        DataTable dtNew = new DataTable();
        SqlDataAdapter adpnew = new SqlDataAdapter(selQry2, con);
        adpnew.Fill(dtNew);

        string selQry3 = "select * from tbl_playerdetails where p_email='" + txtemail.Text + "' and p_pwd='" + txtpassword.Text + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry3, con);
        adp.Fill(dt);

        if (dtAdmin.Rows.Count > 0)
        {
            Session["adminname"] = dtAdmin.Rows[0]["admin_name"].ToString();
            Session["adminid"] = dtAdmin.Rows[0]["admin_id"].ToString();

            Response.Redirect("../Admin/HomePage.aspx");
        }
        else if (dtcb.Rows.Count > 0)
        {
            Session["clubname"] = dtcb.Rows[0]["nc_name"].ToString();
            Session["clubid"] = dtcb.Rows[0]["nc_id"].ToString();
            Response.Redirect("../Club/HomePage.aspx");

        }
        else if (dtNew.Rows.Count > 0)
        {
            Session["newfname"] = dtNew.Rows[0]["nu_fname"].ToString();
            Session["newid"] = dtNew.Rows[0]["nu_id"].ToString();

            Response.Redirect("../User/HomePage.aspx");
        }
        else if (dt.Rows.Count > 0)
        {
            Session["pname"] = dt.Rows[0]["p_name"].ToString();
            Session["pid"] = dt.Rows[0]["p_id"].ToString();
            Session["clubid"] = dt.Rows[0]["nc_id"].ToString();
            Response.Redirect("../Player/HomePage.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login!!!";
        }

        txtemail.Text = "";
        txtpassword.Text = "";

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtemail.Text = "";
        txtpassword.Text = "";
    }
}