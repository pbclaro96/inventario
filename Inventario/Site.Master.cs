﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventario
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LkbCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            FormsAuthentication.SignOut();

            Response.Redirect("~/FrmLogin.aspx");
        }
    }
}