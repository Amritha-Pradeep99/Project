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
    static int edid, flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            fillGrid();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            SqlCommand cmd = new SqlCommand("updateRecordsDistrict", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.ExecuteNonQuery();

            flag = 0;
        }
        else
        {

            SqlCommand cmd = new SqlCommand("insertRecordsDistrict", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text;
            cmd.ExecuteNonQuery();
        }

        fillGrid();
    }
    protected void fillGrid()
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsDistrict", con);
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
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("deleteRecordsDistrict", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@districtid", SqlDbType.Int).Value = idno;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);


            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            edid =  Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd = new SqlCommand("selectRecordsDistrict", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@districtid", SqlDbType.Int).Value = edid;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["district_name"].ToString();

            flag = 1;

            fillGrid();
        }

        
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("selectAllRecordsDistrict", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}