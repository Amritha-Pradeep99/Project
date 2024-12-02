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
        if (!IsPostBack)
        {
            HttpCookie requestcookie = Request.Cookies["login"];
            if (requestcookie != null)
            { 
               requestcookie["admin_id"].ToString();
            }
            string selQry = "select * from tbl_adminregistration where admin_id='" + requestcookie["admin_id"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["admin_name"].ToString();
            txtemail.Text = dt.Rows[0]["admin_email"].ToString();
            txtcontact.Text = dt.Rows[0]["admin_contact"].ToString();
            
        }
          
            
    }
  

    protected void btnedit_Click(object sender, EventArgs e)
    {
        HttpCookie requestcookie = Request.Cookies["login"];
        if (requestcookie != null)
        {
            requestcookie["admin_id"].ToString();
        }
        string upQry = "update tbl_adminregistration set admin_name='" + txtname.Text + "',admin_email='" + txtemail.Text + "',admin_contact='" + txtcontact.Text + "' where admin_id='" + requestcookie["admin_id"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}