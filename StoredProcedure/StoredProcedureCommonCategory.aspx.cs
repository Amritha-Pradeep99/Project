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
    static int idno, flag;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string tablename = "tbl_category";
            string updationset = "ct_name='"+txtcategory.Text+"'";
            string conditionfield = "ct_id";
            string conditionvalue = ""+idno+"";
            obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionvalue);

            string fieldset = "*";
            obj.FillGridProcedure(tablename, fieldset, gdDetails);
            flag = 0;
        }
        else
        {
            string tablename = "tbl_category";
            string fieldset = "ct_name";
            string valueset = "'" + txtcategory.Text + "'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, valueset);
        }
        
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_category";
        string fieldset = "*";
        obj.FillGridProcedure(tablename, fieldset, gdDetails);
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_category";
        string fieldset = "*";
        string conditionset = "ct_id='"+txtid.Text+"'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        gdDetails.DataSource = dt;
        gdDetails.DataBind();

    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_category";
        string fieldset = "*";
        string conditionset = "ct_id='" + txtid.Text + "'";
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
            lblmsg.Text = "Record not found..";
        }
        
    }
    protected void gdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int delID = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_category";
            string conditionset = "ct_id='" + delID + "'";
            obj.DeleteCommonProcedure(tablename, conditionset);

            string fieldset = "*";
            obj.FillGridProcedure(tablename, fieldset, gdDetails);
        }
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_category";
             string fieldset = "*";
            string conditionset = "ct_id='" + idno + "'";
            DataTable dt = new DataTable();
            dt=obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
            if (dt.Rows.Count > 0)
            {
                txtcategory.Text = dt.Rows[0]["ct_name"].ToString();
            }
            flag = 1;
        }
    }
}