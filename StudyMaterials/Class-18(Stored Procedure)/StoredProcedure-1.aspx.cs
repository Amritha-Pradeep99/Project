using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class Class_18_Stored_Procedure_StoredProcedure : System.Web.UI.Page
{
    static int idno, flag;
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_aspsylabus;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

        if (!Page.IsPostBack)
        {
            fillDept();
        }
    }
    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edt")
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
            txtsalary.Text = dt.Rows[0]["empsalary"].ToString();
            rdbgender.SelectedValue = dt.Rows[0]["empgender"].ToString();
            ddldept.SelectedValue = dt.Rows[0]["empdept"].ToString();

            flag = 1;

          

        }
    }
    protected void grdDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(grdDetails.DataKeys[e.RowIndex].Value);
        SqlCommand cmd = new SqlCommand("deleteRecords", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@eid", SqlDbType.Int).Value = id;
        cmd.ExecuteNonQuery();

        fillDetails();

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            SqlCommand cmd = new SqlCommand("updateRecords", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = idno;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = rdbgender.SelectedValue;
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
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = rdbgender.SelectedValue;
            cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = ddldept.SelectedValue;
            cmd.Parameters.Add("@salary", SqlDbType.Int).Value = txtsalary.Text;
            cmd.ExecuteNonQuery();
        }

        fillDetails();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("selectAllRecords", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();
    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("IT");
    }
    protected void fillDetails()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecords", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();
    }
    
}