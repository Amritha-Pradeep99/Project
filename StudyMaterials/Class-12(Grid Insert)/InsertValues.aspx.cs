using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Class_12_Grid_Insert_InsertValues : System.Web.UI.Page
{
    MyProject obj = new MyProject();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillDept();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string ins = "insert into tbl_employee(empname,empgender,empdept,empsalary)values('" + txtname.Text + "','" + rdbgender.SelectedValue + "','" + ddldept.SelectedValue + "'," + txtsalary.Text + ")";
        obj.ExcecuteCommand(ins);
    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("IT");
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string sel = "select * from tbl_employee";
        obj.fillGrid(sel,grdDetails);
    }
    protected void fillDetails()
    {
        string sel = "select * from tbl_employee";
        obj.fillGrid(sel, grdDetails);
    }
    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            string del = "delete from tbl_employee where empid=" + id + "";
            obj.ExcecuteCommand(del);
            fillDetails();

        }

        if (e.CommandName == "save")
        {
            TextBox txtna = (TextBox)grdDetails.FooterRow.FindControl("txtna");
            RadioButtonList rdbgen = (RadioButtonList)grdDetails.FooterRow.FindControl("rdbgen");
            DropDownList ddldep = (DropDownList)grdDetails.FooterRow.FindControl("ddldep");
            TextBox txtsal = (TextBox)grdDetails.FooterRow.FindControl("txtsal");

            string ins = "insert into tbl_employee(empname,empgender,empdept,empsalary)values('" + txtna.Text + "','" + rdbgen.SelectedValue + "','" + ddldep.SelectedValue + "',"+txtsal.Text+")";
            obj.ExcecuteCommand(ins);

            fillDetails();

        }

    }
    protected void grdDetails_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}