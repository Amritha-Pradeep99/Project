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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if(!IsPostBack)
        {
            
        }
    }
    private bool checkdate()   //.......Entered date is greater than system date
    {
        DateTime d1 = DateTime.Today;
        DateTime d2 = Convert.ToDateTime(txtdate.Text);
        TimeSpan ts = d1.Subtract(d2);
        if (ts.Days <= 0)
            return false;
        else
            return true;
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (checkdate())
        {
              lblmsg.Text="saved details....";
        }
  else
        {
            Response.Write("<script>alert('Date Invalid...!')</script>");
        }

    }
}