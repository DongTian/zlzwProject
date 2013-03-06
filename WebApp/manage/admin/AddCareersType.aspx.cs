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
    public partial class AddCareersType : System.Web.UI.Page
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
                zlzw.BLL.CareersTypeListBLL careersTypeListBLL = new zlzw.BLL.CareersTypeListBLL();
                zlzw.Model.CareersTypeListModel careersTypeListModel = careersTypeListBLL.GetModel(int.Parse(strID));
                txbCareersTypeName.Text = careersTypeListModel.CareersTypeName;//职位名称
                if (careersTypeListModel.IsEnable == 1)
                {
                    ckbIsEnable.Checked = true;
                }
                else
                {
                    ckbIsEnable.Checked = false;
                }

                ViewState["PublishDate"] = careersTypeListModel.PublishDate.ToString();
                ToolbarText2.Text = "编辑一个职位性质";
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
                zlzw.Model.CareersTypeListModel careersTypeListModel = new zlzw.Model.CareersTypeListModel();
                careersTypeListModel.CareersTypeName = txbCareersTypeName.Text;
                if (ckbIsEnable.Checked)
                {
                    careersTypeListModel.IsEnable = 1;
                }
                else
                {
                    careersTypeListModel.IsEnable = 0;
                }
                careersTypeListModel.PublishDate = DateTime.Parse(ViewState["PublishDate"].ToString());
                careersTypeListModel.CareersTypeID = int.Parse(Request.QueryString["value"]);
                zlzw.BLL.CareersTypeListBLL careersTypeListBLL = new zlzw.BLL.CareersTypeListBLL();
                careersTypeListBLL.Update(careersTypeListModel);
            }
            else
            {
                //添加保存

                zlzw.Model.CareersTypeListModel careersTypeListModel = new zlzw.Model.CareersTypeListModel();
                careersTypeListModel.CareersTypeName = txbCareersTypeName.Text;

                careersTypeListModel.IsEnable = 1;
                

                careersTypeListModel.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                zlzw.BLL.CareersTypeListBLL careersTypeListBLL = new zlzw.BLL.CareersTypeListBLL();
                careersTypeListBLL.Add(careersTypeListModel);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion
    }
}
