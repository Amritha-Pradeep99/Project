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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    protected void fillGrid()
    {


        string selQry = "select * from tbl_schedule s inner join tbl_place p on s.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id where s.schedule_id='" + Session["sid"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        DetailsView1.DataSource = dt;
        DetailsView1.DataBind();
        
        
    }


    protected void btnapplynow_Click(object sender, EventArgs e)
    {

        string selQry = "select * from tbl_tournamentapplication where schedule_id='" + Session["sid"] + "' and nc_id='" + Session["clubid"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lblmessage.Text = "Already Applied...";
        }
        else
        {
            string insQry = "insert into tbl_tournamentapplication (schedule_id,nc_id)values('" + Session["sid"] + "','" + Session["clubid"] + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();

            lblmessage.Text = "Applied Successfully...";
        }
    }
}