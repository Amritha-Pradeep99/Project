using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;
public partial class Test_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-FDV8RAL7;Initial Catalog=db_project;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string video = Path.GetFileName(FileVideo.PostedFile.FileName.ToString());
        FileVideo.SaveAs(Server.MapPath("../Assests/Video/" + video));

        string insQry = "insert into tbl_video(video_caption,video_filename)values('" + txtcaption.Text + "','" + video + "')";
        SqlCommand cmd=new SqlCommand(insQry,con);
        cmd.ExecuteNonQuery();
    }
}