﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Club_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
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
        string selQry = "select * from tbl_newclub where nc_id='" + Session["clubid"] + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        DetailsView1.DataSource = dt;
        DetailsView1.DataBind();
    }

    
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");

    }
}