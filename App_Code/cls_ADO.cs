using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for cls_ADO
/// </summary>
public class cls_ADO
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_aspsylabus;Integrated Security=True");
	public cls_ADO()
	{
        con.Open();
	}
    public void executeQuery(string str)
    {
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.ExecuteNonQuery();
    }
    public DataTable selectQuery(string str)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(str, con);
        adp.Fill(dt);
        return dt;
    }
    public DataSet selectData(string str)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(str, con);
        adp.Fill(ds);
        return ds;
    }
    public void fillGrid(GridView grd, string str)
    {
        DataTable dt = new DataTable();
        dt = selectQuery(str);
        grd.DataSource = dt;
        grd.DataBind();
    }
    public void fillDataList(DataList dlst, string str)
    {
        DataTable dt = new DataTable();
        dt = selectQuery(str);
        dlst.DataSource = dt;
        dlst.DataBind();
    }
    public void fillRepeater(Repeater rptr, string str)
    {
        DataTable dt = new DataTable();
        dt = selectQuery(str);
        rptr.DataSource = dt;
        rptr.DataBind();
    }
    public void fillDetailsView(DetailsView dtv, string str)
    {
        DataTable dt = new DataTable();
        dt = selectQuery(str);
        dtv.DataSource = dt;
        dtv.DataBind();
    }
    public void fillDDL(DropDownList ddl,string txtFiled,string valField, string str)
    {
        DataTable dt = new DataTable();
        dt = selectQuery(str);
        ddl.DataSource = dt;
        ddl.DataTextField = txtFiled;
        ddl.DataValueField = valField;
        ddl.DataBind();
        ddl.Items.Insert(0, "--select--");
    }
    public void fillChkList(CheckBoxList chklist, string txtFiled, string valField, string str)
    {
        DataTable dt = new DataTable();
        dt = selectQuery(str);
        chklist.DataSource = dt;
        chklist.DataTextField = txtFiled;
        chklist.DataValueField = valField;
        chklist.DataBind();
    }
    
}