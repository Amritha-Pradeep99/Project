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
    cls_StoredProcedureCommon obj = new cls_StoredProcedureCommon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillDetails();
        }
    }
    protected void fillDetails()
    {
        HttpCookie reqcookies=Request.Cookies["userlogin"];
        if(reqcookies!=null)
        {
            reqcookies["nu_id"].ToString();
        }
        string tablename = "tbl_newuser";
        string table1 = "tbl_place";
        string table2 = "tbl_district";
        string fieldset = "*";
        string fields = "place_id,district_id";
        string condition1 = "tbl_newuser.place_id=tbl_place.place_id";
        string condition2 = "tbl_district.district_id=tbl_place.district_id";
        string conditionset = "nu_id='"+reqcookies["nu_id"]+"'";
        DataTable dt = new DataTable();
        dt = obj.selectConditionCommonProcedureInnerInner(tablename, table1, table2, fieldset, fields, condition1, condition2, conditionset);
        DetailsView1.DataSource = dt;
        DetailsView1.DataBind();
    }
}