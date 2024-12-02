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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        if (CheckBox1.Checked == true)//accepting terms and condition
        {
            
            

            
            //string insQry = "insert into tbl_cart(payment_fromaccount,payment_pin,payment_pin,payment_toaccount,payment_date)values('" + TextBox1.Text + "','" + TextBox2.Text + "','************4367','" + DateTime.Now.ToShortDateString() + "')";
            string upQry = "update tbl_cart set payment_fromaccount='" + TextBox1.Text + "',payment_pin='" + TextBox2.Text + "',payment_toaccount='************4367',payment_date='" + DateTime.Now.ToShortDateString() + "' where  nu_id='" + Session["newid"] + "' and cart_id='" + Session["cartID"] + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
           
            Response.Redirect("Second.aspx");
        }
        else
        {
            Label1.Text = "Please accept the Terms & Conditions";
            Label1.ForeColor = System.Drawing.Color.Red;
        }
        con.Close();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}