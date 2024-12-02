using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Class_18_Stored_Procedure_StoreProcedure_3_Common_ : System.Web.UI.Page
{
    cls_StoredProcedureCommon obj = new cls_StoredProcedureCommon();
    static int flag, idno;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillDept();
        }
    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("IT");
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {

            string tblname = "tbl_employee";
            string updationset = "empname='" + txtname.Text + "',empgender='" + rdbgender.SelectedValue + "',empdept='" + ddldept.SelectedValue + "',empsalary=" + Convert.ToInt32(txtsalary.Text) + "";
            string conditionfield = "empid";
            string conditionvalue = "" + idno + "";

            obj.UpdateCommonProcedure(tblname, updationset, conditionfield, conditionvalue);

            string filedset = "*";
            obj.FillGridProcedure(tblname, filedset, grdDetails);

            flag = 0;
        }
        else
        {
            string tblname = "tbl_employee";
            string fieldset = "empname,empgender,empdept,empsalary";
            string valueset = "'" + txtname.Text + "','" + rdbgender.SelectedValue + "','" + ddldept.SelectedValue + "'," + Convert.ToInt32(txtsalary.Text) + "";

            obj.ExcecuteCommonProcedure(tblname, fieldset, valueset);
        

        }


    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string tblname = "tbl_employee";
        string filedset = "*";

        obj.FillGridProcedure(tblname, filedset, grdDetails);

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string tblname = "tbl_employee";
        string filedset = "*";   
        string conditionset = "empid=" + txtid.Text + "";

        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tblname, filedset, conditionset);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_employee";
        string fieldset = "*";
        string conditionset = "empid=" + txtid.Text + "";
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
            lblmsg.Text = "NoRecord Found...";
        }

    }
    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edt")
        {

            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string tblname = "tbl_employee";
            string fieldset = "*";
            string conditionset = "empid=" + idno + "";

            DataTable dt = new DataTable();

            dt = obj.SelectConditionCommonProcedure(tblname, fieldset, conditionset);

            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0]["empname"].ToString();
                rdbgender.SelectedValue = dt.Rows[0]["empgender"].ToString();
                ddldept.SelectedValue = dt.Rows[0]["empdept"].ToString();
                txtsalary.Text = dt.Rows[0]["empsalary"].ToString();
            }
            flag = 1;
        }

    }
    protected void grdDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string tblname = "tbl_employee";
        int id = Convert.ToInt32(grdDetails.DataKeys[e.RowIndex].Value);
        string conditionset = "empid=" + id + "";
        obj.DeleteCommonProcedure(tblname, conditionset);
        
        string filedset = "*";
        obj.FillGridProcedure(tblname, filedset, grdDetails);

    }
}