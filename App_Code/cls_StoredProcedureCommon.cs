using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;


public class cls_StoredProcedureCommon
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project ;Integrated Security=True");
	public cls_StoredProcedureCommon()
	{

        con.Open();
	}
    public void ExcecuteCommonProcedure(string tablename, string fieldset, string valueset)
    {
        SqlCommand cmd = new SqlCommand("[commonInsert]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@valueset", SqlDbType.VarChar).Value = valueset;
        cmd.ExecuteNonQuery();
    }
    public void UpdateCommonProcedure(string tablename, string updationset, string conditionfield, string conditionvalue)
    {
        SqlCommand cmd = new SqlCommand("[commonUpdate]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@updationset", SqlDbType.VarChar).Value = updationset;
        cmd.Parameters.Add("@conditionfield", SqlDbType.VarChar).Value = conditionfield;
        cmd.Parameters.Add("@conditionvalue", SqlDbType.VarChar).Value = conditionvalue;
        cmd.ExecuteNonQuery();
    }
    public DataTable SelectAllCommonProcedure(string tablename, string fieldset)
    {
        SqlCommand cmd = new SqlCommand("[commonAllSelect]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
   
    
    public DataTable SelectConditionCommonProcedure(string tablename, string fieldset, string conditionset)
    {

        SqlCommand cmd = new SqlCommand("[commonSelectCondition]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@conditionset", SqlDbType.VarChar).Value = conditionset;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public void FillCommonProcedure(string tablename, string fieldset, BulletedList bl)
    {
        DataTable dt = SelectAllCommonProcedure(tablename, fieldset);
        bl.DataSource = dt;
        bl.DataBind();
    }
    public void DeleteCommonProcedure(string tablename, string conditionset)
    {
        SqlCommand cmd = new SqlCommand("[commonAllDelete]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@conditionset", SqlDbType.VarChar).Value = conditionset;
        cmd.ExecuteNonQuery();
    }
    public void FillGridProcedure(string tablename, string fieldset, GridView gr)
    {
        DataTable dt = SelectAllCommonProcedure(tablename, fieldset);
        gr.DataSource = dt;
        gr.DataBind();
    }
    public DataTable SelectCommonProcedure(string tablename, string tableset, string fieldset, string fields, string conditionset)
    {
        SqlCommand cmd = new SqlCommand("[commonAllSelectInner]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@tableset", SqlDbType.VarChar).Value = tableset;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@fields", SqlDbType.VarChar).Value = fields;
        cmd.Parameters.Add("@conditionset", SqlDbType.VarChar).Value = conditionset;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        return dt;
    }
    public DataTable SelectConditionCommonProcedureInner(string tablename, string tableset, string fieldset, string fields, string condition, string conditionset)
    {

        SqlCommand cmd = new SqlCommand("[commonSelectConditionInner]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@tableset", SqlDbType.VarChar).Value = tableset;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@fields", SqlDbType.VarChar).Value = fields;
        cmd.Parameters.Add("@condition", SqlDbType.VarChar).Value = condition;
        cmd.Parameters.Add("@conditionset", SqlDbType.VarChar).Value = conditionset;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public void FillGridProcedureInner(string tablename, string tableset, string fieldset, string fields, string conditionset, GridView gr)
    {
        DataTable dt = SelectCommonProcedure(tablename, tableset, fieldset, fields, conditionset);
        gr.DataSource = dt;
        gr.DataBind();
    }
    public DataTable selectCommonProcedureInner(string tablename, string table1,string table2, string fieldset, string fields, string condition1, string condition2)
    {
        SqlCommand cmd = new SqlCommand("[commonSelectInnerInner]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@table1", SqlDbType.VarChar).Value = table1;
        cmd.Parameters.Add("@table2", SqlDbType.VarChar).Value = table2;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@fields", SqlDbType.VarChar).Value = fields;
        cmd.Parameters.Add("@condition1", SqlDbType.VarChar).Value = condition1;
        cmd.Parameters.Add("@condition2", SqlDbType.VarChar).Value = condition2;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adp.SelectCommand = cmd;
        adp.Fill(dt);
        return dt;
    }
    public DataTable selectConditionCommonProcedureInnerInner(string tablename, string table1, string table2, string fieldset, string fields, string condition1, string condition2, string conditionset)
    {
        SqlCommand cmd = new SqlCommand("[commonSelectConditionInnerInnerjoin]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@table1", SqlDbType.VarChar).Value = table1;
        cmd.Parameters.Add("@table2", SqlDbType.VarChar).Value = table2;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@fields", SqlDbType.VarChar).Value = fields;
        cmd.Parameters.Add("@condition1", SqlDbType.VarChar).Value = condition1;
        cmd.Parameters.Add("@condition2", SqlDbType.VarChar).Value = condition2;
        cmd.Parameters.Add("@conditionset", SqlDbType.VarChar).Value = conditionset;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;

    }
    public void FillGridProcedureInnerInner(string tablename, string table1,string table2, string fieldset, string fields, string condition1, string condition2, GridView gr)
    {
        DataTable dt = selectCommonProcedureInner(tablename, table1,table2, fieldset, fields, condition1, condition2);
        gr.DataSource = dt;
        gr.DataBind();
    }
    public void FillGridProcedureInnerInnerdl(string tablename, string table1, string table2, string fieldset, string fields, string condition1, string condition2,DataList dl )
    {
        DataTable dt = selectCommonProcedureInner(tablename, table1, table2, fieldset, fields, condition1, condition2);
        dl.DataSource = dt;
        dl.DataBind();
    }
    
    public DataTable FillDropDownSelectedIndex(string tablename, string fieldset, string conditionfield, string conditionvalue)
    {
        SqlCommand cmd = new SqlCommand("[fillDropDownSelected]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@conditionfield", SqlDbType.VarChar).Value = conditionfield;
        cmd.Parameters.Add("@conditionvalue", SqlDbType.VarChar).Value = conditionvalue;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public DataTable selectCommonLogin(string tablename, string fieldset,string fields, string condition1,string condition2)
    {
        SqlCommand cmd = new SqlCommand("[commonSelectLogin]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@fields", SqlDbType.VarChar).Value = fields;
        cmd.Parameters.Add("@condition1", SqlDbType.VarChar).Value = condition1;
        cmd.Parameters.Add("@condition2", SqlDbType.VarChar).Value = condition2;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public DataTable selectCommonChange(string tablename, string fieldset, string condition1, string condition2)
    {
        SqlCommand cmd = new SqlCommand("[CommonSelectChange]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@condition1", SqlDbType.VarChar).Value = condition1;
        cmd.Parameters.Add("@condition2", SqlDbType.VarChar).Value = condition2;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public DataTable selectCommonProcedureInnerInnerInner(string tablename, string table1, string table2, string table3, string fieldset, string fields, string condition1, string condition2, string condition3)
    {
        SqlCommand cmd = new SqlCommand("[commonSelectInnerInnerInner]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@table1", SqlDbType.VarChar).Value = table1;
        cmd.Parameters.Add("@table2", SqlDbType.VarChar).Value = table2;
        cmd.Parameters.Add("@table3", SqlDbType.VarChar).Value = table3;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@fields", SqlDbType.VarChar).Value = fields;
        cmd.Parameters.Add("@condition1", SqlDbType.VarChar).Value = condition1;
        cmd.Parameters.Add("@condition2", SqlDbType.VarChar).Value = condition2;
        cmd.Parameters.Add("@condition3", SqlDbType.VarChar).Value = condition3;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public void FillGridProcedureInnerInnerInner(string tablename, string table1, string table2, string table3, string fieldset, string fields, string condition1, string condition2, string condition3, DataList dl)
    {
        DataTable dt = selectCommonProcedureInnerInnerInner(tablename, table1, table2, table3, fieldset, fields, condition1, condition2, condition3);
        dl.DataSource = dt;
        dl.DataBind();
    }
    public DataTable selectConditionCommonProcedureInnerInnerInner(string tablename, string table1, string table2, string table3, string fieldset, string fields, string condition1, string condition2, string condition3, string conditionset)
    {
        SqlCommand cmd = new SqlCommand("[CommonSelectConditionInnerInnerInner]", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
        cmd.Parameters.Add("@table1", SqlDbType.VarChar).Value = table1;
        cmd.Parameters.Add("@table2", SqlDbType.VarChar).Value = table2;
        cmd.Parameters.Add("@table3", SqlDbType.VarChar).Value = table3;
        cmd.Parameters.Add("@fieldset", SqlDbType.VarChar).Value = fieldset;
        cmd.Parameters.Add("@fields", SqlDbType.VarChar).Value = fields;
        cmd.Parameters.Add("@condition1", SqlDbType.VarChar).Value = condition1;
        cmd.Parameters.Add("@condition2", SqlDbType.VarChar).Value = condition2;
        cmd.Parameters.Add("@condition3", SqlDbType.VarChar).Value = condition3;
        cmd.Parameters.Add("@conditionset", SqlDbType.VarChar).Value = conditionset;
        SqlDataAdapter adp = new SqlDataAdapter();
        adp.SelectCommand = cmd;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    
   
}