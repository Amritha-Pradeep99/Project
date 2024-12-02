﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Admin_Default : System.Web.UI.Page
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
        string selQry = "select * from tbl_cart c inner join tbl_product p on c.product_id=p.product_id inner join tbl_subcategory s on s.subcategory_id=p.subcategory_id inner join tbl_category ca on ca.ct_id=s.ct_id inner join tbl_offer f on  f.offer_id=c.offer_id inner join tbl_newuser n on n.nu_id=c.nu_id where delivery_status='1'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}