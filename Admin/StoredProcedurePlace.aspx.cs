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
    static int editID, flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            fillDistrict();
            fillDetails();
        }
    }
    
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            SqlCommand cmd = new SqlCommand("updateRecordsPlace", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@placeid", SqlDbType.Int).Value = editID;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@pincode", SqlDbType.VarChar).Value = txtpincode.Text;
            cmd.Parameters.Add("@distid", SqlDbType.VarChar).Value = ddldistrict.SelectedValue;
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            SqlCommand cmd = new SqlCommand("insertRecordsPlace", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.Parameters.Add("@pincode", SqlDbType.VarChar).Value = txtpincode.Text;
            cmd.Parameters.Add("@distid", SqlDbType.VarChar).Value = ddldistrict.SelectedValue;
            cmd.ExecuteNonQuery();
        }
        fillDetails();

        txtname.Text = "";
        txtpincode.Text = "";
        ddldistrict.ClearSelection();
    }
    protected void fillDetails()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsPlace", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void fillDistrict()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsDistrict", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        ddldistrict.DataSource = dt;
        ddldistrict.DataTextField = "district_name";
        ddldistrict.DataValueField = "district_id";
        ddldistrict.DataBind();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("deleteRecordsPlace", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@placeid", SqlDbType.VarChar).Value = idno;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);

        }
        if (e.CommandName == "ed")
        {
            editID = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("selectRecordsPlace", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@placeid", SqlDbType.VarChar).Value = editID;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["place_name"].ToString();
            txtpincode.Text = dt.Rows[0]["place_pincode"].ToString();
            ddldistrict.SelectedValue = dt.Rows[0]["district_id"].ToString();
            flag = 1;
        }
        fillDetails();
    }


    protected void btnshow_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsPlace", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}