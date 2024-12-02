using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;
public partial class StoredProcedure_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    static int editID,flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if(!Page.IsPostBack)
        {
            fillCategory();
            fillDetails();
        }
    }
    
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string photoimage=Path.GetFileName(filePhoto.PostedFile.FileName.ToString());
        filePhoto.SaveAs(Server.MapPath("../Assests/Product/"+photoimage));
        if(flag==1)
        {
            SqlCommand cmd=new SqlCommand("updateRecordsProduct",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@pid",SqlDbType.Int).Value=editID;
            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtname.Text;
            cmd.Parameters.Add("@price",SqlDbType.VarChar).Value=txtprice.Text;
            cmd.Parameters.Add("@subid",SqlDbType.Int).Value=ddlsubcategory.SelectedValue;
            cmd.Parameters.Add("@unit",SqlDbType.VarChar).Value=txtunit.Text;
            cmd.Parameters.Add("@photo", SqlDbType.VarChar).Value = photoimage;
            cmd.ExecuteNonQuery();

            flag=0;
        }
        else
        {
            SqlCommand cmd=new SqlCommand("insertRecordsProduct",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtname.Text;
            cmd.Parameters.Add("@price",SqlDbType.VarChar).Value=txtprice.Text;
            cmd.Parameters.Add("@subid",SqlDbType.Int).Value=ddlsubcategory.SelectedValue;
            cmd.Parameters.Add("@unit",SqlDbType.VarChar).Value=txtunit.Text;
            cmd.Parameters.Add("@photo", SqlDbType.VarChar).Value = photoimage;
            cmd.ExecuteNonQuery();
        }
        fillDetails();
        txtname.Text="";
        txtprice.Text="";
        ddlsubcategory.ClearSelection();
        txtunit.Text = "";
    }
    protected void fillDetails()
    {
        SqlCommand cmd=new SqlCommand("selectAllRecordsProduct",con);
        cmd.CommandType=CommandType.StoredProcedure;
        SqlDataAdapter adp=new SqlDataAdapter();
        DataTable dt=new DataTable();
        adp.SelectCommand=cmd;
        adp.Fill(dt);
        gdProduct.DataSource=dt;
        gdProduct.DataBind();
    }
    protected void fillCategory()
    {
        SqlCommand cmd=new SqlCommand("selectAllRecordsCategory",con);
        cmd.CommandType=CommandType.StoredProcedure;
        SqlDataAdapter adp=new SqlDataAdapter();
        DataTable dt=new DataTable();
        adp.SelectCommand=cmd;
        adp.Fill(dt);
        ddlcategory.DataSource=dt;
        ddlcategory.DataTextField="ct_name";
        ddlcategory.DataValueField="ct_id";
        ddlcategory.DataBind();
    }
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        SqlCommand cmd = new SqlCommand("selectSubcategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@cid", SqlDbType.Int).Value = ddlcategory.SelectedValue;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        ddlsubcategory.DataSource = dt;
        ddlsubcategory.DataTextField = "subcategory_name";
        ddlsubcategory.DataValueField = "subcategory_id";
        ddlsubcategory.DataBind();

    }
    
    protected void gdProduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName=="del")
        {
            int delID=Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd=new SqlCommand("deleteRecordsProduct",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@pid",SqlDbType.Int).Value=delID;
            SqlDataAdapter adp=new SqlDataAdapter();
            DataTable dt=new DataTable();
            adp.SelectCommand=cmd;
            adp.Fill(dt);

        }
        if(e.CommandName=="ed")
        {
            editID=Convert.ToInt32(e.CommandArgument.ToString());
            SqlCommand cmd=new SqlCommand("selectRecordsProduct",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@pid",SqlDbType.Int).Value=editID;
            SqlDataAdapter adp=new SqlDataAdapter();
            DataTable dt=new DataTable();
            adp.SelectCommand=cmd;
            adp.Fill(dt);
            txtname.Text=dt.Rows[0]["product_Name"].ToString();
            txtprice.Text=dt.Rows[0]["product_price"].ToString();
            ddlcategory.SelectedValue = dt.Rows[0]["ct_id"].ToString();
            ddlsubcategory.SelectedValue=dt.Rows[0]["subcategory_id"].ToString();
            txtunit.Text=dt.Rows[0]["product_unit"].ToString();

            flag=1;
        }
        fillDetails();
    }
     protected void gdProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
         gdProduct.PageIndex=e.NewPageIndex;
         fillDetails();
    }
     protected void btncancel_Click(object sender, EventArgs e)
     {

     }
}