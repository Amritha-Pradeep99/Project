using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using System.Data.SqlClient;

public partial class TopicWise_Details_Class_17_SplitReplace : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    static int flag, idno;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

        if (!Page.IsPostBack)
        {
            filldob();
            fillsqn();
        }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {

        string dob = ddlDD.SelectedValue + "/" + ddlMM.Text + "/" + ddlYY.SelectedValue;
       
        string sqn = ddlSqn.SelectedValue;
        sqn = sqn.Replace("'", "''");

        if (flag == 1)
        {
            string up = "update tbl_splitreplace set user_name='" + txtname.Text + "',user_dob='" + dob + "',user_sqn='" + sqn + "' where user_id=" + idno + "";
            SqlCommand cmd = new SqlCommand(up, con);
            cmd.ExecuteNonQuery();

            filldetails();

            flag = 0;
        }
        else
        {
            string ins = "insert into tbl_splitreplace(user_name,user_dob,user_sqn)values('" + txtname.Text + "','" + dob + "','" + sqn + "')";
            SqlCommand cmd = new SqlCommand(ins, con);
            cmd.ExecuteNonQuery();
        }


    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string sel = "select * from tbl_splitreplace";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(sel, con);
        adp.Fill(dt);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();
    }

    protected void filldob()
    {
        for (int i = 1; i <= 31; i++)
        {
            ddlDD.Items.Add(i.ToString());
        }
        for (int i = 1980; i <= 2000; i++)
        {
            ddlYY.Items.Add(i.ToString());
        }
        for (int i = 1; i <= 12; i++)
        {
            ddlMM.Items.Add(i.ToString());
        }

        ddlDD.Items.Insert(0, "DD");
        ddlMM.Items.Insert(0, "MM");
        ddlYY.Items.Insert(0, "YY");
        
    }
    protected void fillsqn()
    {
        
        ddlSqn.Items.Add("what is u r favourite color ?");
        ddlSqn.Items.Add("what is u r pet's name ?");
        ddlSqn.Items.Insert(0, "--select--");

    }
    protected void grdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ed")
        {
            idno = Convert.ToInt32(e.CommandArgument.ToString());

            string sel = "select * from tbl_splitreplace where user_id=" + idno + "";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sel, con);
            adp.Fill(dt);

            txtname.Text = dt.Rows[0]["user_name"].ToString();
            ddlSqn.SelectedValue = dt.Rows[0]["user_sqn"].ToString();

            string dob = dt.Rows[0]["user_dob"].ToString(); 
            string[] str = new string[3];
            str = dob.Split('/');
            ddlDD.SelectedValue = str[0];
            ddlMM.SelectedValue = str[1];
            ddlYY.SelectedValue = str[2];

            flag = 1;

        }
    }

    protected void filldetails()
    {
        string sel = "select * from tbl_splitreplace";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(sel, con);
        adp.Fill(dt);
        grdDetails.DataSource = dt;
        grdDetails.DataBind();
    }
}
