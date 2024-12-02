using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

using System.Text;
using System.Security.Cryptography;
public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_sampleuser where ur_name='" + txtname.Text + "'and ur_pwd='"+txtpwd.Text+"'";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        if (dt.Rows.Count > 0)
        {
            string psw = dt.Rows[0]["ur_pwd"].ToString();

            psw = Decryptdata(psw);

            if (psw.CompareTo(txtpwd.Text) == 0)
            {
                Session["uname"] = dt.Rows[0]["ur_name"].ToString();
                Session["uid"] = dt.Rows[0]["ur_id"].ToString();

                Response.Redirect("../NewUserStoredProcedure/HomePageDecrypt.aspx");
            }
            else
            {
                lblmsg.Text = "Invalid Login ....";
            }
            
        }
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