using System;
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
        String selQry = "select * from tbl_cart c inner join tbl_product p on c.product_id=p.product_id inner join tbl_subcategory s on s.subcategory_id=p.subcategory_id inner join tbl_category ca on ca.ct_id=s.ct_id inner join tbl_newuser n on n.nu_id=c.nu_id  where cart_id='" + Session["cid"] + "' and delivery_status='0' ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        DetailsView1.DataSource = dt;
        DetailsView1.DataBind();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        string upQry = "update tbl_cart set delivery_status='1',deliveryagent_name='" + txtname.Text + "',deliveryagent_email='" + txtemail.Text + "',deliveryagent_contact='" + txtcontact.Text + "'where cart_id='" + Session["cid"] + "' ";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

        lblmsg.Text = "Delivery assigned........";
        Response.Redirect("ViewDeliveryDetails.aspx");
    }
}
