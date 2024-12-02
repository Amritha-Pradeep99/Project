using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;

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
        string photoimage = Path.GetFileName(filephoto.PostedFile.FileName.ToString());
        filephoto.SaveAs(Server.MapPath("../Assests/Product/"+photoimage));

        if (flag == 1)
        {
            string upQry = "update tbl_product set product_Name='" + txtproductname.Text + "',product_price='" + txtprice.Text + "',product_details='" + txtdetails.Text + "',subcategory_id='" + ddlsubcategory.SelectedValue + "' where product_id='" + editID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_product(product_Name,product_price,product_details,subcategory_id,product_photo)values('" + txtproductname.Text + "','" + txtprice.Text + "','" + txtdetails.Text + "','" + ddlsubcategory.SelectedValue + "','" + photoimage + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }

            txtproductname.Text = "";
            txtprice.Text = "";
            txtdetails.Text = "";

            fillGrid();
        
    }
    protected void fillcategory()
    {
        string selQry = "select * from tbl_category";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlcategory.DataSource = dt;
        ddlcategory.DataTextField = "ct_name";
        ddlcategory.DataValueField = "ct_id";
        ddlcategory.DataBind();

       
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_product p inner join tbl_subcategory s on p.subcategory_id=s.subcategory_id  inner join tbl_category c on c.ct_id=s.ct_id";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        gdP.DataSource = dt;
        gdP.DataBind();
    }



    protected void gdP_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdP.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtproductname.Text = "";
        txtprice.Text = "";
        txtdetails.Text = "";
    }
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_subcategory where ct_id='" + ddlcategory.SelectedValue + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlsubcategory.DataSource = dt;
        ddlsubcategory.DataTextField = "subcategory_name";
        ddlsubcategory.DataValueField = "subcategory_id";
        ddlsubcategory.DataBind();

    }

    protected void gdP_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int productidno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_product where product_id='" + productidno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
        }
        if (e.CommandName == "ed")
        {
            editID= Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_product p inner join tbl_subcategory s on p.subcategory_id=s.subcategory_id  inner join tbl_category c on c.ct_id=s.ct_id where product_id='" + editID + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtproductname.Text = dt.Rows[0]["product_Name"].ToString();
            txtprice.Text = dt.Rows[0]["product_price"].ToString();
            txtdetails.Text = dt.Rows[0]["product_details"].ToString();
            ddlsubcategory.SelectedValue = dt.Rows[0]["subcategory_id"].ToString();
            flag = 1;
            fillGrid();
        }
            fillGrid();
    }
} 