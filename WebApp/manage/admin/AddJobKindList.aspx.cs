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
    public partial class AddJobKindList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_JobCategoryList(); //加载岗位分类
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载岗位分类

        private void Load_JobCategoryList()
        {
            zlzw.BLL.JobCategoryListBLL jobCategoryListBLL = new zlzw.BLL.JobCategoryListBLL();
            DataTable dt = jobCategoryListBLL.GetList("IsEnable=1").Tables[0];

            drpJobCategory.DataTextField = "JobCategoryName";
            drpJobCategory.DataValueField = "JobCategoryGUID";

            drpJobCategory.DataSource = dt;
            drpJobCategory.DataBind();
        }

        #endregion

        #region 加载岗位信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.JobKindListBLL jobKindListBLL = new zlzw.BLL.JobKindListBLL();
                zlzw.Model.JobKindListModel jobKindListModel = jobKindListBLL.GetModel(int.Parse(Get_JobKindID(strID)));
                txbNJobKindName.Text = jobKindListModel.JobKindName;//岗位名称
                drpJobCategory.SelectedValue = jobKindListModel.JobCategoryGUID.ToString();//岗位类型名称
                if (jobKindListModel.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }
                if (jobKindListModel.IsShowDefaultPage == 1)
                {
                    ckbIsShowDefaultPage.Checked = true;
                }
                else
                {
                    ckbIsShowDefaultPage.Checked = false;
                }
                ViewState["PublishDate"] = jobKindListModel.PublishDate.ToString();
                ViewState["JobKindGUID"] = jobKindListModel.JobKindGUID;
                ViewState["JobCategoryGUID"] = jobKindListModel.JobCategoryGUID;//岗位分类
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
                zlzw.Model.JobKindListModel jobKindListModel = new zlzw.Model.JobKindListModel();
                jobKindListModel.JobKindName = txbNJobKindName.Text;
                jobKindListModel.JobKindGUID = new Guid(ViewState["JobKindGUID"].ToString());
                jobKindListModel.JobCategoryGUID = new Guid(drpJobCategory.SelectedValue);
                jobKindListModel.IsEnable = 1;
                if(ckbIsHot.Checked)
                {
                    jobKindListModel.IsHot = 1;
                }
                else
                {
                    jobKindListModel.IsHot = 0;
                }
                if (ckbIsShowDefaultPage.Checked)
                {
                    jobKindListModel.IsShowDefaultPage = 1;
                }
                else
                {
                    jobKindListModel.IsShowDefaultPage = 0;
                }
                jobKindListModel.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                jobKindListModel.JobKindID = int.Parse(Get_JobKindID(Request.QueryString["value"]));
                zlzw.BLL.JobKindListBLL jobKindListBLL = new zlzw.BLL.JobKindListBLL();
                jobKindListBLL.Update(jobKindListModel);
            }
            else
            {
                //添加保存

                zlzw.Model.JobKindListModel jobKindListModel = new zlzw.Model.JobKindListModel();
                jobKindListModel.JobKindName = txbNJobKindName.Text;
                jobKindListModel.JobKindGUID = Guid.NewGuid();
                jobKindListModel.JobCategoryGUID = new Guid(drpJobCategory.SelectedValue);
                jobKindListModel.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    jobKindListModel.IsHot = 1;
                }
                else
                {
                    jobKindListModel.IsHot = 0;
                }
                if (ckbIsShowDefaultPage.Checked)
                {
                    jobKindListModel.IsShowDefaultPage = 1;
                }
                else
                {
                    jobKindListModel.IsShowDefaultPage = 0;
                }
                jobKindListModel.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.JobKindListBLL jobKindListBLL = new zlzw.BLL.JobKindListBLL();
                jobKindListBLL.Add(jobKindListModel);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID获取ID

        private string Get_JobKindID(string strJobKindGUID)
        {
            zlzw.BLL.JobKindListBLL jobKindListBLL = new zlzw.BLL.JobKindListBLL();
            DataTable dt = jobKindListBLL.GetList("JobKindGUID='" + strJobKindGUID + "'").Tables[0];

            return dt.Rows[0]["JobKindID"].ToString();
        }

        #endregion
    }
}
