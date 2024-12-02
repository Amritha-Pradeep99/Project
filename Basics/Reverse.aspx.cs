using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Basics_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnreverse_Click(object sender, EventArgs e)
    {
        int  n, rev,d,temp;
        rev = 0;
        n = Convert.ToInt32(txtnumber.Text);
        temp = n;
        while (n != 0)
        {
            d = n % 10;
            rev = rev * 10 + d;
            n = n / 10;
        }
        if (temp == rev)
        {
            lblresult.Text = temp.ToString()+ "reverse no";
        }

    }
}