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
    protected void btnperfect_Click(object sender, EventArgs e)
    {
        int i, n, s,r;
        s = 0;
        n = Convert.ToInt32(txtnumber.Text);
        for (i = 1; i < n; i++)
        {
           r= n % i ;
            if (r== 0)
            {
                s = s + i;
            }
        }
        if (s == n)
        {
            lblperfect.Text = n.ToString() + " is perfect";
        }
        else
        {
            lblnperfect.Text = n.ToString();
        }

    }
}