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
    public partial class AddIndicators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载评比指标信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
                zlzw.Model.DictionaryListModel dictionaryListModel = dictionaryListBLL.GetModel(int.Parse(strID));
                txbIndicatorsIndex.Text = dictionaryListModel.DictionaryKey;//新闻类型索引
                txbIndicatorsName.Text = dictionaryListModel.DictionaryValue;//新闻类型名称
                txbOrderNumber.Text = dictionaryListModel.OrderNumber.ToString();
                txbDictionaryDesc.Text = dictionaryListModel.DictionaryDesc;
                ViewState["PublishDate"] = dictionaryListModel.PublishDate.ToString();
                ToolbarText2.Text = "编辑一个指标类型";
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
                zlzw.Model.DictionaryListModel dictionaryListModel = new zlzw.Model.DictionaryListModel();
                dictionaryListModel.DictionaryValue = txbIndicatorsName.Text;
                dictionaryListModel.DictionaryKey = txbIndicatorsIndex.Text;
                dictionaryListModel.OrderNumber = int.Parse(txbOrderNumber.Text);
                dictionaryListModel.DictionaryDesc = txbDictionaryDesc.Text;
                dictionaryListModel.DictionaryCategory = "Indicators";
                dictionaryListModel.IsEnable = 1;
                dictionaryListModel.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                dictionaryListModel.DictionaryListID = int.Parse(Request.QueryString["value"]);
                zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
                dictionaryListBLL.Update(dictionaryListModel);
            }
            else
            {
                //添加保存

                zlzw.Model.DictionaryListModel dictionaryListModel = new zlzw.Model.DictionaryListModel();
                dictionaryListModel.DictionaryValue = txbIndicatorsName.Text;
                dictionaryListModel.DictionaryKey = txbIndicatorsIndex.Text;
                dictionaryListModel.OrderNumber = int.Parse(txbOrderNumber.Text);
                dictionaryListModel.DictionaryDesc = txbDictionaryDesc.Text;
                dictionaryListModel.IsEnable = 1;
                dictionaryListModel.IsInner = 0;
                dictionaryListModel.DictionaryCategory = "Indicators";

                dictionaryListModel.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
                dictionaryListBLL.Add(dictionaryListModel);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion
    }
}
