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
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtName_TextChanged(object sender, EventArgs e)
    {
        string selQry1 = "select * from tbl_newuser where nu_fname='"+txtName.Text+"'";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry1);

        string selQry2 = "select * from tbl_adminregistration where admin_name='"+txtName.Text+"'";
        DataTable dtAdmin = new DataTable();
        dtAdmin = obj.selCommand(selQry2);

        string selQry3 = "select * from tbl_newclub where nc_name='"+txtName.Text+"'";
        DataTable dtClub = new DataTable();
        dtClub = obj.selCommand(selQry3);

        if ((dt.Rows.Count > 0) || (dtAdmin.Rows.Count > 0) || (dtClub.Rows.Count > 0))
        {
            lblmsg.Text = "Already exits...";
            txtName.Text = "";
        }
        else
        {
            lblmsg.Text = "You can continuee.....";
        }

    }
}