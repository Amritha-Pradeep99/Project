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
        string insQry = "insert into tbl_employee (empname,empgender,empdept,empsalary)values('"+txtname.Text+"','"+rblgender.SelectedValue+"','"+ddldept.SelectedValue+"','"+txtsalary.Text+"')";
        obj.ExcecuteCommand(insQry);
    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0,"--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("IT");
        ddldept.Items.Add("ME");
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_employee ";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        
    }
}