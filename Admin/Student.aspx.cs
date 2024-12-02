using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    static int flag, editID;
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
         if(flag==1)
        {
            string upQry = "update tbl_student set stu_name= '" + txtname.Text + "',stu_rollno='" + txtrn.Text + "',stu_gender='" + rdbgender.SelectedValue + "',stu_dept='" + ddldept.SelectedValue + "' where stu_id='" + editID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {

            string insQry = "insert into tbl_student(stu_name,stu_rollno,stu_gender,stu_dept)values('"+ txtname.Text +"','"+txtrn.Text+"','"+rdbgender.SelectedValue+"','"+ddldept.SelectedValue+"' )";
            SqlCommand cmd=new SqlCommand(insQry,con);
            cmd.ExecuteNonQuery();
        }

        txtname.Text="";
        txtrn.Text="";
        rdbgender.ClearSelection();
        ddldept.ClearSelection();

        fillGrid();

    }

    protected void fillGrid()
    {
        string selQry="select * from tbl_student";
        DataTable dt=new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
        adp.Fill(dt);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();
    }

    
    protected void grdDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        grdDetails.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

        txtname.Text = "";
        txtrn.Text = "";
        rdbgender.ClearSelection();
        ddldept.ClearSelection();
    }


    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_student where stu_id='" + idno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
        }
        if (e.CommandName == "ed")
        {
            editID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_student where stu_id='" + editID + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["stu_name"].ToString();
            txtrn.Text = dt.Rows[0]["stu_rollno"].ToString();
            rdbgender.SelectedValue = dt.Rows[0]["stu_gender"].ToString();
            ddldept.SelectedValue = dt.Rows[0]["stu_dept"].ToString();
            flag = 1;
        }
        fillGrid();
    }
}