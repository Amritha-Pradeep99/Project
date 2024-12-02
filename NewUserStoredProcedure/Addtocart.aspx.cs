using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
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
        string conditionset = "ct_id='"+ddlcategory.SelectedValue+"'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        ddlsubcategory.DataSource = dt;
        ddlsubcategory.DataTextField = "subcategory_name";
        ddlsubcategory.DataValueField = "subcategory_id";
        ddlsubcategory.DataBind();

        fillGrid();
    }
    protected void fillGrid()
    {
        string tablename = "tbl_product";
        string table1 = "tbl_subcategory";
        string table2 = "tbl_category";
        string fieldset = "*";
        string fields = "subcategory_id,ct_id";
        string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
        string condition2 = "tbl_category.ct_id=tbl_subcategory.ct_id";
        DataTable dt = new DataTable();
        dt = obj.selectCommonProcedureInner(tablename, table1, table2, fieldset, fields, condition1, condition2);
        obj.FillGridProcedureInnerInnerdl(tablename, table1, table2, fieldset, fields, condition1, condition2, DataList1);

    }
}