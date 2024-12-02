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
    protected void btnsod_Click(object sender, EventArgs e)
    {
        int i,n,d,s;
        s=0;
        n=Convert.ToInt32(txtnumber.Text);
        while (n != 0)
        {
            d = n % 10;
            s = s + d;
            n = n / 10;
        }
        lblresult.Text = s.ToString();
    }
}