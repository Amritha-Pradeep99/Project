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
        if (!IsPostBack)
        {
            fillNews();
        }
    }
    protected void fillNews()
    {
        string selQry = "select * from tbl_newsupload where news_status='1'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            ltrlnews.Text = "<table border='1' class='highlighted-table'>";
            ltrlnews.Text += "<tr><td class='color'><b>Caption</b></td><td  class='color'><b>Content</b></td>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                ltrlnews.Text += "<tr><td><b><font size='4' color='red'>" + dt.Rows[i]["news_caption"].ToString() + "</font></b></td>";
                ltrlnews.Text += "<td><marquee><Font size='3' >" + dt.Rows[i]["news_content"].ToString() + "</Font></marquee></td></tr>";
            }
            ltrlnews.Text += "</table>";
        }
        else
        {
            ltrlnews.Text += "no records";
        }
    }
}