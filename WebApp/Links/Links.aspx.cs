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

namespace WebApp.Links
{
    public partial class Links1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_LinksImageList();//友情链接图片列表绑定
                Load_LinksTextList();//友情链接文字列表绑定
            }
        }

        #region 友情链接图片数据绑定

        private void Load_LinksImageList()
        {
            zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
            DataTable dt = linkListBLL.GetList("IsEnable=1 and LinkType=0").Tables[0];

            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        #endregion

        #region 友情链接文字数据绑定

        private void Load_LinksTextList()
        {
            zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
            DataTable dt = linkListBLL.GetList("IsEnable=1 and LinkType=1").Tables[0];

            repLinks.DataSource = dt;
            repLinks.DataBind();
        }

        #endregion

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labLinkImage = (Label)e.Item.FindControl("labLinkImage");
                Label labLinkTitle = (Label)e.Item.FindControl("labLinkTitle");

                labLinkImage.Text = "<a href='" + drv["LinkTarget"].ToString() + "' target='_blank'><img style='border:0px;margin:5px;' src='" + drv["LinkImage"].ToString().Split('~')[1] + "' /></a>";
                labLinkTitle.Text = "<a class='huia' style='color:#E67115;' href='" + drv["LinkTarget"].ToString() + "' target='_blank' title='" + drv["LinkTitle"].ToString() + "'>" + Set_EnterpriseTitleLength(drv["LinkTitle"].ToString(), 0) + "</a>";
            }
        }

        #region 字符串截取

        private string Set_EnterpriseTitleLength(string strTitle,int nType)
        {
            if (nType == 0)
            {
                if (strTitle.Length >= 9)
                {
                    return strTitle.Substring(0, 9) + "...";
                }
                else
                {
                    return strTitle;
                }
            }
            else
            {
                if (strTitle.Length >= 12)
                {
                    return strTitle.Substring(0, 12) + "...";
                }
                else
                {
                    return strTitle;
                }
            }
        }

        #endregion

        //protected void DataList2_ItemDataBound(object sender, DataListItemEventArgs e)
        //{
        //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
        //        Label labLinksText = (Label)e.Item.FindControl("labLinksText");

        //        labLinksText.Text = "<a class='huia' style='color:#304874;' href='" + drv["LinkTarget"].ToString() + "' target='_blank' title='" + drv["LinkTitle"].ToString() + "'>" + drv["LinkTitle"].ToString() + "</a>";
        //    }
        //}

        protected void repLinks_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labLinksText = (Label)e.Item.FindControl("labLinksText");

                labLinksText.Text = "<a class='huia' style='color:#304874;' href='" + drv["LinkTarget"].ToString() + "' target='_blank' title='" + drv["LinkTitle"].ToString() + "'>" + drv["LinkTitle"].ToString() + "</a>";
            }
        }
    }
}

