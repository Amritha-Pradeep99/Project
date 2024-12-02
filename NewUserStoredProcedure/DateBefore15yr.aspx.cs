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
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)   //validator Event
    {

        if (GetDateDiff() <= 15)
        {
            args.IsValid = false;
        }

    }
    private int GetDateDiff()
    {
        DateTime curdate = DateTime.Now;
        DateTime selDate = Convert.ToDateTime(txtdate.Text);
        TimeSpan tsDate = curdate.Subtract(selDate);

        int diffDate = tsDate.Days / 365;

        return diffDate;

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
             lblmsg.Text="Save Details....";

        }
    }
}