﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reg_step2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.email.Text = Request.QueryString["email"];
        this.ValidTest.Text = Request.QueryString["test_url"];
    }
}
