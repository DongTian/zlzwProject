using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_BannerList();//加载Banner列表
                Load_HotPost();//加载热门岗位
                Load_PartnerList();//加载合作伙伴
                Load_labAdvertisingInfo();//加载广告位
                //Label1.Text = "<li><span class='r hui'>2010-01-01</span><a href='#' class='huia'>青岛诺尔信电子科技　/　<span style='color:#58738D'>销售员、业务员</span>　/　<span style='color:#58738D'>　6人　</span></li>";
            }
        }

        #region 加载首页Banner List

        private void Load_BannerList()
        {
            //zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
            //DataTable dt = bannerListBLL.GetList("BannerType=1 and IsHot=1 and IsEnable=1").Tables[0];
            //for (int nCount = 0; nCount < dt.Rows.Count; nCount++)
            //{
            //    labBanner.Text += "<div><a href='" + dt.Rows[nCount]["BannerLinks"].ToString() + "'><img style='border:0px;' src='" + dt.Rows[nCount]["BannerImage"].ToString().Split('~')[1] + "' alt='' /></a></div>";
            //}
        }

        #endregion

        #region 加载广告位

        private void Load_labAdvertisingInfo()
        {
            zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
            DataTable dt = bannerListBLL.GetList(1,"BannerType=1 and IsEnable=1 and IsHot=1","PublishDate desc").Tables[0];
            if (dt.Rows.Count > 0)
            {
                labAdvertising.Text = "<a href='" + dt.Rows[0]["BannerLinks"].ToString() + "' target='_blank'><img style='border:0px;' width='1000' src='" + dt.Rows[0]["BannerImage"].ToString().Split('~')[1] + "' alt='" + dt.Rows[0]["BannerTitle"].ToString() + "'/></a>";
            }
        }

        #endregion

        #region 加载热门岗位

        private void Load_HotPost()
        {
            zlzw.BLL.JobKindListBLL jobKindListBLL = new zlzw.BLL.JobKindListBLL();
            DataTable dt = jobKindListBLL.GetList(14,"IsShowDefaultPage=1 and IsEnable=1","PublishDate desc").Tables[0];

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        #endregion

        #region 加载合作伙伴

        private void Load_PartnerList()
        {
            zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
            DataTable dt = partnersListBLL.GetList(12,"IsHot=1 and IsEnable=1","PublishDate desc").Tables[0];

            Repeater2.DataSource = dt;
            Repeater2.DataBind();
        }

        #endregion

        #region 热门岗位行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labHotPost = (Label)e.Item.FindControl("labHotPost");

                labHotPost.Text = "<a href='SearchResultList.aspx?id=" + Server.UrlEncode(drv["JobKindName"].ToString()) + "' style='color:#fff;text-decoration:none;'>" + drv["JobKindName"].ToString() + "</a>";
            }
        }

        #endregion

        #region 合作伙伴行绑定
        
        protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label lablabImage = (Label)e.Item.FindControl("lablabImage");

                lablabImage.Text = "<a href='../PartnerTemplates/default.aspx?id=" + drv["PartnerGUID"].ToString() + "' target='_blank'><img style='border:0px;' src='" + drv["PartnerLogo"].ToString().Split('~')[1] + "' alt='" + drv["PartnerName"].ToString() + "' title='" + drv["PartnerName"].ToString() + "' /></a>";
            }
        }

        #endregion   

        #region 查询按钮事件响应

        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SearchResultList.aspx?id=" + Server.UrlEncode(txbSearchKey.Value));
        }

        #endregion
    }
}
