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

        }
    }
    protected void btnchange_Click(object sender, EventArgs e)
    {
        HttpCookie reqcookie=Request.Cookies["newuserlogin"];
        if (reqcookie != null)
        {
            reqcookie["nu_id"].ToString();
        }
        string selQry = "select * from tbl_newuser where nu_pwd='" + txtpwd.Text + "' and nu_id='"+reqcookie["nu_id"]+"'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            if (txtnpwd.Text == txtcpwd.Text)
            {
                string upQry = "update tbl_newuser set nu_pwd='" + txtnpwd.Text + "' where nu_id='" + reqcookie["nu_id"] + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();

                lblmsg.Text = "Password Changed...";
            }
            else
            {
                lblmsg.Text = "Password  NOt Changed...";
            }
        }
    }
}