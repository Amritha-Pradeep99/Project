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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newuser where nu_usern='"+txtun.Text+"' and nu_pwd='"+txtpwd.Text+"'";
        DataTable dtNew = new DataTable();
        SqlDataAdapter adpnew = new SqlDataAdapter(selQry, con);
        adpnew.Fill(dtNew);
        if (dtNew.Rows.Count > 0)
        {
            Session["newfname"] = dtNew.Rows[0]["nu_fname"].ToString();
            Session["newid"] = dtNew.Rows[0]["nu_id"].ToString();
            
            Response.Redirect("../User/HomePage.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login!!!";
        }
        con.Close();
    }
     
}