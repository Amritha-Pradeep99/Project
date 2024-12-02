using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class ExtraToolBoxs_SplitReplace : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    static int flag, idno;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!Page.IsPostBack)
        {
            fillSecurityqn();
            fillDob();
            fillDetails();
        }
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string dob = ddlDD.SelectedValue + "/" + ddlMM.Text + "/" + ddlYY.SelectedValue;

        string securityqn = ddlsqn.SelectedValue;
        securityqn=securityqn.Replace("'", "''");

        if (flag == 1)
        {
            string upQry = "update tbl_splitreplace set user_name='" + txtname.Text + "',user_dob='" + dob + "',user_sqn='" + securityqn + "' where user_id='" + idno + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {

            string insQry = "insert into tbl_splitreplace (user_name,user_dob,user_sqn)values('" + txtname.Text + "','" + dob + "','" + securityqn + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }

    }
    protected void fillSecurityqn()
    {
        ddlsqn.Items.Insert(0, "--select--");
        ddlsqn.Items.Add("What is your favourite food  ?");
        ddlsqn.Items.Add("what is your pet's name ?");
    }
    protected void fillDob()
    {
        int i;
        for (i = 0; i <= 31; i++)
        {
            ddlDD.Items.Add(i.ToString());
        }
        for (i = 1980; i <= 2024; i++)
        {
            ddlYY.Items.Add(i.ToString());
        }
        for (i = 1; i <= 12; i++)
        {
            ddlMM.Items.Add(i.ToString());
        }
        ddlDD.Items.Insert(0, "DD");
        ddlMM.Items.Insert(0, "MM");
        ddlYY.Items.Insert(0, "YY");
    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_splitreplace";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        grddetails.DataSource = dt;
        grddetails.DataBind();
    }
    protected void grddetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_splitreplace where user_id='"+idno+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["user_name"].ToString();
            ddlsqn.SelectedValue = dt.Rows[0]["user_sqn"].ToString();


            string dob = dt.Rows[0]["user_dob"].ToString();
            string[] str = new string[3];
            str = dob.Split('/');

            ddlDD.SelectedValue = str[0];
            ddlMM.SelectedValue = str[1];
            ddlYY.SelectedValue = str[2];

            flag = 1;

        }
       
    }
    protected void fillDetails()
    {
        string selQry = "select * from tbl_splitreplace";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        grddetails.DataSource = dt;
        grddetails.DataBind();
        
    }
}