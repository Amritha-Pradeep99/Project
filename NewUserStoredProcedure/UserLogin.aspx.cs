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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string tablename = "tbl_newuser";
        string fieldset = "*";
        string fields = "nu_email,nu_pwd";
        string condition1 = "nu_email='" + txtemail.Text + "'";
        string condition2 = "nu_pwd='" + txtpwd.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.selectCommonLogin(tablename, fieldset, fields, condition1,condition2);
        if (dt.Rows.Count > 0)
        {
            HttpCookie log = new HttpCookie("userlogin");
            log["nu_email"] = txtemail.Text;
            log["nu_pwd"] = txtpwd.Text;
            log["nu_fname"] = dt.Rows[0]["nu_fname"].ToString();
            log["nu_lname"] = dt.Rows[0]["nu_lname"].ToString();
            log["nu_id"] = dt.Rows[0]["nu_id"].ToString();
            Response.Cookies.Add(log);

            Response.Redirect("../NewUserStoredProcedure/HomePage.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login!!";
        }
    }
    
}