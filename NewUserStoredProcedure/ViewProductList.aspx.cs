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
public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
{
    cls_StoredProcedureCommon obj = new cls_StoredProcedureCommon();

    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //required to avoid the runtime error "
        //Control 'GridView1' of type 'GridView' must be placed inside a form tag with runat=server."
    }
    protected void fillGrid()
    {
        string tablename = "tbl_product";
        string table1 = "tbl_subcategory";
        string table2 = "tbl_category";
        string fieldset = "*";
        string fields = "subcategory_id,ct_id";
        string condition1 = "tbl_product.subcategory_id=tbl_subcategory.subcategory_id";
        string condition2 = "tbl_subcategory.ct_id=tbl_category.ct_id";
        DataTable dt = new DataTable();
        dt = obj.selectCommonProcedureInner(tablename, table1, table2, fieldset, fields, condition1, condition2);
        gdDetails.DataSource = dt;
        gdDetails.DataBind();
    }
    //protected void gdDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    gdDetails.PageIndex = e.NewPageIndex;
    //    fillGrid();
    //}
    protected void btnExcel_Click(object sender, EventArgs e)
    {
        ExportGridToExcel();
    }
    
    private void ExportGridToExcel()
    {
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "LAPTOP-FDV8RAL7" + DateTime.Now + ".xls";
        StringWriter strwritter = new StringWriter();
        HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = "application/vnd.ms-excel";
        Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
        gdDetails.GridLines = GridLines.Both;
        gdDetails.HeaderStyle.Font.Bold = true;
        gdDetails.RenderControl(htmltextwrtter);
        Response.Write(strwritter.ToString());
        Response.End();
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
        gdDetails.RenderControl(hw);
        StringReader sr = new StringReader(sw.ToString());
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
        gdDetails.AllowPaging = true;
        gdDetails.DataBind();
    }
}