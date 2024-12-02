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
    cls_StoredProcedureCommon obj = new cls_StoredProcedureCommon();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnchange_Click(object sender, EventArgs e)
    {
        HttpCookie reqcookie = Request.Cookies["userlogin"];
        if (reqcookie != null)
        {
            reqcookie["nu_id"].ToString();
        }
        string tablename = "tbl_newuser";
        string fieldset = "*";
        string condition1 = "nu_pwd='"+txtpwd.Text+"'";
        string condition2 = "nu_id='"+reqcookie["nu_id"]+"'";
        DataTable dt = new DataTable();
        dt = obj.selectCommonChange(tablename, fieldset, condition1, condition2);
        if (dt.Rows.Count > 0)
        {
            if (txtnpwd.Text == txtcpwd.Text)
            {
                string tablenm = "tbl_newuser";
                string updationset = "nu_pwd='" + txtnpwd.Text + "'";
                string condtionfield = "nu_id";
                string conditionvalue = "" + reqcookie["nu_id"] + "";
                obj.UpdateCommonProcedure(tablenm, updationset, condtionfield, conditionvalue);

                lblmsg.Text = "Password Changed...";
            }
            else
            {
                lblmsg.Text = "Password not changed..";
            }
        }
        txtpwd.Text = "";
        txtnpwd.Text = "";
        txtcpwd.Text = "";
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtpwd.Text = "";
        txtnpwd.Text = "";
        txtcpwd.Text = "";
    }
}