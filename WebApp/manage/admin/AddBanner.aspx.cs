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
    public partial class AddBanner : System.Web.UI.Page
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

        #region 加载用户信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
                zlzw.Model.BannerListModel bannerListModel = bannerListBLL.GetModel(int.Parse(Get_BannerID(strID)));
                txbBannerTitle.Text = bannerListModel.BannerTitle;//焦点图名称
                txbBannerContent.Text = bannerListModel.BannerContent;//焦点图简介
                txbBannerLinks.Text = bannerListModel.BannerLinks;//焦点图链接地址
                if (bannerListModel.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }
                ViewState["BannerImage"] = bannerListModel.BannerImage;//焦点图路径
                ViewState["PublishDate"] = bannerListModel.PublishDate.ToString();
                ViewState["BannerGUID"] = bannerListModel.BannerGUID.ToString();
                ToolbarText2.Text = "编辑一个焦点图";
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
                zlzw.Model.BannerListModel bannerListModel = new zlzw.Model.BannerListModel();
                bannerListModel.BannerTitle = txbBannerTitle.Text;
                bannerListModel.BannerContent = txbBannerContent.Text;
                bannerListModel.BannerType = 0;
                bannerListModel.IsEnable = 1;
                bannerListModel.BannerLinks = txbBannerLinks.Text;
                if (btnBannerUpload.PostedFile.ContentLength > 0)
                {
                    btnBannerUpload.SaveAs(Server.MapPath(ViewState["BannerImage"].ToString()));
                    bannerListModel.BannerImage = ViewState["BannerImage"].ToString();//保存Banner路径
                }
                else
                {
                    bannerListModel.BannerImage = ViewState["BannerImage"].ToString();
                }
                if (ckbIsHot.Checked)
                {
                    bannerListModel.IsHot = 1;
                }
                else
                {
                    bannerListModel.IsHot = 0;
                }
                bannerListModel.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                bannerListModel.BannerGUID = new Guid(ViewState["BannerGUID"].ToString());
                bannerListModel.BannerID = int.Parse(Get_BannerID(Request.QueryString["value"]));
                zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
                bannerListBLL.Update(bannerListModel);
            }
            else
            {
                //添加保存

                zlzw.Model.BannerListModel bannerListModel = new zlzw.Model.BannerListModel();
                bannerListModel.BannerTitle = txbBannerTitle.Text;
                bannerListModel.BannerContent = txbBannerContent.Text;
                bannerListModel.BannerType = 0;
                bannerListModel.IsEnable = 1;
                bannerListModel.BannerLinks = txbBannerLinks.Text;
                if (btnBannerUpload.PostedFile.ContentLength > 0)
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "_" + btnBannerUpload.FileName;
                    btnBannerUpload.SaveAs(Server.MapPath("~/BannerImages/" + fileName));
                    bannerListModel.BannerImage = "~/BannerImages/" + fileName;//保存Banner路径
                }
                else
                {
                    Alert.Show("请上传一张尺寸为624*411的焦点图", "错误提醒", MessageBoxIcon.Error);
                    return;
                }
                if (ckbIsHot.Checked)
                {
                    bannerListModel.IsHot = 1;
                }
                else
                {
                    bannerListModel.IsHot = 0;
                }
                bannerListModel.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                bannerListModel.BannerGUID = System.Guid.NewGuid();
                zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
                bannerListBLL.Add(bannerListModel);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取焦点图ID

        private string Get_BannerID(string strBannerGUID)
        {
            zlzw.BLL.BannerListBLL bannerListBLL = new zlzw.BLL.BannerListBLL();
            DataTable dt = bannerListBLL.GetList("BannerGUID='" + strBannerGUID + "'").Tables[0];

            return dt.Rows[0]["BannerID"].ToString();
        }

        #endregion
    }
}
