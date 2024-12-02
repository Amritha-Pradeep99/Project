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
            fillDepartment();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_subtree(course_id,sub_name)values('" + ddlcourse.SelectedValue + "','" + txtsubject.Text + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();

        
        ddlcourse.ClearSelection();
        txtsubject.Text = "";
    }
    protected void fillDepartment()
    {
        string selQry = "select * from tbl_deptree";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddldept.DataSource = dt;
        ddldept.DataTextField = "dept_name";
        ddldept.DataValueField = "dept_id";
        ddldept.DataBind();
    }

    
    protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_coursetree where dept_id='" + ddldept.SelectedValue + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlcourse.DataSource = dt;
        ddlcourse.DataTextField = "course_name";
        ddlcourse.DataValueField = "course_id";
        ddlcourse.DataBind();
    }
    
}