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
            string selQry = "select * from tbl_complaint where complaint_id='" + Session["cid"] + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtcomplainttitle.Text = dt.Rows[0]["complaint_title"].ToString();
            txtcomplaint.Text = dt.Rows[0]["complaint_content"].ToString();

            
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string upQry = "update tbl_complaint set complaint_title='" + txtcomplainttitle.Text + "',complaint_content='" + txtcomplaint.Text + "',complaint_replay='" + txtcomreplay.Text + "',complaint_status='1',replay_date='"+DateTime.Now.ToShortDateString()+"'  where complaint_id='" + Session["cid"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

        lblmsg.Text = "Complaint Replaied......";

        Response.Redirect("SolvedStatus.aspx");
    }

}