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
    public partial class AddPartnersJobList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_PartnersList();//加载合作伙伴列表
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载合作伙伴

        private void Load_PartnersList()
        {
            zlzw.BLL.PartnersListBLL partnersListBLL = new zlzw.BLL.PartnersListBLL();
            DataTable dt = partnersListBLL.GetList("IsEnable=1 order by PublishDate desc").Tables[0];
            drpPartnerGUID.DataTextField = "PartnerName";
            drpPartnerGUID.DataValueField = "PartnerGUID";
                                             
            drpPartnerGUID.DataSource = dt;
            drpPartnerGUID.DataBind();
        }

        #endregion

        #region 加载职位信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
                zlzw.Model.PartnersJobListModel partnersJobListModel = partnersJobListBLL.GetModel(int.Parse(strID));
                drpPartnerGUID.SelectedValue = partnersJobListModel.PartnerGUID.ToString();
                txbWorkAdd.Text = partnersJobListModel.WorkAdd;//工作地点
                txbPostInfo.Text = partnersJobListModel.PostInfo;//招聘职位
                txbRecruitmentNumber.Text = partnersJobListModel.RecruitmentNumber;//招聘人数
                txbPostDemand.Text = partnersJobListModel.PostDemand;//岗位要求
                txbTreatmentInfo.Text = partnersJobListModel.TreatmentInfo;//待遇相关
                txbOtherInfo.Text = partnersJobListModel.OtherInfo;//备注信息
                //if (partnersJobListModel.IsHot == 1)
                //{
                //    ckbIsHot.Checked = true;
                //}
                //else
                //{
                //    ckbIsHot.Checked = false;
                //}

                ViewState["PublishDate"] = partnersJobListModel.PublishDate.ToString();
                ViewState["PartnerGUID"] = partnersJobListModel.PartnerGUID.ToString();
                ToolbarText2.Text = "编辑一个合作伙伴职位信息";
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
                zlzw.Model.PartnersJobListModel partnersJobListModel = new zlzw.Model.PartnersJobListModel();
                partnersJobListModel.PartnerGUID = new Guid(drpPartnerGUID.SelectedValue);
                partnersJobListModel.WorkAdd = txbWorkAdd.Text;//工作地点
                partnersJobListModel.PostInfo = txbPostInfo.Text;//招聘职位
                partnersJobListModel.RecruitmentNumber = txbRecruitmentNumber.Text;//招聘人数
                partnersJobListModel.PostDemand = txbPostDemand.Text;//岗位要求
                partnersJobListModel.TreatmentInfo = txbTreatmentInfo.Text;//待遇相关
                partnersJobListModel.OtherInfo = txbOtherInfo.Text;//备注信息
                partnersJobListModel.IsEnable = 1;
                //if (ckbIsHot.Checked)
                //{
                //    partnersJobListModel.IsHot = 1;
                //}
                //else
                //{
                //    partnersJobListModel.IsHot = 0;
                //}
                partnersJobListModel.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                partnersJobListModel.PartnerGUID = new Guid(ViewState["PartnerGUID"].ToString());
                partnersJobListModel.PartnersJobID = int.Parse(Request.QueryString["value"]);
                zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
                partnersJobListBLL.Update(partnersJobListModel);
            }
            else
            {
                //添加保存

                zlzw.Model.PartnersJobListModel partnersJobListModel = new zlzw.Model.PartnersJobListModel();
                partnersJobListModel.PartnerGUID = new Guid(drpPartnerGUID.SelectedValue);
                partnersJobListModel.WorkAdd = txbWorkAdd.Text;//工作地点
                partnersJobListModel.PostInfo = txbPostInfo.Text;//招聘职位
                partnersJobListModel.RecruitmentNumber = txbRecruitmentNumber.Text;//招聘人数
                partnersJobListModel.PostDemand = txbPostDemand.Text;//岗位要求
                partnersJobListModel.TreatmentInfo = txbTreatmentInfo.Text;//待遇相关
                partnersJobListModel.OtherInfo = txbOtherInfo.Text;//备注信息
                partnersJobListModel.IsEnable = 1;
                //if (ckbIsHot.Checked)
                //{
                //    partnersJobListModel.IsHot = 1;
                //}
                //else
                //{
                //    partnersJobListModel.IsHot = 0;
                //}
                partnersJobListModel.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                zlzw.BLL.PartnersJobListBLL partnersJobListBLL = new zlzw.BLL.PartnersJobListBLL();
                partnersJobListBLL.Add(partnersJobListModel);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion
    }
}