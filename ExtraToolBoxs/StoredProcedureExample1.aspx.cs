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
    static int flag,idno;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            fillDept();
            fillDetails();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            SqlCommand cmd = new SqlCommand("updateRecords", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = idno;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = rblgender.SelectedValue;
            cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = ddldept.SelectedValue;
            cmd.Parameters.Add("@salary", SqlDbType.Int).Value = txtsalary.Text;
            cmd.ExecuteNonQuery();

            flag = 0;
        }
        else
        {
            SqlCommand cmd = new SqlCommand("insertRecords", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = rblgender.SelectedValue;
            cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = ddldept.SelectedValue;
            cmd.Parameters.Add("@salary", SqlDbType.Int).Value = txtsalary.Text;
            cmd.ExecuteNonQuery();
           
        }
        fillDetails();
    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("IT");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("ME");

    }
    
    protected void btnshow_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("selectAllRecords", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("selectRecords", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = idno;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["empname"].ToString();
            rblgender.SelectedValue = dt.Rows[0]["empgender"].ToString();
            ddldept.SelectedValue = dt.Rows[0]["empdept"].ToString();
            txtsalary.Text = dt.Rows[0]["empsalary"].ToString();


            flag = 1;
            fillDetails();
        }
        if (e.CommandName == "del")
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("deleteRecords", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = id;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);
        }
        fillDetails();
    }
    
    protected void fillDetails()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecords", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}