using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Club_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
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
            string photoimage = Path.GetFileName(filephoto.PostedFile.FileName.ToString());
            filephoto.SaveAs(Server.MapPath("../Assests/Playerdoc/" + photoimage));

            string proofimage = Path.GetFileName(fileproof.PostedFile.FileName.ToString());
            fileproof.SaveAs(Server.MapPath("../Assests/Playerdoc/" + proofimage));

            string insQry = "insert into tbl_playerdetails (p_name,p_dob,p_email,p_address,p_contact,p_photo,p_proof,p_pwd,nc_id)values('" + txtname.Text + "','" + txtdob.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + photoimage + "','" + proofimage + "','" + txtpwd.Text + "','" + Session["clubid"] + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
        txtname.Text = "";
        txtdob.Text = "";
        txtemail.Text = "";
        txtaddress.Text = "";
        txtcontact.Text = "";
        txtpwd.Text = "";
    }

   
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtdob.Text = "";
        txtemail.Text = "";
        txtaddress.Text = "";
        txtcontact.Text = "";
        txtpwd.Text = "";
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
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
            lblmsg.Text = "Already registered.. ";
            
        }

        else if (dt1.Rows.Count > 0)
        {
            lblmsg.Text = "Already registered.. ";

        }

        else if (dt2.Rows.Count > 0)
        {
            lblmsg.Text = "Already registered.. ";

        }

        else if (dt3.Rows.Count > 0)
        {
            lblmsg.Text = "Already registered.. ";

        }
        else
        {
            lblmsg.Text = "Valid";
        }

    }
    
}