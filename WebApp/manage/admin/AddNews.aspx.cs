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
using FineUI;

namespace WebApp.manage.admin
{
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["AdminID"] == null && Request.Cookies["AdminName"] == null)
                {
                    Response.Write("<script type='text/javascript'>window.parent.location='login.aspx'</script>");
                    return;
                }
                else
                {
                    labPublishID.Text = Request.Cookies["AdminName"].Value;
                }
                string strType = Request.QueryString["Type"];
                Load_NewsTypeList();//加载新闻类型
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载新闻类型

        private void Load_NewsTypeList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='NewsType' and IsEnable=1").Tables[0];
            drpNewsType.DataTextField = "DictionaryValue";
            drpNewsType.DataValueField = "DictionaryKey";

            drpNewsType.DataSource = dt;
            drpNewsType.DataBind();
        }

        #endregion

        #region 加载用户信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.NewsListBLL newsListBLL = new zlzw.BLL.NewsListBLL();
                zlzw.Model.NewsListModel newsListModel = newsListBLL.GetModel(int.Parse(strID));


                txbNewsTitle.Text = newsListModel.NewsTitle;//新闻标题
                drpNewsType.SelectedValue = newsListModel.DictionaryKey;//新闻类型
                txbNewsSummary.Text = newsListModel.NewsSummary;//新闻简介
                FCKeditor1.Value = newsListModel.NewsContent;//新闻正文
                if (newsListModel.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }
                ViewState["PublishDate"] = newsListModel.PublishDate.ToString();
                ViewState["NewsID"] = newsListModel.NewsID;
                ViewState["NewsGUID"] = newsListModel.NewsGUID;
                ToolbarText2.Text = "编辑新闻";
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
                zlzw.Model.NewsListModel newsListModal = new zlzw.Model.NewsListModel();
                newsListModal.NewsTitle = txbNewsTitle.Text;
                newsListModal.DictionaryKey = drpNewsType.SelectedValue;
                newsListModal.PublishUserGUID = new Guid(Request.Cookies["AdminID"].Value);
                newsListModal.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    newsListModal.IsHot = 1;
                }
                else
                {
                    newsListModal.IsHot = 0;
                }
                newsListModal.NewsSummary = txbNewsSummary.Text;
                newsListModal.NewsContent = FCKeditor1.Value;
                newsListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                newsListModal.NewsGUID = new Guid(ViewState["NewsGUID"].ToString());
                newsListModal.NewsID = int.Parse(ViewState["NewsID"].ToString());
                zlzw.BLL.NewsListBLL newsListBLL = new zlzw.BLL.NewsListBLL();
                newsListBLL.Update(newsListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.NewsListModel newsListModal = new zlzw.Model.NewsListModel();
                newsListModal.NewsTitle = txbNewsTitle.Text;
                newsListModal.DictionaryKey = drpNewsType.SelectedValue;
                newsListModal.PublishUserGUID = new Guid(Request.Cookies["AdminID"].Value);
                newsListModal.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    newsListModal.IsHot = 1;
                }
                else
                {
                    newsListModal.IsHot = 0;
                }
                newsListModal.NewsSummary = txbNewsSummary.Text;
                newsListModal.NewsContent = FCKeditor1.Value;
                newsListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.NewsListBLL newsListBLL = new zlzw.BLL.NewsListBLL();
                newsListBLL.Add(newsListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion
    }
}
