using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        
        string insQry="insert into tbl_newsupload(news_caption,news_content,news_date,news_status)values('"+txtcaption.Text+"','"+txtnews.Text+"','"+DateTime.Now.ToShortDateString()+"','0')";
        SqlCommand cmd=new SqlCommand(insQry,con);
        cmd.ExecuteNonQuery();
       

        txtcaption.Text="";
        txtnews.Text="";
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
         txtcaption.Text="";
         txtnews.Text="";
    }
    protected void chkshow_CheckedChanged(object sender, EventArgs e)
    {
        string upQry = "update tbl_newsupload set news_status='1'  ";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

    }
}