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
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_playerdetails where p_id='" + Session["pid"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["p_name"].ToString();
            txtcontact.Text = dt.Rows[0]["p_contact"].ToString();
        }

    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        string upQry = "update tbl_playerdetails set p_name='" + txtname.Text + "' , p_contact='" + txtcontact.Text + "'  where p_id='" + Session["pid"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("MyProfile.aspx");
    }
}