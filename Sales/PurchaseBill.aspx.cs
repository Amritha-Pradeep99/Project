using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Web;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
public partial class Sales_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source =LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string selQry = "select * from tbl_saleshead s inner join tbl_newuser n on s.nu_id=n.nu_id where sh_id='"+Session["shid"]+"' ";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblbill.Text = dt.Rows[0]["sh_invoice"].ToString();
                lbldate.Text = dt.Rows[0]["sh_date"].ToString();
                lblcustomer.Text = dt.Rows[0]["nu_fname"].ToString();
            }
            fillBill();

        }
    }
    protected void fillBill()
    {
        string selQry = "select * from tbl_cart c inner join tbl_product p on c.product_id=p.product_id where sh_id='" + Session["shid"] + "' ";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

        string selQry1 = "select sum(cart_total) as total from tbl_cart where sh_id='" + Session["shid"] + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        if (dt1.Rows.Count > 0)
        {
            lbltotal.Text = dt1.Rows[0]["total"].ToString();
            Session["price"] = lbltotal.Text;

        }

        //string upQry = "update from tbl_saleshead set sh_grandtotal='" + Session["amount"] + "' where sh_id='" + Session["shid"] + "'";
        //SqlCommand cmd = new SqlCommand(upQry, con);
        //cmd.ExecuteNonQuery();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //required to avoid the runtime error "
        //Control 'GridView1' of type 'GridView' must be placed inside a form tag with runat=server."
    }
    protected void btnpdf_Click(object sender, EventArgs e)
    {
        ExportGridToPdf();
    }
    protected void ExportGridToPdf()
    {
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=LAPTOP-FDV8RAL7.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        GridView1.RenderControl(hw);
        StringReader sr = new StringReader(sw.ToString());
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
        GridView1.AllowPaging = true;
        GridView1.DataBind();
    }
}