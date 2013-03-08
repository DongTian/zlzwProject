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
    public partial class ProjectDescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_IndicatorsList();
                Get_URLParam();//获取第一个店面风采的key
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
    }
}
