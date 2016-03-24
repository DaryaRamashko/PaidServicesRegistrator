﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaidServicesRegistrator.Utils;

namespace PaidServicesRegistrator.View
{
    public partial class MainView : Page
    {
        private static bool firstStart = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (firstStart)
            {
                TokenTypeDropDownList.DataSource = new[] {TokenUtil.TokenType.OneOff, TokenUtil.TokenType.ThirtyDays}; //Enum.GetNames(typeof (TokenUtil.TokenType));
                TokenTypeDropDownList.DataBind();
                //TODO get services names from database
                firstStart = false;
            }
        }
    }
}