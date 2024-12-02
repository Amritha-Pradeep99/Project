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
    }
    protected void btnchange_Click(object sender, EventArgs e)
    {
        HttpCookie requestcookie = Request.Cookies["login"];
        {
            if (requestcookie != null)
            {
                requestcookie["admin_id"].ToString();
            }
        }
        string selQry = "select * from tbl_adminregistration where admin_pwd='" + txtpwd.Text + "' and admin_id='"+ requestcookie["admin_id"]+"'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            if (txtnpwd.Text == txtcpwd.Text)
            {
                string upQry = "update tbl_adminregistration set admin_pwd='" + txtnpwd.Text + "' where admin_id='" + requestcookie["admin_id"] + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();

                lblmsg.Text = "Password Changed..";
            }
            else
            {
                lblmsg.Text = "Password  Not Changed..";
            }
        }
        txtpwd.Text = "";
        txtnpwd.Text = "";
        txtcpwd.Text = "";
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtpwd.Text = "";
        txtnpwd.Text = "";
        txtcpwd.Text = "";
    }
}