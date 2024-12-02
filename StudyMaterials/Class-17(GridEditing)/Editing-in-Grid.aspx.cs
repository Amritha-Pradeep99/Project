using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Class_17_GridEditing_Editing_in_Grid : System.Web.UI.Page
{
    cls_ADO obj = new cls_ADO();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillClass();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string ins = "insert into tbl_grdstudent(studname,studgender,clsid)values('" + txtName.Text + "','" + rdbGender.SelectedValue + "'," + ddlClass.SelectedValue + ")";
        obj.executeQuery(ins);
    }
    protected void fillClass()
    {
        string sel = "select * from tbl_grdclass";
        obj.fillDDL(ddlClass, "clsname", "clsid", sel);
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string selqry = "select st.*,cls.* from tbl_grdstudent st,tbl_grdclass cls where cls.clsid=st.clsid";
        obj.fillGrid(grdStudent, selqry);

    }
    protected void fillstudent()
    {
        string selqry = "select st.*,cls.* from tbl_grdstudent st,tbl_grdclass cls where cls.clsid=st.clsid";
        obj.fillGrid(grdStudent, selqry);
    }

    protected void grdStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdStudent.EditIndex = -1; //The EditIndex property of the GridView is set to -1. The EditIndex property determines the index of the row being edited. Setting it to -1 cancels the edit mode for any row, effectively exiting edit mode.
        fillstudent();
    }
    protected void grdStudent_RowEditing(object sender, GridViewEditEventArgs e)//grdStudent_RowEditing: This is the name of the event handler method.
    {
        grdStudent.EditIndex = e.NewEditIndex;//grdStudent.EditIndex = e.NewEditIndex;: The EditIndex property of the GridView is set to the index of the row being edited. The NewEditIndex property of the GridViewEditEventArgs object e holds the index of the row that the user has selected to edit. Setting the EditIndex to this value puts the specified row into edit mode.
        fillstudent();
    }
    protected void grdStudent_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            DropDownList ddlcls = (DropDownList)e.Row.FindControl("ddlCls");//DropDownList ddlcls = (DropDownList)e.Row.FindControl("ddlCls");: Finds the DropDownList control named ddlCls in the current row.
            TextBox txtcls = (TextBox)e.Row.FindControl("txtCls");//TextBox txtcls = (TextBox)e.Row.FindControl("txtCls");: Finds the TextBox control named txtCls in the current row.
            string sel = "select * from tbl_grdclass";//string sel = "select * from tbl_grdclass";: Defines an SQL query to select all records from the tbl_grdclass table.
            obj.fillDDL(ddlcls, "clsname", "clsid", sel);
            if (txtcls != null)
            {
                ddlcls.SelectedValue = ddlcls.Items.FindByText(txtcls.Text).Value;//If the TextBox is not null, it sets the selected value of the DropDownList to match the text in the TextBox.

            }


            RadioButtonList rdbgen = (RadioButtonList)e.Row.FindControl("rdbGen");//Finds the RadioButtonList control named rdbGen in the current row.
            TextBox txtgen = (TextBox)e.Row.FindControl("txtGen");//Finds the TextBox control named txtGen in the current row.

            if (txtgen != null)//If the TextBox is not null, it checks the text value
            {
                if (txtgen.Text == "Male") //If the text is "Male", it selects the first radio button and deselects the second.
                {
                    rdbgen.Items[0].Selected = true;
                    rdbgen.Items[1].Selected = false;
                }
                else//If the text is not "Male", it deselects the first radio button and selects the second.
                {
                    rdbgen.Items[0].Selected = false;
                    rdbgen.Items[1].Selected = true;
                }
            }

        }
    }
    protected void grdStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int idno = Convert.ToInt32(grdStudent.DataKeys[e.RowIndex].Value);//DataKeys: This is a collection within the GridView that holds the values of the primary keys for each row. These keys are specified in the GridView's DataKeyNames property and are used to uniquely identify each row.

        TextBox txtna = (TextBox)grdStudent.Rows[e.RowIndex].FindControl("txtna");
        RadioButtonList rdbgen = (RadioButtonList)grdStudent.Rows[e.RowIndex].FindControl("rdbGen");
        DropDownList ddlcls = (DropDownList)grdStudent.Rows[e.RowIndex].FindControl("ddlCls");

        string upqry = "update tbl_grdstudent set studname='" + txtna.Text + "',studgender='" + rdbgen.SelectedValue + "',clsid=" + ddlcls.SelectedValue + " where studid=" + idno + "";
        obj.executeQuery(upqry);

        grdStudent.EditIndex = -1;
        fillstudent();

    }
}