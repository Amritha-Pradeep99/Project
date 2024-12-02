using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test_Default : System.Web.UI.Page
{
    protected List<string> Images { get; set; }
    public string photoname;
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        Images = new List<string>();
        con.Open();
        if (!IsPostBack)
        {
            string sel = "select * from tbl_playergallery";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sel, con);
            adp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                photoname = dt.Rows[i]["pg_photo"].ToString();
                Images.Add(photoname);
            }
        }
    }
}