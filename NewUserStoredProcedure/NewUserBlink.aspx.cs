using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        HttpCookie reqcookie = Request.Cookies["userlogin"];
        if (reqcookie != null)
        {
            reqcookie["nu_id"].ToString();

        }
        lblUsername.Text = reqcookie["nu_fname"].ToString();
        FillUserName();
    }
    private void FillUserName()
    {
        HttpCookie reqcookie = Request.Cookies["userlogin"];
        if (reqcookie != null)
        {
            reqcookie["nu_id"].ToString();

        }
        string str = "select * from tbl_newuser where nu_id='" + reqcookie["nu_id"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(str, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lblMarque.Text = dt.Rows[0]["nu_usern"].ToString();
        }

    }
}