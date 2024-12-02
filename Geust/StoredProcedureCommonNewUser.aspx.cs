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
    }
}