using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Basics_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnchoice_Click(object sender, EventArgs e)
    {
        int a,ch;
        a = Convert.ToInt32(txtno1.Text);
       
        ch = Convert.ToInt32(ddlchoice.SelectedValue);
        switch (ch)
        {
            case 1:
               
                if (a % 2 == 0)
                {
                    lblresult.Text = a.ToString() + "is even";
                }
                break;
            case 2:
                 
                if (a % 2 != 0)
                {
                    lblresult.Text = a.ToString() + "is odd";
                }
                break;

        }

    }
}