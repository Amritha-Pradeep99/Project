using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Sales_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
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
        string insQry = "insert into tbl_customer(customer_name,customer_address,customer_email,customer_contact,place_id)values('"+txtname.Text+"','"+txtaddress.Text+"','"+txtemail.Text+"','"+txtcontact.Text+"','"+ddlplace.SelectedValue+"')";
        obj.ExcecuteCommand(insQry);

        txtname.Text = "";
        txtaddress.Text = "";
        txtemail.Text = "";
        txtcontact.Text = "";
       ddlplace.ClearSelection();

       fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtaddress.Text="";
        txtemail.Text="";
        txtcontact.Text="";
        ddlplace.ClearSelection();
    }
    protected void fillDistrict()
    {
        string selQry = "select * from tbl_district";
        obj.fillDropDown(ddldistrict,"district_name","district_id",selQry);
       
    }
    protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_place where district_id='" + ddldistrict.SelectedValue + "'";
        obj.fillDropDown(ddlplace,"place_name","place_id",selQry);
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_customer c inner join tbl_place p on c.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id";
        obj.fillGrid(selQry, GridView1);
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
    }
}