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
            fillcourse();
            fillsubject();
            fillsemester();
            fillGrid();
        }
    }
    protected void fillcourse()
    {
        string selQry = "select * from tbl_course";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlcourse.DataSource = dt;
        ddlcourse.DataTextField = "course_name";
        ddlcourse.DataValueField = "course_id";
        ddlcourse.DataBind();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        foreach (ListItem ch in chksubject.Items)
        {
            if (ch.Selected == true)
            {
                string insQry = "insert into tbl_syllabus(course_id,sem_id,subject_id)values('" + ddlcourse.SelectedValue + "','" + ddlsemester.SelectedValue + "','" + ch.Value + "')";
                SqlCommand cmd = new SqlCommand(insQry, con);
                cmd.ExecuteNonQuery();
            }
        }

        ddlcourse.ClearSelection();
        ddlsemester.ClearSelection();
        chksubject.ClearSelection();
    }
    protected void fillsubject()
    {
        string selQry = "select * from tbl_subject";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        chksubject.DataSource = dt;
        chksubject.DataTextField = "subject_name";
        chksubject.DataValueField = "subject_id";
        chksubject.DataBind();
    }
    protected void fillsemester()
    {
        string selQry = "select * from tbl_semester";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlsemester.DataSource = dt;
        ddlsemester.DataTextField = "sem_name";
        ddlsemester.DataValueField = "sem_id";
        ddlsemester.DataBind();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_syllabus sy inner join tbl_course c on sy.course_id=c.course_id inner join tbl_semester sem on sem.sem_id=sy.sem_id inner join tbl_subject sub on sub.subject_id=sy.subject_id";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        gdsyllabus.DataSource = dt;
        gdsyllabus.DataBind();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        ddlcourse.ClearSelection();
        ddlsemester.ClearSelection();
        chksubject.ClearSelection();
    }
    protected void gdsyllabus_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdsyllabus.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void gdsyllabus_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_syllabus where syllabus_id='" + idno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();


            fillGrid();
        }
    }
}