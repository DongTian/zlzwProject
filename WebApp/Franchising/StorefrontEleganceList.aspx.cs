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
    public partial class StorefrontEleganceList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["type"] != null)
                {
                    Load_StoreInfo(Request.QueryString["type"]);
                    Load_StoreOthewrImageList(Request.QueryString["type"]);
                }
                Load_StoreMenuList();
            }
        }

        #region 页面变量

        private int nIsDefault = 0;
        public int IsDefaule
        {
            set
            {
                nIsDefault = value;
            }
            get
            {
                return nIsDefault;
            }
        }

        private int nIsMenuItem = 0;
        public int IsMneuItem
        {
            set
            {
                nIsMenuItem = value;
            }
            get
            {
                return nIsMenuItem;
            }
        }

        private int nIsMenuItemSelect = 0;
        public int IsMenuItemSelect 
        {
            set
            {
                nIsMenuItemSelect = value;
            }
            get
            {
                return nIsMenuItemSelect;
            }
        }

        #endregion

        #region 加载店面菜单列表

        private void Load_StoreMenuList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='StoreType' and IsEnable=1 order by OrderNumber asc").Tables[0];
            string strStoreKey = dt.Rows[0]["DictionaryKey"].ToString();
            
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            if (Request.QueryString["type"] == null)
            {
                Load_StoreInfo(strStoreKey);
                Load_StoreOthewrImageList(strStoreKey);
            }
        }

        #endregion

        #region 加载店面信息

        private void Load_StoreInfo(string strStoreKey)
        {
            zlzw.BLL.StorefrontEleganceListBLL storefrontEleganceListBLL = new zlzw.BLL.StorefrontEleganceListBLL();
            DataTable dt = storefrontEleganceListBLL.GetList("DictionaryKey='" + strStoreKey + "'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                labStoreImage.Text = "<img src='" + dt.Rows[0]["StorefrontEleganceHeadImage"].ToString().Split('~')[1] + "' alt='' />";
                labStoreDesc.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dt.Rows[0]["StorefrontEleganceDescription"].ToString();
                labPostJob.Text = "<span style='color:#1D5087;font-size:14px;'>主推岗位：</span>" + dt.Rows[0]["PushJobs"].ToString();
            }
        }

        #endregion

        #region 菜单行绑定

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
            Label labMenuContent = (Label)e.Item.FindControl("labMenuContent");
            if (Request.QueryString["type"] == null)
            {
                if (nIsDefault == 0)
                {
                    labMenuContent.Text = "<dt class='expand1' style='color:#314777;'>" + drv["DictionaryValue"].ToString() + "</dt>";
                    labMenuContent.Text += Get_StoreList(drv["DictionaryListID"].ToString());
                    nIsDefault = 1;
                }
                else
                {
                    labMenuContent.Text = "<dt class='original1'>" + drv["DictionaryValue"].ToString() + "</dt>";
                    labMenuContent.Text += Get_StoreList(drv["DictionaryListID"].ToString());
                }
            }
            else
            {
                if (Request.QueryString["reg"] == drv["DictionaryKey"].ToString())
                {
                    labMenuContent.Text = "<dt class='expand1' style='color:#314777;'>" + drv["DictionaryValue"].ToString() + "</dt>";
                    labMenuContent.Text += Get_StoreList(drv["DictionaryListID"].ToString());
                }
                else
                {
                    labMenuContent.Text = "<dt class='original1'>" + drv["DictionaryValue"].ToString() + "</dt>";
                    labMenuContent.Text += Get_StoreList(drv["DictionaryListID"].ToString());
                }
            }

        }

        #endregion

        #region 加载页面其他图片列表

        private void Load_StoreOthewrImageList(string strStoreKey)
        {
            zlzw.BLL.StoreImageListBLL storeImageListBLL = new zlzw.BLL.StoreImageListBLL();
            DataTable dt = storeImageListBLL.GetList("DictionaryKey='" + strStoreKey + "' and IsEnable=1").Tables[0];

            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        #endregion

        #region 获取区域下的所有店面

        private string Get_StoreList(string strRegionCode)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("IsInner=" + strRegionCode + " and DictionaryCategory='StoreItem' and IsEnable=1 order by OrderNumber asc").Tables[0];
            if (dt.Rows.Count > 0)
            {
                System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
                if (IsMneuItem == 0 && Request.QueryString["reg"] == Get_BaseKey(dt.Rows[0]["IsInner"].ToString()))
                {
                    strBuilder.Append("<dd style='display:block;'>");
                    for (int nCount = 0; nCount < dt.Rows.Count; nCount++)
                    {
                        if (IsMenuItemSelect == 0 && Request.QueryString["type"] == dt.Rows[nCount]["DictionaryKey"].ToString())
                        {
                            strBuilder.Append("<a style='text-decoration:none;' class='h_hover2' href='StorefrontEleganceList.aspx?type=" + dt.Rows[nCount]["DictionaryKey"].ToString() + "&reg=" + Get_BaseKey(dt.Rows[0]["IsInner"].ToString()) + "'>" + dt.Rows[nCount]["DictionaryValue"].ToString() + "</a>");
                            IsMenuItemSelect = 1;
                        }
                        else
                        {
                            strBuilder.Append("<a style='text-decoration:none;' class='' href='StorefrontEleganceList.aspx?type=" + dt.Rows[nCount]["DictionaryKey"].ToString() + "&reg=" + Get_BaseKey(dt.Rows[0]["IsInner"].ToString()) + "'>" + dt.Rows[nCount]["DictionaryValue"].ToString() + "</a>");
                        }
                        IsMneuItem = 1;
                    }
                    
                }
                else
                {
                    strBuilder.Append("<dd style='display:none;'>");
                    for (int nCount = 0; nCount < dt.Rows.Count; nCount++)
                    {
                        strBuilder.Append("<a style='text-decoration:none;' class='' href='StorefrontEleganceList.aspx?type=" + dt.Rows[nCount]["DictionaryKey"].ToString() + "&reg=" + Get_BaseKey(dt.Rows[0]["IsInner"].ToString()) + "'>" + dt.Rows[nCount]["DictionaryValue"].ToString() + "</a>");
                    }
                }
                
                strBuilder.Append("</dd>");

                return strBuilder.ToString();
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region 获取父类key

        private string Get_BaseKey(string strID)
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            zlzw.Model.DictionaryListModel dictionaryListModel = dictionaryListBLL.GetModel(int.Parse(strID));

            return dictionaryListModel.DictionaryKey;
        }

        #endregion

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)e.Item.DataItem;
                Label labImageList = (Label)e.Item.FindControl("labImageList");
                Label labImageName = (Label)e.Item.FindControl("labImageName");

                labImageList.Text = "<img width='210' src='" + drv["StoreImagePath"].ToString().Split('~')[1] + "' />";
            }
        }
        
    }
}
