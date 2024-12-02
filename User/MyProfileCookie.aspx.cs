using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class User_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        fillDetails();
    }
    protected void fillDetails()
    {
        string selQry = "select * from tbl_newuser n inner join tbl_place p on n.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        DetailsView1.DataSource = dt;
        DetailsView1.DataBind();
    }
}