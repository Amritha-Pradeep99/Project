﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test_Default : System.Web.UI.Page
{
    public string videoname;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            videoname = Session["videoName"].ToString();
        }
    }
}