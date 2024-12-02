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
    MyProject obj = new MyProject();
    static int flag, editID;
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {

         if (flag == 1)
        {
            string upQry = " update tbl_district set district_name='" + txtdist.Text + "' where district_id='" + editID + "'";
            obj.ExcecuteCommand(upQry);
            txtdist.Text = "";
            flag = 0;
        }
        else
        {
            string insQry = " insert into tbl_district(district_name)values('" + txtdist.Text + "')";
            obj.ExcecuteCommand(insQry);
            txtdist.Text = "";
        }

        fillGrid();

    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_district";
        obj.fillGrid(selQry, grdd);
    }




    protected void grdd_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdd.PageIndex=e.NewPageIndex;
        fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtdist.Text = "";
    }

    protected void grdd_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_district where district_id='" + idno + "'";
            obj.ExcecuteCommand(delQry);
           
            fillGrid();
        }


        if (e.CommandName == "ed")
        {

            editID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_district where district_id='" + editID + "'";
            DataTable dt = new DataTable();
            dt = obj.selCommand(selQry);
            txtdist.Text = dt.Rows[0]["district_name"].ToString();
            flag = 1;

        }


    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}