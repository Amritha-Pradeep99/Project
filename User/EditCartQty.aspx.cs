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
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_cart c inner join tbl_product p on c.product_id=p.product_id where cart_id='" + Session["cartid"] + "'";
            DataTable dt = new DataTable();
            dt = obj.selCommand(selQry);
            if (dt.Rows.Count > 0)
            {
                txtproduct.Text = dt.Rows[0]["product_Name"].ToString();
                txtprice.Text = dt.Rows[0]["product_price"].ToString();
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        double total, p, c;
        p = Convert.ToInt32(txtprice.Text);
        c = Convert.ToInt32(txtqty.Text);
        total = p * c;

       lbltotal.Text = total.ToString();

       string upQry = "update tbl_cart set cart_qty='" + txtqty.Text + "',cart_total='" + lbltotal.Text + "' where cart_id='" + Session["cartid"] + "'";
        obj.ExcecuteCommand(upQry);


        Response.Redirect("ViewCartDetails.aspx");
    }
}