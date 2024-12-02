using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class StoredProcedure_Default : System.Web.UI.Page
{
    cls_StoredProcedureCommon obj = new cls_StoredProcedureCommon();
    static int flag, idno;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillCategory();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string tablename = "tbl_subcategory";
            string updationset = "ct_id='" + ddlcategory.SelectedValue + "',subcategory_name='" +txtsubname.Text + "'";
            string conditionfield = "subcategory_id";
            string conditionvalue = "" + idno + "";
            obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionvalue);
            
            
            flag = 0;
        }
        else
        {
            string tablename = "tbl_subcategory";
            string fieldset = "ct_id,subcategory_name";
            string valueset = "'"+ddlcategory.SelectedValue+"','"+txtsubname.Text+"'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, valueset);

        }
    }
    protected void fillCategory()
    {
        string tablename = "tbl_category";
        string fieldset = "*";
        DataTable dt = new DataTable();
        dt = obj.SelectAllCommonProcedure(tablename, fieldset);
        ddlcategory.DataSource = dt;
        ddlcategory.DataTextField = "ct_name";
        ddlcategory.DataValueField = "ct_id";
        ddlcategory.DataBind();
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_subcategory";
        string tableset = "tbl_category";
        string fieldset = "*";
        string fields = "ct_id";
        string conditionset = "tbl_subcategory.ct_id=tbl_category.ct_id";
        DataTable dt = new DataTable();
        dt = obj.SelectCommonProcedure(tablename,tableset, fieldset,fields, conditionset);
        obj.FillGridProcedureInner( tablename, tableset,  fieldset, fields, conditionset,gdDetails);
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_subcategory";
        string tableset = "tbl_category";
        string fieldset = "*";
        string fields = "ct_id";
        string condition = "tbl_subcategory.ct_id=tbl_category.ct_id";
        string conditionset = "subcategory_id='"+ txtid.Text +"'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedureInner(tablename, tableset, fieldset, fields, condition, conditionset);
        gdDetails.DataSource = dt;
        gdDetails.DataBind();
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_subcategory";
        string tableset = "tbl_category";
        string fieldset = "*";
        string fields = "ct_id";
        string condition = "tbl_subcategory.ct_id=tbl_category.ct_id";
        string conditionset = "subcategory_id='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedureInner(tablename, tableset, fieldset, fields, condition, conditionset);
        if (dt.Rows.Count > 0)
        {
            obj.DeleteCommonProcedure(tablename, conditionset);
            lblmsg.Text = "Record Deleted.....";
            obj.FillGridProcedureInner(tablename, tableset, fieldset, fields, conditionset, gdDetails);
        }
        else
        {
            lblmsg.Text = "Record not found.....";
        }


    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int delID = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_subcategory";
            string conditionset = "subcategory_id='" + delID + "'";
            obj.DeleteCommonProcedure(tablename, conditionset);

            
        }
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_subcategory";
            string tableset = "tbl_category";
            string fieldset = "*";
            string fields = "ct_id";
            string condition = "tbl_subcategory.ct_id=tbl_category.ct_id";
            string conditionset = "subcategory_id='" + idno + "'";
            DataTable dt = new DataTable();
            dt = obj.SelectConditionCommonProcedureInner(tablename, tableset, fieldset, fields, condition, conditionset);
            if (dt.Rows.Count > 0)
            {
                ddlcategory.SelectedValue = dt.Rows[0]["ct_id"].ToString();
                txtsubname.Text = dt.Rows[0]["subcategory_name"].ToString();
            }
            flag = 1;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdDetails.PageIndex = e.NewPageIndex;
    }
}