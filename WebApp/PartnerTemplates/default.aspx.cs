using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WebApp.PartnerTemplates
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!IsPostBack)
                {
                    try
                    {
                        string strGUID = Request.QueryString["id"];
                        Load_JobList();//加载职位列表
                        Load_EnterpriseInfo(strGUID);
                    }
                    catch (Exception exp)
                    {
                        Response.Redirect("../default.aspx");
                    }
                }
            }
        }

        #region 加载企业信息

        private void Load_EnterpriseInfo(string strEnterPriseGUID)
        {
            try
            {
                zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
                DataTable dt = partnersListBLL.GetList("PartnerGUID='" + strEnterPriseGUID + "'").Tables[0];

                txbTitle.Text = "校企英才官方合作伙伴-"+dt.Rows[0]["PartnerName"].ToString();
                labEnterpriseLogo.Text = "<img style='padding-left:20px;' alt='' title='' src='" + dt.Rows[0]["PartnerLogo"].ToString().Split('~')[1] + "' />";
                labBanner.Text = "<img alt='' title='' src='" + dt.Rows[0]["PartnerBanner"].ToString().Split('~')[1] + "' />";
                labEnterpriseContent.Text = dt.Rows[0]["PartnerIntroduction"].ToString();
                labJobContactAdd.Text = dt.Rows[0]["JobContactAdd"].ToString();
                labJobContactPhone.Text = dt.Rows[0]["JobContactPhone"].ToString();
                labJobContactName.Text = dt.Rows[0]["JobContactName"].ToString();
            }
            catch (Exception exp)
            {
                Response.Redirect("../default.aspx");
            }
        }

        #endregion

        #region 职位列表绑定

        private void Load_JobList()
        {
            try
            {
                string strPartnersGUID = Request.QueryString["id"];
                zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
                DataTable dt = partnersJobListBLL.GetList("PartnerGUID='"+ strPartnersGUID +"'").Tables[0];

                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
            catch (Exception exp)
            {
                Response.Redirect("../default.aspx");
            }
        }

        #endregion

        #region 职位列表行绑定事件

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labJobTitle = (Label)e.Item.FindControl("labJobTitle");

                labJobTitle.Text = "<a class='jobList' href='#' onclick=\"javascript:art.dialog.open('JobList.html?id="+ drv["PartnersJobID"].ToString() +"', {width: 577, height: 371})\"; style='text-decoration:none;'>" + drv["PostInfo"].ToString() + "</a>";
            }
        }

        #endregion
    }
}
