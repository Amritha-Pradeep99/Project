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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        
    }
    protected void btnchange_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newuser where nu_pwd='"+txtpwd.Text+"' and  nu_id='" + Session["newid"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        
        if(dt.Rows.Count>0)
        {
            if (txtCpwd.Text == txtNpwd.Text)
            {

                string upQry = "update tbl_newuser set nu_pwd='" + txtNpwd.Text + "' where  nu_id='" + Session["newid"] + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();
                lblmsg.Text = "Password Updated....";
            }
            else
            {
                lblmsg.Text = "Paswword not Equal...";
            }
        }
        else
        {
            lblmsg.Text = "Invalid Password...";
         }

        
        
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtpwd.Text = "";
        txtNpwd.Text="";
        txtCpwd.Text = "";
    }
}