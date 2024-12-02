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
   
    protected void btnavg_Click(object sender, EventArgs e)
    {

        int m1, m2, m3, s, a;
        m1 = Convert.ToInt32(txtmark1.Text);
        m2 = Convert.ToInt32(txtmark2.Text);
        m3 = Convert.ToInt32(txtmark3.Text);
        s = m1 + m2 + m3;
        a = s / 3;
        lblavg.Text = a.ToString();
    }
}