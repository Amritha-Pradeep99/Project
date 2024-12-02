using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Introduction_ValidationControl_ValidationControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillDept();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
    protected void fillDept()
    {
        ddlDept.Items.Add("CS");
        ddlDept.Items.Add("EC");
        ddlDept.Items.Add("IT");
        ddlDept.Items.Insert(0, "--select--");
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        try
        {
            int val = Convert.ToInt32(args.Value);
            if ((val >= 5000) && (val <= 8000))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        catch
        {
            args.IsValid = false;
        }

    }
}