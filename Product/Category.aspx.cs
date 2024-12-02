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
    MyProject obj = new MyProject();
    static int flag, editID;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_category set ct_name='" + txtcategory.Text + "' where ct_id='" + editID + "'";
            //SqlDataAdapter adp = new SqlDataAdapter(upQry, con);
            //adp.Fill(dt);
            obj.ExcecuteCommand(upQry);
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_category (ct_name) values ('" + txtcategory.Text + "')";
            //SqlDataAdapter adp = new SqlDataAdapter(insQry, con);
            //adp.Fill(dt);
            obj.ExcecuteCommand(insQry);
        }

        txtcategory.Text = "";
        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_category";
        DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);

        //Repeater1.DataSource = dt;
        //Repeater1.DataBind();
        obj.fillGrid(selQry, Repeater1);
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_category where ct_id='" + idno + "'";
            //SqlCommand cmd = new SqlCommand(delQry, con);
            //cmd.ExecuteNonQuery();
            obj.ExcecuteCommand(delQry);
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            editID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_category where ct_id='" + editID + "'";
            DataTable dt = new DataTable();
            //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            //adp.Fill(dt);
            dt = obj.selCommand(selQry);
            txtcategory.Text = dt.Rows[0]["ct_name"].ToString();

            flag = 1;
            fillGrid();
        }
    }
    protected void txtcategory_TextChanged(object sender, EventArgs e)
    {

    }
}