using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;
public partial class Admin_Default : System.Web.UI.Page
{
    MyProject obj = new MyProject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                fillDistrict();
                fillQual();
            }
            else
            {
                Response.Redirect("../Guest/AdminLogin.aspx");
            }

            //fillDistrict();
            //fillQual();
            
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string photoimage = Path.GetFileName(filephoto.PostedFile.FileName.ToString());
        filephoto.SaveAs(Server.MapPath("../Assests/UserDocs/" + photoimage));

        string proofimage = Path.GetFileName(fileproof.PostedFile.FileName.ToString());
        filephoto.SaveAs(Server.MapPath("../Assests/UserDocs/" + proofimage));

        string insQry = "insert into tbl_newuser(nu_fname,nu_lname,nu_gender,nu_martial,nu_qual,nu_email,nu_phone,nu_address,place_id,nu_photo,nu_proof)values('" + txtfname.Text + "','" + txtlname.Text + "','" + rdbgender.SelectedValue + "','" + rdbmartial.SelectedValue + "','" + ddlqual.SelectedValue + "','" + txtemail.Text + "','" + txtpn.Text + "','" + txtaddress.Text + "','" + ddlplace.SelectedValue + "','" + photoimage + "','" + proofimage + "')";
        obj.ExcecuteCommand(insQry);
    }
    protected void fillQual()
    {
        ddlqual.Items.Insert(0, "--select--");
        ddlqual.Items.Add("BCA");
        ddlqual.Items.Add("MCA");
    }
    protected void fillDistrict()
    {
        string selQry = "select * from tbl_district ";
        obj.fillDropDown(ddldist,"district_name", "district_id", selQry);
    }
    protected void ddldist_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_place  where district_id='"+ddldist.SelectedValue+"'";
        obj.fillDropDown(ddlplace, "place_name", "place_id", selQry);
    }

    protected void btnshow_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newuser  n inner join tbl_place p on n.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        if (dt.Rows.Count > 0)
        {
            ltrlUserlist.Text = "<table border='1'>";
            ltrlUserlist.Text += "<tr><td><b>ID</b></td><td><b>Fname</b></td><td><b>Lname</b></td><td><b>Gender</b></td><td><b>Martial</b></td>";
            ltrlUserlist.Text += "<td><b>Qual</b></td><td><b>Email</b></td><td><b>Address</b></td><td><b>Contact</b></td><td><b>place</b></td><td><b>District</b></td><td><b>Photo</b></td><td><b>Proof</b></td></tr>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrlUserlist.Text += "<tr><td>" + dt.Rows[i]["nu_id"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_fname"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_lname"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_gender"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_martial"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_qual"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_email"].ToString()+ "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_address"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_phone"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["place_name"].ToString()+ "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["district_name"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_photo"].ToString() + "</td>";
                ltrlUserlist.Text += "<td>" + dt.Rows[i]["nu_proof"].ToString() + "</td></tr>";
            }
            ltrlUserlist.Text += "</table>";

        }
        else
        {
            ltrlUserlist.Text = "no records..";
        }

    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_newuser  n inner join tbl_place p on n.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id where nu_id='" + txtid.Text + "'";
        DataTable dt = new DataTable();
        dt = obj.selCommand(selQry);
        if (dt.Rows.Count > 0)
        {
            ltrlUserlist.Text = "<table border='1'>";
            ltrlUserlist.Text += "<tr><td><b>ID</b></td><td><b>Fname</b></td><td><b>Lname</b></td><td><b>Gender</b></td><td><b>Martial</b></td>";
            ltrlUserlist.Text += "<td><b>Qual</b></td><td><b>Email</b></td><td><b>Address</b></td><td><b>Contact</b></td><td><b>place</b></td><td><b>District</b></td><td><b>Photo</b></td><td><b>Proof</b></td></tr>";



            ltrlUserlist.Text += "<tr><td>" + dt.Rows[0]["nu_id"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_fname"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_lname"].ToString()+ "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_gender"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_martial"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_qual"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_email"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_address"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_phone"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["place_name"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["district_name"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_photo"].ToString() + "</td>";
            ltrlUserlist.Text += "<td>" + dt.Rows[0]["nu_proof"].ToString()+ "</td></tr>";

            ltrlUserlist.Text += "</table>";
        }
        else
        {
            ltrlUserlist.Text = "no such records..";
        }
    }
   
}