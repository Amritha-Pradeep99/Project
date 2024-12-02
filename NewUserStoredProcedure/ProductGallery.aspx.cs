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
    static int flag, edID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillcategory();
            fillProduct();
            fillDetails();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string tablename = "tbl_productgallery";
            string updationset = "product_id='" + ddlproduct.SelectedValue + "',gallery_caption='" + txtcaption.Text + "',gallery_filename='" + txtfilename.Text + "'";
            string conditionfield = "gallery_id";
            string conditionvalue = "" + edID + "";
            obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionvalue);
            flag = 0;
        }
        else
        {
            string tablename = "tbl_productgallery";
            string fieldset = "product_id,gallery_caption,gallery_filename";
            string valueset = "'" + ddlproduct.SelectedValue + "','" + txtcaption.Text + "','" + txtfilename.Text + "'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, valueset);
        }

        fillDetails();
        ddlsubcategory.ClearSelection();
        ddlproduct.ClearSelection();
        txtcaption.Text = "";
        txtfilename.Text = "";
    }
    protected void fillcategory()
    {
        string tablename= "tbl_category";
        string fieldset = "*";
        DataTable dt = new DataTable();
        dt = obj.SelectAllCommonProcedure(tablename, fieldset);
        ddlcategory.DataSource = dt;
        ddlcategory.DataTextField = "ct_name";
        ddlcategory.DataValueField="ct_id";
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
    protected void fillProduct()
    {
        string tablename = "tbl_product";
        string fieldset = "*";
        DataTable dt = new DataTable();
        dt = obj.SelectAllCommonProcedure(tablename, fieldset);
        ddlproduct.DataSource = dt;
        ddlproduct.DataTextField = "product_Name";
        ddlproduct.DataValueField = "product_id";
        ddlproduct.DataBind();
    }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        ddlsubcategory.ClearSelection();
        ddlproduct.ClearSelection();
        txtcaption.Text = "";
        txtfilename.Text = "";
    }
    protected void fillDetails()
    {
        string tablename = "tbl_productgallery";
        string table1 = "tbl_product";
        string table2 = "tbl_subcategory";
        string table3 = "tbl_category";
        string fieldset = "*";
        string fields = "product_id,subcategory_id,ct_id";
        string condition1 = "tbl_productgallery.product_id=tbl_product.product_id";
        string condition2 = "tbl_subcategory.subcategory_id=tbl_product.subcategory_id";
        string condition3 = "tbl_category.ct_id=tbl_subcategory.ct_id";
        DataTable dt = new DataTable();
        dt = obj.selectCommonProcedureInnerInnerInner(tablename, table1, table2, table3, fieldset, fields, condition1, condition2, condition3);
        obj.FillGridProcedureInnerInnerInner(tablename, table1, table2, table3, fieldset, fields, condition1, condition2, condition3, dlDetails);
        dlDetails.DataSource = dt;
        dlDetails.DataBind();

    }
    protected void dlDetails_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int delID =Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_productgallery";
            string conditionset = "gallery_id='" + delID + "'";
            obj.DeleteCommonProcedure(tablename, conditionset);

            fillDetails();
        }
        if (e.CommandName == "ed")
        {
            edID =Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_productgallery";
            string table1 = "tbl_product";
            string table2 = "tbl_subcategory";
            string table3 = "tbl_category";
            string fieldset = "*";
            string fields = "product_id,subcategory_id,ct_id";
            string condition1 = "tbl_productgallery.product_id=tbl_product.product_id";
            string condition2 = "tbl_subcategory.subcategory_id=tbl_product.subcategory_id";
            string condition3 = "tbl_category.ct_id=tbl_subcategory.ct_id";
            string conditionset = "gallery_id='"+edID+"'";
            DataTable dt = new DataTable();
            dt = obj.selectConditionCommonProcedureInnerInnerInner(tablename, table1, table2, table3, fieldset, fields, condition1, condition2, condition3, conditionset);
            if (dt.Rows.Count>0)
            {
                txtcaption.Text = dt.Rows[0]["gallery_caption"].ToString();
                txtfilename.Text = dt.Rows[0]["gallery_filename"].ToString();
                ddlsubcategory.SelectedValue = dt.Rows[0]["subcategory_id"].ToString();
                ddlproduct.SelectedValue = dt.Rows[0]["product_id"].ToString();
            }
            flag = 1;
        }
        fillDetails();
    }



    
}