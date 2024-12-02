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
    static int flag, idno;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string tablename = "tbl_district";
            string updationset = "district_name='"+txtname.Text+"'";
            string conditionfield = "district_id";
            string conditionvalue = ""+idno+"";
            obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionvalue);

            string fieldset = "*";
            obj.FillGridProcedure(tablename, fieldset, grdDetails);

            flag = 0;
        }
        else
        {

            string tablename = "tbl_district";
            string fieldset = "district_name";
            string valueset = "'"+txtname.Text+"'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, valueset);


        }
       
    }
    
    
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_district";
        string fieldset = "*";
        obj.FillGridProcedure(tablename, fieldset, grdDetails);

    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {

        string tablename = "tbl_district";
        string fieldset = "*";
        string conditionset = "district_id='"+ txtid.Text +"'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();

    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_district";
        string fieldset = "*";
        string conditionset = "district_id='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        if (dt.Rows.Count > 0)
        {
            obj.DeleteCommonProcedure(tablename, conditionset);
            lblmsg.Text = "Record Deleted...";
            obj.FillGridProcedure(tablename, fieldset, grdDetails);
        }
        else
        {
            lblmsg.Text = "No Record Found...";
        }
       

    }
    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int delID = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_district";
            string conditionset = "district_id='" + delID + "'";
            obj.DeleteCommonProcedure(tablename, conditionset);

            string fieldset = "*";
            obj.FillGridProcedure(tablename, fieldset, grdDetails);

        }
        if (e.CommandName == "ed")
        {
            idno=Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_district";
            string fieldset = "*";
            string conditionset = "district_id='" + idno + "'";
            DataTable dt = new DataTable();
            dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);

            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0]["district_name"].ToString();
            }
            flag = 1;
        }

    }
    

}