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
    public partial class AddPartners : System.Web.UI.Page
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

        #region 加载合作伙伴信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
                DataTable dt = partnersListBLL.GetList("PartnerGUID='"+ strID +"'").Tables[0];
                zlzw.Model.PartnersListModal partnersListModal = partnersListBLL.GetModel(int.Parse(dt.Rows[0]["PartnerID"].ToString()));
                txbPartnersName.Text = partnersListModal.PartnerName;//合作伙伴名称
                txbPartner.Text = partnersListModal.PartnerIntroduction;//合作伙伴简介
                
                if (partnersListModal.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }
                imgUploadLogo.ImageUrl = partnersListModal.PartnerLogo;//显示上传后的图片
                imgUploadBanner.ImageUrl = partnersListModal.PartnerBanner;//显示上传后的图片
                imgUploadLogo.Visible = true;
                imgUploadBanner.Visible = true;
                ViewState["PartnerLogo"] = partnersListModal.PartnerLogo;//合作伙伴图片地址
                ViewState["PartnerBanner"] = partnersListModal.PartnerBanner;//合作伙伴Banner
                ViewState["PublishDate"] = partnersListModal.PublishDate.ToString();
                ViewState["PartnersGUID"] = partnersListModal.PartnerGUID.ToString();
                ToolbarText2.Text = "编辑一个岗位";
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
                zlzw.Model.PartnersListModal partnersListModal = new zlzw.Model.PartnersListModal();
                partnersListModal.PartnerName = txbPartnersName.Text;//合作伙伴名称
                partnersListModal.PartnerIntroduction = txbPartner.Text;//合作伙伴简介

                if (btnImageUpload.PostedFile.ContentLength > 0)
                {
                    btnImageUpload.SaveAs(Server.MapPath(ViewState["PartnerLogo"].ToString()));
                    partnersListModal.PartnerLogo = ViewState["PartnerLogo"].ToString();//保存企业Logo路径
                }
                else
                {
                    partnersListModal.PartnerLogo = ViewState["PartnerLogo"].ToString();
                }

                if (btnBannerUpload.PostedFile.ContentLength > 0)
                {
                    btnBannerUpload.SaveAs(Server.MapPath(ViewState["PartnerBanner"].ToString()));
                    partnersListModal.PartnerBanner = ViewState["PartnerBanner"].ToString();//保存企业Logo路径
                }
                else
                {
                    partnersListModal.PartnerBanner = ViewState["PartnerBanner"].ToString();
                }

                if (ckbIsHot.Checked)
                {
                    partnersListModal.IsHot = 1;
                }
                else
                {
                    partnersListModal.IsHot = 0;
                }
                partnersListModal.IsEnable = 1;
                partnersListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                partnersListModal.PartnerID = int.Parse(Get_PartnersID(Request.QueryString["value"]));
                partnersListModal.PartnerGUID = new Guid(Request.QueryString["value"]);
                zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
                partnersListBLL.Update(partnersListModal);
            }
            else
            {
                //添加保存
                zlzw.Model.PartnersListModal partnersListModal = new zlzw.Model.PartnersListModal();
                partnersListModal.PartnerName = txbPartnersName.Text;//合作伙伴名称
                partnersListModal.PartnerIntroduction = txbPartner.Text;//合作伙伴简介
                partnersListModal.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    partnersListModal.IsHot = 1;
                }
                else
                {
                    partnersListModal.IsHot = 0;
                }
                if (btnImageUpload.HasFile)
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "_" + btnImageUpload.FileName;
                    btnImageUpload.SaveAs(Server.MapPath("~/PartnersLogo/" + fileName));
                    partnersListModal.PartnerLogo = "~/PartnersLogo/" + fileName;//保存企业Logo路径
                }
                else
                {
                    Alert.Show("请上传一张尺寸为137 * 70 的企业Logo","错误提醒", MessageBoxIcon.Error);
                    return;
                }
                if (btnBannerUpload.HasFile)
                {
                    string fileName = DateTime.Now.Ticks.ToString() + "_" + btnBannerUpload.FileName;
                    btnBannerUpload.SaveAs(Server.MapPath("~/PartnersBanner/" + fileName));
                    partnersListModal.PartnerBanner = "~/PartnersBanner/" + fileName;//保存企业Logo路径
                }
                else
                {
                    Alert.Show("请上传一张宽度为1024px的企业Banner", "错误提醒", MessageBoxIcon.Error);
                    return;
                }
                partnersListModal.PartnerGUID = Guid.NewGuid();
                partnersListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
                partnersListBLL.Add(partnersListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取ID

        private string Get_PartnersID(string strPartnerGUID)
        {
            zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
            DataTable dt = partnersListBLL.GetList("PartnerGUID='" + strPartnerGUID + "'").Tables[0];

            return dt.Rows[0]["PartnerID"].ToString();
        }

        #endregion

    }
}
