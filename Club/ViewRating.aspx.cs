using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Club_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_rate r inner join tbl_playerdetails p on r.p_id=p.p_id inner join tbl_newclub n on n.nc_id=p.nc_id where p.nc_id='"+Session["clubid"]+"'";
        obj.fillGrid(selQry, gdrate);
    }
}