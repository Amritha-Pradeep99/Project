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
    static int editid,flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillDistrict();
           //fillGrid();
        }
        
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if(flag==1)
        {
            string upQry = "update tbl_schedule set  place_id='" + ddlplace.SelectedValue + "',schedule_venue='" + txtvenue.Text + "',schedule_address='" + txtaddress.Text + "',schedule_start='" + txtstartdate.Text + "',schedule_end='" + txtenddate.Text + "' where schedule_id='" + editid + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_schedule(place_id,schedule_venue,schedule_address,schedule_start,schedule_end)values('" + ddlplace.SelectedValue + "','" + txtvenue.Text + "','" + txtaddress.Text + "','" + txtstartdate.Text + "','" + txtenddate.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }

        
        txtvenue.Text = "";
        txtaddress.Text = "";
        txtstartdate.Text = "";
        txtenddate.Text = "";
    }
    protected void fillDistrict()
    {
        string selQry = "select * from tbl_district";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddldistrict.DataSource = dt;
        ddldistrict.DataTextField = "district_name";
        ddldistrict.DataValueField = "district_id";
        ddldistrict.DataBind();
        ddldistrict.Items.Insert(0, "--select--");

        //fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_schedule s  inner join tbl_place p on s.place_id=p.place_id inner join tbl_district  d on d.district_id=p.district_id ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        gdms.DataSource = dt;
        gdms.DataBind();
    }

    protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_place where district_id='"+ddldistrict.SelectedValue+"'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        ddlplace.DataSource = dt;
        ddlplace.DataTextField = "place_name";
        ddlplace.DataValueField = "place_id";
        ddlplace.DataBind();
    }

    protected void gdmatchschedule_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdms.PageIndex = e.NewPageIndex;
        //fillGrid();
    }
    protected void gdmatchschedule_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_schedule where schedule_id='" + idno + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            //fillGrid();
        }
        if (e.CommandName == "ed")
        {
            editid = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_schedule  s  inner join tbl_place p on s.place_id=p.place_id inner join tbl_district  d on d.district_id=p.district_id where schedule_id='" + editid + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            ddlplace.SelectedValue = dt.Rows[0]["place_id"].ToString();
            txtvenue.Text=dt.Rows[0]["schedule_venue"].ToString();
            txtaddress.Text=dt.Rows[0]["schedule_address"].ToString();
            txtstartdate.Text=dt.Rows[0]["schedule_start"].ToString();
            txtenddate.Text=dt.Rows[0]["schedule_end"].ToString();
            
            flag = 1;
            //fillGrid();
        }
       
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
       
        txtvenue.Text = "";
        txtaddress.Text = "";
        txtstartdate.Text = "";
        txtenddate.Text = "";
    }
    
    protected void btnshow_Click1(object sender, EventArgs e)
    {
        fillGrid();
    }
}