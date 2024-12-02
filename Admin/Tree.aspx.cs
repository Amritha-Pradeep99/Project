using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
public partial class Admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillTree();
        }

    }
    protected void fillTree()
    {
        string selQry = "select * from tbl_deptree";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);
        TreeNode tnParent = null, tnChild1 = null, tnChild2 = null;
        foreach (DataRow dr in dt.Rows)
        {
            tnParent = new TreeNode();
            tnParent.Text = dr["dept_name"].ToString();
            tnParent.Value = dr["dept_id"].ToString();


            string sel1 = "select * from tbl_coursetree where dept_id=" + Convert.ToInt32(dr["dept_id"].ToString()) + "";
            DataTable dt1 = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(sel1, con);
            adp1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                tnChild1=new TreeNode();
                tnChild1.Text = dr1["course_name"].ToString(); 
                tnChild1.Value = dr1["course_id"].ToString();
                tnParent.ChildNodes.Add(tnChild1);


                string sel2="select * from tbl_subtree where course_id="+Convert.ToInt32(dr1["course_id"].ToString())+"";
                 DataTable dt2 = new DataTable();
                SqlDataAdapter adp2= new SqlDataAdapter(sel2, con);
                adp2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    tnChild2=new TreeNode();
                    tnChild2.Text=dr2["sub_name"].ToString();
                    tnChild2.Value=dr2["sub_id"].ToString();
                    tnChild1.ChildNodes.Add(tnChild2);
                }
            }
            tv.Nodes.Add(tnParent);
        }
       tv.CollapseAll();
    }
}