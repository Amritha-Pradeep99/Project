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
        int n, i, d, s,temp,fact;
        s = 0;
        n = Convert.ToInt32(txtno.Text);
        temp = n;
        while (n != 0)
        {
            d = n % 10;
            fact = 1; 
            for (i = 1; i <= d; i++)
            {
                fact = fact * i;
            }
            s = s + fact;
            n = n / 10;
        }
        if (temp == s)
        {
            lblresult.Text = temp.ToString() + "strong number";
        }       
            
    }
}