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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    static int Edid, flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillProduct();
            fillGrid();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_stock set stock_qty='" + txtstock.Text + "' where stock_id='" + Edid + "'";
            SqlCommand cmd1 = new SqlCommand(upQry, con);
            cmd1.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_stock (product_id,stock_qty)values('" + ddlproduct.SelectedValue + "','" + txtstock.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();

            
        }
        fillGrid();

        ddlproduct.ClearSelection();
        txtstock.Text = "";
    }
    protected void fillProduct()
    {
        string selQry = "select * from tbl_product ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlproduct.DataSource = dt;
        ddlproduct.DataTextField = "product_Name";
        ddlproduct.DataValueField = "product_id";
        ddlproduct.DataBind();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_stock s inner join tbl_product p on s.product_id=p.product_id ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        gds.DataSource = dt;
        gds.DataBind();
    }

    protected void gds_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gds.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void gds_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_stock where stock_id='"+idno+"'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            int Edid = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_stock  where stock_id='" + Edid + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                txtstock.Text = dt.Rows[0]["stock_qty"].ToString();
            }
            flag = 1;
            fillGrid();
        }
    }
}