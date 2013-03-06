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
    public partial class AddMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strType = Request.QueryString["Type"];
                Load_UserList();
                LoadData(strType);
            }
            btnClose.OnClientClick = ActiveWindow.GetConfirmHideReference();
            Panel2.Title = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        #region 加载管理员列表

        private void Load_UserList()
        {
            zlzw.BLL.AdminListBLL adminListBLL = new zlzw.BLL.AdminListBLL();
            DataTable dt = adminListBLL.GetList("IsEnable=1").Tables[0];

            drpReplyUserGUID.DataTextField = "AdminName";
            drpReplyUserGUID.DataValueField = "AdminGUID";

            drpReplyUserGUID.DataSource = dt;
            drpReplyUserGUID.DataBind();
        }

        #endregion

        #region 加载用户信息

        private void LoadData(string strType)
        {
            if (strType == "1")
            {
                string strID = Request.QueryString["value"];//操作ID
                zlzw.BLL.MessageListBLL messageListBLL = new zlzw.BLL.MessageListBLL();
                zlzw.Model.MessageListModal messageListModal = messageListBLL.GetModel(int.Parse(Get_MessageID(strID)));
                txbPublishUserName.Text = messageListModal.PublishUserName;//发布者姓名
                txbPublishContent.Text = messageListModal.PublishContent;//发布内容
                txbReplyContent.Text = messageListModal.ReplyContent;//回复内容
                txbPublishDate.Text = messageListModal.PublishDate.ToString();//发布日期
                drpReplyUserGUID.SelectedValue = messageListModal.ReplyUserGUID.ToString();//回复人ID
                txbReplyDate.Text = messageListModal.ReplyDate.ToString();//回复日期
                if (messageListModal.IsReply == 1)
                {
                    ckbIsReply.Checked = true;
                }
                else
                {
                    ckbIsReply.Checked = false;
                }

                ViewState["MessageGUID"] = messageListModal.MessageGUID.ToString();
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
                zlzw.Model.MessageListModal messageListModal = new zlzw.Model.MessageListModal();
                messageListModal.PublishUserName = txbPublishUserName.Text;//发布者姓名
                messageListModal.PublishContent = txbPublishContent.Text;//发布内容
                messageListModal.PublishDate =  DateTime.Parse(txbPublishDate.Text);//发布日期
                messageListModal.ReplyUserGUID = new Guid(drpReplyUserGUID.SelectedValue);//回复人ID
                messageListModal.ReplyDate = DateTime.Parse(txbReplyDate.Text);//回复日期
                messageListModal.ReplyContent = txbReplyContent.Text;//回复内容
                messageListModal.MessageGUID = new Guid(ViewState["MessageGUID"].ToString());
                messageListModal.IsEnable = 1;
                if (ckbIsReply.Checked)
                {
                    messageListModal.IsReply = 1;
                }
                else
                {
                    messageListModal.IsReply = 0;
                }
                messageListModal.MessageID = int.Parse(Get_MessageID(Request.QueryString["value"]));
                zlzw.BLL.MessageListBLL messageListBLL = new zlzw.BLL.MessageListBLL();
                messageListBLL.Update(messageListModal);
            }
            else
            {
                //添加保存

                zlzw.Model.MessageListModal messageListModal = new zlzw.Model.MessageListModal();
                messageListModal.PublishUserName = txbPublishUserName.Text;//发布者姓名
                messageListModal.PublishContent = txbPublishContent.Text;//发布内容
                messageListModal.PublishDate = DateTime.Parse(txbPublishDate.Text);//发布日期
                messageListModal.ReplyUserGUID = new Guid(drpReplyUserGUID.SelectedValue);//回复人ID
                messageListModal.ReplyDate = DateTime.Parse(txbReplyDate.Text);//回复日期
                messageListModal.ReplyContent = txbReplyContent.Text;//回复内容
                messageListModal.MessageGUID = Guid.NewGuid();
                messageListModal.IsEnable = 1;
                if (ckbIsReply.Checked)
                {
                    messageListModal.IsReply = 1;
                }
                else
                {
                    messageListModal.IsReply = 0;
                }
                zlzw.BLL.MessageListBLL messageListBLL = new zlzw.BLL.MessageListBLL();
                messageListBLL.Add(messageListModal);
            }

            // 2. Close this window and Refresh parent window
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

        #endregion

        #region 根据GUID转换ID

        private string Get_MessageID(string strMessageGUID)
        {
            zlzw.BLL.MessageListBLL messageListBLL = new zlzw.BLL.MessageListBLL();
            DataTable dt = messageListBLL.GetList("MessageGUID='" + strMessageGUID + "'").Tables[0];

            return dt.Rows[0]["MessageID"].ToString();
        }

        #endregion

    }
}
