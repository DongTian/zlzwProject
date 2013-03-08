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
using ExtAspNet;

namespace WebApp.manage.admin
{
    public partial class AddStoreStatistics1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_StoreType();
                Load_IndicatorsList();
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载门店信息

        private void Load_StoreType()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='StoreType'").Tables[0];

            drpStoreDictionaryKey.DataTextField = "DictionaryValue";
            drpStoreDictionaryKey.DataValueField = "DictionaryKey";

            drpStoreDictionaryKey.DataSource = dt;
            drpStoreDictionaryKey.DataBind();
        }

        #endregion

        #region 加载指标信息

        private void Load_IndicatorsList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='Indicators'").Tables[0];

            drpDictionaryKey.DataTextField = "DictionaryValue";
            drpDictionaryKey.DataValueField = "DictionaryKey";

            drpDictionaryKey.DataSource = dt;
            drpDictionaryKey.DataBind();
        }

        #endregion

        #region 加载用户信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.StoreStatisticsListBLL storeStatisticsListBLL = new zlzw.BLL.StoreStatisticsListBLL();
                zlzw.Model.StoreStatisticsListModal storeStatisticsListModal = storeStatisticsListBLL.GetModel(int.Parse(Get_StoreStatisticsID(strID)));
                drpStoreDictionaryKey.SelectedValue = storeStatisticsListModal.StoreDictionaryKey;//所属店铺
                drpDictionaryKey.SelectedValue = storeStatisticsListModal.DictionaryKey;//所属指标
                txbStoreStatisticsDate.Text = storeStatisticsListModal.StoreStatisticsDate.ToString();//评比日期
                txbIndexValue.Text = storeStatisticsListModal.IndexValue;//指标数值
                txbStoreStatisticsOrder.Text = storeStatisticsListModal.StoreStatisticsOrder.ToString();//排序序号

                ViewState["StoreStatisticsDate"] = storeStatisticsListModal.StoreStatisticsDate.ToString();
                ViewState["PublishDate"] = storeStatisticsListModal.PublishDate.ToString();
                ViewState["StoreStatisticsGUID"] = storeStatisticsListModal.StoreStatisticsGUID.ToString();
                ToolbarText2.Text = "编辑一个指标评比";
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
        }

        #endregion

        #region 保存按钮事件

        protected void btnSaveRefresh_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["Type"] == "1")
            {
                //编辑保存
                zlzw.Model.StoreStatisticsListModal storeStatisticsListModal = new zlzw.Model.StoreStatisticsListModal();
                storeStatisticsListModal.StoreDictionaryKey = drpStoreDictionaryKey.SelectedValue;
                storeStatisticsListModal.DictionaryKey = drpDictionaryKey.SelectedValue;
                if (txbStoreStatisticsDate.Text == "")
                {
                    storeStatisticsListModal.StoreStatisticsDate = DateTime.Parse(ViewState["StoreStatisticsDate"].ToString());
                }
                else
                {
                    storeStatisticsListModal.StoreStatisticsDate = DateTime.Parse(txbStoreStatisticsDate.Text.ToString());
                }
                
                storeStatisticsListModal.IndexValue = txbIndexValue.Text;
                storeStatisticsListModal.StoreStatisticsOrder = int.Parse(txbStoreStatisticsOrder.Text);
                storeStatisticsListModal.IsEnable = 1;
                storeStatisticsListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                storeStatisticsListModal.StoreStatisticsGUID = new Guid(ViewState["StoreStatisticsGUID"].ToString());
                storeStatisticsListModal.StoreStatisticsID = int.Parse(Get_StoreStatisticsID(Request.QueryString["value"]));
                zlzw.BLL.StoreStatisticsListBLL storeStatisticsListBLL = new zlzw.BLL.StoreStatisticsListBLL();
                storeStatisticsListBLL.Update(storeStatisticsListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.StoreStatisticsListModal storeStatisticsListModal = new zlzw.Model.StoreStatisticsListModal();
                storeStatisticsListModal.StoreDictionaryKey = drpStoreDictionaryKey.SelectedValue;
                storeStatisticsListModal.DictionaryKey = drpDictionaryKey.SelectedValue;
                storeStatisticsListModal.StoreStatisticsDate = DateTime.Parse(txbStoreStatisticsDate.Text.ToString());
                storeStatisticsListModal.IndexValue = txbIndexValue.Text;
                storeStatisticsListModal.StoreStatisticsOrder = int.Parse(txbStoreStatisticsOrder.Text);
                storeStatisticsListModal.IsEnable = 1;
                storeStatisticsListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                storeStatisticsListModal.StoreStatisticsGUID = System.Guid.NewGuid();
                zlzw.BLL.StoreStatisticsListBLL storeStatisticsListBLL = new zlzw.BLL.StoreStatisticsListBLL();
                storeStatisticsListBLL.Add(storeStatisticsListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 获取评比ID

        private string Get_StoreStatisticsID(string strStoreStatisticsGUID)
        {
            zlzw.BLL.StoreStatisticsListBLL storeStatisticsListBLL = new zlzw.BLL.StoreStatisticsListBLL();
            DataTable dt = storeStatisticsListBLL.GetList("StoreStatisticsGUID='" + strStoreStatisticsGUID + "'").Tables[0];

            return dt.Rows[0]["StoreStatisticsID"].ToString();
        }

        #endregion
    }
}
