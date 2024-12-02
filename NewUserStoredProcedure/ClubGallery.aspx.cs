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
    static int flag, idno;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillDistrict();
            fillClub();
            fillDetails();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string tablename = "tbl_clubgallery";
            string updationset = "nc_id='" + ddlclub.SelectedValue + "',clubgallery_caption='" + txtcaption.Text + "',clubgallery_filename='" + txtfilename.Text + "'";
            string conditionfield = "clubgallery_id";
            string conditionvalue = "" + idno + "";
            obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionvalue);
            flag = 0;
        }
        else
        {
            string tablename = "tbl_clubgallery";
            string fieldset = "nc_id,clubgallery_caption,clubgallery_filename";
            string valueset = "'" + ddlclub.SelectedValue + "','" + txtcaption.Text + "','" + txtfilename.Text + "'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, valueset);
        }
        fillDetails();

        ddldistrict.ClearSelection();
        ddlplace.ClearSelection();
        ddlclub.ClearSelection();
        txtcaption.Text = "";
        txtfilename.Text = "";
    }
    public void fillDistrict()
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
    protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        string tablename = "tbl_place";
        string fieldset = "*";
        string conditionset = "district_id='" + ddldistrict.SelectedValue + "'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        ddlplace.DataSource = dt;
        ddlplace.DataTextField = "place_name";
        ddlplace.DataValueField = "place_id";
        ddlplace.DataBind();
    }
    protected void fillClub()
    {
        string tablename = "tbl_newclub";
        string fieldset = "*";
        DataTable dt = new DataTable();
        dt = obj.SelectAllCommonProcedure(tablename, fieldset);
        ddlclub.DataSource = dt;
        ddlclub.DataTextField = "nc_name";
        ddlclub.DataValueField = "nc_id";
        ddlclub.DataBind();
    }
    protected void fillDetails()
    {
        string tablename = "tbl_clubgallery";
        string table1 = "tbl_newclub";
        string table2 = "tbl_place";
        string table3 = "tbl_district";
        string fieldset = "*";
        string fields = "nc_id,place_id,district_id";
        string condition1 = "tbl_clubgallery.nc_id=tbl_newclub.nc_id";
        string condition2 = "tbl_place.place_id=tbl_newclub.place_id";
        string condition3 = "tbl_district.district_id=tbl_place.district_id";
        DataTable dt = new DataTable();
        dt = obj.selectCommonProcedureInnerInnerInner(tablename, table1, table2, table3, fieldset, fields, condition1, condition2, condition3);
        obj.FillGridProcedureInnerInnerInner(tablename, table1, table2, table3, fieldset, fields, condition1, condition2, condition3, DataList1);
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int delID=Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_clubgallery";
            string conditionset = "clubgallery_id='"+delID+"'";
            obj.DeleteCommonProcedure(tablename, conditionset);
            fillDetails();
        }
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_clubgallery";
            string table1 = "tbl_newclub";
            string table2 = "tbl_place";
            string table3 = "tbl_district";
            string fieldset = "*";
            string fields = "nc_id,place_id,district_id";
            string condition1 = "tbl_clubgallery.nc_id=tbl_newclub.nc_id";
            string condition2 = "tbl_place.place_id=tbl_newclub.place_id";
            string condition3 = "tbl_district.district_id=tbl_place.district_id";
            string conditionset = "clubgallery_id='"+idno+"'";
            DataTable dt = new DataTable();
            dt = obj.selectConditionCommonProcedureInnerInnerInner(tablename, table1, table2, table3, fieldset, fields, condition1, condition2, condition3, conditionset);
            if (dt.Rows.Count > 0)
            {
                ddlclub.SelectedValue = dt.Rows[0]["nc_id"].ToString();
                txtcaption.Text = dt.Rows[0]["clubgallery_caption"].ToString();
                txtfilename.Text = dt.Rows[0]["clubgallery_filename"].ToString();
                ddlplace.SelectedValue = dt.Rows[0]["place_id"].ToString();
            }
            flag = 1;
        }
        fillDetails();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        ddldistrict.ClearSelection();
        ddlplace.ClearSelection();
        ddlclub.ClearSelection();
        txtcaption.Text = "";
        txtfilename.Text = "";
    }
    
}