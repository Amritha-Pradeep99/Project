using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for cls_StoredProcedure
/// </summary>
public class cls_StoredProcedure
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-RC921KK;Initial Catalog=db_aspsylabus;Integrated Security=True");
	public cls_StoredProcedure()
	{
        con.Open();
	}
    public void ExceuteProcedure(string spname, string name,string gender,string dept,int salary)
    {
        SqlCommand cmd = new SqlCommand(spname, con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
        cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
        cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = dept;
        cmd.Parameters.Add("@salary", SqlDbType.Int).Value = salary;
        cmd.ExecuteNonQuery();
    }





    public void UpdateProcedure(string spname, string name,string gender,string dept,int salary,int idno)
    {
        SqlCommand cmd = new SqlCommand(spname, con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@eid", SqlDbType.Int).Value = idno;
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
        cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
        cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = dept;
        cmd.Parameters.Add("@salary", SqlDbType.Int).Value = salary;
        cmd.ExecuteNonQuery();
    }

    public DataTable SelectProcedure(string spname, int idno)
    {
        SqlCommand cmd = new SqlCommand(spname, con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@eid", SqlDbType.Int).Value = idno;
        SqlDataAdapter ada = new SqlDataAdapter();
        ada.SelectCommand = cmd;
        DataTable dt = new DataTable();
        ada.Fill(dt);
        return dt;
    }

   

    public void FillGrid(string spname, GridView grd)
    {
        SqlCommand cmd = new SqlCommand(spname, con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter ada = new SqlDataAdapter();
        ada.SelectCommand = cmd;
        DataTable dt = new DataTable();
        ada.Fill(dt);
        grd.DataSource = dt;
        grd.DataBind();
    }


    public void DeleteProcedure(string spname, int id)
    {
        SqlCommand cmd1 = new SqlCommand(spname, con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@eid", SqlDbType.Int).Value = id;
        cmd1.ExecuteNonQuery();
    }

}