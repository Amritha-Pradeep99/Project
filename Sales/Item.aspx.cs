using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
public partial class Sales_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillCategory();
            fillGrid();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string photoimage = Path.GetFileName(fileimage.PostedFile.FileName.ToString());
        fileimage.SaveAs(Server.MapPath("../Assests/Product/" + photoimage));

        string insQry = "insert into tbl_item(item_name,item_price,item_unit,item_photo,subcategory_id)values('" + txtname.Text + "','" + txtprice.Text + "','" + txtunit.Text + "','" + photoimage + "','" + ddlsubcategory.SelectedValue + "')";
        obj.ExcecuteCommand(insQry);

        txtname.Text = "";
        txtprice.Text = "";
        txtunit.Text = "";
        ddlsubcategory.ClearSelection();
        fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtprice.Text = "";
        txtunit.Text = "";
        ddlsubcategory.ClearSelection();
    }
    protected void fillCategory()
    {
        string selQry = "select * from tbl_category ";
        obj.fillDropDown(ddlcategory, "ct_name", "ct_id", selQry);

    }
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_subcategory where ct_id='" + ddlcategory.SelectedValue + "' ";
        obj.fillDropDown(ddlsubcategory, "subcategory_name", "subcategory_id", selQry);
    }
    protected void fillGrid()
    {

        string selQry = "select * from   tbl_item i inner join tbl_subcategory s on i.subcategory_id=s.subcategory_id inner join tbl_category c on c.ct_id=s.ct_id";
       
        obj.fillGrid(selQry, GridView1);
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
    }
}