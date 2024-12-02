using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class User_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            HttpCookie reqcookie = Request.Cookies["newuserlogin"];
            if (reqcookie != null)
            {
                reqcookie["nu_id"].ToString();
            }
            string selQry = "select * from tbl_newuser where nu_id='" + reqcookie["nu_id"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtfname.Text = dt.Rows[0]["nu_fname"].ToString();
            txtlname.Text = dt.Rows[0]["nu_lname"].ToString();
            txtemail.Text = dt.Rows[0]["nu_email"].ToString();
            txtcontact.Text = dt.Rows[0]["nu_phone"].ToString();
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        HttpCookie reqcookie = Request.Cookies["newuserlogin"];
        if (reqcookie != null)
        {
            reqcookie["nu_id"].ToString();
        }
        string upQry = "update tbl_newuser set nu_fname='" + txtfname.Text + "',nu_lname='" + txtlname.Text + "',nu_email='" + txtemail.Text + "',nu_phone='" + txtcontact.Text + "' where nu_id='" + reqcookie["nu_id"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtfname.Text = "";
        txtlname.Text = "";
        txtemail.Text = "";
        txtcontact.Text = "";
    }
}