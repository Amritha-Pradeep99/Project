using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Geust_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            filldistrict();
            
            
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newuser where nu_email='" + txtemail.Text + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        string selQry1 = "select * from tbl_adminregistration where admin_email='" + txtemail.Text + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        string selQry2 = "select * from tbl_newclub where nc_email='" + txtemail.Text + "'";
        DataTable dt2 = new DataTable();
        SqlDataAdapter adp2 = new SqlDataAdapter(selQry2, con);
        adp2.Fill(dt2);

        string selQry3 = "select * from tbl_playerdetails where p_email='" + txtemail.Text + "'";
        DataTable dt3 = new DataTable();
        SqlDataAdapter adp3 = new SqlDataAdapter(selQry3, con);
        adp3.Fill(dt3);

        if (dt.Rows.Count > 0)
        {
            Label2.Text = "Already registered.. ";

        }

        else if (dt1.Rows.Count > 0)
        {
            Label2.Text = "Already registered.. ";

        }

        else if (dt2.Rows.Count > 0)
        {
            Label2.Text = "Already registered.. ";

        }

        else if (dt3.Rows.Count > 0)
        {
            Label2.Text = "Already registered.. ";

        }
        else
        {

            string photoName = Path.GetFileName(fileImage.PostedFile.FileName.ToString());
            fileImage.SaveAs(Server.MapPath("../Assests/UserDocs/" + photoName));

            string proofname = Path.GetFileName(fileproof.PostedFile.FileName.ToString());
            fileproof.SaveAs(Server.MapPath("../Assests/UserDocs/" + proofname));

            string insQry = "insert into tbl_newuser(nu_fname,nu_lname,nu_gender,nu_martial,nu_qual,nu_usern,nu_email,nu_phone,nu_address,place_id,nu_photo,nu_proof,nu_pwd,nu_status,nu_onlinestatus,nu_retypepassword)values('" + txtfname.Text + "','" + txtlname.Text + "','" + rdbgender.SelectedValue + "','" + rdbmartial.SelectedValue + "','" + rdbqual.SelectedValue + "','" + txtusern.Text + "','" + txtemail.Text + "','" + txtpn.Text + "','" + txtaddress.Text + "','" + ddlplace.SelectedValue + "','" + photoName + "','" + proofname + "','" + txtpwd.Text + "','0','0','" + txtrpwd.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
        txtfname.Text ="";
        txtlname.Text = "";
        rdbgender.ClearSelection();
        rdbmartial.ClearSelection();
       
        rdbqual.ClearSelection();
        txtusern.Text = "";
        txtemail.Text = "";
        txtpn.Text = "";
        txtpwd.Text = "";
        txtrpwd.Text = "";
        txtaddress.Text = "";

      

    }

    protected void filldistrict()
    {
        string selQry = "select * from tbl_district";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        ddldist.DataSource = dbt;
        ddldist.DataTextField="district_name";
        ddldist.DataValueField = "district_id";
        ddldist.DataBind();
        ddldist.Items.Insert(0, "--select--");
    }
   
   
  
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtfname.Text = "";
        txtlname.Text = "";
        rdbgender.ClearSelection();
        rdbmartial.ClearSelection();
        
        rdbqual.ClearSelection();
        txtusern.Text = "";
        txtemail.Text = "";
        txtpn.Text = "";
        txtrpwd.Text = "";
        txtaddress.Text = "";
    }
    protected void ddldist_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_place where district_id='" + ddldist.SelectedValue + "'";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        ddlplace.DataSource = dbt;
        ddlplace.DataTextField = "place_name";
        ddlplace.DataValueField = "place_id";
        ddlplace.DataBind();
    }



    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newuser where nu_email='" + txtemail.Text + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        string selQry1 = "select * from tbl_adminregistration where admin_email='" + txtemail.Text + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        string selQry2 = "select * from tbl_newclub where nc_email='" + txtemail.Text + "'";
        DataTable dt2 = new DataTable();
        SqlDataAdapter adp2 = new SqlDataAdapter(selQry2, con);
        adp2.Fill(dt2);

        string selQry3 = "select * from tbl_playerdetails where p_email='" + txtemail.Text + "'";
        DataTable dt3 = new DataTable();
        SqlDataAdapter adp3 = new SqlDataAdapter(selQry3, con);
        adp3.Fill(dt3);

        if (dt.Rows.Count > 0 )
        {
            Label1.Text = "Already registered.. ";
            
        }

        else if (dt1.Rows.Count > 0)
        {
            Label1.Text = "Already registered.. ";

        }

        else if (dt2.Rows.Count > 0)
        {
            Label1.Text = "Already registered.. ";

        }

        else if (dt3.Rows.Count > 0)
        {
            Label1.Text = "Already registered.. ";

        }
        else
        {
            Label1.Text = "Valid";
        }

    }
}