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
    static int flag, editID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillcategory();
            fillGrid();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_subcategory set ct_id='" + ddlcname.SelectedValue + "',subcategory_name='" + txtsubname.Text + "' where subcategory_id='" + editID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();

            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_subcategory(subcategory_name,ct_id)values('" + txtsubname.Text + "','" + ddlcname.SelectedValue + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
        txtsubname.Text = "";
        ddlcname.ClearSelection();

        fillGrid();
    }
    protected void fillcategory()
    {
        string selQry = "select * from tbl_category";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        ddlcname.DataSource = dbt;
        ddlcname.DataTextField = "ct_name";
        ddlcname.DataValueField = "ct_id";
        ddlcname.DataBind();
    }

    protected void fillGrid()
    {
        string selQry = "select * from tbl_subcategory s inner join tbl_category c on s.ct_id=c.ct_id";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        gdsc.DataSource = dbt;
        gdsc.DataBind();
    }

    protected void gdsc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int subidno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_subcategory where subcategory_id='" + subidno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            editID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_subcategory s inner join tbl_category c on s.ct_id=c.ct_id where subcategory_id='" + editID + "'";
            DataTable dbt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dbt);
            ddlcname.SelectedValue = dbt.Rows[0]["ct_id"].ToString();
            txtsubname.Text = dbt.Rows[0]["subcategory_name"].ToString();
            flag= 1;

            fillGrid();
        }

    }
}