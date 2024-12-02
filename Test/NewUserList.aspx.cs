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
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillGrid();
            
        }
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_newuser n inner join tbl_place p on n.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        gdDetails.DataSource = dt;
        gdDetails.DataBind();
    }

    protected void gdDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdDetails.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void gdDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ac")
        {
            int userID = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_newuser set nu_status='1' where nu_id='" + userID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();

            

            fillGrid();
            //Response.Redirect("NewUserAcceptList.aspx");
        }
        if (e.CommandName == "rej")
        {
            int idno = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_newuser set nu_status='2' where nu_id='" + idno + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();

           

            fillGrid();
            //Response.Redirect("NewUserRejectList.aspx");

        }
    }
    protected void gdDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            HiddenField hf = (HiddenField)e.Row.FindControl("HiddenField1");
            Label lb = (Label)e.Row.FindControl("lblmsg");
            LinkButton lb1 = (LinkButton)e.Row.FindControl("LinkButton1");
            LinkButton lb2 = (LinkButton)e.Row.FindControl("LinkButton4");
            int hfid = Convert.ToInt32(hf.Value);
            if (hfid == 0)
            {
                lb.Text = "Pending";
                lb1.Visible = true;
                lb2.Visible = true;

            }
            else if (hfid == 1)
            {
                lb.Text = "Approved";
                lb1.Visible = false;
                lb2.Visible = true;

            }
            else if (hfid == 2)
            {
                lb.Text = "Block";
                lb1.Visible = true;
                lb2.Visible = false;

            }

        }

       /* if (e.Row.RowType == DataControlRowType.DataRow)
        {
            HiddenField hf = (HiddenField)e.Row.FindControl("HiddenField1");
            Label lb = (Label)e.Row.FindControl("lblmsg");

            LinkButton lb1 = (LinkButton)e.Row.FindControl("LinkButton1");

            LinkButton lb2 = (LinkButton)e.Row.FindControl("LinkButton4");

             int  hfid = Convert.ToInt32(hf.Value);
             if (hf != null && lb != null && lb1 != null && lb2 != null)
             {
                 if (hfid == 0)
                 {
                     lb.Text = "Pending";
                     lb1.Visible = true;
                     lb2.Visible = true;
                 }
                 else if (hfid == 1)
                 {
                     lb.Text = "Approved";
                     lb1.Visible = false;
                     lb2.Visible = true;
                 }
                 else if (hfid == 2)
                 {
                     lb.Text = "Block";
                     lb1.Visible = true;
                     lb2.Visible = false;
                 }
             }*/
        }
    }
    

    
