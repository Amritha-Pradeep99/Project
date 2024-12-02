using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class User_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            FillOnlineMembers();
            FillMessages();
            FillNotification();
        }

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        FillOnlineMembers();
        FillMessages();
        FillNotification();
    }
    protected void grdMessage_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lbl = (Label)e.Row.FindControl("lblfrom");
            HiddenField hd = (HiddenField)e.Row.FindControl("HiddenField1");
            string str = "select nu_fname from tbl_newuser where nu_id=" + hd.Value + "";
            //DataTable dt = obj.SelectDatatable(str);
            SqlDataAdapter adp = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            lbl.Text = dt.Rows[0][0].ToString();
        }
    }
    protected void grdNotification_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "not")
        {
            hdto.Value = e.CommandArgument.ToString();
            FillMessages();
            FillNotification();
        }
    }
    private void FillOnlineMembers()
    {
        string str = @"select n.nu_id,n.nu_fname,(case when(n.nu_onlinestatus=0) then 'offline.png' else 'online.png' end)as online from tbl_newuser n
 where n.nu_id<>" + Session["newid"] + " order by n.nu_onlinestatus desc";
        //obj.fillGridView(str, grdOnline);
        SqlDataAdapter adp = new SqlDataAdapter(str, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdonline.DataSource = dt;
        grdonline.DataBind();
    }
    private void FillMessages()
    {
        if (hdto.Value != "")
        {
            string str = @"select * from tbl_chat c where (c.chat_fromid=" +  Session["newid"]+ " and c.chat_toid=" + hdto.Value + ") or(c.chat_fromid=" + hdto.Value + " and c.chat_toid=" + Session["newid"] + ") order by c.chat_id desc";
            //obj.fillGridView(str, grdMessage);
            SqlDataAdapter adp = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            grdMessage.DataSource = dt;
            grdMessage.DataBind();
            string str1 = "update tbl_chat  set chat_readstatus=1 where chat_fromid=" + hdto.Value + " and chat_toid=" +  Session["newid"] + "";

            //str = "update tbl_chat  set chat_readstatus=1 where chat_fromid=" + hdto.Value + " and chat_toid=" + Session["candid"] + "";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.ExecuteNonQuery();
        }
    }

    protected void grdonline_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "online")
        {
            LinkButton lk = (LinkButton)((LinkButton)e.CommandSource).NamingContainer.FindControl("lbtn1");
            lblchat.Text = "Chat with " + lk.Text;
            hdto.Value = e.CommandArgument.ToString();
        }
    }
    private void FillNotification()
    {
        string str = @"select x.*,n.nu_fname from
(select COUNT(chat_id)as msg,chat_fromid from tbl_chat where chat_toid='" + Session["newid"] + "' and chat_readstatus=0 group by chat_fromid)as x inner join  tbl_newuser n on n.nu_id=x.chat_fromid";
        SqlDataAdapter adp = new SqlDataAdapter(str, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdNotification.DataSource = dt;
        grdNotification.DataBind();
        //obj.fillGridView(str, grdNotification);
    }

    protected void btnsend_Click(object sender, EventArgs e)
    {
        if (txtmsg.Text != "" && hdto.Value != "")
        {
            string str = "insert into tbl_chat(chat_date,chat_msg,chat_fromid,chat_toid,chat_readstatus) values('" + DateTime.Now.ToShortDateString() + "','" + txtmsg.Text + "','" + Session["newid"] + "','" + hdto.Value + "',0)";
            //obj.ExecuteQuery(str);
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            txtmsg.Text = "";
            FillMessages();
        }

    }
}