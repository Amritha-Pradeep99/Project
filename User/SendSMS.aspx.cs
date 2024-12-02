using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;

using System.Net;

public partial class User_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    string phno = "9496283812";//dt6.Rows[0]["std_phn"].ToString();
    string msg = "attendance short";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        sendSMS(msg, phno);
    }
    public string sendSMS(string sms, string phno)
    {
        string url = "http://sms.a4add.com/pushsms.php";
        string result = "";
        string strPost = "username=progressive" + "&api_password=8f280qjav5fzll7dj" + "&sender=PCPL&to=" + phno.ToString() + "&message=" + sms + "&priority=1";
        StreamWriter myWriter = null;
        HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
        objRequest.Method = "POST";
        objRequest.ContentLength = strPost.Length;
        objRequest.ContentType = "application/x-www-form-urlencoded";
        try
        {
            myWriter = new StreamWriter(objRequest.GetRequestStream());
            myWriter.Write(strPost);
        }
        catch (Exception e1)
        {

        }
        finally
        {
            myWriter.Close();
        }
        HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
        using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
        {
            result = sr.ReadToEnd();
            // Close and clean up the StreamReader
            sr.Close();

        }
        return result;
        //alert_8221125962
    }
}
