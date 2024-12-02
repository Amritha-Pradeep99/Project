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
    cls_StoredProcedureCommon obj = new cls_StoredProcedureCommon();
    static int idno, flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillDistrict();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string tablename = "tbl_place";
            string updationset = "district_id='" + ddldistrict.SelectedValue + "',place_name='" + txtplace.Text + "',place_pincode='" + txtpincode.Text + "'";
            string conditionfield = "place_id";
            string conditionvalue = "" + idno + "";
            obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionvalue);
            flag = 0;
        }
        else
        {
            string tablename = "tbl_place";
            string fieldset = "place_name,place_pincode,district_id";
            string valueset = "'" + txtplace.Text + "','" + txtpincode.Text + "','" + ddldistrict.SelectedValue + "'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, valueset);
        }
    }
    protected void fillDistrict()
    {
        string tablename = "tbl_district";
        string fieldset = "*";
        DataTable dt = new DataTable();
        dt = obj.SelectAllCommonProcedure(tablename, fieldset);
        ddldistrict.DataSource = dt;
        ddldistrict.DataTextField = "district_name";
        ddldistrict.DataValueField = "district_id";
        ddldistrict.DataBind();
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_place";
        string fieldset = "*";
        obj.FillGridProcedure(tablename, fieldset, gdDetails);
        
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_place";
        string fieldset = "*";
        string conditionset = "place_id='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        gdDetails.DataSource = dt;
        gdDetails.DataBind();

    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_place"; ;
        string fieldset = "*";
        string conditionset = "place_id='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        if (dt.Rows.Count > 0)
        {
            obj.DeleteCommonProcedure(tablename, conditionset);
            lblmsg.Text = "Record Deleted..";
            obj.FillGridProcedure(tablename, fieldset, gdDetails);
        }
        else
        {
            lblmsg.Text = "Record Not Found..";
        }
    }
    protected void gdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int deleteID = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_place";
            string conditionset = "place_id='" + deleteID + "'";
            obj.DeleteCommonProcedure(tablename, conditionset);

            string fieldset = "*";
            obj.FillGridProcedure(tablename, fieldset, gdDetails);

        }
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_place";
            string conditionset = "place_id='" + idno + "'";
            string fieldset = "*";
            DataTable dt = new DataTable();
            dt=obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
            if (dt.Rows.Count > 0)
            {
                ddldistrict.SelectedValue = dt.Rows[0]["district_id"].ToString();
                txtplace.Text = dt.Rows[0]["place_name"].ToString();
                txtpincode.Text = dt.Rows[0]["place_pincode"].ToString();
            }
            flag = 1;
            
        }
    }
    protected void gdDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdDetails.PageIndex = e.NewPageIndex;

    }
}