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
    public partial class EnterpriseNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AspNetPager1.RecordCount = Get_NewsRecordCount();//获取新闻分页总数
                Load_NewsList();//加载新闻列表
            }
        }

        #region 返回新闻总数

        private int Get_NewsRecordCount()
        {
            zlzw.BLL.NewsListBLL newsListBLL = new zlzw.BLL.NewsListBLL();
            DataTable dt = newsListBLL.GetList("IsEnable=1 order by PublishDate").Tables[0];

            return dt.Rows.Count;
        }

        #endregion

        #region 加载新闻列表

        private void Load_NewsList()
        {
            int nPageIndex = AspNetPager1.CurrentPageIndex;
            int nPageSize = AspNetPager1.PageSize = 10;
            zlzw.BLL.NewsListBLL newsListBLL = new zlzw.BLL.NewsListBLL();
            DataTable dt = newsListBLL.GetList(nPageSize, nPageIndex, "*", "PublishDate", 0, "desc", "IsEnable=1").Tables[0];

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        #endregion

        #region 新闻列表行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labNewsDate = (Label)e.Item.FindControl("labNewsDate");
                Label labNewsTitle = (Label)e.Item.FindControl("labNewsTitle");

                labNewsDate.Text = DateTime.Parse(drv["PublishDate"].ToString()).ToString("yyyy年MM月dd日");
                labNewsTitle.Text = "<a href='EnterpriseNewsInfo.aspx?id=" + drv["NewsGUID"].ToString() + "' class='huia'><img src='../Resources/images/nnew.gif' style='border:0px;' width='22' height='9' border='0' />　" + Set_NewsTitleLength(drv["NewsTitle"].ToString()) + "</a>";
            }
        }

        #endregion

        #region 分页事件

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Load_NewsList();
        }

        #endregion

        #region 辅助函数

        private string Set_NewsTitleLength(string strNewsTitle)
        {
            if (strNewsTitle.Length >= 35)
            {
                return strNewsTitle.Substring(0, 35) + "...";
            }
            else
            {
                return strNewsTitle;
            }
        }

        #endregion
    }
}
