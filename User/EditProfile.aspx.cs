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
        if(!IsPostBack)
        {
            string selQry = "select * from tbl_newuser where nu_id='" + Session["newid"] + "'"; 
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtfname.Text = dt.Rows[0]["nu_fname"].ToString();
            txtlname.Text = dt.Rows[0]["nu_lname"].ToString();
            txtphone.Text = dt.Rows[0]["nu_phone"].ToString();
        }
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        string upQry = "update  tbl_newuser set nu_fname='" + txtfname.Text + "',nu_lname='" + txtlname.Text + "',nu_phone='" + txtphone.Text + "' where nu_id='" + Session["newid"] + "'" ;
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("MyProfile.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtfname.Text="";
        txtlname.Text="";
        txtphone.Text = "";
    }
}