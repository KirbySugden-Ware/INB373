﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;

public partial class AccessGeneral_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginPanel_Authenticate(object sender, AuthenticateEventArgs e) {
        //code to authenticate user

        e.Authenticated = true;
    }
}