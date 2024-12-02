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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillCategory();
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
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string tablename = "tbl_subcategory";
        string fieldset = "*";
        string conditionfield = "ct_id";
        string conditionvalue = "" + ddlcategory.SelectedValue + "";
        DataTable dt = new DataTable();
        dt = obj.FillDropDownSelectedIndex(tablename, fieldset, conditionfield, conditionvalue);
        ddlsubcategory.DataSource = dt;
        ddlsubcategory.DataTextField = "subcategory_name";
        ddlsubcategory.DataValueField = "subcategory_id";
        ddlsubcategory.DataBind();

        fillProduct();
    }
    protected void fillProduct()
    {
        string tablename = "tbl_product";
        string table1 = "tbl_subcategory";
        string table2 = "tbl_category";
        string fieldset = "*";
        string fields = "subcategory_id,ct_id";
        string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
        string condition2 = "tbl_category.ct_id=tbl_subcategory.ct_id";
        string conditionset = "tbl_subcategory.ct_id='"+ddlcategory.SelectedValue+"'";
        DataTable dt = new DataTable();
        dt = obj.selectConditionCommonProcedureInnerInner(tablename, table1, table2, fieldset, fields, condition1, condition2, conditionset);
        gdDetails.DataSource = dt;
        gdDetails.DataBind();
    }
}