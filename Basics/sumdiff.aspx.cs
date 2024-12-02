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
    protected void btnSum_Click(object sender, EventArgs e)
    {
        int a, b, c, s;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        c = Convert.ToInt32(txtnumber3.Text);
        s = a + b + c;
        lblsum.Text = s.ToString();
    }
    protected void txtdifference_Click(object sender, EventArgs e)
    {

        int a, b, c, d;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        c = Convert.ToInt32(txtnumber3.Text);
        d = a - b - c;
        lbldiff.Text = d.ToString();
    }
}