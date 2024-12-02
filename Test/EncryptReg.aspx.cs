using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Sql;
using System.Data;
using System.Text;
public partial class Test_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillDept();
            fillSemester();
        }
    }
    protected void btnencrypt_Click(object sender, EventArgs e)
    {
       
        string insQry = "insert into tbl_sampleuser(ur_name,ur_gender,ur_dept,ur_sem,ur_pwd)values('"+txtname.Text+"','"+rblgender.SelectedValue+"','"+ddlDept.SelectedValue+"','"+ddlSem.SelectedValue+"','"+txtpwd.Text+"')";
        obj.ExcecuteCommand(insQry);

        string strPsw = Encryptdata(txtpwd.Text);
        lblEncrypt.Text = strPsw;
    }
    private string Encryptdata(string password)
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[password.Length];
        encode = Encoding.UTF8.GetBytes(password);
        strmsg = Convert.ToBase64String(encode);
        return strmsg;
    }
    protected void fillDept()
    {
        ddlDept.Items.Insert(0,"--select--");
        ddlDept.Items.Add("CS");
        ddlDept.Items.Add("CSE");
        ddlDept.Items.Add("ECE");
        ddlDept.Items.Add("EEE");
        ddlDept.Items.Add("ME");
    }
    protected void fillSemester()
    {
        ddlSem.Items.Insert(0, "--select--");
        ddlSem.Items.Add("S1");
        ddlSem.Items.Add("S2");
        ddlSem.Items.Add("S3");
        ddlSem.Items.Add("S4");
        ddlSem.Items.Add("S5");
        ddlSem.Items.Add("S6");
        ddlSem.Items.Add("S7");
        ddlSem.Items.Add("S8");
    }

}