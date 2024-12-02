using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Player_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnchange_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_playerdetails where p_pwd='" + txtpwd.Text + "' and p_id='" + Session["pid"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            if (txtCpwd.Text == txtNewpwd.Text)
            {
                string upQry = "update tbl_playerdetails set p_pwd='" + txtNewpwd.Text + "' where p_id='" + Session["pid"] + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();
                lblmsg.Text = "Password updated";
            }
            else
            {
                lblmsg.Text = "Password not equal..";
            }
        }
        else
        {
            lblmsg.Text="Invalid password..";
        }

    }
}