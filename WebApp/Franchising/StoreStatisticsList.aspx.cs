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
    public partial class StoreStatisticsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

        #region 加载指标评比

        private void Load_IndicatorsList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt01 = dictionaryListBLL.GetList("IsEnable=1 and DictionaryCategory='Indicators'").Tables[0];
            for (int nCount = 0; nCount < dt01.Rows.Count; nCount++)
            {
                if (Request.QueryString["id"] == null)
                {
                    if (nCount == 0)
                    {
                        labMenuList.Text += "<a class='h_hover2' href='StoreStatisticsList.aspx?id=" + dt01.Rows[nCount]["DictionaryKey"].ToString() + "'>" + dt01.Rows[nCount]["DictionaryValue"].ToString() + "</a>";
                    }
                    else
                    {
                        labMenuList.Text += "<a href='StoreStatisticsList.aspx?id=" + dt01.Rows[nCount]["DictionaryKey"].ToString() + "'>" + dt01.Rows[nCount]["DictionaryValue"].ToString() + "</a>";
                    }
                }
                else
                {
                    if (dt01.Rows[nCount]["DictionaryKey"].ToString() == Request.QueryString["id"])
                    {
                        labMenuList.Text += "<a class='h_hover2' href='StoreStatisticsList.aspx?id=" + dt01.Rows[nCount]["DictionaryKey"].ToString() + "'>" + dt01.Rows[nCount]["DictionaryValue"].ToString() + "</a>";
                    }
                    else
                    {
                        labMenuList.Text += "<a href='StoreStatisticsList.aspx?id=" + dt01.Rows[nCount]["DictionaryKey"].ToString() + "'>" + dt01.Rows[nCount]["DictionaryValue"].ToString() + "</a>";
                    }
                }
            }
            if (Request.QueryString["id"] != null)
            {
                zlzw.BLL.StoreStatisticsListBLL storeStatisticsListBLL = new zlzw.BLL.StoreStatisticsListBLL();
                DataTable dt = storeStatisticsListBLL.GetList("DictionaryKey='" + Request.QueryString["id"] + "'").Tables[0];

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            else
            {
                zlzw.BLL.StoreStatisticsListBLL storeStatisticsListBLL = new zlzw.BLL.StoreStatisticsListBLL();
                DataTable dt = storeStatisticsListBLL.GetList("DictionaryKey='" + dt01.Rows[0]["DictionaryKey"].ToString() + "'").Tables[0];

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            
        }

        #endregion

        #region 指标评比行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Web.UI.WebControls.ListItemType lit = e.Item.ItemType;
            if (lit == System.Web.UI.WebControls.ListItemType.Item || lit == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labPingBi = (Label)e.Item.FindControl("labPingBi");
                if (nRowIndex % 2 == 0)
                {
                    labPingBi.Text = "<tr class='odd'><td>" + Get_StoreName(drv["DictionaryKey"].ToString()) + "</td><td>第 " + drv["StoreStatisticsOrder"].ToString() + " 名</td><td>" + Get_StoreName(drv["StoreDictionaryKey"].ToString()) + "</td><td>" + Convert_DateTime(drv["PublishDate"].ToString()) + "</td></tr>";
                }
                else
                {
                    labPingBi.Text = "<tr><td>" + Get_StoreName(drv["DictionaryKey"].ToString()) + "</td><td>第 " + drv["StoreStatisticsOrder"].ToString() + " 名</td><td>" + Get_StoreName(drv["StoreDictionaryKey"].ToString()) + "</td><td>" + Convert_DateTime(drv["PublishDate"].ToString()) + "</td></tr>";
                }
                nRowIndex++;
            }
        }

        #endregion

        #region 页面变量

        private int nRowIndex = 1;
        public int RowIndex
        {
            set
            {
                nRowIndex = value;
            }
            get
            {
                return nRowIndex;
            }
        }

        #endregion

        #region 日期格式转换

        private string Convert_DateTime(string strDate)
        {
            try
            {
                return DateTime.Parse(strDate).ToString("yyyy年MM月");
            }
            catch (Exception exp)
            {
                return "未知";
            }
        }

        #endregion

        #region 获取店面名称

        private string Get_StoreName(string strStoreID)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryKey='" + strStoreID + "'").Tables[0];

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["DictionaryValue"].ToString();
            }
            else
            {
                return "未知";
            }
        }

        #endregion

        #region 日期查询按钮事件
        
        protected void btnUpdte_Click(object sender, EventArgs e)
        {

        }

        #endregion

        

    }
}
