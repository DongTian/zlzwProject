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
    public partial class AddJobType : System.Web.UI.Page
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
                zlzw.BLL.JobTypeListBLL jobTypeListBLL = new zlzw.BLL.JobTypeListBLL();
                zlzw.Model.JobTypeListModel jobTypeListModal = jobTypeListBLL.GetModel(int.Parse(strID));
                txbJobTypeName.Text = jobTypeListModal.JobTypeName;//职位名称
                if (jobTypeListModal.IsEnable == 1)
                {
                    ckbIsEnable.Checked = true;
                }
                else
                {
                    ckbIsEnable.Checked = false;
                }

                ViewState["PublishDate"] = jobTypeListModal.PublishDate.ToString();
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
                zlzw.Model.JobTypeListModel jobTypeListModal = new zlzw.Model.JobTypeListModel();
                jobTypeListModal.JobTypeName = txbJobTypeName.Text;
                if (ckbIsEnable.Checked)
                {
                    jobTypeListModal.IsEnable = 1;
                }
                else
                {
                    jobTypeListModal.IsEnable = 0;
                }
                jobTypeListModal.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                jobTypeListModal.JobTypeID = int.Parse(Request.QueryString["value"]);
                zlzw.BLL.JobTypeListBLL jobTypeListBLL = new zlzw.BLL.JobTypeListBLL();
                jobTypeListBLL.Update(jobTypeListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.JobTypeListModel jobTypeListModal = new zlzw.Model.JobTypeListModel();
                jobTypeListModal.JobTypeName = txbJobTypeName.Text;
                jobTypeListModal.IsEnable = 1;

                jobTypeListModal.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.JobTypeListBLL jobTypeListBLL = new zlzw.BLL.JobTypeListBLL();
                jobTypeListBLL.Add(jobTypeListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion
    }
}
