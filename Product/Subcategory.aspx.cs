using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Product_Default : System.Web.UI.Page
{
   // SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    MyProject obj = new MyProject();
    static int flag, editID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //con.Open();
        if (!IsPostBack)
        {
            fillGrid();
            fillcategory();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_subcategory set subcategory_name='" + txtsubcategory.Text + "',ct_id='" + ddlcategory.SelectedValue + "'  where subcategory_id='" + editID + "'";
            //SqlCommand cmd = new SqlCommand(upQry, con);
            //cmd.ExecuteNonQuery();
            obj.ExcecuteCommand(upQry);
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_subcategory (subcategory_name,ct_id) values ('" + txtsubcategory.Text + "','" + ddlcategory.SelectedValue + "')";
            //SqlCommand cmd = new SqlCommand(insQry, con);
            //cmd.ExecuteNonQuery();
            obj.ExcecuteCommand(insQry);
        }
        txtsubcategory.Text = "";
        ddlcategory.ClearSelection();

        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_subcategory s inner join tbl_category c on s.ct_id=c.ct_id";
        DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);

        //Repeater1.DataSource = dt;
        //Repeater1.DataBind();
        obj.fillGrid(selQry, Repeater1);
    }
    protected void fillcategory()
    {
        string selQry = "select * from tbl_category";
        obj.fillDropDown(ddlcategory, "ct_name", "ct_id", selQry);
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //ddlcategory.DataSource = dt;
        //ddlcategory.DataTextField = "ct_name";
        //ddlcategory.DataValueField = "ct_id";
        //ddlcategory.DataBind();
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int IDno=Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_subcategory where subcategory_id ='"+ IDno +"'";
            //SqlCommand cmd = new SqlCommand(delQry, con);
            //cmd.ExecuteNonQuery();
            obj.ExcecuteCommand(delQry);
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            
            editID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_subcategory where subcategory_id ='" + editID + "'";
            DataTable dt = new DataTable();
            //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            //adp.Fill(dt);
            dt = obj.selCommand(selQry);
            txtsubcategory.Text = dt.Rows[0]["subcategory_name"].ToString();
            ddlcategory.SelectedValue = dt.Rows[0]["ct_id"].ToString();
            flag = 1;
            
            fillGrid();
        }
    }
    
}
