using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }
    protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
    {
        Label1.Text = e.PostBackValue.ToString();
    }
}