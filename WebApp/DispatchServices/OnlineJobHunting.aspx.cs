﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using FineUI;

namespace WebApp
{
    public partial class OnlineJobHunting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txbPostBackURL.Text = Request.Url.OriginalString;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Alert.Show("提交成功","内容提交",MessageBoxIcon.Question);

        }
    }
}
