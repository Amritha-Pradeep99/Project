using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtdob_TextChanged(object sender, EventArgs e)
    {
        DateTime dob = new DateTime();
        int currentYear, currentMonth, birthMonth, birthYear, years, months;
        dob = Convert.ToDateTime(txtdob.Text);
        currentYear = Convert.ToInt32(DateTime.Now.Year);
        currentMonth = Convert.ToInt32(DateTime.Now.Month);
        birthYear = Convert.ToInt32(dob.Year);
        birthMonth = Convert.ToInt32(dob.Month);
        years = currentYear - birthYear;
        if ((currentMonth - birthMonth >= 0))
        {
            months = Convert.ToInt32(currentMonth - birthMonth);
        }
        else
        {
            years = years - 1;
           months = Convert.ToInt32((12 - birthMonth) + currentMonth);
        }
        lblmsg.Text = years.ToString() + "years" + months.ToString() + "Months";
        if (years < 19)
        {
            Response.Write("<script>alert('Age Restricted...')</script>");
            btnsubmit.Enabled = false;
        }
        else
        {
            btnsubmit.Enabled = true;
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

    }
}