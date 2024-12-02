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
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    static int flag, edtID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

      
        if (!IsPostBack)
        {


            if (Session["adminid"] == null || string.IsNullOrEmpty(Session["adminid"].ToString()))
            {
                Response.Redirect("../Geust/AdminLogin.aspx");
            }
            else
            {
                fillGrid();
            }
           
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_category set ct_name='" + txtcategory.Text + "'  where ct_id='" + edtID + "'"; 
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            txtcategory.Text = "";
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_category(ct_name)values('" + txtcategory.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            txtcategory.Text = "";
         }

        fillGrid();
    }
     protected void fillGrid()
     {
         string selQry="select * from tbl_category";
         DataTable dt=new DataTable();
         SqlDataAdapter adp=new SqlDataAdapter(selQry,con);
         adp.Fill(dt);
         grdCategory.DataSource=dt;
         grdCategory.DataBind();

     }
    protected void grdCategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
       grdCategory.PageIndex= e.NewPageIndex;
        fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtcategory.Text= "";
    }
    protected void grdCategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int categoryidno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_category where ct_id='" + categoryidno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();

             fillGrid();
        }
        if (e.CommandName == "ed")
        {
            edtID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_category where ct_id='" + edtID + "'"; 
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtcategory.Text = dt.Rows[0]["ct_name"].ToString();
            flag = 1;
            
        }

        
       
            
            
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Logout.aspx");
    }
}