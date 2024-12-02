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

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string str = "Years";
        DateTime TodayDate = DateTime.Today;
        DateTime BirthDate = default(DateTime);
        BirthDate = Convert.ToDateTime(txtdob.Text);
        TimeSpan diffDate = TodayDate.Subtract(BirthDate);
        lblmsg.Text = (Convert.ToInt32(diffDate.Days / 365).ToString()) + str; 
    }
    
}