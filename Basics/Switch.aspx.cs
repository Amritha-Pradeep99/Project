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
    
    protected void btnchoice_Click(object sender, EventArgs e)
    {
        int a, b, c, ch;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        ch = Convert.ToInt32(ddlchoice.SelectedValue);
        switch (ch)
        {
            case 1:

                c = a + b;
                lblresult.Text = c.ToString();
                break;

            case 2:

                c = a - b;
                lblresult.Text = c.ToString();
                break;

            case 3:

                c = a * b;
                lblresult.Text = c.ToString();
                break;

            case 4:

                c = a / b;
                lblresult.Text = c.ToString();
                break;
        }

    }

    protected void ddlchoice_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}