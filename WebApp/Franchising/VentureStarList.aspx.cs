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

namespace WebApp.Franchising
{
    public partial class VentureStarList1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_VentureStarList();
                Load_IndicatorsList();
                Get_URLParam();
            }
        }

        private void Get_URLParam()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dtMenu = dictionaryListBLL.GetList("DictionaryCategory='StoreType' and IsEnable=1 order by OrderNumber asc").Tables[0];
            DataTable dtMenuItem = dictionaryListBLL.GetList("DictionaryCategory='StoreItem' and IsEnable=1 and IsInner=" + dtMenu.Rows[0]["DictionaryListID"].ToString()).Tables[0];
            lab10.Text = "<a style='text-decoration:none;' href='StorefrontEleganceList.aspx?type=" + dtMenuItem.Rows[0]["DictionaryKey"].ToString() + "&reg=" + dtMenu.Rows[0]["DictionaryKey"].ToString() + "'><dt class='original1'>店面风采</dt></a>";
        }

        #region 加载评比指标菜单项目

        private void Load_IndicatorsList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt01 = dictionaryListBLL.GetList("IsEnable=1 and DictionaryCategory='Indicators'").Tables[0];
            for (int nCount = 0; nCount < dt01.Rows.Count; nCount++)
            {
                labMenuList.Text += "<a href='StoreStatisticsList.aspx?id=" + dt01.Rows[nCount]["DictionaryKey"].ToString() + "'>" + dt01.Rows[nCount]["DictionaryValue"].ToString() + "</a>";

            }
        }
        #endregion

        #region 创业明星列表绑定

        private void Load_VentureStarList()
        {
            zlzw.BLL.VentureStarListBLL ventureStarListBLL = new zlzw.BLL.VentureStarListBLL();
            DataTable dt = ventureStarListBLL.GetList("IsEnable=1").Tables[0];
            if (dt.Rows.Count > 0)
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            
        }

        #endregion

        #region 创业明星行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labImage = (Label)e.Item.FindControl("labImage");
                Label labContent = (Label)e.Item.FindControl("labContent");


                labImage.Text = "<img src='" + drv["VentureStarImage"].ToString().Split('~')[1] + "' alt='" + Get_StoreName(drv["DictionaryKey"].ToString()) + "　" + drv["VentureStarName"].ToString() + "'/>";
                labContent.Text = "<p>姓名：" + drv["VentureStarName"].ToString() + "</p><p style='margin-bottom:10px;margin-top:10px;'>所在店面：" + Get_StoreName(drv["DictionaryKey"].ToString()) + "</p><p style='margin-bottom:10px;margin-top:10px;'>明星介绍：" + drv["VentureStarContent"].ToString() + "</p>";
            }
        }

        #endregion

        #region 获取店面名称

        private string Get_StoreName(string strStoreKey)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryKey='" + strStoreKey + "'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["DictionaryValue"].ToString();
            }
            else
            {
                return "";
            }
        }

        #endregion
    }
}
