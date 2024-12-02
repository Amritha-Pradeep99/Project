using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Class_19_View_Multiview_MultiView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void lnkCourse_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        
    }
    protected void lnkBook_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void lnkStudent_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {

    }
}