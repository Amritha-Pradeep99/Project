using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Club_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }

    protected void btnchange_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newclub  where nc_pwd='"+txtpwd.Text+"' and nc_id='" + Session["clubid"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            if (txtNpwd.Text == txtCpwd.Text)
            {

                string upQry = "update tbl_newclub set  nc_pwd='" + txtNpwd.Text + "'  where nc_id='" + Session["clubid"] + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();
                lblmsg.Text = "Password Updated.......";
            }
            else
            {
                lblmsg.Text = "Password Not Updated.......";
            }

        }
        else
        {
            lblmsg.Text = "Invalid Password!!!!!";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtpwd.Text="";
        txtNpwd.Text="";
        txtCpwd.Text = "";
    }
}