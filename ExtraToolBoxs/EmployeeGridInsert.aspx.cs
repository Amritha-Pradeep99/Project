using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Admin_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillDept();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_employee(empname,empgender,empdept,empsalary)values('"+txtname.Text+"','"+rblgender.SelectedValue+"','"+ddldept.SelectedValue+"','"+txtsalary.Text+"')";
        obj.ExcecuteCommand(insQry);
    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("IT");
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_employee";
        obj.fillGrid(selQry, gddetails);
    }

    protected void fillDetails()
    {
        string selQry = "select * from tbl_employee";
        obj.fillGrid(selQry, gddetails);
    }

    protected void gddetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_employee where empid='"+idno+"'";
            obj.ExcecuteCommand(delQry);

            fillDetails();
        }
        if (e.CommandName == "save")
        {
            TextBox txtna = (TextBox)gddetails.FooterRow.FindControl("txtna");
            RadioButtonList rblgend = (RadioButtonList)gddetails.FooterRow.FindControl("rblgend");
            DropDownList ddldep = (DropDownList)gddetails.FooterRow.FindControl("ddldep");
            TextBox txtsal = (TextBox)gddetails.FooterRow.FindControl("txtsal");

            string insQry = "insert into tbl_employee(empname,empgender,empdept,empsalary)values('" + txtna.Text + "','" + rblgend.SelectedValue + "','" + ddldep.SelectedValue + "','" + txtsal.Text + "')";
            obj.ExcecuteCommand(insQry);

            fillDetails();
        }
       
    }
    protected void gddetails_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}