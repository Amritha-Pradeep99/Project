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
    protected void btncheck_Click(object sender, EventArgs e)
    {
        int n, d, s, i,temp;
        s=0;
      
        n = Convert.ToInt32(txtnumber.Text);
        temp = n;
        while (n != 0)
        {
            d = n % 10;
            s = s + (d * d * d);
            n = n / 10;
        }
        if (temp == s)
        {
            lblresult.Text = temp.ToString()+ " is armstrong number";
        }
    }
}