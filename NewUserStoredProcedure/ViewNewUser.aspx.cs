using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class NewUserStoredProcedure_Default : System.Web.UI.Page
{
    cls_StoredProcedureCommon obj=new cls_StoredProcedureCommon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillGrid();
        }
    }
    protected void fillGrid()
    {
        string tabelename = "tbl_newuser";
        string table1 = "tbl_place";
        string tabel2 = "tbl_district";
        string fieldset = "*";
        string fields = "place_id,district_id";
        string condition1 = "tbl_newuser.place_id=tbl_place.place_id";
        string condition2 = "tbl_district.district_id=tbl_place.district_id";
        DataTable dt = new DataTable();
        dt = obj.selectCommonProcedureInner(tabelename, table1, tabel2, fieldset, fields, condition1, condition2);
        gdUserView.DataSource = dt;
        gdUserView.DataBind();
    }
    protected void gdUserView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdUserView.PageIndex = e.NewPageIndex;
        fillGrid();
    }
}