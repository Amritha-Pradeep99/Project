using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;


public partial class Class_18_Stored_Procedure_StoreProcedure_2_generalClass_ : System.Web.UI.Page
{
    static int idno, flag;
   
    cls_StoredProcedure obj = new cls_StoredProcedure();

    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (!Page.IsPostBack)
        {
            fillDept();
        }
    }
    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edt")
        {
            
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            DataTable dt = new DataTable();
            dt=obj.SelectProcedure("selectRecords", idno);

            txtname.Text = dt.Rows[0]["empname"].ToString();
            txtsalary.Text = dt.Rows[0]["empsalary"].ToString();
            rdbgender.SelectedValue = dt.Rows[0]["empgender"].ToString();
            ddldept.SelectedValue = dt.Rows[0]["empdept"].ToString();

            flag = 1;



        }
    }
    protected void grdDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(grdDetails.DataKeys[e.RowIndex].Value);

        obj.DeleteProcedure("deleteRecords", id);

        fillDetails();

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {

            obj.UpdateProcedure("updateRecords", txtname.Text, rdbgender.SelectedValue, ddldept.SelectedValue,Convert.ToInt32(txtsalary.Text), idno);
            
            flag = 0;

        }
        else
        {

            obj.ExceuteProcedure("insertRecords", txtname.Text, rdbgender.SelectedValue, ddldept.SelectedValue, Convert.ToInt32(txtsalary.Text));
            
        }

        fillDetails();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        obj.FillGrid("selectAllRecords", grdDetails);
    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("IT");
    }
    protected void fillDetails()
    {
        obj.FillGrid("selectAllRecords", grdDetails);
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        
        DataTable dt = new DataTable();
        dt = obj.SelectProcedure("selectRecords", Convert.ToInt32(txtid.Text));
        grdDetails.DataSource = dt;
        grdDetails.DataBind();

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = obj.SelectProcedure("selectRecords", Convert.ToInt32(txtid.Text));
        if (dt.Rows.Count > 0)
        {
            obj.DeleteProcedure("deleteRecords", Convert.ToInt32(txtid.Text));
            lblmsg.Text = "RecordDeleted....";
        }
        else
        {
            lblmsg.Text = "No Record....";
        }
    }
}