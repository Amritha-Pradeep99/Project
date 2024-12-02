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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillChart();
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_employeechart(employee_name,employee_salary)values('" + txtname.Text + "','" + txtsalary.Text + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();

        txtname.Text = "";
        txtsalary.Text = "";
    }
    protected void fillChart()
    {
        string selQry = "select * from tbl_employeechart ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp=new SqlDataAdapter(selQry,con);
        adp.Fill(dt);
        Chart1.DataSource = dt;
        Chart1.Legends.Add("txtname.Text").Title = "name";
        Chart1.Legends.Add("txtsalary.Text").Title = "salary";
        Chart1.ChartAreas["ChartArea1"].AxisX.Title = "Name";
        Chart1.ChartAreas["ChartArea1"].AxisY.Title = "Salary";
        Chart1.Series["Series1"].XValueMember = "employee_name";
        Chart1.Series["Series1"].YValueMembers = "employee_salary";
        Chart1.Series["Series1"].ToolTip = "#VALX,#VALY";
        Chart1.DataBind();
    }



}