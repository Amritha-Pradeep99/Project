using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class User_Payment_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_cart where cart_id='"+Session["cartID"]+"'";
            DataTable dt = new DataTable();
            dt = obj.selCommand(selQry);
            lbl_Payto.Text = dt.Rows[0]["payment_toaccount"].ToString();
            lbl_Amount.Text = Session["amount"].ToString();
            lblCardNumber.Text = dt.Rows[0]["payment_fromaccount"].ToString(); 
            fillBill();
        }
    }
    protected void fillBill()
    {
        string selQry = "select * from tbl_newuser where nu_id='" + Session["newid"] + "'";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        if (dt.Rows.Count > 0)
        {


            txtName.Text = dt.Rows[0]["nu_usern"].ToString();
            txtAddress.Text = dt.Rows[0]["nu_address"].ToString();
            txtEmail.Text = dt.Rows[0]["nu_email"].ToString();
            txtPhone.Text = dt.Rows[0]["nu_phone"].ToString();
        }
    }


   
   
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string selQry1 = "select * from tbl_cart where cart_id='" + Session["cartID"] + "'";
        DataTable dt1 = new DataTable();
        dt1 = obj.selCommand(selQry1);
        if (dt1.Rows.Count > 0)
        {
            Session["productID"] = dt1.Rows[0]["product_id"].ToString();
            Session["cartStock"] = dt1.Rows[0]["cart_qty"].ToString();

        }
        string selQry2 = "select * from tbl_stock where product_id='" + Session["productID"] + "'";
        DataTable dtStock = new DataTable();
        dtStock = obj.selCommand(selQry2);
        if (dtStock.Rows.Count > 0)
        {
            Session["stockQty"] = dtStock.Rows[0]["stock_qty"].ToString();
        }

        int oldStock = Convert.ToInt32(Session["stockQty"].ToString());
        int cartStock = Convert.ToInt32(Session["cartStock"].ToString());

        int NewStock = oldStock - cartStock;


        string upQry1 = "update tbl_stock set stock_qty='" + NewStock + "' where product_id='" + Session["cartID"] + "'";
        obj.ExcecuteCommand(upQry1);


        string upQry = "update tbl_cart set cart_status='1' where  nu_id='" + Session["newid"] + "' and  cart_status='0'";
        obj.ExcecuteCommand(upQry);

        Response.Redirect("Third.aspx");
    }
}