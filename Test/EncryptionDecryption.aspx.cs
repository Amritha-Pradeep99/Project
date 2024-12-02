using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
         string strPsw = Encryptdata(txttext.Text);
         lblmsg.Text = strPsw;
    }

    private string Encryptdata(string MyText)
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[MyText.Length];
        encode = Encoding.UTF8.GetBytes(MyText);
        strmsg = Convert.ToBase64String(encode);
        return strmsg;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string decryptText = Decryptdata(lblmsg.Text);
        lbldecrypt.Text = decryptText;

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




             

