using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Text;
public partial class Test_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btndecrypt_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_sampleuser where ur_name='" + txtname.Text + "' and ur_pwd='" + txtpwd.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        if (dt.Rows.Count > 0)
        {

            //string psw = dt.Rows[0]["ur_pwd"].ToString();
            string strPsw = Encryptdata(txtpwd.Text);
            string psw = Decryptdata(strPsw);
            lbldecrypt.Text = psw;

            if (psw.CompareTo(txtpwd.Text) == 0)
            {
                Session["urid"] = dt.Rows[0]["ur_id"].ToString();
                Session["urname"] = dt.Rows[0]["ur_name"].ToString();
               Response.Redirect("~/Test/HomePage.aspx");
            }
            
        }
    }
    private string Encryptdata(string password)
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[password.Length];
        encode = Encoding.UTF8.GetBytes(password);
        strmsg = Convert.ToBase64String(encode);
        return strmsg;
    }
    private string Decryptdata(string encryptpwd)
    {
        string decryptpwd = string.Empty;
        UTF8Encoding encodepwd = new UTF8Encoding();
        Decoder Decode = encodepwd.GetDecoder();
        byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
        int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
        char[] decoded_char = new char[charCount];
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0); decryptpwd = new String(decoded_char);
        return decryptpwd;
    }
}