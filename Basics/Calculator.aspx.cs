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
    protected void btnadd_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        c = a + b;
        lblresult.Text = c.ToString();
    }
    protected void btnminus_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        c = a - b;
        lblresult.Text = c.ToString();
    }
}