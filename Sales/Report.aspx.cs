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
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
           

        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_saleshead where sh_todate BETWEEN '" + txtfromdate.Text + "' and '" + txttodate.Text + "' and  sh_id='" + Session["salesid"] + "' ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_saleshead s  inner join tbl_newuser n on s.nu_id=n.nu_id ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        grdReport.DataSource = dt;
        grdReport.DataBind();
    }
    protected void grdReport_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdReport.PageIndex = e.NewPageIndex;
        fillGrid();
    }


    protected void grdReport_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
        if (e.CommandName == "bill")
        {
            Session["shid"] = e.CommandArgument.ToString();
            Response.Redirect("PurchaseBill.aspx");
          
        }
    }
    
}