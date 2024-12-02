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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        CaptchaControl1.ValidateCaptcha(txtcode.Text);
        if (!CaptchaControl1.UserValidated)
        {
            lblmsg.Text = "invalid Captcha";
            lblmsg.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            string insQry = "insert into tbl_newuser(nu_fname,nu_lname,nu_usern,nu_pwd)values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            lblmsg.Text = "Data Entered Successfully...";
            lblmsg.ForeColor=System.Drawing.Color.Green;
        }
    }
}