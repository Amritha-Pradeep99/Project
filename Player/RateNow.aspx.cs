using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Player_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillrate();
        }
    }
    
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_rate(rate_value,rate_comment,rate_date,nc_id,p_id)values('"+drpratevalue.SelectedValue+"','"+txtcomment.Text+"','"+DateTime.Now.ToShortDateString()+"','"+ Session["clubid"]+"','"+ Session["pid"] +"')";
        obj.ExcecuteCommand(insQry);


        drpratevalue.ClearSelection();
        txtcomment.Text = "";
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        drpratevalue.ClearSelection();
        txtcomment.Text = "";
    }
    protected void fillrate()
    {
        drpratevalue.Items.Insert(0, "--select--");
        drpratevalue.Items.Add("Excellent");
        drpratevalue.Items.Add("Very Good");
        drpratevalue.Items.Add("Good");
        drpratevalue.Items.Add("Average");
       
    }
   
}