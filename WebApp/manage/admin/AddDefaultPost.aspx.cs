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
    public partial class AddDefaultPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_RegionList();//加载地区信息
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载地区列表

        private void Load_RegionList()
        {
            zlzw.BLL.DictionaryListBLL dictionaryListBLL = new zlzw.BLL.DictionaryListBLL();
            DataTable dt = dictionaryListBLL.GetList("DictionaryCategory='RegionType' and IsEnable=1").Tables[0];

            drpRegion.DataTextField = "DictionaryValue";
            drpRegion.DataValueField = "DictionaryListID";

            drpRegion.DataSource = dt;
            drpRegion.DataBind();
        }

        #endregion

        #region 加载职位信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.DefaultPostListBLL defaultPostListBLL = new zlzw.BLL.DefaultPostListBLL();
                zlzw.Model.DefaultPostListModal defaultPostListModal = defaultPostListBLL.GetModel(int.Parse(strID));
                txbEnterpriseName.Text = defaultPostListModal.EnterpriseName;//企业名称
                drpRegion.SelectedValue = defaultPostListModal.DictionaryListID.ToString();//所属区域ID
                txbWorkAdd.Text = defaultPostListModal.WorkAdd;//工作地点
                txbPostInfo.Text = defaultPostListModal.PostInfo;//招聘职位
                txbRecruitmentNumber.Text = defaultPostListModal.RecruitmentNumber;//招聘人数
                txbPostDemand.Text = defaultPostListModal.PostDemand;//岗位要求
                txbTreatmentInfo.Text = defaultPostListModal.TreatmentInfo;//待遇相关
                txbOtherInfo.Text = defaultPostListModal.OtherInfo;//备注信息
                if (defaultPostListModal.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }

                ViewState["PublishDate"] = defaultPostListModal.PublishDate.ToString();
                ViewState["EnterpriseGUID"] = defaultPostListModal.EnterpriseGUID.ToString();
                ToolbarText2.Text = "编辑一个职位信息";
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
                zlzw.Model.DefaultPostListModal defaultPostListModal = new zlzw.Model.DefaultPostListModal();
                defaultPostListModal.EnterpriseName = txbEnterpriseName.Text;//企业名称
                defaultPostListModal.DictionaryListID = int.Parse(drpRegion.SelectedValue);//所属区域ID
                defaultPostListModal.WorkAdd = txbWorkAdd.Text;//工作地点
                defaultPostListModal.PostInfo = txbPostInfo.Text;//招聘职位
                defaultPostListModal.RecruitmentNumber = txbRecruitmentNumber.Text;//招聘人数
                defaultPostListModal.PostDemand = txbPostDemand.Text;//岗位要求
                defaultPostListModal.TreatmentInfo = txbTreatmentInfo.Text;//待遇相关
                defaultPostListModal.OtherInfo = txbOtherInfo.Text;//备注信息
                defaultPostListModal.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    defaultPostListModal.IsHot = 1;
                }
                else
                {
                    defaultPostListModal.IsHot = 0;
                }
                defaultPostListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                defaultPostListModal.EnterpriseGUID = new Guid(ViewState["EnterpriseGUID"].ToString());
                defaultPostListModal.EnterpriseID = int.Parse(Request.QueryString["value"]);
                zlzw.BLL.DefaultPostListBLL defaultPostListBLL = new zlzw.BLL.DefaultPostListBLL();
                defaultPostListBLL.Update(defaultPostListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.DefaultPostListModal defaultPostListModal = new zlzw.Model.DefaultPostListModal();
                defaultPostListModal.EnterpriseName = txbEnterpriseName.Text;//企业名称
                defaultPostListModal.DictionaryListID = int.Parse(drpRegion.SelectedValue);//所属区域ID
                defaultPostListModal.WorkAdd = txbWorkAdd.Text;//工作地点
                defaultPostListModal.PostInfo = txbPostInfo.Text;//招聘职位
                defaultPostListModal.RecruitmentNumber = txbRecruitmentNumber.Text;//招聘人数
                defaultPostListModal.PostDemand = txbPostDemand.Text;//岗位要求
                defaultPostListModal.TreatmentInfo = txbTreatmentInfo.Text;//待遇相关
                defaultPostListModal.OtherInfo = txbOtherInfo.Text;//备注信息
                defaultPostListModal.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    defaultPostListModal.IsHot = 1;
                }
                else
                {
                    defaultPostListModal.IsHot = 0;
                }
                defaultPostListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                defaultPostListModal.EnterpriseGUID = System.Guid.NewGuid();
                zlzw.BLL.DefaultPostListBLL defaultPostListBLL = new zlzw.BLL.DefaultPostListBLL();
                defaultPostListBLL.Add(defaultPostListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion
    }
}
