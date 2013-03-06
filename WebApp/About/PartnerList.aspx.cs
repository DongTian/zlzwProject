using System;
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

namespace WebApp.About
{
    public partial class PartnerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AspNetPager1.RecordCount = Get_EnterpriseRecordCount();
                Load_EnterpriseList();//加载合作伙伴列表
            }
        }

        #region 获取伙伴总数

        private int Get_EnterpriseRecordCount()
        {
            zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
            DataTable dt = partnersListBLL.GetList("IsEnable=1").Tables[0];

            return dt.Rows.Count;
        }

        #endregion

        #region 加载合作伙伴列表

        private void Load_EnterpriseList()
        {
            int nPageIndex = AspNetPager1.CurrentPageIndex;
            int nPageSize = AspNetPager1.PageSize = 5;
            zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
            DataTable dt = partnersListBLL.GetList(nPageSize, nPageIndex, "*", "PublishDate", 0, "desc", "IsEnable=1").Tables[0];

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        #endregion

        #region 合作伙伴行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labLogoImage = (Label)e.Item.FindControl("labLogoImage");
                Label labEnterpriseName = (Label)e.Item.FindControl("labEnterpriseName");
                Label labEnterpriseContent = (Label)e.Item.FindControl("labEnterpriseContent");
                labLogoImage.Text = "<a href='../PartnerTemplates/default.aspx?id=" + drv["PartnerGUID"].ToString() + "' target='_blank'><img style='border:0px;' alt='' title='' src='" + drv["PartnerLogo"].ToString().Split('~')[1] + "' /></a>";
                labEnterpriseName.Text = "<a class='huia' target='_blank' href='../PartnerTemplates/default.aspx?id=" + drv["PartnerGUID"].ToString() + "'>" + drv["PartnerName"].ToString() + "</a>";
                labEnterpriseContent.Text = Set_PartnerIntroductionLength(drv["PartnerIntroduction"].ToString()) + "　...<a class='huia' style='color:#F26200;' href='../PartnerTemplates/default.aspx?id=" + drv["PartnerGUID"].ToString() + "' target='_blank'>查看</a>";
            }
        }

        #endregion

        #region 字符长度设置

        private string Set_PartnerIntroductionLength(string strTitle)
        {
            if (strTitle.Length >= 105)
            {
                return strTitle.Substring(0, 105);
            }
            else
            {
                return strTitle;
            }
        }

        #endregion

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Load_EnterpriseList();
        }
    }
}
