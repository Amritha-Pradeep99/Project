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
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        //lblmsg.Text = "";
        string selQry = "select * from tbl_adminregistration where admin_email='" + txtemail.Text + "' and admin_pwd='" + txtpwd.Text + "'";
        DataTable dtAdmin = new DataTable();
        SqlDataAdapter adpAdmin = new SqlDataAdapter(selQry, con);
        adpAdmin.Fill(dtAdmin);
        if (dtAdmin.Rows.Count > 0)
        {
            HttpCookie myck = new HttpCookie("login");
            myck["admin_email"] = txtemail.Text;
            myck["admin_pwd"] = txtpwd.Text;
            myck["admin_name"] = dtAdmin.Rows[0]["admin_name"].ToString();
            myck["admin_id"] = dtAdmin.Rows[0]["admin_id"].ToString();
            Response.Cookies.Add(myck);


            Response.Redirect("../Admin/HomePageCookie.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login!!!";
        }
    }
}