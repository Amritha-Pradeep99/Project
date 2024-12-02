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
        if (!Page.IsPostBack)
        {
            fillDept();
        }

    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("IT");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("ME");
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string tablename = "tbl_employee";
            string updationset = "empname='" + txtname.Text + "',empgender='" + rblgender.SelectedValue + "',empdept='" + ddldept.SelectedValue + "',empsalary='" + txtsalary.Text + "'";
            string conditionset = "empid";
            string conditionvalue = ""+idno+"";
            obj.UpdateCommonProcedure(tablename, updationset, conditionset, conditionvalue);

            string fieldset = "*";
            obj.FillGridProcedure(tablename, fieldset, GridView1);
            flag = 0;
        }
        else
        {
            string tablename = "tbl_employee";
            string fieldset = "empname,empgender,empdept,empsalary";
            string valueset = "'" + txtname.Text + "','" + rblgender.SelectedValue + "','" + ddldept.SelectedValue + "','" +txtsalary.Text+ "'";
            obj.ExcecuteCommonProcedure(tablename, fieldset, valueset);

        }
    }

    protected void btnshow_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_employee";
        string fieldset = "*";
        obj.FillGridProcedure(tablename, fieldset, GridView1);
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_employee";
        string fieldset = "*";
        string conditionset = "empid='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_employee";
        string fieldset = "*";
        string conditionset = "empid='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);

        if (dt.Rows.Count > 0)
        {
            obj.DeleteCommonProcedure(tablename, conditionset);
            lblmsg.Text = "Record Deleted...";
            obj.FillGridProcedure(tablename, fieldset, GridView1);
        }
        else
        {
            lblmsg.Text = "No Record Found...";
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_employee";
            string fieldset = "*";
            string conditionset = "empid='"+idno+"'";
            DataTable dt = new DataTable();
            dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);

            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0]["empname"].ToString();
                rblgender.SelectedValue = dt.Rows[0]["empgender"].ToString();
                ddldept.SelectedValue = dt.Rows[0]["empdept"].ToString();
                txtsalary.Text = dt.Rows[0]["empsalary"].ToString(); 
            }
            flag = 1;
        }
        if (e.CommandName == "del")
        {
            int deleteID = Convert.ToInt32(e.CommandArgument.ToString());
            string tablename = "tbl_employee";
            string conditionset = "empid='"+deleteID+"'";
            obj.DeleteCommonProcedure(tablename, conditionset);

            string fieldset = "*";
            obj.FillGridProcedure(tablename, fieldset,GridView1);
        }
    }
}