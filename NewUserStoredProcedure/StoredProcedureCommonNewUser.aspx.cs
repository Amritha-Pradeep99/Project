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
    cls_StoredProcedureCommon obj = new cls_StoredProcedureCommon();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillqual();
            fillDistrict();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string photoimage = Path.GetFileName(filePhoto.PostedFile.FileName.ToString());
        filePhoto.SaveAs(Server.MapPath("../Assests/UserDocs/" + photoimage));

        string proofimage = Path.GetFileName(fileProof.PostedFile.FileName.ToString());
        fileProof.SaveAs(Server.MapPath("../Assests/UserDocs/" + proofimage));

        string tablename = "tbl_newuser";
        string fieldset = "nu_fname,nu_lname,nu_gender,nu_martial,nu_qual,nu_email,nu_address,nu_phone,nu_usern,nu_pwd,place_id,nu_photo,nu_proof";
        string valueset="'"+txtfname.Text+"','"+txtlname.Text+"','"+rblgender.SelectedValue+"','"+rblmartial.SelectedValue+"','"+ddlqual.SelectedValue+"','"+txtemail.Text+"','"+txtaddress.Text+"','"+txtcontact.Text+"','"+txtusername.Text+"','"+txtpwd.Text+"','"+ddlplace.SelectedValue+"','"+photoimage+"','"+proofimage+"'";
        obj.ExcecuteCommonProcedure(tablename,fieldset,valueset);

        txtfname.Text = "";
        txtlname.Text = "";
        rblgender.ClearSelection();
        rblmartial.ClearSelection();
        ddlqual.ClearSelection();
        txtemail.Text = "";
        txtaddress.Text = "";
        txtcontact.Text = "";
        txtusername.Text = "";
        txtpwd.Text = "";
        ddlplace.ClearSelection();
    }
    protected void fillqual()
    {
        ddlqual.Items.Insert(0,"--select--");
        ddlqual.Items.Add("BCA");
        ddlqual.Items.Add("MCA");

    }
    protected void fillDistrict()
    {
        string tablename = "tbl_district";
        string fieldset = "*";
        DataTable dt = new DataTable();
        dt = obj.SelectAllCommonProcedure(tablename, fieldset);
        ddldistrict.DataSource = dt;
        ddldistrict.DataTextField = "district_name";
        ddldistrict.DataValueField = "district_id";
        ddldistrict.DataBind();
    }
    
    protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        string tablename = "tbl_place";
        string fieldset = "*";
        string conditionfield = "district_id";
        string conditiovalue = "" + ddldistrict.SelectedValue + "";
        DataTable dt = new DataTable();
        dt = obj.FillDropDownSelectedIndex(tablename, fieldset, conditionfield, conditiovalue);
        ddlplace.DataSource = dt;
        ddlplace.DataTextField = "place_name";
        ddlplace.DataValueField = "place_id";
        ddlplace.DataBind();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtfname.Text = "";
        txtlname.Text = "";
        rblgender.ClearSelection();
        rblmartial.ClearSelection();
        ddlqual.ClearSelection();
        txtemail.Text = "";
        txtaddress.Text = "";
        txtcontact.Text = "";
        txtusername.Text = "";
        txtpwd.Text = "";
        ddlplace.ClearSelection();
    }
}