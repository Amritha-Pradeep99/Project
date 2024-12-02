using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Class_10_LiteralExample : System.Web.UI.Page
{
    MyProject obj = new MyProject();
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
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string sel = "select * from tbl_employee";
        DataTable dt = new DataTable();
        dt=obj.selCommand(sel);
        if (dt.Rows.Count > 0)
        {
            ltrlEmployee.Text = "<table border='1' >";
            ltrlEmployee.Text += "<tr><td><b>ID</b></td>";
            ltrlEmployee.Text += "<td><b>Name</b></td>";
            ltrlEmployee.Text += "<td><b>Gender</b></td><td><b>Dept</b></td><td><b>Salary</b></td></tr>";
            
            for (int i = 0; i <dt.Rows.Count; i++)
            {
                ltrlEmployee.Text += "<tr><td>" + dt.Rows[i]["empid"].ToString() + "</td>";
                ltrlEmployee.Text += "<td>" + dt.Rows[i]["empname"].ToString() + "</td>";
                ltrlEmployee.Text += "<td>" + dt.Rows[i]["empgender"].ToString() + "</td>";
                ltrlEmployee.Text += "<td>" + dt.Rows[i]["empdept"].ToString() + "</td>";
                ltrlEmployee.Text += "<td>" + dt.Rows[i]["empsalary"].ToString() + "</td></tr>";
            }
            ltrlEmployee.Text += "</table>";
        }
        else
        {
            ltrlEmployee.Text = "no such record ";
        }
    }

    protected void  btnSave_Click(object sender, EventArgs e)
    {
        string ins = "insert into tbl_employee(empname,empgender,empdept,empsalary)values('" + txtname.Text + "','" + rdbgender.SelectedValue + "','" + ddldept.SelectedValue + "'," + txtsalary.Text + ")";
        obj.ExcecuteCommand(ins);
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string sel = "select * from tbl_employee where empid=" + txtid.Text + "";
        DataTable dt = new DataTable();
        dt = obj.selCommand(sel);

        if (dt.Rows.Count > 0)
        {
            ltrlEmployee.Text = "<table border='1'>";
            ltrlEmployee.Text += "<tr><td><b>ID</b></td>";
            ltrlEmployee.Text += "<td><b>Name</b></td>";
            ltrlEmployee.Text += "<td><b>Gender</b></td><td><b>Dept</b></td><td><b>Salary</b></td></tr>";

            ltrlEmployee.Text += "<tr><td>" + dt.Rows[0]["empid"].ToString() + "</td>";
            ltrlEmployee.Text += "<td>" + dt.Rows[0]["empname"].ToString() + "</td>";
            ltrlEmployee.Text += "<td>" + dt.Rows[0]["empgender"].ToString() + "</td>";
            ltrlEmployee.Text += "<td>" + dt.Rows[0]["empdept"].ToString() + "</td>";
            ltrlEmployee.Text += "<td>" + dt.Rows[0]["empsalary"].ToString() + "</td></tr>";
         
            ltrlEmployee.Text += "</table>";
        }
        else
        {
            ltrlEmployee.Text = "no such record ";
        }
    }
}
   