﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Class_22_ImageMap_ImageMap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
    {
 Label1.Text = e.PostBackValue.ToString();

        /*if (e.PostBackValue == "BMW")
        {
            Response.Redirect("bmwdetails.aspx");
        }*/

    }
  
}