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
    public partial class AddJobCategoryList : System.Web.UI.Page
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

        #region 加载岗位类型信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.JobCategoryListBLL jobCategoryListBLL = new zlzw.BLL.JobCategoryListBLL();
                zlzw.Model.JobCategoryListModal jobCategoryListModal = jobCategoryListBLL.GetModel(int.Parse(Get_JobCategoryID(strID)));
                txbJobCategoryName.Text = jobCategoryListModal.JobCategoryName;//岗位名称
                ViewState["PublishDate"] = jobCategoryListModal.PublishDate.ToString();
                ViewState["JobCategoryGUID"] = jobCategoryListModal.JobCategoryGUID.ToString();
                if (jobCategoryListModal.IsHot == 1)
                {
                    ckbIsHot.Checked = true;
                }
                else
                {
                    ckbIsHot.Checked = false;
                }
                ToolbarText2.Text = "编辑一个岗位类型";
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
                zlzw.Model.JobCategoryListModal jobCategoryListModal = new zlzw.Model.JobCategoryListModal();
                jobCategoryListModal.JobCategoryName = txbJobCategoryName.Text;
                jobCategoryListModal.JobCategoryGUID = new Guid(ViewState["JobCategoryGUID"].ToString());
                jobCategoryListModal.IsEnable = 1;
                if (ckbIsHot.Checked)
                {
                    jobCategoryListModal.IsHot = 1;
                }
                else
                {
                    jobCategoryListModal.IsHot = 0;
                }
                jobCategoryListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                jobCategoryListModal.JobCategoryID = int.Parse(Get_JobCategoryID(Request.QueryString["value"]));
                zlzw.BLL.JobCategoryListBLL jobCategoryListBLL = new zlzw.BLL.JobCategoryListBLL();
                jobCategoryListBLL.Update(jobCategoryListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.JobCategoryListModal jobCategoryListModal = new zlzw.Model.JobCategoryListModal();
                jobCategoryListModal.JobCategoryName = txbJobCategoryName.Text;
                jobCategoryListModal.JobCategoryGUID = Guid.NewGuid();
                jobCategoryListModal.IsEnable = 1;
                if(ckbIsHot.Checked)
                {
                    jobCategoryListModal.IsHot = 1;
                }
                else
                {
                    jobCategoryListModal.IsHot = 0;
                }

                jobCategoryListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.JobCategoryListBLL jobCategoryListBLL = new zlzw.BLL.JobCategoryListBLL();
                jobCategoryListBLL.Add(jobCategoryListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID取得ID

        private string Get_JobCategoryID(string strJobCategoryGUID)
        {
            zlzw.BLL.JobCategoryListBLL jobCategoryListBLL = new zlzw.BLL.JobCategoryListBLL();
            DataTable dt = jobCategoryListBLL.GetList("JobCategoryGUID='" + strJobCategoryGUID + "'").Tables[0];

            return dt.Rows[0]["JobCategoryID"].ToString();
        }

        #endregion

    }
}
