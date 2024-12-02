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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_cart c inner join tbl_product p on c.product_id=p.product_id";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtproduct.Text = dt.Rows[0]["product_Name"].ToString();
               // txtqty.Text = dt.Rows[0]["cart_qty"].ToString();
                txtprice.Text = dt.Rows[0]["cart_total"].ToString();
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string upQry = "update  tbl_cart set cart_qty='"+txtqty.Text+"' where cart_id='"+Session["cartid"]+"'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

        Response.Redirect("ViewOfferCartDetails.aspx");
    }
    protected void txtqty_TextChanged(object sender, EventArgs e)
    {
        double total, p, c;
        p = Convert.ToInt32(txtprice.Text);
        c = Convert.ToInt32(txtqty.Text);
        total = p * c;

        lbltotal.Text = total.ToString();

    }
}