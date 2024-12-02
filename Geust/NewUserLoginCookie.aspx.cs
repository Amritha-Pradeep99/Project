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
        string selQry = "select * from tbl_newuser where nu_email='" + txtemail.Text + "' and nu_pwd='"+ txtpwd.Text +"'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            HttpCookie adc = new HttpCookie("newuserlogin");
            adc["nu_email"] = txtemail.Text;
            adc["nu_pwd"] = txtpwd.Text;
            adc["nu_fname"] = dt.Rows[0]["nu_fname"].ToString();
            //adc["nu_lname"] = dt.Rows[0]["nu_lname"].ToString();
            adc["nu_id"] = dt.Rows[0]["nu_id"].ToString();
            Response.Cookies.Add(adc);

            Response.Redirect("../User/HomePageCookie.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login..";
        }
       
    }
}