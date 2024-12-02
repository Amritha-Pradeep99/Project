using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Test_Default : System.Web.UI.Page
{
    cls_ADO obj = new cls_ADO();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillClass();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_grdstudent(studname,studgender,clsid)values('" + txtname.Text + "','" + rdbgender.SelectedValue + "','" + ddlclass.SelectedValue + "')";
        obj.executeQuery(insQry);

        txtname.Text = "";
        rdbgender.ClearSelection();
        ddlclass.ClearSelection();
    }
   
    protected void fillClass()
    {
        string selQry = "select * from tbl_grdclass";
        obj.fillDDL(ddlclass, "clsname","clsid", selQry);
    }

    protected void fillDetails()
    {
        string selQry = "select st.*,cls.* from tbl_grdstudent st,tbl_grdclass cls where cls.clsid=st.clsid";
        obj.fillGrid(grdDetails, selQry);
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string selQry = "select st.*,cls.* from tbl_grdstudent st,tbl_grdclass cls where cls.clsid=st.clsid";
        obj.fillGrid(grdDetails, selQry);
    }
    protected void grdDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdDetails.EditIndex = -1;
        fillDetails();
    }
    protected void grdDetails_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdDetails.EditIndex = e.NewEditIndex;
        fillDetails();
    }
    protected void grdDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            DropDownList ddlcl = (DropDownList)e.Row.FindControl("ddlcl");
            TextBox txtcl = (TextBox)e.Row.FindControl("txtcl");

            string sel = "select * from tbl_grdclass";
            obj.fillDDL(ddlcl, "clsname", "clsid", sel);
            if (txtcl != null)
            {
                ddlcl.SelectedValue = ddlcl.Items.FindByText(txtcl.Text).Value;

            }


            RadioButtonList rdbgen = (RadioButtonList)e.Row.FindControl("rdbgen");
            TextBox txtgen = (TextBox)e.Row.FindControl("txtgen");

            if (txtgen != null)
            {
                if (txtgen.Text == "Male") 
                {
                    rdbgen.Items[0].Selected = true;
                    rdbgen.Items[1].Selected = false;
                }
                else
                {
                    rdbgen.Items[0].Selected = false;
                    rdbgen.Items[1].Selected = true;
                }
            }

        }
    }
    
    protected void grdDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int idno = Convert.ToInt32(grdDetails.DataKeys[e.RowIndex].Value);
        TextBox txtna = (TextBox)grdDetails.Rows[e.RowIndex].FindControl("txtna");
        RadioButtonList rdbgen = (RadioButtonList)grdDetails.Rows[e.RowIndex].FindControl("rdbgen");
        DropDownList ddlcl = (DropDownList)grdDetails.Rows[e.RowIndex].FindControl("ddlcl");

        string upQry = "update tbl_grdstudent set studname='" + txtna.Text + "',studgender='" + rdbgen.SelectedValue + "',clsid='" + ddlcl.SelectedValue + "' where studid='" + idno + "'";
        obj.executeQuery(upQry);

        grdDetails.EditIndex = -1;
        fillDetails();
    }
   
   
}