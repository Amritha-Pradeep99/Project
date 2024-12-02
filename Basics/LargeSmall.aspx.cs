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
    protected void txtnumber1_TextChanged(object sender, EventArgs e)
    {
       


    }
    protected void txtnumber2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtnumber3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btndisplay_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        c = Convert.ToInt32(txtnumber3.Text);
        if (a > b)
        {
            if (a > c)
            {
                lbllarge.Text = a.ToString();
            }
            else
            {
                lbllarge.Text = c.ToString();
            }
        }
        else
        {
            if (b > c)
            {
                lbllarge.Text = b.ToString();
            }
            else
            {
                lbllarge.Text = c.ToString();
            }
        }

        if (a < b)
        {
            if (a < c)
            {
                lblsmall.Text = a.ToString();
            }
            else
            {
                lblsmall.Text = c.ToString();
            }
        }
        else
        {
            if (b < c)
            {
                lblsmall.Text = b.ToString();
            }
            else
            {
                lblsmall.Text = c.ToString();
            }
        }
    }
}