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
    protected void btnprime_Click(object sender, EventArgs e)
    {
        int i, flag, n;
        flag = 0;
        n = Convert.ToInt32(txtnumber.Text);
        for (i = 2; i < n / 2; i++)
        {
            if (n % i == 0)
            {
                flag = 1;
                break;
            }
        }
        if (flag == 0)
        {
            lblprime.Text = n.ToString();
        }
        else
        {
            lblnprime.Text = n.ToString();
        }
    }
}