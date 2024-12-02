using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Product_Default : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    MyProject obj = new MyProject();
    static int flag, editID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //con.Open();
        if (!IsPostBack)
        {
            fillCategory();
            fillGrid();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string photoimage = Path.GetFileName(filephoto.PostedFile.FileName.ToString());
        filephoto.SaveAs(Server.MapPath("../Assests/Product/" + photoimage));

        if (flag == 1)
        {
            string upQry = "update tbl_product set product_Name='" + txtPname.Text + "',product_price='" + txtprice.Text + "',subcategory_id='" + ddlsubcategory.SelectedValue + "',product_photo='" + photoimage + "' ,product_unit='" + txtunit.Text + "'where product_id='" + editID + "' ";
            //SqlCommand cmd = new SqlCommand(upQry, con);
            //cmd.ExecuteNonQuery();
            obj.selCommand(upQry);
            flag = 0;
        }
        else
        {

            string insQry = "insert into tbl_product (product_Name,product_price,subcategory_id,product_photo,product_unit)values('" + txtPname.Text + "','" + txtprice.Text + "','" + ddlsubcategory.SelectedValue + "','" + photoimage + "','" + txtunit.Text + "')";
            //SqlCommand cmd = new SqlCommand(insQry, con);
            //cmd.ExecuteNonQuery();
            obj.selCommand(insQry);
        }
        fillGrid();

        txtPname.Text = "";
        txtprice.Text = "";
        txtunit.Text = "";
        ddlsubcategory.ClearSelection();
        ddlcategory.ClearSelection();

    }
    protected void fillCategory()
    {
        string selQry = "select * from tbl_category ";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //ddlcategory.DataSource = dt;
        //ddlcategory.DataTextField = "ct_name";
        //ddlcategory.DataValueField = "ct_id";
        //ddlcategory.DataBind();
        obj.fillDropDown(ddlcategory, "ct_name", "ct_id", selQry);
    }
    protected void fillGrid()
    {

        string selQry = "select * from tbl_product  p inner join tbl_subcategory s on p.subcategory_id=s.subcategory_id inner join tbl_category c on c.ct_id=s.ct_id";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);

        //DataList1.DataSource = dt;
        //DataList1.DataBind();

        //Repeater1.DataSource = dt;
        //Repeater1.DataBind();

        //GridView1.DataSource = dt;
        //GridView1.DataBind();
        obj.fillGrid(selQry, DataList1);
        obj.fillGrid(selQry, Repeater1);
        obj.fillGrid(selQry, GridView1);
    }



    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_subcategory where ct_id='"+ddlcategory.SelectedValue+"' ";
        //DataTable dt = new DataTable();
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //adp.Fill(dt);
        //ddlsubcategory.DataSource = dt;
        //ddlsubcategory.DataTextField = "subcategory_name";
        //ddlsubcategory.DataValueField = "subcategory_id";
        //ddlsubcategory.DataBind();
        obj.fillDropDown(ddlsubcategory, "subcategory_name", "subcategory_id", selQry);
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno=Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_product where product_id='" + idno + "'";
            //SqlCommand cmd = new SqlCommand(delQry, con);
            //cmd.ExecuteNonQuery();
            obj.ExcecuteCommand(delQry);
            fillGrid();
        }
        if(e.CommandName == "ed")
        {
            editID=Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_product  p inner join tbl_subcategory s on p.subcategory_id=s.subcategory_id inner join tbl_category c on c.ct_id=s.ct_id where product_id='" + editID + "' ";
            DataTable dt = new DataTable();
            //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            //adp.Fill(dt);
            dt = obj.selCommand(selQry);
            txtPname.Text=dt.Rows[0]["product_Name"].ToString();
            txtprice.Text=dt.Rows[0]["product_price"].ToString();
            txtunit.Text = dt.Rows[0]["product_unit"].ToString();
            ddlsubcategory.SelectedValue = dt.Rows[0]["subcategory_id"].ToString();
            flag = 1;

            fillGrid();
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtPname.Text = "";
        txtprice.Text = "";
        txtunit.Text = "";
        ddlsubcategory.ClearSelection();
        ddlcategory.ClearSelection();
    }
}