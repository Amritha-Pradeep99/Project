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
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(txtno1.Text);
        b = Convert.ToInt32(txtno2.Text);
        c = a * b;
        lblresult.Text = c.ToString();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
  int a, b, c;
        a=Convert.ToInt32(txtno1.Text);
        b=Convert.ToInt32(txtno2.Text);
        c = a / b;
        lblresult.Text = c.ToString();
    }
}