using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillGender();
            fillmonth();
            fillDept();
            
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_employee(empname,empgender,empmonth,empdept)values('" + txtname.Text + "','" + ddlgender.SelectedValue + "','"+ddlmonth.SelectedValue+"','" + ddldept.SelectedValue + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();

    }
    protected void fillGender()
    {
        ddlgender.Items.Insert(0, "--select--");
        ddlgender.Items.Add("Male");
        ddlgender.Items.Add("Female");
    }
   
    protected void fillmonth()
    {

        string str = DateTime.Now.ToShortDateString();
        DateTime cmonh = DateTime.Parse(str);
        string mon = cmonh.ToString("MMMM");
        if (ddlmonth.SelectedItem.Text != mon)
        {
            ddlmonth.ClearSelection();
            ddlmonth.Items.FindByText(mon).Selected = true;
        }


        //DateTime month = DateTime.Parse("1/1/1990");
        //for (int i = 0; i < 12; i++)
        //{
        //    DateTime nmonth = month.AddMonths(i);
        //    string months = nmonth.ToString("MMMM");
        //    ddlmonth.Items.Insert(i, months);
        //}

    }
    protected void fillDept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("ME");
        ddldept.Items.Add("CE");
        ddldept.Items.Add("EC");
        ddldept.Items.Add("EEE");
        ddldept.Items.Add("IT");
    }
}