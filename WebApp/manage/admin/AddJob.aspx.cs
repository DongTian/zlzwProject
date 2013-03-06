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
    public partial class AddJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_JobType();//加载岗位类型
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载岗位类型

        private void Load_JobType()
        {
            zlzw.BLL.JobTypeListBLL jobTypeListBLL = new zlzw.BLL.JobTypeListBLL();
            DataTable dt = jobTypeListBLL.GetList("IsEnable=1").Tables[0];

            drpJobType.DataTextField = "JobTypeName";
            drpJobType.DataValueField = "JobTypeID";

            drpJobType.DataSource = dt;
            drpJobType.DataBind();
        }

        #endregion

        #region 加载用户信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.JobListBLL jobListBLL = new zlzw.BLL.JobListBLL();
                zlzw.Model.JobListModel jobListModal = jobListBLL.GetModel(int.Parse(strID));
                txbJobName.Text = jobListModal.JobName;//职位名称
                drpJobType.SelectedValue = jobListModal.JobTypeID.ToString();
                if (jobListModal.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }
                if (jobListModal.IsEnable == 1)
                {
                    ckbIsEnable.Checked = true;
                }
                else
                {
                    ckbIsEnable.Checked = false;
                }

                ViewState["PublishDate"] = jobListModal.PublishDate.ToString();
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
                zlzw.Model.JobListModel jobListModal = new zlzw.Model.JobListModel();
                jobListModal.JobName = txbJobName.Text;
                jobListModal.JobTypeID = int.Parse(drpJobType.SelectedValue);
                if (ckbIsHot.Checked)
                {
                    jobListModal.IsHot = 1;
                }
                else
                {
                    jobListModal.IsHot = 0;
                }
                if (ckbIsEnable.Checked)
                {
                    jobListModal.IsEnable = 1;
                }
                else
                {
                    jobListModal.IsEnable = 0;
                }
                jobListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                jobListModal.JobID = int.Parse(Request.QueryString["value"]);
                zlzw.BLL.JobListBLL jobListBLL = new zlzw.BLL.JobListBLL();
                jobListBLL.Update(jobListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.JobListModel jobListModal = new zlzw.Model.JobListModel();
                jobListModal.JobName = txbJobName.Text;
                jobListModal.JobTypeID = int.Parse(drpJobType.SelectedValue);
                jobListModal.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    jobListModal.IsHot = 1;
                }
                else
                {
                    jobListModal.IsHot = 0;
                }

                jobListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.JobListBLL jobListBLL = new zlzw.BLL.JobListBLL();
                jobListBLL.Add(jobListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

    }
}
