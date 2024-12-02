using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Test_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            Dept();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_employee(empname,empgender,empdept,empsalary)values('"+txtname.Text+"','"+rblgender.SelectedValue+"','"+ddldept.SelectedValue+"','"+txtsalary.Text+"')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
    }

    protected void Dept()
    {
        ddldept.Items.Insert(0, "--select--");
        ddldept.Items.Add("CS");
        ddldept.Items.Add("IT");
        ddldept.Items.Add("ME");
        ddldept.Items.Add("EEE");
        ddldept.Items.Add("ECE");
    }
    
   
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_employee";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();

    }
    protected void fillDetails()
    {
        string selQry = "select * from tbl_employee";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();
    }
    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_employee where empid='"+idno+"'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();

            fillDetails();
        }
        if (e.CommandName == "save")
        {
            if (e.CommandName == "save")
            {
                TextBox txtna = (TextBox)grdDetails.FooterRow.FindControl("txtna");
                RadioButtonList rdbgen = (RadioButtonList)grdDetails.FooterRow.FindControl("rdbgen");
                DropDownList ddldep = (DropDownList)grdDetails.FooterRow.FindControl("ddldep");
                TextBox txtsal = (TextBox)grdDetails.FooterRow.FindControl("txtsal");

                string ins = "insert into tbl_employee(empname,empgender,empdept,empsalary)values('" + txtna.Text + "','" + rdbgen.SelectedValue + "','" + ddldep.SelectedValue + "'," + txtsal.Text + ")";
                SqlCommand cmd = new SqlCommand(ins, con);
                cmd.ExecuteNonQuery();

                fillDetails();

            }
        }
    }
}