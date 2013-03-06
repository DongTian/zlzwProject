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
    public partial class AddAdmin : System.Web.UI.Page
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
                zlzw.BLL.AdminListBLL adminListBLL = new zlzw.BLL.AdminListBLL();
                zlzw.Model.AdminListModel adminListModel = adminListBLL.GetModel(int.Parse(strID));
                txbAdminName.Text = adminListModel.AdminName;//用户名称
                txbAdminPassword.Text = adminListModel.AdminPassword;//用户密码
                ViewState["PublishDate"] = adminListModel.PublishDate.ToString();
                ViewState["AdminGUID"] = adminListModel.AdminGUID.ToString();
                ToolbarText2.Text = "编辑一个管理员账号";
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
                zlzw.Model.AdminListModel adminListModel = new zlzw.Model.AdminListModel();
                adminListModel.AdminName = txbAdminName.Text;
                adminListModel.AdminPassword = txbAdminPassword.Text;
                adminListModel.IsEnable = 1;
                adminListModel.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                adminListModel.AdminGUID = new Guid(ViewState["AdminGUID"].ToString());
                adminListModel.AdminID = int.Parse(Request.QueryString["value"]);
                zlzw.BLL.AdminListBLL adminListBLL = new zlzw.BLL.AdminListBLL();
                adminListBLL.Update(adminListModel);
            }
            else
            {
                //添加保存

                zlzw.Model.AdminListModel adminListModel = new zlzw.Model.AdminListModel();
                adminListModel.AdminName = txbAdminName.Text;
                adminListModel.AdminPassword = txbAdminPassword.Text;
                adminListModel.IsEnable = 1;
                adminListModel.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                adminListModel.AdminGUID = System.Guid.NewGuid();
                zlzw.BLL.AdminListBLL adminListBLL = new zlzw.BLL.AdminListBLL();
                adminListBLL.Add(adminListModel);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion
    }
}
