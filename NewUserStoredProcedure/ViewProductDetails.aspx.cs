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
        BulletedList1.DataSource = dt;
        BulletedList1.DataTextField = "ct_name";
        BulletedList1.DataValueField = "ct_id";
        BulletedList1.DataBind();
        obj.FillCommonProcedure(tablename, fieldset, BulletedList1);

    }
    protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
    {
        ListItem li = BulletedList1.Items[e.Index];
        lblmsg.Text = "you selected ="+li.Text+"with value="+li.Value+"index="+e.Index.ToString();

        string tablename = "tbl_product";
        string table1 = "tbl_subcategory";
        string table2 = "tbl_category";
        string fieldset = "*";
        string fields = "subcategory_id,ct_id";
        string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
        string condition2 = "tbl_subcategory.ct_id=tbl_category.ct_id";
        string conditionset = "tbl_subcategory.ct_id='"+li.Value+"'";
        DataTable dt = new DataTable();
        dt = obj.selectConditionCommonProcedureInnerInner(tablename, table1, table2, fieldset, fields, condition1, condition2, conditionset);
        GridView1.DataSource = dt;
        GridView1.DataBind();
       
    }
}