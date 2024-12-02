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
    //SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        //con.Open();
        if (!IsPostBack)
        {
            fillCourse();
        }

    }
    protected void fillCourse()
    {
        string selQry = "select * from tbl_course";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //blsyllabus.DataSource = dt;
        //blsyllabus.DataTextField = "course_name";
        //blsyllabus.DataValueField = "course_id";
        //blsyllabus.DataBind();
        obj.fillBulletedList(blsyllabus, "course_name", "course_id", selQry);
    }


    protected void blsyllabus_Click(object sender, BulletedListEventArgs e)
    {
        ListItem li = blsyllabus.Items[e.Index];
        lblmsg.Text = "youselected=" + li.Text + "with value=" + li.Value + "index=" + e.Index.ToString();
        string selQry = "select * from tbl_syllabus sy inner join tbl_subject s on sy.subject_id=s.subject_id inner join tbl_semester sem on sem.sem_id=sy.sem_id where sy.course_id='"+ li.Value+"'";
        DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //GridView1.DataSource = dt;
        //GridView1.DataBind();
        obj.fillGrid(selQry, GridView1);
    }
}


   
    
   
  
