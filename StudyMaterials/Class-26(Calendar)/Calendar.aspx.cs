using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Class_26_Calendar_Calendar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            filldob();
        }
    }
    protected void filldob()
    {
        for (int i = 1; i <= 31; i++)
        {
            ddlDD.Items.Add(i.ToString());
        }
        for (int i = 1980; i <= 2020; i++)
        {
            ddlYY.Items.Add(i.ToString());
        }
        for (int i = 1; i <= 12; i++)
        {
            ddlMM.Items.Add(i.ToString());
        }

        ddlDD.Items.Insert(0, "DD");
        ddlMM.Items.Insert(0, "MM");
        ddlYY.Items.Insert(0, "YY");

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        ddlDD.SelectedValue = Calendar1.SelectedDate.Day.ToString();
        ddlMM.SelectedValue = Calendar1.SelectedDate.Month.ToString();
        ddlYY.SelectedValue = Calendar1.SelectedDate.Year.ToString();
    }
}