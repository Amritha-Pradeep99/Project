using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillDob();
        }
    }
    protected void fillDob()
    {
        int i;
        for (i = 1; i <= 31; i++)
        {
            ddldate.Items.Add(i.ToString());
        }
        for (i = 1; i <= 12; i++)
        {
            ddlmonth.Items.Add(i.ToString());
        }
        for (i = 1980; i <= 2024; i++)
        {
            ddlyear.Items.Add(i.ToString());
        }
        ddldate.Items.Insert(0, "DD");
        ddlmonth.Items.Insert(0, "MM");
        ddlyear.Items.Insert(0, "YY");
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        ddldate.SelectedValue = Calendar1.SelectedDate.Day.ToString();
        ddlmonth.SelectedValue = Calendar1.SelectedDate.Month.ToString();
        ddlyear.SelectedValue = Calendar1.SelectedDate.Year.ToString();
    }
}