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
         string photoimage = Path.GetFileName(filephoto.PostedFile.FileName.ToString());
        filephoto.SaveAs(Server.MapPath("../Assests/Product/" + photoimage));

        if (flag == 1)
        {
            string tablename = "tbl_product";
            string updationset = "product_Name='" + txtname.Text + "',product_price='" + txtprice.Text + "',subcategory_id='" + ddlcategory.SelectedValue + "'";
            string conditionfield = "product_id";
            string conditionvalue = "" + idno + "";
            obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionvalue);
            flag = 0;
        }
        else
        {
            string tablename = "tbl_product";
            string fieldset = "product_Name,product_price,subcategory_id,product_photo";
            string values = "'"+txtname.Text+"','"+txtprice.Text+"','"+ddlsubcategory.SelectedValue+"','"+photoimage+"'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, values);
        }
        //string fieldset = "*";
        //obj.FillGridProcedure(
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_product";
        string table1 = "tbl_subcategory";
        string table2 = "tbl_category";
        string fieldset="*";
        string fields = "subcategory_id,ct_id";
        string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
        string condition2 = "tbl_category.ct_id=tbl_subcategory.ct_id";
        DataTable dt = new DataTable();
        dt = obj.selectCommonProcedureInner(tablename, table1,table2, fieldset, fields, condition1, condition2);
        obj.FillGridProcedureInnerInner(tablename, table1, table2, fieldset, fields, condition1, condition2, gddetails);
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_product";
        string table1 = "tbl_subcategory";
        string table2 = "tbl_category";
        string fieldset = "*";
        string fields = "subcategory_id,ct_id";
        string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
        string condition2 = "tbl_category.ct_id=tbl_subcategory.ct_id";
        string conditionset = "product_id='"+txtid.Text+"'";
        DataTable dt = new DataTable();
        dt = obj.selectConditionCommonProcedureInnerInner(tablename, table1, table2, fieldset, fields, condition1, condition2, conditionset);
        gddetails.DataSource = dt;
        gddetails.DataBind();
    }
    protected void fillCategory()
    {
        string tablename = "tbl_category";
        string fieldset = "*";
        DataTable dt = new DataTable();
        dt=obj.SelectAllCommonProcedure(tablename, fieldset);
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
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_product";
        string table1 = "tbl_subcategory";
        string table2 = "tbl_category";
        string fieldset = "*";
        string fields = "subcategory_id,ct_id";
        string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
        string condition2 = "tbl_category.ct_id=tbl_subcategory.ct_id";
        string conditionset = "product_id='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.selectConditionCommonProcedureInnerInner(tablename, table1, table2, fieldset, fields, condition1, condition2, conditionset);
        if (dt.Rows.Count > 0)
        {
            obj.DeleteCommonProcedure(tablename, conditionset);
            lblmsg.Text = "Record Deleted....";
            obj.FillGridProcedureInnerInner(tablename, table1,table2, fieldset, fields, condition1, condition2, gddetails);
        }
        else
        {
            lblmsg.Text = "Record Not Found...";
        }
    }
    
    protected void gddetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int delID = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_product";
            string conditionset = "product_id='"+delID+"'";
            obj.DeleteCommonProcedure(tablename, conditionset);

           
        }
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_product";
            string table1 = "tbl_subcategory";
            string table2 = "tbl_category";
            string fieldset = "*";
            string fields = "subcategory_id,ct_id";
            string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
            string condition2 = "tbl_category.ct_id=tbl_subcategory.ct_id";
            string conditionset = "product_id='" + idno + "'";
            DataTable dt = new DataTable();
            dt = obj.selectConditionCommonProcedureInnerInner(tablename, table1, table2, fieldset, fields, condition1, condition2, conditionset);
            if (dt.Rows.Count > 0)
            {
                ddlcategory.SelectedValue = dt.Rows[0]["ct_id"].ToString();
                ddlsubcategory.SelectedValue = dt.Rows[0]["subcategory_name"].ToString();
                txtname.Text = dt.Rows[0]["product_Name"].ToString();
                txtprice.Text = dt.Rows[0]["product_price"].ToString();
               
            }

            flag = 1;
            
        }
    }

}