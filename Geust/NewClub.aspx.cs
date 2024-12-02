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
        if(!IsPostBack)
            
        {
            filldistrict();
        }
        
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newclub where nc_email='" + txtemail.Text + "'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        string selQry1 = "select * from tbl_newuser where nu_email='" + txtemail.Text + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        string selQry2 = "select * from tbl_adminregistration where admin_email='" + txtemail.Text + "'";
        DataTable dt2 = new DataTable();
        SqlDataAdapter adp2 = new SqlDataAdapter(selQry2, con);
        adp2.Fill(dt2);

        string selQry3 = "select * from tbl_playerdetails where p_email='" + txtemail.Text + "'";
        DataTable dt3 = new DataTable();
        SqlDataAdapter adp3 = new SqlDataAdapter(selQry3, con);
        adp3.Fill(dt3);

        if (dt.Rows.Count > 0)
        {
            Label2.Text = "Already Registered..";
        }
        else if (dt1.Rows.Count > 0)
        {
            Label2.Text = "Already Registered..";

        }

        else if (dt2.Rows.Count > 0)
        {
            Label2.Text = "Already Registered..";
        }

        else if (dt3.Rows.Count > 0)
        {
            Label2.Text = "Already Registered..";

        }
        else
        {
            string photoimage = Path.GetFileName(filephoto.PostedFile.FileName.ToString());
            filephoto.SaveAs(Server.MapPath("../Assests/Clubdoc/" + photoimage));

            string proofimage = Path.GetFileName(fileproof.PostedFile.FileName.ToString());
            fileproof.SaveAs(Server.MapPath("../Assests/Clubdoc/" + proofimage));


            string insQry = "insert into tbl_newclub(nc_name,nc_email,nc_contact,nc_username,nc_pwd,nc_address,nc_date,nc_photo,nc_proof,place_id,nc_retypepassword)values('" + txtname.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + txtaddress.Text + "','" + txtdate.Text + "','" + photoimage + "','" + proofimage + "','" + ddlplace.SelectedValue + "','" + txtrpwd.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();

        }

        txtname.Text = "";
        txtemail.Text = "";
        txtcontact.Text = "";
        txtusername.Text = "";
        txtpwd.Text = "";
        txtaddress.Text = "";
        txtdate.Text = "";

        
    }

    protected void filldistrict()
    {
        string selQry = "select * from tbl_district";
        DataTable dbt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dbt);
        ddldist.DataSource = dbt;
        ddldist.DataTextField = "district_name";
        ddldist.DataValueField = "district_id";
        ddldist.DataBind();
        ddldist.Items.Insert(0,"--select--");
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

    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtemail.Text = "";
        txtcontact.Text = "";
        txtusername.Text = "";
        txtpwd.Text = "";
        txtaddress.Text = "";
        txtdate.Text = "";
    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newclub where nc_email='"+txtemail.Text+"'";
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        adp.Fill(dt);

        string selQry1 = "select * from tbl_newuser where nu_email='" + txtemail.Text + "'";
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        adp1.Fill(dt1);

        string selQry2 = "select * from tbl_adminregistration where admin_email='" + txtemail.Text + "'";
        DataTable dt2 = new DataTable();
        SqlDataAdapter adp2 = new SqlDataAdapter(selQry2, con);
        adp2.Fill(dt2);

        string selQry3 = "select * from tbl_playerdetails where p_email='" + txtemail.Text + "'";
        DataTable dt3 = new DataTable();
        SqlDataAdapter adp3 = new SqlDataAdapter(selQry3, con);
        adp3.Fill(dt3);

        if (dt.Rows.Count > 0)
        {
            Label1.Text = "Already Registered..";
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
            Label1.Text = "Valid...";
        }
    }
   
}