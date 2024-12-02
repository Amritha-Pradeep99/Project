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
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        double BS,TA ,DA, HRA, LIC, PF, NET;

        BS = Convert.ToDouble(txtbs.Text);
        
        if (BS >= 10000)
        {
            TA =BS*.4;
            DA = BS*.35;
            HRA = BS*.3;
            LIC = BS*.25;
            PF = BS*.2;
        }
        else if (BS >= 5000)
        {
            TA = BS*.35;
            DA = BS*.3;
            HRA = BS*.25;
            LIC = BS*.2;
            PF = BS *.15;
        }
        else
        {
            TA = BS * .3;
            DA = BS * .25;
            HRA = BS * .2;
            LIC = BS * .15;
            PF = BS * .1;
        }
        NET = (BS + TA + DA + HRA) - (LIC + PF);

        if (rblgender.SelectedValue == "Male")
        {
            lblname.Text ="Mr. "+ txtFname.Text + " " + txtlname.Text;
        }
        if ((rblgender.SelectedValue == "Female")&&(rblmartial.SelectedValue=="Single"))
        {
            lblname.Text = "Ms. " + txtFname.Text + " " + txtlname.Text;
        }
        if ((rblgender.SelectedValue == "Female") && (rblmartial.SelectedValue == "Married"))
        {
            lblname.Text = "Mrs. " + txtFname.Text + " " + txtlname.Text;
        }
        lblgender.Text = rblgender.SelectedValue;
        lblmartial.Text = rblmartial.SelectedValue;
        lbldepartment.Text = ddldept.SelectedValue;
        lblta.Text = TA.ToString();
        lblda.Text = DA.ToString();
        lblhra.Text = HRA.ToString();
        lbllic.Text = LIC.ToString();
        lblpf.Text = PF.ToString();
        lblnet.Text = NET.ToString();

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtbs.Text = "";
        rblmartial.ClearSelection();
        ddldept.ClearSelection();
        txtFname.Text = "";
        txtlname.Text = "";
        rblgender.ClearSelection();
        lblname.Text = "";
        lblgender.Text = "";
        lblmartial.Text = "";
        lbldepartment.Text = "";
        lblta.Text = "";
        lblda.Text = "";
        lblhra.Text = "";
        lbllic.Text = "";
        lblpf.Text = "";
        lblnet.Text = "";
       

    }
}