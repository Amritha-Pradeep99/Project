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
    static int flag, edID;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            fillDistrict();
            fillGrid();
        }

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_place set place_name='" + txtplace.Text + "',district_id='" + ddldist.SelectedValue + "',place_pincode='"+txtpincode.Text+"' where place_id='" + edID + "'";
            obj.ExcecuteCommand(upQry);
           
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_place(place_name,place_pincode,district_id)values('" + txtplace.Text + "','" + txtpincode.Text + "','" + ddldist.SelectedValue + "')";
            obj.ExcecuteCommand(insQry);
        }
        txtplace.Text = "";
        txtpincode.Text = "";
        ddldist.ClearSelection();

        fillGrid();


    }
    protected void fillDistrict()
    {
        
        string selQry = "select * from tbl_district";
        obj.fillDropDown(ddldist, "district_name", "district_id", selQry);
        //DataTable dt = new DataTable();
        //dt = obj.selCommand(selQry);
        //ddldist.DataSource = dt;
        //ddldist.DataTextField = "district_name";
        //ddldist.DataValueField = "district_id";
        //ddldist.DataBind();
    }

    protected void fillGrid()
    {
        string selQry = "select * from tbl_place p inner join tbl_district d on p.district_id=d.district_id";
        obj.fillGrid(selQry, GridView1);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "dele")
        {
            int placeidno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_place where place_id='" + placeidno + "'";
            obj.ExcecuteCommand(delQry);
            fillGrid();

        }
        if (e.CommandName == "ed")
        {
            edID=Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_place p inner join tbl_district d on p.district_id=d.district_id where place_id='" + edID + "'";
            DataTable dt = new DataTable();
            dt = obj.selCommand(selQry);
            ddldist.SelectedValue = dt.Rows[0]["district_id"].ToString();
            txtplace.Text = dt.Rows[0]["place_name"].ToString();
            txtpincode.Text = dt.Rows[0]["place_pincode"].ToString();
            flag = 1;
            fillGrid();
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}