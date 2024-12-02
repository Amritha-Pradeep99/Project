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
            fillDetails();
        }
    }
    protected void fillDetails()
    {
        string selQry = "select * from tbl_wishlist w inner join tbl_product p on w.product_id=p.product_id inner join tbl_newuser n on w.nu_id=n.nu_id inner join tbl_subcategory s on p.subcategory_id=s.subcategory_id inner join tbl_category c on s.ct_id=c.ct_id";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddtoCart.aspx");
    }
}