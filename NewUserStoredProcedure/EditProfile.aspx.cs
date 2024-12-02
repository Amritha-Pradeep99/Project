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
        if (!Page.IsPostBack)
        {
            HttpCookie reqcookie = Request.Cookies["userlogin"];
            if(reqcookie!=null)
            {
                reqcookie["nu_id"].ToString();
            }
            string tablename = "tbl_newuser";
            string fieldset = "*";
            string conditionset = "nu_id='"+reqcookie["nu_id"]+"'";
            DataTable dt = new DataTable();
            dt = obj.SelectConditionCommonProcedure(tablename, fieldset, conditionset);
            if (dt.Rows.Count > 0)
            {
                txtfname.Text = dt.Rows[0]["nu_fname"].ToString();
                txtlname.Text = dt.Rows[0]["nu_lname"].ToString();
                txtemail.Text = dt.Rows[0]["nu_email"].ToString();
                txtcontact.Text = dt.Rows[0]["nu_phone"].ToString();
            }
        }
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        HttpCookie reqcookie = Request.Cookies["userlogin"];
        if (reqcookie != null)
        {
            reqcookie["nu_id"].ToString();
        }
        string tablename = "tbl_newuser";
        string updationset = "nu_fname='" + txtfname.Text + "',nu_lname='" + txtlname.Text + "',nu_email='" + txtemail.Text + "',nu_phone='"+txtcontact.Text+"'";
        string conditionfield = "nu_id";
        string conditionValue = "" + reqcookie["nu_id"] + "";
        obj.UpdateCommonProcedure(tablename, updationset, conditionfield, conditionValue);
        lblmsg.Text = "Updated....";

        txtfname.Text = "";
        txtlname.Text = "";
        txtemail.Text = "";
        txtcontact.Text = "";
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtlname.Text = "";
        txtlname.Text = "";
        txtemail.Text = "";
        txtcontact.Text = "";
    }
}