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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_complaint (complaint_title,complaint_content,nu_id,complaint_status,complaint_date)values('" + txtct.Text + "','" + txtcom.Text + "','" + Session["newid"] + "','0','"+DateTime.Now.ToShortDateString()+"')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();

        txtct.Text = "";
        txtcom.Text = "";
    }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtct.Text = "";
        txtcom.Text = "";
    }
}