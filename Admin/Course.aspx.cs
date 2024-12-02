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
    static int flag,editID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_course set course_name='" + txtname.Text + "',course_duration='" + txtduration.Text + "',course_fees='" + txtfees.Text + "'  where course_id='" + editID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_course(course_name,course_duration,course_fees)values('" + txtname.Text + "','" + txtduration.Text + "','" + txtfees.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }

        txtname.Text = "";
        txtduration.Text = "";
        txtfees.Text = "";

        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_course";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        Repeater1.DataSource=dt;
        Repeater1.DataBind();
    }
   
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtduration.Text = "";
        txtfees.Text = "";
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_course where course_id='"+idno+"'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            editID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_course where course_id='" + editID + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["course_name"].ToString();
            txtduration.Text = dt.Rows[0]["course_duration"].ToString();
            txtfees.Text = dt.Rows[0]["course_fees"].ToString();
            flag = 1;
            fillGrid();
        }
       
    }
}