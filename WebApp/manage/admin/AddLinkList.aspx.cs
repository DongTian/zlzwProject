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
    public partial class AddLinkList : System.Web.UI.Page
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

        #region 加载新闻类型信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
                zlzw.Model.LinkListModal linkListModal = linkListBLL.GetModel(int.Parse(Get_LinkID(strID)));
                drpLinkType.SelectedValue = linkListModal.LinkType.ToString();
                txbLinkTitle.Text = linkListModal.LinkTitle;//友情链接名称
                txbLinkTarget.Text = linkListModal.LinkTarget;//友情链接跳转地址
                txbLinkDesc.Text = linkListModal.LinkDesc;//链接简介
                ViewState["LinkImages"] = linkListModal.LinkImage;//友情链接图片
                imgLinkImage.ImageUrl = linkListModal.LinkImage;
                imgLinkImage.Visible = true;
                ViewState["PublishDate"] = linkListModal.PublishDate.ToString();
                ToolbarText2.Text = "编辑一个友情链接";
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
                zlzw.Model.LinkListModal linkListModal = new zlzw.Model.LinkListModal();
                linkListModal.LinkType = int.Parse(drpLinkType.SelectedValue);
                linkListModal.LinkTitle = txbLinkTitle.Text;//友情链接名称
                linkListModal.LinkTarget = txbLinkTarget.Text;//友情链接地址
                linkListModal.LinkDesc = txbLinkDesc.Text;//友情链接简介
                if (btnImageUpload.PostedFile.ContentLength > 0)
                {
                    btnImageUpload.SaveAs(Server.MapPath(ViewState["LinkImages"].ToString()));
                    linkListModal.LinkImage = ViewState["LinkImages"].ToString();//友情链接Logo路径
                }
                else
                {
                    linkListModal.LinkImage = ViewState["LinkImages"].ToString();
                }
                linkListModal.IsEnable = 1;
                linkListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                linkListModal.LinkID = int.Parse(Get_LinkID(Request.QueryString["value"]));
                zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
                linkListBLL.Update(linkListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.LinkListModal linkListModal = new zlzw.Model.LinkListModal();
                linkListModal.LinkType = int.Parse(drpLinkType.SelectedValue);
                linkListModal.LinkTitle = txbLinkTitle.Text;//友情链接名称
                linkListModal.LinkTarget = txbLinkTarget.Text;//友情链接地址
                linkListModal.LinkDesc = txbLinkDesc.Text;//友情链接简介
                if (btnImageUpload.HasFile)
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "_" + btnImageUpload.FileName;
                    btnImageUpload.SaveAs(Server.MapPath("~/LinkImages/" + fileName));
                    linkListModal.LinkImage = "~/LinkImages/" + fileName;//友情链接Logo路径
                }
                else
                {
                    if (drpLinkType.SelectedValue == "0")
                    {
                        Alert.Show("请上传一张尺寸为166 * 55 的友情链接Logo", "错误提醒", MessageBoxIcon.Error);
                        return;
                    }
                }

                linkListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                linkListModal.IsEnable = 1;
                zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
                linkListBLL.Add(linkListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取链接ID

        private string Get_LinkID(string LinkGUID)
        {
            zlzw.BLL.LinkListBLL linkListBLL = new zlzw.BLL.LinkListBLL();
            DataTable dt = linkListBLL.GetList("LinkGUID='" + LinkGUID + "'").Tables[0];

            return dt.Rows[0]["LinkID"].ToString();
        }

        #endregion

        #region 友情链接类型选择
        
        protected void drpLinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpLinkType.SelectedValue == "0")
            {
                btnImageUpload.Enabled = true;
            }
            else
            {
                btnImageUpload.Enabled = false;
            }
        }

        #endregion

        

    }
}
